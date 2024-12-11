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

namespace EEControl.CorrectExams
{
    public partial class SelectExam : Form
    {
        public SelectExam()
        {
            InitializeComponent();
        }

        private async void SelectExam_Load(object sender, EventArgs e)
        {
            ExamSpace.Controls.Clear();

            var g = new gzera();


            var AllExams = await g.Exams.ToListAsync();

            if (Main.LoggedUser.Username != "admin" && !Main.LoggedUser.CanDeleteAllExams)
            {
                AllExams = AllExams.Where(x => x.DoctorUserName == Main.LoggedUser.Username).ToList();
            }

            foreach (ExamMain em in AllExams)
            {
                ExamCover ec = new ExamCover();

                ec.IDOfExam = em.ID;

                ec.Title.Text = em.Title;

                var SelectedSubj = await g.Subjects.FirstOrDefaultAsync(x => x.ID == em.Subject);

                if (SelectedSubj == null)
                {
                    return;
                }

                ec.Subject.Text = SelectedSubj.Title;

                ExamSpace.Controls.Add(ec);
            }
        }
    }
}
