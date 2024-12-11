using EEControl.Results;
using EntityBaseEE.Classes;
using ESiteCore.Server;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EEControl.Exams
{
    public partial class ExamsClick : UserControl
    {
        public int IDOfExam { get; set; }
        public ExamsClick()
        {
            InitializeComponent();
        }

        private void All_Click(object sender, EventArgs e)
        {
            new ExamResultsShow(IDOfExam).ShowDialog();
        }

        private async void All_DoubleClick(object sender, EventArgs e)
        {
            //var addexam = new AddExamNow();

            //var g = new gzera();

            //var SelectedExam = await g.Exams.FirstOrDefaultAsync(x => x.ID == IDOfExam);

            //if (SelectedExam == null)
            //{
            //    MessageBox.Show("لا  يمكن الوصول الي هذا الامتحان");
            //    return;
            //}

            //addexam.ExamGuidDesc.Text = SelectedExam.Desc;

            //addexam.Cover.BackgroundImage = Image.FromStream(new MemoryStream(SelectedExam.CoverImage));

            //var spec = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.ID == SelectedExam.Specality);

            //addexam.SpecalityCB.Text = spec.NameOf;

            //var goy = await g.GradeOfYears.FirstOrDefaultAsync(x => x.TypeOfLearnID == spec.ID);

            //addexam.GradeYearCB.Text = goy.IDOfGrade.ToString();

            //var subj = await g.Subjects.FirstOrDefaultAsync(x => x.Specality == spec.ID && x.GradeYear == goy.IDOfGrade);

            //addexam.SubjectCB.Text = subj.Title;

            //addexam.TitleOfExam.Text = SelectedExam.Title;

            //var AllChooseQues = await g.ChooseQuestions.Where(x => x.ExamID == IDOfExam).ToListAsync();

            //foreach (ChooseQues cq in AllChooseQues)
            //{
            //    var current = new ChooseQuestionForm();

            //    current.QuestionTitle.Text = cq.Title;
            //    current.Answer1.Text = cq.FirstAnswer;
            //    current.Answer2.Text = cq.SecondAnswer;
            //    current.Answer3.Text = cq.ThirdAnswer;
            //    current.Answer4.Text = cq.FourthAnswer;
            //    current.Answer.SelectedIndex = cq.RightAnswer;

            //    addexam.QuestionsSwim.Controls.Add(current);
            //    addexam.QuestionsSwim.ScrollControlIntoView(current);
            //}

            //var AllRWQues = await g.RightWrongQuestions.Where(x => x.ExamID == IDOfExam).ToListAsync();

            //foreach (RightWrongQues rwq in AllRWQues)
            //{
            //    var current = new RightWrongQuestionForm();

            //    current.Title.Text = rwq.Title;
            //    current.Answer.Checked = rwq.RightAnswer;

            //    addexam.QuestionsSwim.Controls.Add(current);
            //    addexam.QuestionsSwim.ScrollControlIntoView(current);
            //}

            //addexam.ShowDialog();
        }
    }
}
