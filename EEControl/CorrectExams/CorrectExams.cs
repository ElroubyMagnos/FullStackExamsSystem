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
    public partial class CorrectExams : Form
    {
        public int IDOFExams { get; set; }
        public CorrectExams(int ID)
        {
            InitializeComponent();

            IDOFExams = ID;
        }

        private async void CorrectExams_Load(object sender, EventArgs e)
        {
            var g = new gzera();

            StudentsGrid.DataSource = await g.ExamProgresses.Where(x => !x.Corrected && x.ExamID == IDOFExams).Select(x => new
            {
                الاسم = g.Students.FirstOrDefault(y => x.StudentID == y.ID).Name,
                الدرجات = x.GottenMarks,
                من = x.TotalMarks,
                السري = x.StudentID,
                الامتحان = x.ExamID,
                مصحح = x.Corrected,
                المعرف = x.ID,
            }).ToListAsync();
        }

        private async void StudentsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (StudentsGrid.SelectedRows.Count > 0)
            {
                EssayCorrectContainer.Controls.Clear();

                var g = new gzera();

                var CurrentExamID = StudentsGrid.SelectedRows[0].Cells[4].Value.ToString().IntOrDefault();

                var AllEssayAnsw = await g.AnswersOfEssay
                    .Where(x => !x.ismarked && x.studentname == StudentsGrid.SelectedRows[0].Cells[0].Value.ToString())
                    .ToListAsync();

                foreach (var Essay in AllEssayAnsw)
                {
                    var Selected = await g.EssayQuestions
                        .FirstOrDefaultAsync(x => x.ExamID == IDOFExams
                        && x.ID == Essay.quesid);

                    if (Selected != null)
                    {
                        var EssayForm = new CorrectedEssay(Essay.ID, Essay.quesid);
                        EssayForm.Answer.Text = Essay.answer;
                        EssayForm.Question.Text = Selected.Title;

                        EssayCorrectContainer.Controls.Add(EssayForm);
                        EssayCorrectContainer.ScrollControlIntoView(EssayForm);
                    }
                }
            }
        }

        async Task<int> EssayCount(int index)
        {
            var g = new gzera();

            var CurrentStudentID = StudentsGrid.Rows[index].Cells[0].Value.ToString();

            return g.AnswersOfEssay.Where(x => x.studentname == CurrentStudentID && !x.ismarked).Count();
        }

        private async void ShowResults_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < StudentsGrid.RowCount; i++)
            {
                if (await EssayCount(i) > 0)
                {
                    MessageBox.Show("لازال هناك اسئلة لتصحيحها");
                    return;
                }    
            }

            var g = new gzera();

            for (int i = 0; i < StudentsGrid.RowCount; i++)
            {
                var CurrentID = StudentsGrid.Rows[i].Cells[6].Value.ToString().IntOrDefault();

                var Selected = await g.ExamProgresses.FirstOrDefaultAsync(x => x.ID == CurrentID);

                if (Selected != null)
                {
                    Selected.Corrected = true;

                    g.ExamProgresses.Update(Selected);

                    await g.SaveChangesAsync();
                }
            }

            Close();
        }
    }
}
