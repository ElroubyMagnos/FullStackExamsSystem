namespace EEControl.Exams
{
    partial class AddExamNow
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
            QuestionsSwim = new FlowLayoutPanel();
            DeleteSelected = new Button();
            SpecalityCB = new DesktopSupport.FixedStringComboBox();
            GradeYearCB = new DesktopSupport.FixedStringComboBox();
            label1 = new Label();
            label2 = new Label();
            SaveExam = new Button();
            ClearAll = new Button();
            ExamGuidDesc = new TextBox();
            TitleOfExam = new TextBox();
            label3 = new Label();
            SubjectCB = new DesktopSupport.FixedStringComboBox();
            Cover = new PictureBox();
            ChoosePic = new Button();
            GetPic = new OpenFileDialog();
            Shuffle = new CheckBox();
            AddQuesPanel = new Button();
            SummonQuestions = new Button();
            ((System.ComponentModel.ISupportInitialize)Cover).BeginInit();
            SuspendLayout();
            // 
            // QuestionsSwim
            // 
            QuestionsSwim.AutoScroll = true;
            QuestionsSwim.Location = new Point(12, 56);
            QuestionsSwim.Name = "QuestionsSwim";
            QuestionsSwim.Size = new Size(327, 205);
            QuestionsSwim.TabIndex = 3;
            // 
            // DeleteSelected
            // 
            DeleteSelected.Location = new Point(12, 267);
            DeleteSelected.Name = "DeleteSelected";
            DeleteSelected.Size = new Size(90, 23);
            DeleteSelected.TabIndex = 4;
            DeleteSelected.Text = "حذف المختار";
            DeleteSelected.UseVisualStyleBackColor = true;
            DeleteSelected.Click += DeleteSelected_Click;
            // 
            // SpecalityCB
            // 
            SpecalityCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecalityCB.Font = new Font("Tahoma", 10F);
            SpecalityCB.FormattingEnabled = true;
            SpecalityCB.Location = new Point(345, 27);
            SpecalityCB.Name = "SpecalityCB";
            SpecalityCB.ReadOnly = false;
            SpecalityCB.Size = new Size(121, 24);
            SpecalityCB.TabIndex = 5;
            SpecalityCB.SelectedIndexChanged += SpecalityCB_SelectedIndexChanged;
            // 
            // GradeYearCB
            // 
            GradeYearCB.DropDownStyle = ComboBoxStyle.DropDownList;
            GradeYearCB.Font = new Font("Tahoma", 10F);
            GradeYearCB.FormattingEnabled = true;
            GradeYearCB.Location = new Point(345, 72);
            GradeYearCB.Name = "GradeYearCB";
            GradeYearCB.ReadOnly = false;
            GradeYearCB.Size = new Size(121, 24);
            GradeYearCB.TabIndex = 6;
            GradeYearCB.SelectedIndexChanged += GradeYearCB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "التخصص";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 54);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 8;
            label2.Text = "العام الدراسي";
            // 
            // SaveExam
            // 
            SaveExam.Location = new Point(345, 176);
            SaveExam.Name = "SaveExam";
            SaveExam.Size = new Size(121, 69);
            SaveExam.TabIndex = 9;
            SaveExam.Text = "حفظ الامتحان";
            SaveExam.UseVisualStyleBackColor = true;
            SaveExam.Click += SaveExam_Click;
            // 
            // ClearAll
            // 
            ClearAll.Location = new Point(345, 147);
            ClearAll.Name = "ClearAll";
            ClearAll.Size = new Size(121, 23);
            ClearAll.TabIndex = 10;
            ClearAll.Text = "حذف الكل";
            ClearAll.UseVisualStyleBackColor = true;
            ClearAll.Click += ClearAll_Click;
            // 
            // ExamGuidDesc
            // 
            ExamGuidDesc.Location = new Point(483, 12);
            ExamGuidDesc.Multiline = true;
            ExamGuidDesc.Name = "ExamGuidDesc";
            ExamGuidDesc.PlaceholderText = "تعليمات الامتحان";
            ExamGuidDesc.RightToLeft = RightToLeft.Yes;
            ExamGuidDesc.Size = new Size(166, 131);
            ExamGuidDesc.TabIndex = 11;
            // 
            // TitleOfExam
            // 
            TitleOfExam.Location = new Point(12, 12);
            TitleOfExam.Multiline = true;
            TitleOfExam.Name = "TitleOfExam";
            TitleOfExam.PlaceholderText = "اسم الامتحان";
            TitleOfExam.RightToLeft = RightToLeft.Yes;
            TitleOfExam.Size = new Size(327, 38);
            TitleOfExam.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 99);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 14;
            label3.Text = "المادة";
            // 
            // SubjectCB
            // 
            SubjectCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SubjectCB.Font = new Font("Tahoma", 10F);
            SubjectCB.FormattingEnabled = true;
            SubjectCB.Location = new Point(345, 117);
            SubjectCB.Name = "SubjectCB";
            SubjectCB.ReadOnly = false;
            SubjectCB.Size = new Size(121, 24);
            SubjectCB.TabIndex = 13;
            // 
            // Cover
            // 
            Cover.BackgroundImage = Properties.Resources.logo;
            Cover.BackgroundImageLayout = ImageLayout.Stretch;
            Cover.Location = new Point(483, 149);
            Cover.Name = "Cover";
            Cover.Size = new Size(166, 112);
            Cover.TabIndex = 15;
            Cover.TabStop = false;
            // 
            // ChoosePic
            // 
            ChoosePic.Location = new Point(483, 267);
            ChoosePic.Name = "ChoosePic";
            ChoosePic.Size = new Size(166, 23);
            ChoosePic.TabIndex = 16;
            ChoosePic.Text = "اختيار صورة";
            ChoosePic.UseVisualStyleBackColor = true;
            ChoosePic.Click += ChoosePic_Click;
            // 
            // GetPic
            // 
            GetPic.DefaultExt = "png";
            GetPic.Filter = "Png|*.png|Jpg|*.jpg";
            // 
            // Shuffle
            // 
            Shuffle.AutoSize = true;
            Shuffle.Location = new Point(345, 267);
            Shuffle.Name = "Shuffle";
            Shuffle.Size = new Size(66, 19);
            Shuffle.TabIndex = 17;
            Shuffle.Text = "عشوائي";
            Shuffle.UseVisualStyleBackColor = true;
            // 
            // AddQuesPanel
            // 
            AddQuesPanel.Location = new Point(264, 267);
            AddQuesPanel.Name = "AddQuesPanel";
            AddQuesPanel.Size = new Size(75, 23);
            AddQuesPanel.TabIndex = 18;
            AddQuesPanel.Text = "اضافة";
            AddQuesPanel.UseVisualStyleBackColor = true;
            AddQuesPanel.Click += AddQuesPanel_Click;
            // 
            // SummonQuestions
            // 
            SummonQuestions.Location = new Point(108, 267);
            SummonQuestions.Name = "SummonQuestions";
            SummonQuestions.Size = new Size(150, 23);
            SummonQuestions.TabIndex = 19;
            SummonQuestions.Text = "استدعاء اسئلة عشوائية";
            SummonQuestions.UseVisualStyleBackColor = true;
            SummonQuestions.Click += SummonQuestions_Click;
            // 
            // AddExamNow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(661, 302);
            Controls.Add(SummonQuestions);
            Controls.Add(AddQuesPanel);
            Controls.Add(Shuffle);
            Controls.Add(ChoosePic);
            Controls.Add(Cover);
            Controls.Add(label3);
            Controls.Add(SubjectCB);
            Controls.Add(TitleOfExam);
            Controls.Add(ExamGuidDesc);
            Controls.Add(ClearAll);
            Controls.Add(SaveExam);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GradeYearCB);
            Controls.Add(SpecalityCB);
            Controls.Add(DeleteSelected);
            Controls.Add(QuestionsSwim);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AddExamNow";
            Text = "اضافة امتحان";
            Load += AddExamNow_Load;
            ((System.ComponentModel.ISupportInitialize)Cover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public FlowLayoutPanel QuestionsSwim;
        public Button DeleteSelected;
        public DesktopSupport.FixedStringComboBox SpecalityCB;
        public DesktopSupport.FixedStringComboBox GradeYearCB;
        public Label label1;
        public Label label2;
        public Button SaveExam;
        public Button ClearAll;
        public TextBox ExamGuidDesc;
        public TextBox TitleOfExam;
        public Label label3;
        public DesktopSupport.FixedStringComboBox SubjectCB;
        public PictureBox Cover;
        public Button ChoosePic;
        public OpenFileDialog GetPic;
        private CheckBox Shuffle;
        private Button AddQuesPanel;
        private Button SummonQuestions;
    }
}