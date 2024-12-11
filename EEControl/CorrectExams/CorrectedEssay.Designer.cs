namespace EEControl.CorrectExams
{
    partial class CorrectedEssay
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
            Question = new RichTextBox();
            Answer = new RichTextBox();
            RightBtn = new DesktopSupport.SkyButton();
            Points = new DesktopSupport.FixedIntBox();
            label1 = new Label();
            label2 = new Label();
            MaxPoints = new DesktopSupport.FixedIntBox();
            SuspendLayout();
            // 
            // Question
            // 
            Question.Location = new Point(3, 0);
            Question.Name = "Question";
            Question.ReadOnly = true;
            Question.Size = new Size(354, 61);
            Question.TabIndex = 0;
            Question.Text = "";
            // 
            // Answer
            // 
            Answer.Location = new Point(3, 67);
            Answer.Name = "Answer";
            Answer.ReadOnly = true;
            Answer.Size = new Size(354, 61);
            Answer.TabIndex = 1;
            Answer.Text = "";
            // 
            // RightBtn
            // 
            RightBtn.BackColor = SystemColors.Highlight;
            RightBtn.BackgroundImageLayout = ImageLayout.Stretch;
            RightBtn.DefaultColor = SystemColors.Highlight;
            RightBtn.FlatAppearance.BorderSize = 0;
            RightBtn.FlatStyle = FlatStyle.Flat;
            RightBtn.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RightBtn.ForeColor = SystemColors.Control;
            RightBtn.Hover = Color.Empty;
            RightBtn.Location = new Point(282, 142);
            RightBtn.Name = "RightBtn";
            RightBtn.Size = new Size(75, 30);
            RightBtn.TabIndex = 2;
            RightBtn.Text = "تعيين";
            RightBtn.UseVisualStyleBackColor = false;
            RightBtn.Click += RightBtn_Click;
            // 
            // Points
            // 
            Points.Font = new Font("Tahoma", 10F);
            Points.Location = new Point(144, 147);
            Points.Name = "Points";
            Points.Size = new Size(60, 24);
            Points.TabIndex = 3;
            Points.Text = "0";
            Points.Value = 0;
            Points.TextChanged += Points_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 151);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(49, 15);
            label1.TabIndex = 4;
            label1.Text = "الدرجات:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 151);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(25, 15);
            label2.TabIndex = 5;
            label2.Text = "من:";
            // 
            // MaxPoints
            // 
            MaxPoints.Font = new Font("Tahoma", 10F);
            MaxPoints.Location = new Point(23, 147);
            MaxPoints.Name = "MaxPoints";
            MaxPoints.ReadOnly = true;
            MaxPoints.Size = new Size(60, 24);
            MaxPoints.TabIndex = 6;
            MaxPoints.Text = "0";
            MaxPoints.Value = 0;
            // 
            // CorrectedEssay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MaxPoints);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Points);
            Controls.Add(RightBtn);
            Controls.Add(Answer);
            Controls.Add(Question);
            Name = "CorrectedEssay";
            Size = new Size(360, 179);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DesktopSupport.SkyButton RightBtn;
        public RichTextBox Question;
        public RichTextBox Answer;
        private DesktopSupport.FixedIntBox Points;
        private Label label1;
        private Label label2;
        private DesktopSupport.FixedIntBox MaxPoints;
    }
}
