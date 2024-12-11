namespace EEControl.Students
{
    partial class StudentInfo
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
            StudentsGrid = new DataGridView();
            IDNumber = new DesktopSupport.FixedIntBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SecretNumber = new DesktopSupport.FixedIntBox();
            Speciality = new DesktopSupport.FixedStringComboBox();
            label4 = new Label();
            label5 = new Label();
            GradeYear = new DesktopSupport.FixedStringComboBox();
            NameOfStudent = new TextBox();
            label6 = new Label();
            GroupOfStudent = new DesktopSupport.FixedIntBox();
            label7 = new Label();
            Delete = new Button();
            EditChoosen = new Button();
            SearchBox = new TextBox();
            NameSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).BeginInit();
            SuspendLayout();
            // 
            // StudentsGrid
            // 
            StudentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsGrid.Location = new Point(12, 172);
            StudentsGrid.MultiSelect = false;
            StudentsGrid.Name = "StudentsGrid";
            StudentsGrid.ReadOnly = true;
            StudentsGrid.Size = new Size(490, 128);
            StudentsGrid.TabIndex = 0;
            StudentsGrid.SelectionChanged += StudentsGrid_SelectionChanged;
            // 
            // IDNumber
            // 
            IDNumber.Font = new Font("Tahoma", 10F);
            IDNumber.Location = new Point(315, 14);
            IDNumber.Name = "IDNumber";
            IDNumber.ReadOnly = true;
            IDNumber.RightToLeft = RightToLeft.Yes;
            IDNumber.Size = new Size(100, 24);
            IDNumber.TabIndex = 1;
            IDNumber.Value = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(421, 18);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "المعرف الرقمي";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 22);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "الاسم";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 60);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "الرقم السري";
            // 
            // SecretNumber
            // 
            SecretNumber.Font = new Font("Tahoma", 10F);
            SecretNumber.Location = new Point(315, 56);
            SecretNumber.Name = "SecretNumber";
            SecretNumber.ReadOnly = true;
            SecretNumber.RightToLeft = RightToLeft.Yes;
            SecretNumber.Size = new Size(100, 24);
            SecretNumber.TabIndex = 5;
            SecretNumber.Value = 0;
            // 
            // Speciality
            // 
            Speciality.DropDownStyle = ComboBoxStyle.DropDownList;
            Speciality.Font = new Font("Tahoma", 10F);
            Speciality.FormattingEnabled = true;
            Speciality.Location = new Point(12, 60);
            Speciality.Name = "Speciality";
            Speciality.ReadOnly = false;
            Speciality.RightToLeft = RightToLeft.Yes;
            Speciality.Size = new Size(100, 24);
            Speciality.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 65);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "التخصص";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 102);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 10;
            label5.Text = "العام الدراسي";
            // 
            // GradeYear
            // 
            GradeYear.DropDownStyle = ComboBoxStyle.DropDownList;
            GradeYear.Font = new Font("Tahoma", 10F);
            GradeYear.FormattingEnabled = true;
            GradeYear.Location = new Point(315, 97);
            GradeYear.Name = "GradeYear";
            GradeYear.ReadOnly = false;
            GradeYear.RightToLeft = RightToLeft.Yes;
            GradeYear.Size = new Size(100, 24);
            GradeYear.TabIndex = 9;
            // 
            // NameOfStudent
            // 
            NameOfStudent.Location = new Point(12, 19);
            NameOfStudent.Name = "NameOfStudent";
            NameOfStudent.ReadOnly = true;
            NameOfStudent.RightToLeft = RightToLeft.Yes;
            NameOfStudent.Size = new Size(100, 23);
            NameOfStudent.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 101);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 13;
            label6.Text = "المجموعة";
            // 
            // GroupOfStudent
            // 
            GroupOfStudent.Font = new Font("Tahoma", 10F);
            GroupOfStudent.Location = new Point(36, 97);
            GroupOfStudent.Name = "GroupOfStudent";
            GroupOfStudent.RightToLeft = RightToLeft.Yes;
            GroupOfStudent.Size = new Size(76, 24);
            GroupOfStudent.TabIndex = 12;
            GroupOfStudent.Value = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 101);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 14;
            label7.Text = "G-";
            // 
            // Delete
            // 
            Delete.Location = new Point(403, 306);
            Delete.Name = "Delete";
            Delete.Size = new Size(99, 23);
            Delete.TabIndex = 15;
            Delete.Text = "حذف المختار";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // EditChoosen
            // 
            EditChoosen.Location = new Point(298, 306);
            EditChoosen.Name = "EditChoosen";
            EditChoosen.Size = new Size(99, 23);
            EditChoosen.TabIndex = 16;
            EditChoosen.Text = "حفظ التعديلات";
            EditChoosen.UseVisualStyleBackColor = true;
            EditChoosen.Click += EditChoosen_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(93, 143);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "ادخل اسم الطالب";
            SearchBox.RightToLeft = RightToLeft.Yes;
            SearchBox.Size = new Size(409, 23);
            SearchBox.TabIndex = 17;
            SearchBox.KeyDown += SearchBox_KeyDown;
            // 
            // NameSearch
            // 
            NameSearch.Location = new Point(12, 143);
            NameSearch.Name = "NameSearch";
            NameSearch.Size = new Size(75, 23);
            NameSearch.TabIndex = 18;
            NameSearch.Text = "بحث بالاسم";
            NameSearch.UseVisualStyleBackColor = true;
            NameSearch.Click += NameSearch_Click;
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 335);
            Controls.Add(NameSearch);
            Controls.Add(SearchBox);
            Controls.Add(EditChoosen);
            Controls.Add(Delete);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(GroupOfStudent);
            Controls.Add(NameOfStudent);
            Controls.Add(label5);
            Controls.Add(GradeYear);
            Controls.Add(label4);
            Controls.Add(Speciality);
            Controls.Add(label3);
            Controls.Add(SecretNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IDNumber);
            Controls.Add(StudentsGrid);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "StudentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لوحة تحكم الطلاب";
            Load += StudentInfo_Load;
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentsGrid;
        private DesktopSupport.FixedIntBox IDNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private DesktopSupport.FixedIntBox SecretNumber;
        private DesktopSupport.FixedStringComboBox Speciality;
        private Label label4;
        private Label label5;
        private DesktopSupport.FixedStringComboBox GradeYear;
        private TextBox NameOfStudent;
        private Label label6;
        private DesktopSupport.FixedIntBox GroupOfStudent;
        private Label label7;
        private Button Delete;
        private Button EditChoosen;
        private TextBox SearchBox;
        private Button NameSearch;
    }
}