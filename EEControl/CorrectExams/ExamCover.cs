using EEControl.Exams;
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
    public partial class ExamCover : UserControl
    {
        public int IDOfExam { get; set; }
        public ExamCover()
        {
            InitializeComponent();
        }

        private void All_Click(object sender, EventArgs e)
        {
            new CorrectExams(IDOfExam).ShowDialog();
        }
    }
}
