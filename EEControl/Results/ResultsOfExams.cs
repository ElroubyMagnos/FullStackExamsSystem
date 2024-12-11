using EEControl.Exams;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEControl.Results
{
    public partial class ResultsOfExams : Form
    {
        public ResultsOfExams()
        {
            InitializeComponent();
        }

        private async void ResultsOfExams_Load(object sender, EventArgs e)
        {
            ExamsLayout.Controls.Clear();

            var g = new gzera();

            var AllExams = await g.Exams.ToListAsync();

            foreach (ExamMain em in AllExams)
            {
                ExamsClick ec = new ExamsClick();

                ec.IDOfExam = em.ID;

                ec.Title.Text = em.Title;

                var SelectedSubj = await g.Subjects.FirstOrDefaultAsync(x => x.ID == em.Subject);

                if (SelectedSubj == null)
                {
                    return;
                }

                ec.Subject.Text = SelectedSubj.Title;

                ExamsLayout.Controls.Add(ec);
            }
        }
    }
}
