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

namespace EEControl.DB_Web.BaseWebWndows
{
    public partial class TypeOfLearnWindow : Form
    {
        public TypeOfLearnWindow()
        {
            InitializeComponent();
        }

        private void TypeOfLearnWindow_Load(object sender, EventArgs e)
        {
            TypeOfLearnLB.Items.Clear();

            gzera g = new gzera();

            foreach (var s in g.TypeOfLearns)
            {
                TypeOfLearnLB.Items.Add(s.NameOf);
            }
        }

        private async void Add_Click(object sender, EventArgs e)
        {
            if (AddSpace.Text.Length > 0)
            {
                gzera g = new gzera();

                if ((await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == AddSpace.Text)) != null)
                {
                    MessageBox.Show("يوجد بالفعل هذا التخصص");
                    return;
                }

                if (desc.Text.Length < 10)
                {
                    MessageBox.Show("لا يمكنك اضافة تخصص بدون وصف من علي الاقل 10 احرف");
                    return;
                }

                g.TypeOfLearns.Add(new TypeOfLearn
                {
                    NameOf = AddSpace.Text,
                    Description = desc.Text
                });

                await g.SaveChangesAsync();

                AddSpace.Clear();

                desc.Clear();

                TypeOfLearnWindow_Load(sender, e);
            }
            else MessageBox.Show("يرجي كتابة اسم التخصص اولاً");
        }

        private async void DeleteSelected_Click(object sender, EventArgs e)
        {
            if (TypeOfLearnLB.SelectedIndex > -1)
            {
                var g = new gzera();

                var Selected = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == TypeOfLearnLB.SelectedItem.ToString());

                if (Selected != null)
                {
                    g.TypeOfLearns.Remove(Selected);

                    await g.SaveChangesAsync();

                    AddSpace.Clear();

                    desc.Clear();

                    TypeOfLearnWindow_Load(sender, e);
                }
            }
        }

        private async void TypeOfLearnLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            desc.Clear();
            AddSpace.Clear();

            if (TypeOfLearnLB.SelectedIndex > -1)
            {
                var g = new gzera();
                var Selected = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == TypeOfLearnLB.SelectedItem.ToString());

                if (Selected != null)
                {
                    AddSpace.Text = Selected.NameOf;
                    desc.Text = Selected.Description;
                }
            }
        }
    }
}
