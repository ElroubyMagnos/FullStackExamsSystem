namespace EEControl.Bank
{
    partial class ChooseQuestionForm
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
            QuestionTitle = new RichTextBox();
            Answer1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Answer2 = new TextBox();
            label3 = new Label();
            Answer4 = new TextBox();
            label4 = new Label();
            Answer3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Answer = new DesktopSupport.FixedStringComboBox();
            Removeit = new DesktopSupport.SkyButton();
            SuspendLayout();
            // 
            // QuestionTitle
            // 
            QuestionTitle.Location = new Point(63, 3);
            QuestionTitle.Name = "QuestionTitle";
            QuestionTitle.RightToLeft = RightToLeft.Yes;
            QuestionTitle.Size = new Size(200, 96);
            QuestionTitle.TabIndex = 0;
            QuestionTitle.Text = "";
            // 
            // Answer1
            // 
            Answer1.Location = new Point(151, 105);
            Answer1.Name = "Answer1";
            Answer1.Size = new Size(93, 23);
            Answer1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 109);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(15, 15);
            label1.TabIndex = 2;
            label1.Text = "أ-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 110);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(23, 15);
            label2.TabIndex = 4;
            label2.Text = "ب-";
            // 
            // Answer2
            // 
            Answer2.Location = new Point(3, 106);
            Answer2.Name = "Answer2";
            Answer2.Size = new Size(97, 23);
            Answer2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 144);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(18, 15);
            label3.TabIndex = 8;
            label3.Text = "د-";
            // 
            // Answer4
            // 
            Answer4.Location = new Point(3, 140);
            Answer4.Name = "Answer4";
            Answer4.Size = new Size(97, 23);
            Answer4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 143);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(19, 15);
            label4.TabIndex = 6;
            label4.Text = "ج-";
            // 
            // Answer3
            // 
            Answer3.Location = new Point(151, 139);
            Answer3.Name = "Answer3";
            Answer3.Size = new Size(93, 23);
            Answer3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 40);
            label5.Name = "label5";
            label5.Size = new Size(26, 32);
            label5.TabIndex = 9;
            label5.Text = "؟";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(160, 183);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(37, 15);
            label6.TabIndex = 11;
            label6.Text = "الاجابة";
            // 
            // Answer
            // 
            Answer.DropDownStyle = ComboBoxStyle.DropDownList;
            Answer.Font = new Font("Tahoma", 10F);
            Answer.FormattingEnabled = true;
            Answer.Items.AddRange(new object[] { "أ", "ب", "ج", "د" });
            Answer.Location = new Point(93, 179);
            Answer.Name = "Answer";
            Answer.ReadOnly = false;
            Answer.Size = new Size(62, 24);
            Answer.TabIndex = 12;
            // 
            // Removeit
            // 
            Removeit.BackColor = SystemColors.Highlight;
            Removeit.BackgroundImageLayout = ImageLayout.Stretch;
            Removeit.DefaultColor = SystemColors.Highlight;
            Removeit.FlatAppearance.BorderSize = 0;
            Removeit.FlatStyle = FlatStyle.Flat;
            Removeit.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Removeit.ForeColor = SystemColors.Control;
            Removeit.Hover = Color.Empty;
            Removeit.Location = new Point(3, 178);
            Removeit.Name = "Removeit";
            Removeit.Size = new Size(41, 30);
            Removeit.TabIndex = 13;
            Removeit.Text = "X";
            Removeit.UseVisualStyleBackColor = false;
            Removeit.Click += Removeit_Click;
            // 
            // ChooseQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Removeit);
            Controls.Add(Answer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(Answer4);
            Controls.Add(label4);
            Controls.Add(Answer3);
            Controls.Add(label2);
            Controls.Add(Answer2);
            Controls.Add(label1);
            Controls.Add(Answer1);
            Controls.Add(QuestionTitle);
            Name = "ChooseQuestionForm";
            Size = new Size(266, 211);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        public RichTextBox QuestionTitle;
        public TextBox Answer1;
        public TextBox Answer2;
        public TextBox Answer4;
        public TextBox Answer3;
        public DesktopSupport.FixedStringComboBox Answer;
        private DesktopSupport.SkyButton Removeit;
    }
}
