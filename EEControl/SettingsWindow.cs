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

namespace EEControl
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private async void SettingsWindow_Load(object sender, EventArgs e)
        {
            var g = new gzera();

            if (g.SiteSettings.Count() > 0)
            {
                StudentExpire.Value = (await g.SiteSettings.FirstOrDefaultAsync()).StudentAccountExpirationDate;
            }
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            var g = new gzera();

            foreach (SiteSettings ss in g.SiteSettings)
            {
                g.SiteSettings.Remove(ss);
            }

            await g.SaveChangesAsync();

            g.SiteSettings.AddAsync(new SiteSettings()
            {
                StudentAccountExpirationDate = StudentExpire.Value
            });

            await g.SaveChangesAsync();
        }
    }
}
