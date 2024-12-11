namespace EEControl
{
    partial class SignUp
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
            Username = new TextBox();
            Password = new TextBox();
            ConfirmPassword = new TextBox();
            SignBtn = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(12, 23);
            Username.Name = "Username";
            Username.PlaceholderText = "اسم المستخدم";
            Username.RightToLeft = RightToLeft.Yes;
            Username.Size = new Size(290, 23);
            Username.TabIndex = 0;
            // 
            // Password
            // 
            Password.Location = new Point(12, 52);
            Password.Name = "Password";
            Password.PlaceholderText = "كلمة السر";
            Password.RightToLeft = RightToLeft.Yes;
            Password.Size = new Size(290, 23);
            Password.TabIndex = 1;
            Password.UseSystemPasswordChar = true;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.Location = new Point(12, 81);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.PlaceholderText = "تاكيد كلمة السر";
            ConfirmPassword.RightToLeft = RightToLeft.Yes;
            ConfirmPassword.Size = new Size(290, 23);
            ConfirmPassword.TabIndex = 2;
            ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // SignBtn
            // 
            SignBtn.Location = new Point(12, 110);
            SignBtn.Name = "SignBtn";
            SignBtn.Size = new Size(75, 23);
            SignBtn.TabIndex = 3;
            SignBtn.Text = "تسجيل";
            SignBtn.UseVisualStyleBackColor = true;
            SignBtn.Click += SignBtn_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 146);
            Controls.Add(SignBtn);
            Controls.Add(ConfirmPassword);
            Controls.Add(Password);
            Controls.Add(Username);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUp";
            Text = "التسجيل";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Password;
        private TextBox ConfirmPassword;
        private Button SignBtn;
    }
}