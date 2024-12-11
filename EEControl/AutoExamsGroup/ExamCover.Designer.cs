namespace EEControl.AutoExams
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
            picbox = new PictureBox();
            Title = new TextBox();
            Subject = new Label();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            SuspendLayout();
            // 
            // picbox
            // 
            picbox.BackgroundImage = Properties.Resources.logo;
            picbox.BackgroundImageLayout = ImageLayout.Stretch;
            picbox.Location = new Point(3, 3);
            picbox.Name = "picbox";
            picbox.Size = new Size(140, 91);
            picbox.TabIndex = 0;
            picbox.TabStop = false;
            picbox.Click += All_Click;
            picbox.DoubleClick += All_DoubleClick;
            // 
            // Title
            // 
            Title.Location = new Point(3, 100);
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.RightToLeft = RightToLeft.Yes;
            Title.Size = new Size(140, 23);
            Title.TabIndex = 1;
            Title.TextAlign = HorizontalAlignment.Center;
            Title.Click += All_Click;
            Title.DoubleClick += All_DoubleClick;
            // 
            // Subject
            // 
            Subject.AutoSize = true;
            Subject.Location = new Point(3, 138);
            Subject.Name = "Subject";
            Subject.Size = new Size(59, 15);
            Subject.TabIndex = 2;
            Subject.Text = "اسم المادة";
            Subject.Click += All_Click;
            Subject.DoubleClick += All_DoubleClick;
            // 
            // ExamCover
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(Subject);
            Controls.Add(Title);
            Controls.Add(picbox);
            Name = "ExamCover";
            Size = new Size(145, 162);
            Click += All_Click;
            DoubleClick += All_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox picbox;
        public TextBox Title;
        public Label Subject;
    }
}
