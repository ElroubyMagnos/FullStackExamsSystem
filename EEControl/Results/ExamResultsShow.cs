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

namespace EEControl.Results
{
    public partial class ExamResultsShow : Form
    {
        public int ExamID { get; set; }
        public ExamResultsShow(int ExamID)
        {
            InitializeComponent();

            this.ExamID = ExamID;
        }

        private async void ExamResultsShow_Load(object sender, EventArgs e)
        {
            var g = new gzera();

            var AllStudents = from examprog in g.ExamProgresses 
                              join students in g.Students on examprog.StudentID
                              equals students.ID
                              where examprog.StudentID == students.ID
                              select new
                              {
                                  الاسم = students.Name,
                                  الدرجات = examprog.GottenMarks,
                                  من = examprog.TotalMarks,
                                  المجموعة = "G-" + students.Group

                              };

            Grid.DataSource = await AllStudents.ToListAsync();
        }
    }
}
