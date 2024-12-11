namespace EEControl.DB_Web
{
    partial class BaseWebWindow
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
            TypeOfLearn = new Button();
            Grades = new Button();
            AddSubjects = new Button();
            SuspendLayout();
            // 
            // TypeOfLearn
            // 
            TypeOfLearn.Location = new Point(12, 12);
            TypeOfLearn.Name = "TypeOfLearn";
            TypeOfLearn.Size = new Size(157, 51);
            TypeOfLearn.TabIndex = 0;
            TypeOfLearn.Text = "اضافة التخصصات";
            TypeOfLearn.UseVisualStyleBackColor = true;
            TypeOfLearn.Click += TypeOfLearn_Click;
            // 
            // Grades
            // 
            Grades.Location = new Point(175, 12);
            Grades.Name = "Grades";
            Grades.Size = new Size(157, 51);
            Grades.TabIndex = 1;
            Grades.Text = "اضافة الاعوام لكل تخصص";
            Grades.UseVisualStyleBackColor = true;
            Grades.Click += Grades_Click;
            // 
            // AddSubjects
            // 
            AddSubjects.Location = new Point(98, 69);
            AddSubjects.Name = "AddSubjects";
            AddSubjects.Size = new Size(157, 51);
            AddSubjects.TabIndex = 2;
            AddSubjects.Text = "اضافة المواد";
            AddSubjects.UseVisualStyleBackColor = true;
            AddSubjects.Click += AddSubjects_Click;
            // 
            // BaseWebWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 131);
            Controls.Add(AddSubjects);
            Controls.Add(Grades);
            Controls.Add(TypeOfLearn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "BaseWebWindow";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button TypeOfLearn;
        private Button Grades;
        private Button AddSubjects;
    }
}