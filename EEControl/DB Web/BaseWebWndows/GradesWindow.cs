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

namespace EEControl.DB_Web.BaseWebWndows
{
    public partial class GradesWindow : Form
    {
        public GradesWindow()
        {
            InitializeComponent();

            FirstLoad();
        }

        async void FirstLoad()
        {
            var g = new gzera();

            var Selected = await g.TypeOfLearns.ToListAsync();

            if (Selected == null)
                return;

            foreach (var slct in Selected)
            {
                TypeOfLearnLB.Items.Add(slct.NameOf);
            }
        }

        private async void TypeOfLearnWindow_Load(object sender, EventArgs e)
        {
            GOfYear.Items.Clear();

            var g = new gzera();

            if (TypeOfLearnLB.SelectedItem == null)
                return;

            var Typo = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == TypeOfLearnLB.SelectedItem.ToString());

            var Selected = await g.GradeOfYears.Where(x => x.TypeOfLearnID == Typo.ID).ToListAsync();

            if (Selected != null)
            {
                foreach (var select in Selected)
                {
                    GOfYear.Items.Add(select.IDOfGrade);
                }
            }
        }

        private async void Add_Click(object sender, EventArgs e)
        {
            if (AddIntSpace.Value > 0)
            {
                gzera g = new gzera();

                if ((await g.GradeOfYears.FirstOrDefaultAsync(x => x.IDOfGrade == AddIntSpace.Value)) != null)
                {
                    MessageBox.Show("يوجد بالفعل هذا التخصص");
                    return;
                }

                if (desc.Text.Length < 5)
                {
                    MessageBox.Show("لا يمكنك اضافة عام دراسي بدون وصف من علي الاقل 5 احرف");
                    return;
                }

                if (TypeOfLearnLB.SelectedIndex <= -1)
                {
                    return;
                }

                var TypeOLID = await g.TypeOfLearns
                    .FirstOrDefaultAsync(x => x.NameOf == TypeOfLearnLB.SelectedItem.ToString());

                if (TypeOLID != null)
                {
                    if ((await g.GradeOfYears.FirstOrDefaultAsync(x => x.IDOfGrade == AddIntSpace.Value)) != null)
                    {
                        MessageBox.Show("هذا العام الدراسي موجود بالفعل");
                        return;
                    }

                    g.GradeOfYears.Add(new GradeOfYear
                    {
                        IDOfGrade = AddIntSpace.Value,
                        Description = desc.Text,
                        TypeOfLearnID = TypeOLID.ID
                    });

                    await g.SaveChangesAsync();
                }

                AddIntSpace.Clear();

                desc.Clear();

                TypeOfLearnWindow_Load(sender, e);
            }
            else MessageBox.Show("يرجي كتابة اسم التخصص اولاً");
        }

        private async void DeleteSelected_Click(object sender, EventArgs e)
        {
            if (GOfYear.SelectedIndex > -1)
            {
                var g = new gzera();

                var SelectedTypeof = await g.TypeOfLearns
                    .FirstOrDefaultAsync(x => x.NameOf == TypeOfLearnLB.SelectedItem.ToString());

                if (SelectedTypeof != null)
                {
                    var Selected = await g.GradeOfYears.FirstOrDefaultAsync(x => x.TypeOfLearnID == SelectedTypeof.ID);

                    if (Selected != null)
                    {
                        g.GradeOfYears.Remove(Selected);

                        await g.SaveChangesAsync();

                        AddIntSpace.Clear();

                        desc.Clear();

                        TypeOfLearnWindow_Load(sender, e);
                    }
                }
            }
        }

        private async void TypeOfLearnLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            desc.Clear();
            AddIntSpace.Clear();
            GOfYear.Items.Clear();

            var g = new gzera();

            var Selected = await g.TypeOfLearns
                .FirstOrDefaultAsync(x => x.NameOf == TypeOfLearnLB.SelectedItem.ToString());

            if (Selected != null)
            {
                var SelectedOfYear = await g.GradeOfYears
                    .Where(x => x.TypeOfLearnID == Selected.ID).ToListAsync();

                foreach (GradeOfYear goy in SelectedOfYear)
                {
                    GOfYear.Items.Add(goy.IDOfGrade);
                }
            }
        }

        private async void GOfYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var g = new gzera();

            desc.Text = "";

            var CurrentNumber = GOfYear.SelectedItem.ToString().IntOrDefault();

            var Selected = await g.GradeOfYears
                .FirstOrDefaultAsync(x => x.TypeOfLearnID == CurrentNumber);

            if (Selected != null)
            {
                desc.Text = Selected.Description;
            }
        }
    }
}
