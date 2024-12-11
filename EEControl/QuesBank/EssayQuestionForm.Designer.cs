namespace EEControl.Bank
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
            Removeit = new DesktopSupport.SkyButton();
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
            Removeit.Location = new Point(8, 111);
            Removeit.Name = "Removeit";
            Removeit.Size = new Size(41, 30);
            Removeit.TabIndex = 3;
            Removeit.Text = "X";
            Removeit.UseVisualStyleBackColor = false;
            Removeit.Click += Removeit_Click;
            // 
            // EssayQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Removeit);
            Controls.Add(Title);
            Name = "EssayQuestionForm";
            Size = new Size(219, 153);
            Load += EssayQuestionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        public RichTextBox Title;
        private DesktopSupport.SkyButton Removeit;
    }
}
