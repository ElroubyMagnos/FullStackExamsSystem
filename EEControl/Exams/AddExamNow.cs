using EntityBaseEE.Classes;
using EntityBaseEE.Classes.Bank;
using ESiteCore.Server;
using ESiteCore.Server.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace EEControl.Exams
{
    public partial class AddExamNow : Form
    {
        public int ExamID { get; set; } = 0;
        public AddExamNow()
        {
            InitializeComponent();
        }

        private async void AddExamNow_Load(object sender, EventArgs e)
        {
            SpecalityCB.Items.Clear();

            var g = new gzera();

            var AllSpec = await g.TypeOfLearns.ToListAsync();

            foreach (TypeOfLearn tol in AllSpec)
            {
                SpecalityCB.Items.Add(tol.NameOf);
            }


            SubjectCB.Items.Clear();

            var spec = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == SpecalityCB.Text);

            if (spec == null)
                return;

            var goy = await g.GradeOfYears.FirstOrDefaultAsync(x => x.TypeOfLearnID == spec.ID);

            if (goy == null)
                return;

            var Allsubjects = await g.Subjects.Where(x => x.Specality == spec.ID && x.GradeYear == goy.IDOfGrade).ToListAsync();

            foreach (Subject s in Allsubjects)
            {
                SubjectCB.Items.Add(s.Title);
            }
        }



        private void ClearAll_Click(object sender, EventArgs e)
        {
            QuestionsSwim.Controls.Clear();
        }
        static UserControl UC;

        private async void SaveExam_Click(object sender, EventArgs e)
        {
            var All = QuestionsSwim.Controls.OfType<UserControl>();

            foreach (UserControl uc in All)
            {
                foreach (Control c in uc.Controls)
                {
                    if (c.Text.Length == 0)
                    {
                        QuestionsSwim.ScrollControlIntoView(uc);
                        SelectedControl = uc;

                        MessageBox.Show("لقد نسيت حقل فارغ");
                        return;
                    }
                }
            }

            if (SpecalityCB.Text.Length == 0 || GradeYearCB.Text.Length == 0)
            {
                MessageBox.Show("يرجي ملئ كل البيانات علي اليمين");
                return;
            }

            if (ExamGuidDesc.Text.Length < 3)
            {
                MessageBox.Show("يرجي ملئ تعليمات الامتحان");
                return;
            }

            if (TitleOfExam.Text.Length < 10)
            {
                MessageBox.Show("يجب للعنوان ان يكون اكثر من عشرة احرف");
                return;
            }

            if (SubjectCB.Text.Length == 0)
            {
                MessageBox.Show("يرجي اختيار المادة");
                return;
            }

            var g = new gzera();

            var SpecialityContent = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == SpecalityCB.Text);

            if (SpecialityContent == null)
            {
                MessageBox.Show("يرجي اختيار التخصص");
                return;
            }

            var goy = await g.GradeOfYears.FirstOrDefaultAsync(x => x.TypeOfLearnID == SpecialityContent.ID);

            if (goy == null)
            {
                MessageBox.Show("يرجي اختيار العام الدراسي");
                return;
            }

            if (QuestionsSwim.Controls.OfType<UserControl>().Count() < 5)
            {
                MessageBox.Show("يجب ان يكون الامتحان خمسة اسئلة علي الاقل");
                return;
            }

            var ms = new MemoryStream();
            Cover.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            var subj = await g.Subjects
                .FirstOrDefaultAsync(x => x.Specality == SpecialityContent.ID
                && x.GradeYear == goy.IDOfGrade && x.Title == SubjectCB.Text);

            if (subj == null)
            {
                MessageBox.Show("لا يمكن الوصول الي المادة");
                return;
            }

            ExamMain em = null;

            if (ExamID == 0)
            {
                em = new ExamMain()
                {
                    Desc = ExamGuidDesc.Text,
                    Specality = SpecialityContent.ID,
                    Title = TitleOfExam.Text,
                    CoverImage = ms.ToArray(),
                    Subject = subj.ID,
                    YearNumber = goy.IDOfGrade,
                    Shuffle = Shuffle.Checked,
                    OpenTime = DateTime.Now,
                    CloseTime = DateTime.Now,
                    DoctorUserName = Main.LoggedUser.Username
                };
            }
            else
            {
                em = new ExamMain()
                {
                    ID = ExamID,
                    Desc = ExamGuidDesc.Text,
                    Specality = SpecialityContent.ID,
                    Title = TitleOfExam.Text,
                    CoverImage = ms.ToArray(),
                    Subject = subj.ID,
                    YearNumber = goy.IDOfGrade,
                    Shuffle = Shuffle.Checked,
                    OpenTime = DateTime.Now,
                    CloseTime = DateTime.Now
                };
            }

            g.Exams.Update(em);

            await g.SaveChangesAsync();

            var CurrentExamID = (await g.Exams.OrderBy(x => x.ID).LastOrDefaultAsync()).ID;

            foreach (UserControl uc in QuestionsSwim.Controls.OfType<UserControl>())
            {
                if (uc is EssayQuestionForm)
                {
                    var selected = uc as EssayQuestionForm;

                    var cq = new EssayQues()
                    {
                        ExamID = CurrentExamID,
                        Title = selected.Title.Text
                    };

                    cq.Points = selected.Marks.Value;
                    
                    g.EssayQuestions.Add(cq);

                    await g.SaveChangesAsync();
                }
                if (uc is ChooseQuestionForm)
                {
                    var selected = uc as ChooseQuestionForm;

                    var cq = new ChooseQues()
                    {
                        ExamID = CurrentExamID,
                        Title = selected.QuestionTitle.Text,
                        FirstAnswer = selected.Answer1.Text,
                        SecondAnswer = selected.Answer2.Text,
                        ThirdAnswer = selected.Answer3.Text,
                        FourthAnswer = selected.Answer4.Text,
                        RightAnswer = selected.Answer.SelectedIndex
                    };

                    g.ChooseQuestions.Add(cq);

                    await g.SaveChangesAsync();
                }
                else if (uc is RightWrongQuestionForm)
                {
                    var selected = uc as RightWrongQuestionForm;

                    var rwqf = new RightWrongQues()
                    {
                        ExamID = CurrentExamID,
                        Title = selected.Title.Text,
                        RightAnswer = selected.Answer.Checked
                    };

                    g.RightWrongQuestions.Add(rwqf);

                    await g.SaveChangesAsync();
                }
            }

            await g.SaveChangesAsync();

            Close();
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            if (SelectedControl != null)
            {
                QuestionsSwim.Controls.Remove(SelectedControl);
            }
            else MessageBox.Show("يرجي اختيار سؤال لازالته");
        }

        private async void SpecalityCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GradeYearCB.Items.Clear();
            SubjectCB.Items.Clear();

            var g = new gzera();

            var Tol = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == SpecalityCB.Text);

            var AllGrades = await g.GradeOfYears.Where(x => x.TypeOfLearnID == Tol.ID).ToListAsync();

            foreach (GradeOfYear ag in AllGrades)
            {
                GradeYearCB.Items.Add(ag.IDOfGrade);
            }
        }

        private void ChoosePic_Click(object sender, EventArgs e)
        {
            if (GetPic.ShowDialog() == DialogResult.OK)
            {
                Cover.BackgroundImage = Image.FromFile(GetPic.FileName);
            }
        }

        private async void GradeYearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectCB.Items.Clear();

            var g = new gzera();

            var spec = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == SpecalityCB.Text);

            if (spec == null)
                return;

            var goy = await g.GradeOfYears.FirstOrDefaultAsync(x => x.TypeOfLearnID == spec.ID);

            if (goy == null)
            {
                return;
            }

            var All = await g.Subjects.Where(x => x.Specality == spec.ID && x.GradeYear == goy.IDOfGrade).ToListAsync();

            if (All == null)
                return;

            foreach (Subject s in All)
            {
                SubjectCB.Items.Add(s.Title);
            }
        }

        private void AddQuesPanel_Click(object sender, EventArgs e)
        {
            var insertques = new InsertQuestion();

            insertques.ShowDialog();

            if (insertques.SelectedQuesType == Main.QuesType.essay)
            {
                var NewQues = new EssayQuestionForm();
                QuestionsSwim.Controls.Add(NewQues);
                QuestionsSwim.ScrollControlIntoView(NewQues);
            }
            else if (insertques.SelectedQuesType == Main.QuesType.choose)
            {
                var NewQues = new ChooseQuestionForm();
                QuestionsSwim.Controls.Add(NewQues);
                QuestionsSwim.ScrollControlIntoView(NewQues);
            }
            else if (insertques.SelectedQuesType == Main.QuesType.rightwrong)
            {
                var NewQues = new RightWrongQuestionForm();
                QuestionsSwim.Controls.Add(NewQues);
                QuestionsSwim.ScrollControlIntoView(NewQues);
            }
        }

        private async void SummonQuestions_Click(object sender, EventArgs e)
        {
            if (SubjectCB.Text.Length == 0)
            {
                MessageBox.Show("يرجي اختيار المادة");
                return;
            }

            Hide();
            var SQP = new SummonQuesPanel((await new gzera().Subjects.FirstOrDefaultAsync(x => x.Title == SubjectCB.Text)).ID, ExamID);
            SQP.ShowDialog();
            Show();

            bool IsDuplicate = false;

            foreach (BankChooseQues Choose in SQP.Choose)
            {
                foreach (ChooseQuestionForm cqf in QuestionsSwim.Controls.OfType<ChooseQuestionForm>())
                {
                    if (cqf.QuestionTitle.Text == Choose.Title)
                    {
                        IsDuplicate = true;
                        continue;
                    }
                }

                ChooseQuestionForm CQF = new ChooseQuestionForm();

                CQF.QuestionTitle.Text = Choose.Title;
                CQF.Answer1.Text = Choose.FirstAnswer;
                CQF.Answer2.Text = Choose.SecondAnswer;
                CQF.Answer3.Text = Choose.ThirdAnswer;
                CQF.Answer4.Text = Choose.FourthAnswer;
                CQF.Answer.SelectedIndex = Choose.RightAnswer;

                QuestionsSwim.Controls.Add(CQF);
            }

            foreach (BankRightWrongQues RightWrong in SQP.RightWrong)
            {
                foreach (RightWrongQuestionForm rwqf in QuestionsSwim.Controls.OfType<RightWrongQuestionForm>())
                {
                    if (rwqf.Title.Text == RightWrong.Title)
                    {
                        IsDuplicate = true;
                        continue;
                    }
                }

                RightWrongQuestionForm RWQF = new RightWrongQuestionForm();

                RWQF.Title.Text = RightWrong.Title;
                RWQF.Answer.Checked = RightWrong.RightAnswer;

                QuestionsSwim.Controls.Add(RWQF);
            }

            foreach (BankEssayQues Essay in SQP.Essay)
            {
                foreach (EssayQuestionForm eqf in QuestionsSwim.Controls.OfType<EssayQuestionForm>())
                {
                    if (eqf.Title.Text == Essay.Title)
                    {
                        IsDuplicate = true;
                        continue;
                    }
                }

                EssayQuestionForm EQF = new EssayQuestionForm();

                EQF.Title.Text = Essay.Title;

                QuestionsSwim.Controls.Add(EQF);
            }

            if (IsDuplicate)
            {
                MessageBox.Show("كان هناك اسئلة مقررة وتم التعامل مع الامر بمنع التكرار في الاسئلة");
            }
        }

        public static UserControl SelectedControl
        {
            get => UC;
            set
            {
                if (UC != null)
                {
                    UC.BackColor = Color.White;
                }
                UC = value;

                if (UC != null)
                {
                    UC.BackColor = Color.Yellow;
                }
            }
        }
    }
}
