using DesktopSupport;
using EntityBaseEE.Classes.Bank;
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
    public partial class SummonQuesPanel : Form
    {
        public int Subject { get; set; }
        public int ExamID { get; set; }
        public int ChooseCount { get; set; }
        public int RightWrongCount { get; set; }
        public int EssayCount { get; set; }
        public SummonQuesPanel(int Subject, int ExamID)
        {
            InitializeComponent();

            this.Subject = Subject;
            this.ExamID = ExamID;
        }

        private async void SummonQuesPanel_Load(object sender, EventArgs e)
        {
            var g = new gzera();

            restChoose.Value = ChooseCount = await g.ChooseBank.Where(x => x.SubjectID == Subject && x.OwnerID == Main.LoggedUser.ID).CountAsync();
            restRightWrong.Value = RightWrongCount = await g.RightWrongBank.Where(x => x.SubjectID == Subject && x.OwnerID == Main.LoggedUser.ID).CountAsync();
            restEssay.Value =  EssayCount = await g.EssayBank.Where(x => x.SubjectID == Subject && x.OwnerID == Main.LoggedUser.ID).CountAsync();

            All.Text = (ChooseCount + RightWrongCount + EssayCount).ToString();
        }
        public List<BankChooseQues> Choose = new List<BankChooseQues>();
        public List<BankRightWrongQues> RightWrong = new List<BankRightWrongQues>();
        public List<BankEssayQues> Essay = new List<BankEssayQues>();
        private async void EmbedQuestions_Click(object sender, EventArgs e)
        {
            if (restChoose.Value < 0 || restEssay.Value < 0 || restRightWrong.Value < 0)
            {
                MessageBox.Show("هناك اسئلة زائدة، لاحظ قيمة المربع السالب");
                return;
            }

            var g = new gzera();

            Choose = await g.ChooseBank.Where(x => x.SubjectID == Subject && x.OwnerID == Main.LoggedUser.ID).OrderByDescending(x => Guid.NewGuid()).Take(ChooseCountBox.Value).ToListAsync();

            RightWrong = await g.RightWrongBank.Where(x => x.SubjectID == Subject && x.OwnerID == Main.LoggedUser.ID).OrderByDescending(x => Guid.NewGuid()).Take(RightWrongCountBox.Value).ToListAsync();

            Essay = await g.EssayBank.Where(x => x.SubjectID == Subject && x.OwnerID == Main.LoggedUser.ID).OrderByDescending(x => Guid.NewGuid()).Take(EssayCountBox.Value).ToListAsync();

            Close();
        }

        private void ChooseCountBox_TextChanged(object sender, EventArgs e)
        {
            restChoose.Value = ChooseCount - ChooseCountBox.Value;

            TakenCount.Text = (ChooseCountBox.Value + RightWrongCountBox.Value + EssayCountBox.Value).ToString();

            restCount.Text = (All.Text.IntOrDefault() - TakenCount.Text.IntOrDefault()).ToString();
        }

        private void RightWrongCountBox_TextChanged(object sender, EventArgs e)
        {
            restRightWrong.Value = RightWrongCount - RightWrongCountBox.Value;

            TakenCount.Text = (ChooseCountBox.Value + RightWrongCountBox.Value + EssayCountBox.Value).ToString();

            restCount.Text = (All.Text.IntOrDefault() - TakenCount.Text.IntOrDefault()).ToString();
        }

        private void EssayCountBox_TextChanged(object sender, EventArgs e)
        {
            restEssay.Value = EssayCount - EssayCountBox.Value;

            TakenCount.Text = (ChooseCountBox.Value + RightWrongCountBox.Value + EssayCountBox.Value).ToString();

            restCount.Text = (All.Text.IntOrDefault() - TakenCount.Text.IntOrDefault()).ToString();
        }
    }
}
