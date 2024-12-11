using EEControl.AutoExams;
using EEControl.CorrectExams;
using EEControl.DB_Web;
using EEControl.Exams;
using EEControl.QuesBank;
using EEControl.Students;
using EntityBaseEE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEControl
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void baseweb_Click(object sender, EventArgs e)
        {
            if (Main.LoggedUser.Username != "admin" && !Main.LoggedUser.CanEnterCore)
            {
                MessageBox.Show("ليس لديك صلاحية للدخول");
                return;
            }

            Hide();
            new BaseWebWindow().ShowDialog();
            Show();
        }

        private void studentinfo_Click(object sender, EventArgs e)
        {
            if (Main.LoggedUser.Username != "admin" && !Main.LoggedUser.CanEnterStudentWindow)
            {
                MessageBox.Show("ليس لديك صلاحية للدخول");
                return;
            }

            Hide();
            new StudentInfo().ShowDialog();
            Show();
        }

        private void SettingsOfSite_Click(object sender, EventArgs e)
        {
            if (Main.LoggedUser.Username != "admin" && !Main.LoggedUser.CanEnterSettings)
            {
                MessageBox.Show("ليس لديك صلاحية للدخول");
                return;
            }

            Hide();
            new SettingsWindow().ShowDialog();
            Show();
        }

        private void exams_Click(object sender, EventArgs e)
        {
            if (Main.LoggedUser.Username != "admin" && !Main.LoggedUser.CanEnterExamsWindow)
            {
                MessageBox.Show("ليس لديك صلاحية للدخول");
                return;
            }

            Hide();
            new ExamsMain().ShowDialog();
            Show();
        }

        private void StartExams_Click(object sender, EventArgs e)
        {
            Hide();
            new AutoExams.AutoExams().ShowDialog();
            Show();
        }

        private void results_Click(object sender, EventArgs e)
        {
            Hide();
            new Results.ResultsOfExams().ShowDialog();
            Show();
        }

        private void Accounts_Click(object sender, EventArgs e)
        {
            Hide();
            new Accounts.AccountsCreator().ShowDialog();
            Show();
        }

        private void CorrectExams_Click(object sender, EventArgs e)
        {
            Hide();
            new SelectExam().ShowDialog();
            Show();
        }

        private void QuestionsBank_Click(object sender, EventArgs e)
        {
            Hide();
            new QuestionsBank().ShowDialog();
            Show();
        }
    }
}
