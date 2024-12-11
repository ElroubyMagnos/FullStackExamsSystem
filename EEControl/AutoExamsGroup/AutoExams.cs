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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEControl.AutoExams
{
    public partial class AutoExams : Form
    {
        static ExamCover SC;
        public static ExamCover SelectedCover
        {
            get
            {
                return SC;
            }
            set
            {
                if (SC != null)
                {
                    SC.BackColor = Color.White;
                    This.From.Enabled = This.To.Enabled = true;
                    This.From.Value = This.To.Value = DateTime.Now;
                }

                if (SC == value)
                {
                    SC.BackColor = SC.BackColor == Color.White ? Color.Yellow : Color.White;

                    if (SC.BackColor == Color.Yellow)
                    {
                        This.From.Enabled = true;

                        DoIt();
                    }
                    else
                    {
                        This.From.Enabled = false;
                        This.From.Value = This.To.Value = DateTime.Now;
                    }

                    return;
                }

                SC = value;

                if (SC != null)
                {
                    SC.BackColor = Color.Yellow;

                    This.From.Enabled = This.To.Enabled = true;

                    DoIt();
                }

                async void DoIt()
                {
                    var g = new gzera();

                    var TheExam = await g.Exams.FirstOrDefaultAsync(x => x.ID == SC.IDOfExam);

                    if (TheExam == null)
                        return;

                    This.From.Value = TheExam.OpenTime;
                    This.To.Value = TheExam.CloseTime;
                }
            }
        }
        static AutoExams This;
        public AutoExams()
        {
            InitializeComponent();

            This = this;
        }

        private async void AutoExams_Load(object sender, EventArgs e)
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

        private void FromAndTo_ValueChanged(object sender, EventArgs e)
        {
            if (From.Value <= DateTime.Now && To.Value >= DateTime.Now)
            {
                Status.Text = "الامتحان شغال الان";

                Status.ForeColor = Color.Green;
            }
            else
            {
                Status.Text = "الامتحان مغلق الان";

                Status.ForeColor = Color.Red;
            }
        }

        private async void Append_Click(object sender, EventArgs e)
        {
            var g = new gzera();

            var Selected = await g.Exams.FirstOrDefaultAsync(x => x.ID == SelectedCover.IDOfExam);
            
            if (Selected.DoctorUserName != Main.LoggedUser.Username)
            {
                MessageBox.Show("لا يمكنك تحديد موعد لهذا");
                return;
            }


            if (Selected != null)
            {
                From.ValueChanged -= FromAndTo_ValueChanged;
                To.ValueChanged -= FromAndTo_ValueChanged;

                Selected.OpenTime = From.Value;
                Selected.CloseTime = To.Value;

                From.ValueChanged += FromAndTo_ValueChanged;
                To.ValueChanged += FromAndTo_ValueChanged;

                g.Exams.Update(Selected);

                await g.SaveChangesAsync();
            }
        }
    }
}
