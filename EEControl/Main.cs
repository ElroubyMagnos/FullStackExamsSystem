using EntityBaseEE.Classes;
using ESiteCore.Server;
using Microsoft.EntityFrameworkCore;

namespace EEControl
{
    public partial class Main : Form
    {
        public enum QuesType
        {
            none,
            essay,
            rightwrong,
            choose
        }
        public Main()
        {
            InitializeComponent();

            ReUse();
        }
        async void ReUse()
        {
            var g = new gzera();
            if (g.UserConts.Count() == 0)
            {
                await g.UserConts.AddAsync(new EntityBaseEE.Classes.UserCont
                {
                    Username = "admin",
                    Password = "admin"
                });

                await g.SaveChangesAsync();
            }
        }
        public static UserCont LoggedUser;
        private async void SignIn_Click(object sender, EventArgs e)
        {
            gzera gz = new gzera();

            var Account = await gz.UserConts.FirstOrDefaultAsync(x => x.Username == Username.Text && x.Password == Password.Text);

            if (Account != null)
            {
                if (Account.Username != "admin" && !Account.CanSignIn)
                {
                    MessageBox.Show("«‰  „ÕŸÊ—");
                    return;
                }

                if (!Account.IsAccepted && Account.Username != "admin")
                {
                    MessageBox.Show("·„ Ì „ «·„Ê«›ﬁ… ⁄·Ì Õ”«»ﬂ »⁄œ Ì—ÃÌ «·«‰ Ÿ«—");
                    return;
                }

                Hide();

                LoggedUser = Account;

                new DashBoard().ShowDialog();
                Application.Exit();
            }
            else MessageBox.Show("«”„ „” Œœ„ «Ê ﬂ·„… ”— Œ«ÿ∆Ì‰");
        }

        private void All_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignIn_Click(sender, e);
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Hide();
            new SignUp().ShowDialog();
            Show();
        }
    }
}
