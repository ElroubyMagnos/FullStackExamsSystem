using DesktopSupport;
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

namespace EEControl.CorrectExams
{
    public partial class CorrectedEssay : UserControl
    {
        public int IDOfQues { get; set; }
        public CorrectedEssay(int IDOfQues, int quesid)
        {
            InitializeComponent();

            this.IDOfQues = IDOfQues;

            var g = new gzera();

            var Ques = g.EssayQuestions.FirstOrDefault(x => x.ID == quesid);

            MaxPoints.Value = Ques.Points;
        }

        private async void RightBtn_Click(object sender, EventArgs e)
        {
            var g = new gzera();

            var Ques = await g.AnswersOfEssay.FirstOrDefaultAsync(x => x.ID == IDOfQues);

            if (Ques != null)
            {
                var Selected = await g.EssayQuestions
                    .FirstOrDefaultAsync(x => x.ID == Ques.quesid
                    && x.ExamID == (Parent.Parent as CorrectExams).IDOFExams);

                if (Selected != null)
                {
                    Ques.ismarked = true;
                    Ques.Points = Points.Value;

                    var ScoreSelected = await g.ExamProgresses
                        .FirstOrDefaultAsync(x =>
                        x.ExamID == Selected.ExamID
                        && x.StudentID == (Parent.Parent as CorrectExams).StudentsGrid.SelectedRows[0].Cells[3].Value.ToString().IntOrDefault()
                        );

                    if (ScoreSelected == null)
                    {
                        return;
                    }

                    ScoreSelected.GottenMarks += Ques.Points;
                    ScoreSelected.TotalMarks += MaxPoints.Value;

                    g.ExamProgresses.Update(ScoreSelected);
                    await g.SaveChangesAsync();

                    g.AnswersOfEssay.Update(Ques);
                    await g.SaveChangesAsync();

                    Parent.Controls.Remove(this);
                }
            }
        }

        private async void Points_TextChanged(object sender, EventArgs e)
        {
            var g = new gzera();

            var Ques = await g.AnswersOfEssay.FirstOrDefaultAsync(x => x.ID == IDOfQues);

            if (Points.Value > MaxPoints.Value)
            {
                Points.Value = MaxPoints.Value;
            }
        }
    }
}
