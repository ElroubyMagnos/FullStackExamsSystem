namespace EEControl.Exams
{
    partial class ExamsMain
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
            ExamSpace = new FlowLayoutPanel();
            Delete = new Button();
            AddNewExam = new Button();
            SuspendLayout();
            // 
            // ExamSpace
            // 
            ExamSpace.Location = new Point(12, 12);
            ExamSpace.Name = "ExamSpace";
            ExamSpace.Size = new Size(607, 245);
            ExamSpace.TabIndex = 0;
            // 
            // Delete
            // 
            Delete.Location = new Point(531, 263);
            Delete.Name = "Delete";
            Delete.Size = new Size(88, 23);
            Delete.TabIndex = 1;
            Delete.Text = "حذف المختار";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // AddNewExam
            // 
            AddNewExam.Location = new Point(12, 263);
            AddNewExam.Name = "AddNewExam";
            AddNewExam.Size = new Size(121, 23);
            AddNewExam.TabIndex = 2;
            AddNewExam.Text = "اضافة امتحان جديد";
            AddNewExam.UseVisualStyleBackColor = true;
            AddNewExam.Click += AddNewExam_Click;
            // 
            // ExamsMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 298);
            Controls.Add(AddNewExam);
            Controls.Add(Delete);
            Controls.Add(ExamSpace);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ExamsMain";
            Text = "الامتحانات";
            Load += ExamsMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ExamSpace;
        private Button Delete;
        private Button AddNewExam;
    }
}