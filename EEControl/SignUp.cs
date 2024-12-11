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

namespace EEControl
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void SignBtn_Click(object sender, EventArgs e)
        {
            var g = new gzera();

            if (Password.Text != ConfirmPassword.Text)
            {
                MessageBox.Show("كلمتي السر غير متطابقتين");
                return;
            }

            if ((await g.UserConts.FirstOrDefaultAsync(x => x.Username == Username.Text)) == null)
            {
                await g.UserConts.AddAsync(new EntityBaseEE.Classes.UserCont()
                {
                    Username = Username.Text,
                    Password = Password.Text,
                    IsAccepted = false,
                    CanSignIn = true
                });

                await g.SaveChangesAsync();

                Close();
            }
            else MessageBox.Show("الحساب موجود بالفعل");
        }
    }
}
