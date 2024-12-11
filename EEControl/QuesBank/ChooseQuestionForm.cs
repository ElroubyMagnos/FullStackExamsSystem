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
    public partial class ChooseQuestionForm : UserControl
    {
        bool _IRO;
        public bool IsReadOnly
        {
            get => _IRO;
            set
            {
                _IRO = value;

                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                        (c as TextBox).ReadOnly = _IRO;
                    else if (c is RichTextBox)
                        (c as RichTextBox).ReadOnly = _IRO;
                }
            }
        }
        public ChooseQuestionForm()
        {
            InitializeComponent();
        }

        private void Removeit_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
