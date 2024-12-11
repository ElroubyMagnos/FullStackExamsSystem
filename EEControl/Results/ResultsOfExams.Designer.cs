namespace EEControl.Results
{
    partial class ResultsOfExams
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
            ExamsLayout = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // ExamsLayout
            // 
            ExamsLayout.Location = new Point(12, 12);
            ExamsLayout.Name = "ExamsLayout";
            ExamsLayout.Size = new Size(538, 288);
            ExamsLayout.TabIndex = 0;
            // 
            // ResultsOfExams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 312);
            Controls.Add(ExamsLayout);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "ResultsOfExams";
            Text = "نتيجة الامتحانات";
            Load += ResultsOfExams_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ExamsLayout;
    }
}