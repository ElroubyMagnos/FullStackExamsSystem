using DesktopSupport;
using ESiteCore.Server;
using ESiteCore.Server.Classes;
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

namespace EEControl.Students
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private async void NameSearch_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text.Length > 2)
            {
                if (SearchBox.Text.Length > 0)
                    searchwordbank = SearchBox.Text;

                var g = new gzera();

                StudentsGrid.DataSource = await g.Students.Where(x => x.Name.Contains(SearchBox.Text)).Select(x => new
                {
                    المعرف = x.ID,
                    الاسم = x.Name,
                    السري = x.UniqueNumber,
                    التخصص = x.Speciality,
                    الفرقة = x.GradeNumber,
                    المجموعة = x.Group,
                    الانتهاء = x.ExpireDate

                }).ToListAsync();

            }
            else
            {
                MessageBox.Show("لا يمكن البحث باقل من 3 احرف");
            }
        }

        private void StudentsGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (Control tb in Controls)
            {
                if (tb is TextBox)
                    tb.Text = "";
                else if (tb is ComboBox)
                    (tb as ComboBox).SelectedIndex = -1;
            }

            if (StudentsGrid.SelectedRows.Count > 0)
            {
                var SelectedRow = StudentsGrid.SelectedRows[0];

                IDNumber.Text = SelectedRow.Cells[0].Value.ToStringOrEmpty();
                NameOfStudent.Text = SelectedRow.Cells[1].Value.ToStringOrEmpty();
                SecretNumber.Text = SelectedRow.Cells[2].Value.ToStringOrEmpty();
                Speciality.Text = SelectedRow.Cells[3].Value.ToStringOrEmpty();
                GradeYear.Text = SelectedRow.Cells[4].Value.ToStringOrEmpty();
                GroupOfStudent.Text = SelectedRow.Cells[5].Value.ToStringOrEmpty();

            }
        }
        public static string searchwordbank { get; set; }
        private async void Delete_Click(object sender, EventArgs e)
        {
            if (IDNumber.Value > 0 && StudentsGrid.SelectedRows.Count > 0)
            {
                var g = new gzera();

                var Selected = await g.Students.FirstOrDefaultAsync(x => x.ID == IDNumber.Value);

                if (Selected != null)
                {
                    g.Students.Remove(Selected);

                    await g.SaveChangesAsync();

                    StudentsGrid.DataSource = await g.Students.Where(x => x.Name.Contains(searchwordbank)).Select(x => new
                    {
                        المعرف = x.ID,
                        الاسم = x.Name,
                        السري = x.UniqueNumber,
                        التخصص = x.Speciality,
                        الفرقة = x.GradeNumber,
                        المجموعة = x.Group,
                        الانتهاء = x.ExpireDate

                    }).ToListAsync();
                }
            }
        }

        private async void EditChoosen_Click(object sender, EventArgs e)
        {
            var g = new gzera();

            var Selected = await g.Students.FirstOrDefaultAsync(x => x.ID == IDNumber.Value);

            if (Selected != null)
            {
                var Updated = new Student()
                {
                    ID = IDNumber.Value,
                    Name = NameOfStudent.Text,
                    UniqueNumber = SecretNumber.Value,
                    Speciality = Speciality.Text.IntOrDefault(),
                    GradeNumber = GradeYear.Text.IntOrDefault(),
                    Group = GroupOfStudent.Value,
                    ExpireDate = Selected.ExpireDate,
                    Password = Selected.Password
                };


                var studentg = new gzera();

                studentg.Students.Update(Updated);

                await studentg.SaveChangesAsync();

                StudentsGrid.DataSource = await g.Students.Where(x => x.Name.Contains(searchwordbank)).Select(x => new
                {
                    المعرف = x.ID,
                    الاسم = x.Name,
                    السري = x.UniqueNumber,
                    التخصص = x.Speciality,
                    الفرقة = x.GradeNumber,
                    المجموعة = x.Group,
                    الانتهاء = x.ExpireDate

                }).ToListAsync();
            }

        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NameSearch_Click(sender, e);
            }
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            NameOfStudent.ReadOnly = SecretNumber.ReadOnly = Main.LoggedUser.Username == "admin" || Main.LoggedUser.CanEditAllStudentsData;
        }
    }
}
