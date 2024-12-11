using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEControl.Bank
{
    public partial class RightWrongQuestionForm : UserControl
    {
        bool _IRO;
        public bool IsReadOnly
        {
            get => _IRO;
            set
            {
                _IRO = value;

                Title.ReadOnly = Answer.AutoCheck = _IRO;
            }
        }
        public RightWrongQuestionForm()
        {
            InitializeComponent();
        }

        private void RightWrongQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void Removeit_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
