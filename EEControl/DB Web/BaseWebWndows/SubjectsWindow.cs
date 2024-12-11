using EntityBaseEE.Classes;
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
    public partial class SubjectsWindow : Form
    {
        public SubjectsWindow()
        {
            InitializeComponent();
        }

        private async void Speciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            GradeYearCB.Items.Clear();

            var g = new gzera();

            var SelectedSpec = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == SpecialityCB.Text);

            if (SelectedSpec == null)
                return;

            var SelectedGrade = await g.GradeOfYears.Where(x => x.TypeOfLearnID == SelectedSpec.ID).ToListAsync();

            if (SelectedGrade == null)
                return;

            foreach (GradeOfYear goy in SelectedGrade)
            {
                GradeYearCB.Items.Add(goy.IDOfGrade);
            }
        }

        private async void SubjectsWindow_Load(object sender, EventArgs e)
        {
            SpecialityCB.Items.Clear();

            var g = new gzera();
            var AllSpec = await g.TypeOfLearns.ToListAsync();

            foreach (TypeOfLearn spec in AllSpec)
            {
                SpecialityCB.Items.Add(spec.NameOf);
            }

            var allsubjects = await g.Subjects.ToListAsync();

            foreach (Subject s in allsubjects)
            {
                AllSubjects.Items.Add(s.Title);
            }
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            AllSubjects.Items.Clear();

            var g = new gzera();

            if (SubjectSpace.Text.Length < 3)
            {
                MessageBox.Show("يرجي كتابة اكثر من ثلاثة احرف في خانة المادة");
                return;
            }

            if (GradeYearCB.Text.Length == 0 || SpecialityCB.Text.Length == 0)
            {
                MessageBox.Show("يرجي اختيار التخصص والعام الدراسي");
                return;
            }

            var spec = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == SpecialityCB.Text);

            if (spec == null)
            {
                MessageBox.Show("لا يوجد هذا التخصص");
                return;
            }

            var grade = await g.GradeOfYears.FirstOrDefaultAsync(x => x.TypeOfLearnID == spec.ID);

            if (grade == null)
            {
                MessageBox.Show("لا يوجد هذا العام الدراسي");
                return;
            }

            g.Subjects.Add(new Subject()
            {
                Title = SubjectSpace.Text,
                Specality = spec.ID,
                GradeYear = grade.IDOfGrade
            });

            SubjectSpace.Text = "";

            await g.SaveChangesAsync();

            var AllSubjectsQuery = await g.Subjects.ToListAsync();

            foreach (Subject asq in AllSubjectsQuery)
            {
                AllSubjects.Items.Add(asq.Title);
            }
        }

        private async void DeleteSelected_Click(object sender, EventArgs e)
        {
            var g = new gzera();

            var Selected = await g.Subjects.FirstOrDefaultAsync(x => x.Title == AllSubjects.Text);

            if (Selected == null)
            {
                MessageBox.Show("قم باختيار المادة للحذف");
                return;
            }

            g.Subjects.Remove(Selected);

            await g.SaveChangesAsync();
        }

        private async void SaveSubj_Click(object sender, EventArgs e)
        {
            var g = new gzera();

            if (AllSubjects.Text.Length == 0)
            {
                MessageBox.Show("يرجي اختيار المادة");
                return;
            }

            if (SpecialityCB.Text.Length == 0)
            {
                MessageBox.Show("يرجي اختيار التخصص");
                return;
            }

            if (GradeYearCB.Text.Length == 0)
            {
                MessageBox.Show("يرجي اختيار العام الدراسي");
                return;
            }

            var spec = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.NameOf == SpecialityCB.Text);

            if (spec == null)
            {
                MessageBox.Show("هذا التخصص غير موجود بالخدمة");
                return;
            }

            var grade = await g.GradeOfYears.FirstOrDefaultAsync(x => x.TypeOfLearnID == spec.ID);

            if (grade == null)
            {
                MessageBox.Show("هذا العام الدراسي غير موجود في التخصص");
                return;
            }

            var existselect = await g.Subjects
                .FirstOrDefaultAsync(x =>
                x.ID == SelectedID
                );

            if (existselect == null)
            {
                MessageBox.Show("لا توجد هذه المادة لتعديلها");
                return;
            }

            var g2 = new gzera();

            var subj = new Subject()
            {
                ID = existselect.ID,
                Specality = spec.ID,
                GradeYear = grade.IDOfGrade,
                Title = AllSubjects.Text
            };

            g2.Subjects.Update(subj);

            await g2.SaveChangesAsync();
        }
        public static int SelectedID { get; set; } = 0;
        private async void AllSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            GradeYearCB.Text = SpecialityCB.Text = "";

            GradeYearCB.Items.Clear();

            var g = new gzera();

            var subject = await g.Subjects.FirstOrDefaultAsync(x => x.Title == AllSubjects.Text);

            SelectedID = subject.ID;

            if (subject != null)
            {
                var spec = await g.TypeOfLearns.FirstOrDefaultAsync(x => x.ID == subject.Specality);

                if (spec != null)
                {
                    var grade = await g.GradeOfYears.FirstOrDefaultAsync(x => x.IDOfGrade == subject.GradeYear);

                    if (grade != null)
                    {
                        SpecialityCB.Text = spec.NameOf;

                        if (!GradeYearCB.Items.Contains(grade.IDOfGrade.ToString()))
                            GradeYearCB.Items.Add(grade.IDOfGrade.ToString());

                        GradeYearCB.Text = grade.IDOfGrade.ToString();


                    }
                }
            }
        }
    }
}
