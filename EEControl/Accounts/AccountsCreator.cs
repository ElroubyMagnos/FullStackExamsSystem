using DesktopSupport;
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

namespace EEControl.Accounts
{
    public partial class AccountsCreator : Form
    {
        public AccountsCreator()
        {
            InitializeComponent();
        }

        private async void AccountsCreator_Load(object sender, EventArgs e)
        {
            Grid.Rows.Clear();

            var g = new gzera();

            if (Main.LoggedUser.Username == "admin")
            {
                Grid.DataSource = await g.UserConts.Select(x => new
                {
                    المعرف = x.ID,
                    الاسم = x.Username,
                    السر = x.Password
                }).ToListAsync();
            }
            else Grid.DataSource = await g.UserConts.Where(x => x.Username != "admin").Select(x => new
            {
                المعرف = x.ID,
                الاسم = x.Username,
                السر = x.Password
            }).ToListAsync();
        }

        private async void Grid_SelectionChanged(object sender, EventArgs e)
        {
            IDOfAccount.Text = "0";
            Username.Text = "";
            Password.Text = "";

            foreach (CheckBox cb in Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
            }

            var g = new gzera();

            if (Grid.SelectedRows.Count == 0)
                return;

            var SelectedAccount = await g.UserConts
                .FirstOrDefaultAsync(x => x.ID == Grid.SelectedRows[0].Cells[0].Value.ToString().IntOrDefault());

            IDOfAccount.Text = SelectedAccount.ID.ToString();
            Username.Text = SelectedAccount.Username;
            Password.Text = SelectedAccount.Password;

            CanCreateAccounts.Checked = SelectedAccount.CanCreateAccounts;
            CanDeleteAllExams.Checked = SelectedAccount.CanDeleteAllExams;
            CanSignIn.Checked = SelectedAccount.CanSignIn;
            CanEnterSettings.Checked = SelectedAccount.CanEnterSettings;
            CanEnterCore.Checked = SelectedAccount.CanEnterCore;
            CanEnterStudentWindow.Checked = SelectedAccount.CanEnterStudentWindow;
            CanEnterExamsWindow.Checked = SelectedAccount.CanEnterExamsWindow;
            CanEditAllStudentsData.Checked = SelectedAccount.CanEditAllStudentsData;
            AcceptAccount.Checked = SelectedAccount.IsAccepted;
            Username.ReadOnly = true;
        }

        private void NewAccount_Click(object sender, EventArgs e)
        {
            if (Main.LoggedUser.Username != "admin" && !Main.LoggedUser.CanCreateAccounts)
            {
                MessageBox.Show("ليس لديك صلاحية لتعمل حساب جديد");
                return;
            }

            IDOfAccount.Text = "0";
            Username.Text = "";
            Password.Text = "";
            Username.ReadOnly = false;

            foreach (CheckBox cb in Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
            }
        }

        private async void SaveAccount_Click(object sender, EventArgs e)
        {
            if (Username.Text.Length == 0 || Password.Text.Length == 0)
            {
                MessageBox.Show("يرجي ملئ بيانات المستخدم");
                return;
            }

            var checkg = new gzera();
            var checkaccount = checkg.UserConts.FirstOrDefaultAsync(x => x.Username == Username.Text);

            if (checkaccount != null)
            {
                MessageBox.Show("هذا الاسم مسجل من قبل");
                return;
            }

            var SelectedAccount = new UserCont();
            if (Grid.SelectedRows.Count > 0 && IDOfAccount.Text != "0")
            {
                SelectedAccount.ID = Grid.SelectedRows[0].Cells[0].Value.ToString().IntOrDefault();
            }

            SelectedAccount.Username = Username.Text;
            SelectedAccount.Password = Password.Text;

            SelectedAccount.CanCreateAccounts = CanCreateAccounts.Checked;
            SelectedAccount.CanDeleteAllExams = CanDeleteAllExams.Checked;
            SelectedAccount.CanSignIn = CanSignIn.Checked;
            SelectedAccount.CanEnterSettings = CanEnterSettings.Checked;
            SelectedAccount.CanEnterCore = CanEnterCore.Checked;
            SelectedAccount.CanEnterStudentWindow = CanEnterStudentWindow.Checked;
            SelectedAccount.CanEnterExamsWindow = CanEnterExamsWindow.Checked;
            SelectedAccount.CanEditAllStudentsData = CanEditAllStudentsData.Checked;
            SelectedAccount.IsAccepted = AcceptAccount.Checked;
            
            var g = new gzera();

            g.UserConts.Update(SelectedAccount);

            await g.SaveChangesAsync();
        }
    }
}
