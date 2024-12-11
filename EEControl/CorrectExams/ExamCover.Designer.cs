namespace EEControl.CorrectExams
{
    partial class ExamCover
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
            Subject = new Label();
            Title = new TextBox();
            picbox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            SuspendLayout();
            // 
            // Subject
            // 
            Subject.AutoSize = true;
            Subject.Location = new Point(5, 135);
            Subject.Name = "Subject";
            Subject.Size = new Size(59, 15);
            Subject.TabIndex = 5;
            Subject.Text = "اسم المادة";
            Subject.Click += All_Click;
            // 
            // Title
            // 
            Title.Location = new Point(5, 97);
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.RightToLeft = RightToLeft.Yes;
            Title.Size = new Size(140, 23);
            Title.TabIndex = 4;
            Title.TextAlign = HorizontalAlignment.Center;
            Title.Click += All_Click;
            // 
            // picbox
            // 
            picbox.BackgroundImage = Properties.Resources.logo;
            picbox.BackgroundImageLayout = ImageLayout.Stretch;
            picbox.Location = new Point(5, 0);
            picbox.Name = "picbox";
            picbox.Size = new Size(140, 91);
            picbox.TabIndex = 3;
            picbox.TabStop = false;
            picbox.Click += All_Click;
            // 
            // ExamCover
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Subject);
            Controls.Add(Title);
            Controls.Add(picbox);
            Name = "ExamCover";
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label Subject;
        public TextBox Title;
        public PictureBox picbox;
    }
}
