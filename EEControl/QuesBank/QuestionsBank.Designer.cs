namespace EEControl.QuesBank
{
    partial class QuestionsBank
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
            SubjectCombo = new DesktopSupport.FixedStringComboBox();
            label1 = new Label();
            QuestionsFlow = new FlowLayoutPanel();
            AddQues = new DesktopSupport.SkyButton();
            label2 = new Label();
            Save = new DesktopSupport.SkyButton();
            SuspendLayout();
            // 
            // SubjectCombo
            // 
            SubjectCombo.Font = new Font("Tahoma", 10F);
            SubjectCombo.FormattingEnabled = true;
            SubjectCombo.Location = new Point(12, 12);
            SubjectCombo.Name = "SubjectCombo";
            SubjectCombo.ReadOnly = false;
            SubjectCombo.Size = new Size(121, 24);
            SubjectCombo.TabIndex = 0;
            SubjectCombo.SelectedIndexChanged += SubjectCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 16);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "اختيار المادة";
            // 
            // QuestionsFlow
            // 
            QuestionsFlow.AutoScroll = true;
            QuestionsFlow.Location = new Point(12, 85);
            QuestionsFlow.Name = "QuestionsFlow";
            QuestionsFlow.Size = new Size(472, 353);
            QuestionsFlow.TabIndex = 2;
            // 
            // AddQues
            // 
            AddQues.BackColor = SystemColors.Highlight;
            AddQues.BackgroundImageLayout = ImageLayout.Stretch;
            AddQues.DefaultColor = SystemColors.Highlight;
            AddQues.FlatAppearance.BorderSize = 0;
            AddQues.FlatStyle = FlatStyle.Flat;
            AddQues.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddQues.ForeColor = SystemColors.Control;
            AddQues.Hover = Color.Empty;
            AddQues.Location = new Point(409, 7);
            AddQues.Name = "AddQues";
            AddQues.Size = new Size(75, 30);
            AddQues.TabIndex = 3;
            AddQues.Text = "اضف";
            AddQues.UseVisualStyleBackColor = false;
            AddQues.Click += AddQues_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 67);
            label2.Name = "label2";
            label2.Size = new Size(280, 15);
            label2.TabIndex = 4;
            label2.Text = "لاحظ ان الاسئلة الخاصة بك هي من تستطيع تعديلها فقط";
            // 
            // Save
            // 
            Save.BackColor = SystemColors.Highlight;
            Save.BackgroundImageLayout = ImageLayout.Stretch;
            Save.DefaultColor = SystemColors.Highlight;
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save.ForeColor = SystemColors.Control;
            Save.Hover = Color.Empty;
            Save.Location = new Point(409, 43);
            Save.Name = "Save";
            Save.Size = new Size(75, 30);
            Save.TabIndex = 5;
            Save.Text = "حفظ";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // QuestionsBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 450);
            Controls.Add(Save);
            Controls.Add(label2);
            Controls.Add(AddQues);
            Controls.Add(QuestionsFlow);
            Controls.Add(label1);
            Controls.Add(SubjectCombo);
            Name = "QuestionsBank";
            Text = "QuestionsBank";
            Load += QuestionsBank_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DesktopSupport.FixedStringComboBox SubjectCombo;
        private Label label1;
        private FlowLayoutPanel QuestionsFlow;
        private DesktopSupport.SkyButton AddQues;
        private Label label2;
        private DesktopSupport.SkyButton Save;
    }
}