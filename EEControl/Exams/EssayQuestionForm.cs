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

namespace EEControl.Exams
{
    public partial class EssayQuestionForm : UserControl
    {
        bool _IRO;
        public bool IsReadOnly
        {
            get => _IRO;
            set
            {
                _IRO = value;

                Title.ReadOnly = _IRO;
            }
        }
        public EssayQuestionForm()
        {
            InitializeComponent();
        }
        private void AllInOne(object sender, EventArgs e)
        {
            if (AddExamNow.SelectedControl == this)
            {
                AddExamNow.SelectedControl = null;
                return;
            }

            AddExamNow.SelectedControl = this;
        }

        private void EssayQuestionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
