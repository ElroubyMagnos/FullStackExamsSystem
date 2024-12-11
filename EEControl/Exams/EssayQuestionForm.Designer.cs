namespace EEControl.Exams
{
    partial class EssayQuestionForm
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
            Marks = new DesktopSupport.FixedIntBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Location = new Point(8, 9);
            Title.Name = "Title";
            Title.RightToLeft = RightToLeft.Yes;
            Title.Size = new Size(200, 96);
            Title.TabIndex = 1;
            Title.Text = "";
            Title.Click += AllInOne;
            // 
            // Marks
            // 
            Marks.Font = new Font("Tahoma", 10F);
            Marks.Location = new Point(8, 111);
            Marks.Name = "Marks";
            Marks.Size = new Size(111, 24);
            Marks.TabIndex = 2;
            Marks.Text = "1";
            Marks.TextAlign = HorizontalAlignment.Center;
            Marks.Value = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 115);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "اجمالي الدرجات";
            // 
            // EssayQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(Marks);
            Controls.Add(Title);
            Name = "EssayQuestionForm";
            Size = new Size(219, 158);
            Load += EssayQuestionForm_Load;
            Click += AllInOne;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox Title;
        private Label label1;
        public DesktopSupport.FixedIntBox Marks;
    }
}
