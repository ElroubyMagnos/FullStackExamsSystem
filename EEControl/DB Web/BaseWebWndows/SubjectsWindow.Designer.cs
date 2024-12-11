namespace EEControl.DB_Web.BaseWebWndows
{
    partial class SubjectsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AllSubjects = new ListBox();
            SpecialityCB = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            GradeYearCB = new ComboBox();
            SubjectSpace = new TextBox();
            AddBtn = new Button();
            SaveSubj = new Button();
            DeleteSelected = new Button();
            SuspendLayout();
            // 
            // AllSubjects
            // 
            AllSubjects.FormattingEnabled = true;
            AllSubjects.ItemHeight = 15;
            AllSubjects.Location = new Point(12, 12);
            AllSubjects.Name = "AllSubjects";
            AllSubjects.Size = new Size(120, 139);
            AllSubjects.TabIndex = 0;
            AllSubjects.SelectedIndexChanged += AllSubjects_SelectedIndexChanged;
            // 
            // SpecialityCB
            // 
            SpecialityCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecialityCB.FormattingEnabled = true;
            SpecialityCB.Location = new Point(138, 32);
            SpecialityCB.Name = "SpecialityCB";
            SpecialityCB.Size = new Size(121, 23);
            SpecialityCB.TabIndex = 1;
            SpecialityCB.TextChanged += Speciality_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 14);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "التخصص";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 67);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "العام الدراسي";
            // 
            // GradeYearCB
            // 
            GradeYearCB.DropDownStyle = ComboBoxStyle.DropDownList;
            GradeYearCB.FormattingEnabled = true;
            GradeYearCB.Location = new Point(138, 85);
            GradeYearCB.Name = "GradeYearCB";
            GradeYearCB.Size = new Size(121, 23);
            GradeYearCB.TabIndex = 3;
            // 
            // SubjectSpace
            // 
            SubjectSpace.Location = new Point(12, 157);
            SubjectSpace.Name = "SubjectSpace";
            SubjectSpace.PlaceholderText = "ادخال مادة";
            SubjectSpace.RightToLeft = RightToLeft.Yes;
            SubjectSpace.Size = new Size(120, 23);
            SubjectSpace.TabIndex = 5;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(12, 186);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(58, 23);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "اضافة";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // SaveSubj
            // 
            SaveSubj.Location = new Point(138, 186);
            SaveSubj.Name = "SaveSubj";
            SaveSubj.Size = new Size(118, 23);
            SaveSubj.TabIndex = 7;
            SaveSubj.Text = "حفظ حالة المادة";
            SaveSubj.UseVisualStyleBackColor = true;
            SaveSubj.Click += SaveSubj_Click;
            // 
            // DeleteSelected
            // 
            DeleteSelected.Location = new Point(76, 186);
            DeleteSelected.Name = "DeleteSelected";
            DeleteSelected.Size = new Size(56, 23);
            DeleteSelected.TabIndex = 8;
            DeleteSelected.Text = "حذف";
            DeleteSelected.UseVisualStyleBackColor = true;
            DeleteSelected.Click += DeleteSelected_Click;
            // 
            // SubjectsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 224);
            Controls.Add(DeleteSelected);
            Controls.Add(SaveSubj);
            Controls.Add(AddBtn);
            Controls.Add(SubjectSpace);
            Controls.Add(label2);
            Controls.Add(GradeYearCB);
            Controls.Add(label1);
            Controls.Add(SpecialityCB);
            Controls.Add(AllSubjects);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SubjectsWindow";
            Text = "اضافة المواد";
            Load += SubjectsWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox AllSubjects;
        private ComboBox SpecialityCB;
        private Label label1;
        private Label label2;
        private ComboBox GradeYearCB;
        private TextBox SubjectSpace;
        private Button AddBtn;
        private Button SaveSubj;
        private Button DeleteSelected;
    }
}