namespace EEControl
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new TextBox();
            Password = new TextBox();
            SignIn = new Button();
            pictureBox1 = new PictureBox();
            SignUp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(40, 83);
            Username.Name = "Username";
            Username.Size = new Size(189, 23);
            Username.TabIndex = 0;
            Username.KeyDown += All_KeyDown;
            // 
            // Password
            // 
            Password.Location = new Point(40, 110);
            Password.Name = "Password";
            Password.Size = new Size(189, 23);
            Password.TabIndex = 1;
            Password.UseSystemPasswordChar = true;
            Password.KeyDown += All_KeyDown;
            // 
            // SignIn
            // 
            SignIn.Location = new Point(40, 139);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(75, 23);
            SignIn.TabIndex = 2;
            SignIn.Text = "دخول";
            SignIn.UseVisualStyleBackColor = true;
            SignIn.Click += SignIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(91, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 68);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            SignUp.Location = new Point(154, 139);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(75, 23);
            SignUp.TabIndex = 4;
            SignUp.Text = "التسجيل";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 170);
            Controls.Add(SignUp);
            Controls.Add(pictureBox1);
            Controls.Add(SignIn);
            Controls.Add(Password);
            Controls.Add(Username);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لوحة تحكم موقع الاختبارات";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Password;
        private Button SignIn;
        private PictureBox pictureBox1;
        private Button SignUp;
    }
}
