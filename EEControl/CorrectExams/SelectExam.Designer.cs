namespace EEControl.CorrectExams
{
    partial class SelectExam
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
            SuspendLayout();
            // 
            // ExamSpace
            // 
            ExamSpace.Location = new Point(12, 12);
            ExamSpace.Name = "ExamSpace";
            ExamSpace.Size = new Size(607, 245);
            ExamSpace.TabIndex = 1;
            // 
            // SelectExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 267);
            Controls.Add(ExamSpace);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "SelectExam";
            Text = "اختر مادتك للتصحيح";
            Load += SelectExam_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ExamSpace;
    }
}