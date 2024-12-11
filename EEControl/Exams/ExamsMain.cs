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

namespace EEControl.Exams
{
    public partial class ExamsMain : Form
    {
        static ExamCover EC;
        public static ExamCover SelectedCover
        {
            get => EC;
            set
            {
                if (EC != null)
                {
                    EC.BackColor = Color.White;
                }

                EC = value;

                if (EC != null)
                {
                    EC.BackColor = Color.Yellow;
                }
            }
        }
        public ExamsMain()
        {
            InitializeComponent();
        }

        private async void ExamsMain_Load(object sender, EventArgs e)
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

        private void AddNewExam_Click(object sender, EventArgs e)
        {
            Hide();
            new AddExamNow().ShowDialog();
            Show();
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            var selectedid = SelectedCover.IDOfExam;

            var g = new gzera();

            g.Exams.Remove(new ExamMain()
            {
                ID = selectedid
            });

            await g.SaveChangesAsync();

            ExamsMain_Load(sender, e);
        }
    }
}
