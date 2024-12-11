namespace EEControl
{
    partial class DashBoard
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
            baseweb = new Button();
            studentinfo = new Button();
            exams = new Button();
            results = new Button();
            SettingsOfSite = new Button();
            StartExams = new Button();
            Accounts = new Button();
            CorrectExams = new Button();
            QuestionsBank = new Button();
            SuspendLayout();
            // 
            // baseweb
            // 
            baseweb.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            baseweb.ForeColor = Color.Red;
            baseweb.Location = new Point(12, 12);
            baseweb.Name = "baseweb";
            baseweb.Size = new Size(300, 75);
            baseweb.TabIndex = 0;
            baseweb.Text = "الركائز الاساسية لصفحات الويب";
            baseweb.UseVisualStyleBackColor = true;
            baseweb.Click += baseweb_Click;
            // 
            // studentinfo
            // 
            studentinfo.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentinfo.ForeColor = Color.Red;
            studentinfo.Location = new Point(12, 93);
            studentinfo.Name = "studentinfo";
            studentinfo.Size = new Size(512, 75);
            studentinfo.TabIndex = 1;
            studentinfo.Text = "بيانات الطلاب";
            studentinfo.UseVisualStyleBackColor = true;
            studentinfo.Click += studentinfo_Click;
            // 
            // exams
            // 
            exams.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exams.ForeColor = Color.Red;
            exams.Location = new Point(12, 174);
            exams.Name = "exams";
            exams.Size = new Size(512, 75);
            exams.TabIndex = 2;
            exams.Text = "الامتحانات";
            exams.UseVisualStyleBackColor = true;
            exams.Click += exams_Click;
            // 
            // results
            // 
            results.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            results.ForeColor = Color.Red;
            results.Location = new Point(12, 417);
            results.Name = "results";
            results.Size = new Size(512, 75);
            results.TabIndex = 3;
            results.Text = "نتائج الامتحانات";
            results.UseVisualStyleBackColor = true;
            results.Click += results_Click;
            // 
            // SettingsOfSite
            // 
            SettingsOfSite.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsOfSite.ForeColor = Color.Red;
            SettingsOfSite.Location = new Point(318, 12);
            SettingsOfSite.Name = "SettingsOfSite";
            SettingsOfSite.Size = new Size(206, 75);
            SettingsOfSite.TabIndex = 4;
            SettingsOfSite.Text = "اعدادات الموقع";
            SettingsOfSite.UseVisualStyleBackColor = true;
            SettingsOfSite.Click += SettingsOfSite_Click;
            // 
            // StartExams
            // 
            StartExams.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartExams.ForeColor = Color.Red;
            StartExams.Location = new Point(12, 255);
            StartExams.Name = "StartExams";
            StartExams.Size = new Size(512, 75);
            StartExams.TabIndex = 5;
            StartExams.Text = "تشغيل الامتحانات";
            StartExams.UseVisualStyleBackColor = true;
            StartExams.Click += StartExams_Click;
            // 
            // Accounts
            // 
            Accounts.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Accounts.ForeColor = Color.Red;
            Accounts.Location = new Point(530, 12);
            Accounts.Name = "Accounts";
            Accounts.Size = new Size(126, 237);
            Accounts.TabIndex = 6;
            Accounts.Text = "الحسابات";
            Accounts.UseVisualStyleBackColor = true;
            Accounts.Click += Accounts_Click;
            // 
            // CorrectExams
            // 
            CorrectExams.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CorrectExams.ForeColor = Color.Red;
            CorrectExams.Location = new Point(12, 336);
            CorrectExams.Name = "CorrectExams";
            CorrectExams.Size = new Size(512, 75);
            CorrectExams.TabIndex = 7;
            CorrectExams.Text = "تصحيح الامتحانات";
            CorrectExams.UseVisualStyleBackColor = true;
            CorrectExams.Click += CorrectExams_Click;
            // 
            // QuestionsBank
            // 
            QuestionsBank.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestionsBank.ForeColor = Color.Red;
            QuestionsBank.Location = new Point(530, 255);
            QuestionsBank.Name = "QuestionsBank";
            QuestionsBank.Size = new Size(126, 237);
            QuestionsBank.TabIndex = 8;
            QuestionsBank.Text = "بنك الاسئلة";
            QuestionsBank.UseVisualStyleBackColor = true;
            QuestionsBank.Click += QuestionsBank_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 502);
            Controls.Add(QuestionsBank);
            Controls.Add(CorrectExams);
            Controls.Add(Accounts);
            Controls.Add(StartExams);
            Controls.Add(SettingsOfSite);
            Controls.Add(results);
            Controls.Add(exams);
            Controls.Add(studentinfo);
            Controls.Add(baseweb);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لوحة التحكم الرئيسية";
            ResumeLayout(false);
        }

        #endregion

        private Button baseweb;
        private Button studentinfo;
        private Button exams;
        private Button results;
        private Button SettingsOfSite;
        private Button StartExams;
        private Button Accounts;
        private Button CorrectExams;
        private Button QuestionsBank;
    }
}