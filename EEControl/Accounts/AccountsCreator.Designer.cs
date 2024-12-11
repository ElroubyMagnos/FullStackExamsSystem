namespace EEControl.Accounts
{
    partial class AccountsCreator
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            IDOfAccount = new DesktopSupport.FixedIntBox();
            label1 = new Label();
            Username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Password = new TextBox();
            CanCreateAccounts = new CheckBox();
            CanEditAllStudentsData = new CheckBox();
            CanEnterExamsWindow = new CheckBox();
            CanEnterStudentWindow = new CheckBox();
            CanEnterCore = new CheckBox();
            CanEnterSettings = new CheckBox();
            CanSignIn = new CheckBox();
            CanDeleteAllExams = new CheckBox();
            Grid = new DesktopSupport.SkyGrid();
            SaveAccount = new Button();
            NewAccount = new Button();
            AcceptAccount = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // IDOfAccount
            // 
            IDOfAccount.Font = new Font("Tahoma", 10F);
            IDOfAccount.Location = new Point(445, 12);
            IDOfAccount.Name = "IDOfAccount";
            IDOfAccount.ReadOnly = true;
            IDOfAccount.Size = new Size(100, 24);
            IDOfAccount.TabIndex = 0;
            IDOfAccount.Text = "0";
            IDOfAccount.Value = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 16);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "المعرف";
            // 
            // Username
            // 
            Username.Location = new Point(221, 13);
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Size = new Size(100, 23);
            Username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 16);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "اسم المستخدم";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 15);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "كلمة السر";
            // 
            // Password
            // 
            Password.Location = new Point(22, 12);
            Password.Name = "Password";
            Password.Size = new Size(100, 23);
            Password.TabIndex = 4;
            // 
            // CanCreateAccounts
            // 
            CanCreateAccounts.AutoSize = true;
            CanCreateAccounts.Location = new Point(535, 56);
            CanCreateAccounts.Name = "CanCreateAccounts";
            CanCreateAccounts.Size = new Size(89, 19);
            CanCreateAccounts.TabIndex = 6;
            CanCreateAccounts.Text = "عمل حسابات";
            CanCreateAccounts.UseVisualStyleBackColor = true;
            // 
            // CanEditAllStudentsData
            // 
            CanEditAllStudentsData.AutoSize = true;
            CanEditAllStudentsData.Location = new Point(374, 56);
            CanEditAllStudentsData.Name = "CanEditAllStudentsData";
            CanEditAllStudentsData.Size = new Size(110, 19);
            CanEditAllStudentsData.TabIndex = 9;
            CanEditAllStudentsData.Text = "كل بيانات الطلاب";
            CanEditAllStudentsData.UseVisualStyleBackColor = true;
            // 
            // CanEnterExamsWindow
            // 
            CanEnterExamsWindow.AutoSize = true;
            CanEnterExamsWindow.Location = new Point(535, 206);
            CanEnterExamsWindow.Name = "CanEnterExamsWindow";
            CanEnterExamsWindow.Size = new Size(75, 19);
            CanEnterExamsWindow.TabIndex = 12;
            CanEnterExamsWindow.Text = "الامتحانات";
            CanEnterExamsWindow.UseVisualStyleBackColor = true;
            // 
            // CanEnterStudentWindow
            // 
            CanEnterStudentWindow.AutoSize = true;
            CanEnterStudentWindow.Location = new Point(535, 181);
            CanEnterStudentWindow.Name = "CanEnterStudentWindow";
            CanEnterStudentWindow.Size = new Size(61, 19);
            CanEnterStudentWindow.TabIndex = 13;
            CanEnterStudentWindow.Text = "الطلاب";
            CanEnterStudentWindow.UseVisualStyleBackColor = true;
            // 
            // CanEnterCore
            // 
            CanEnterCore.AutoSize = true;
            CanEnterCore.Location = new Point(535, 156);
            CanEnterCore.Name = "CanEnterCore";
            CanEnterCore.Size = new Size(55, 19);
            CanEnterCore.TabIndex = 14;
            CanEnterCore.Text = "الركائز";
            CanEnterCore.UseVisualStyleBackColor = true;
            // 
            // CanEnterSettings
            // 
            CanEnterSettings.AutoSize = true;
            CanEnterSettings.Location = new Point(535, 131);
            CanEnterSettings.Name = "CanEnterSettings";
            CanEnterSettings.Size = new Size(101, 19);
            CanEnterSettings.TabIndex = 15;
            CanEnterSettings.Text = "اعدادات الموقع";
            CanEnterSettings.UseVisualStyleBackColor = true;
            // 
            // CanSignIn
            // 
            CanSignIn.AutoSize = true;
            CanSignIn.Location = new Point(535, 106);
            CanSignIn.Name = "CanSignIn";
            CanSignIn.Size = new Size(96, 19);
            CanSignIn.TabIndex = 16;
            CanSignIn.Text = "تسجيل الدخول";
            CanSignIn.UseVisualStyleBackColor = true;
            // 
            // CanDeleteAllExams
            // 
            CanDeleteAllExams.AutoSize = true;
            CanDeleteAllExams.Location = new Point(535, 81);
            CanDeleteAllExams.Name = "CanDeleteAllExams";
            CanDeleteAllExams.Size = new Size(103, 19);
            CanDeleteAllExams.TabIndex = 17;
            CanDeleteAllExams.Text = "حذف الامتحانات";
            CanDeleteAllExams.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            Grid.AllowUserToAddRows = false;
            Grid.AllowUserToDeleteRows = false;
            Grid.BackgroundColor = Color.White;
            Grid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            Grid.GridColor = SystemColors.ActiveCaption;
            Grid.Location = new Point(22, 56);
            Grid.MultiSelect = false;
            Grid.Name = "Grid";
            Grid.ReadOnly = true;
            Grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid.Size = new Size(346, 219);
            Grid.TabIndex = 18;
            Grid.SelectionChanged += Grid_SelectionChanged;
            // 
            // SaveAccount
            // 
            SaveAccount.Location = new Point(374, 213);
            SaveAccount.Name = "SaveAccount";
            SaveAccount.Size = new Size(91, 62);
            SaveAccount.TabIndex = 19;
            SaveAccount.Text = "حفظ";
            SaveAccount.UseVisualStyleBackColor = true;
            SaveAccount.Click += SaveAccount_Click;
            // 
            // NewAccount
            // 
            NewAccount.Location = new Point(374, 145);
            NewAccount.Name = "NewAccount";
            NewAccount.Size = new Size(91, 62);
            NewAccount.TabIndex = 20;
            NewAccount.Text = "جديد";
            NewAccount.UseVisualStyleBackColor = true;
            NewAccount.Click += NewAccount_Click;
            // 
            // AcceptAccount
            // 
            AcceptAccount.AutoSize = true;
            AcceptAccount.Location = new Point(374, 91);
            AcceptAccount.Name = "AcceptAccount";
            AcceptAccount.Size = new Size(125, 19);
            AcceptAccount.TabIndex = 21;
            AcceptAccount.Text = "موافقة علي الحساب";
            AcceptAccount.UseVisualStyleBackColor = true;
            // 
            // AccountsCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 294);
            Controls.Add(AcceptAccount);
            Controls.Add(NewAccount);
            Controls.Add(SaveAccount);
            Controls.Add(Grid);
            Controls.Add(CanDeleteAllExams);
            Controls.Add(CanSignIn);
            Controls.Add(CanEnterSettings);
            Controls.Add(CanEnterCore);
            Controls.Add(CanEnterStudentWindow);
            Controls.Add(CanEnterExamsWindow);
            Controls.Add(CanEditAllStudentsData);
            Controls.Add(CanCreateAccounts);
            Controls.Add(label3);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(label1);
            Controls.Add(IDOfAccount);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AccountsCreator";
            Text = "صانع الحسابات";
            Load += AccountsCreator_Load;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DesktopSupport.FixedIntBox IDOfAccount;
        private Label label1;
        private TextBox Username;
        private Label label2;
        private Label label3;
        private TextBox Password;
        private CheckBox CanCreateAccounts;
        private CheckBox CanEditAllStudentsData;
        private CheckBox CanEnterExamsWindow;
        private CheckBox CanEnterStudentWindow;
        private CheckBox CanEnterCore;
        private CheckBox checkBox9;
        private CheckBox CanSignIn;
        private CheckBox CanDeleteAllExams;
        private CheckBox checkBox9CanEnterSettings;
        private CheckBox CanEnterSettings;
        private DesktopSupport.SkyGrid Grid;
        private Button SaveAccount;
        private Button NewAccount;
        private CheckBox AcceptAccount;
    }
}