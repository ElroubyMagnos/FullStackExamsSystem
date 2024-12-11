namespace EEControl.Exams
{
    partial class RightWrongQuestionForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new RichTextBox();
            Answer = new CheckBox();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Location = new Point(3, 4);
            Title.Name = "Title";
            Title.Size = new Size(190, 96);
            Title.TabIndex = 0;
            Title.Text = "";
            Title.Click += AllInOne;
            // 
            // Answer
            // 
            Answer.AutoSize = true;
            Answer.Font = new Font("Segoe UI", 9F);
            Answer.Location = new Point(64, 106);
            Answer.Name = "Answer";
            Answer.Size = new Size(56, 19);
            Answer.TabIndex = 1;
            Answer.Text = "الاجابة";
            Answer.UseVisualStyleBackColor = true;
            Answer.Click += AllInOne;
            // 
            // RightWrongQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Answer);
            Controls.Add(Title);
            Name = "RightWrongQuestionForm";
            Size = new Size(196, 136);
            Load += RightWrongQuestionForm_Load;
            Click += AllInOne;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox Title;
        public CheckBox Answer;
    }
}
