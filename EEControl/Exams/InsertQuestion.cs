using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EEControl.Main;

namespace EEControl.Exams
{
    public partial class InsertQuestion : Form
    {
        public QuesType SelectedQuesType { get; set; } = QuesType.none;
        public InsertQuestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedQuesType = QuesType.essay;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedQuesType = QuesType.rightwrong;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectedQuesType = QuesType.choose;
            Close();
        }
    }
}
