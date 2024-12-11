using EntityBaseEE.Classes;
using EntityBaseEE.Classes.Bank;
using ESiteCore.Server;
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
using EEControl.Bank;

namespace EEControl.QuesBank
{
    public partial class QuestionsBank : Form
    {
        public QuestionsBank()
        {
            InitializeComponent();
        }

        private void AddQues_Click(object sender, EventArgs e)
        {
            var insertques = new Exams.InsertQuestion();

            insertques.ShowDialog();

            if (insertques.SelectedQuesType == Main.QuesType.essay)
            {
                var NewQues = new EssayQuestionForm();
                QuestionsFlow.Controls.Add(NewQues);
                QuestionsFlow.ScrollControlIntoView(NewQues);
            }
            else if (insertques.SelectedQuesType == Main.QuesType.choose)
            {
                var NewQues = new ChooseQuestionForm();
                QuestionsFlow.Controls.Add(NewQues);
                QuestionsFlow.ScrollControlIntoView(NewQues);
            }
            else if (insertques.SelectedQuesType == Main.QuesType.rightwrong)
            {
                var NewQues = new RightWrongQuestionForm();
                QuestionsFlow.Controls.Add(NewQues);
                QuestionsFlow.ScrollControlIntoView(NewQues);
            }
        }

        private async void SubjectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionsFlow.Visible = SubjectCombo.SelectedItem != null;

            QuestionsFlow.Controls.Clear();
            var g = new gzera();

            foreach (BankChooseQues Choose in await g.ChooseBank.Where(x => x.OwnerID == Main.LoggedUser.ID).ToListAsync())
            {
                var CQF = new ChooseQuestionForm();
                CQF.QuestionTitle.Text = Choose.Title;

                CQF.Answer1.Text = Choose.FirstAnswer;
                CQF.Answer2.Text = Choose.SecondAnswer;
                CQF.Answer3.Text = Choose.ThirdAnswer;
                CQF.Answer4.Text = Choose.FourthAnswer;

                CQF.Answer.SelectedIndex = Choose.RightAnswer;

                QuestionsFlow.Controls.Add(CQF);
            }

            foreach (BankRightWrongQues RightWrong in await g.RightWrongBank.Where(x => x.OwnerID == Main.LoggedUser.ID).ToListAsync())
            {
                var RW = new RightWrongQuestionForm();

                RW.Title.Text = RightWrong.Title;
                RW.Answer.Checked = RightWrong.RightAnswer;

                QuestionsFlow.Controls.Add(RW);
            }

            foreach (BankEssayQues essay in await g.EssayBank.Where(x => x.OwnerID == Main.LoggedUser.ID).ToListAsync())
            {
                var EssayForm = new EssayQuestionForm();

                EssayForm.Title.Text = essay.Title;

                QuestionsFlow.Controls.Add(EssayForm);
            }
        }

        private async void QuestionsBank_Load(object sender, EventArgs e)
        {
            var g = new gzera();

            foreach (var str in await g.Subjects.Select(x => new
            {
                x.Title
            }).ToListAsync())
            {
                SubjectCombo.Items.Add(str.Title);
            }
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            foreach (UserControl uc in QuestionsFlow.Controls.OfType<UserControl>())
            {
                foreach (Control c in uc.Controls)
                {
                    if (c.Text.Length == 0)
                    {
                        QuestionsFlow.ScrollControlIntoView(uc);

                        MessageBox.Show("لقد نسيت حقل فارغ");
                        return;
                    }
                }
            }

            var g = new gzera();
            var SubjectID = (await g.Subjects.FirstOrDefaultAsync(x => x.Title == SubjectCombo.SelectedItem.ToString())).ID;

            g.ChooseBank.RemoveRange(g.ChooseBank.Where(x => x.SubjectID == SubjectID && x.OwnerID == Main.LoggedUser.ID));
            await g.SaveChangesAsync();
            g.RightWrongBank.RemoveRange(g.RightWrongBank.Where(x => x.SubjectID == SubjectID && x.OwnerID == Main.LoggedUser.ID));
            await g.SaveChangesAsync();
            g.EssayBank.RemoveRange(g.EssayBank.Where(x => x.SubjectID == SubjectID && x.OwnerID == Main.LoggedUser.ID));
            await g.SaveChangesAsync();

            foreach (UserControl uc in QuestionsFlow.Controls.OfType<UserControl>())
            {
                if (uc is EssayQuestionForm)
                {
                    var selected = uc as EssayQuestionForm;

                    var cq = new BankEssayQues()
                    {
                        SubjectID = SubjectID,
                        OwnerID = Main.LoggedUser.ID,
                        Title = selected.Title.Text
                    };

                    g.EssayBank.Add(cq);

                    await g.SaveChangesAsync();
                }
                if (uc is ChooseQuestionForm)
                {
                    var selected = uc as ChooseQuestionForm;

                    var cq = new BankChooseQues()
                    {
                        SubjectID = SubjectID,
                        OwnerID = Main.LoggedUser.ID,
                        Title = selected.QuestionTitle.Text,
                        FirstAnswer = selected.Answer1.Text,
                        SecondAnswer = selected.Answer2.Text,
                        ThirdAnswer = selected.Answer3.Text,
                        FourthAnswer = selected.Answer4.Text,
                        RightAnswer = selected.Answer.SelectedIndex
                    };

                    g.ChooseBank.Add(cq);

                    await g.SaveChangesAsync();
                }
                else if (uc is RightWrongQuestionForm)
                {
                    var selected = uc as RightWrongQuestionForm;

                    var rwqf = new BankRightWrongQues()
                    {
                        SubjectID = SubjectID,
                        OwnerID = Main.LoggedUser.ID,
                        Title = selected.Title.Text,
                        RightAnswer = selected.Answer.Checked
                    };

                    g.RightWrongBank.Add(rwqf);

                    await g.SaveChangesAsync();
                }
            }
        }
    }
}
