namespace EEControl
{
    partial class SettingsWindow
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
            label1 = new Label();
            StudentExpire = new DateTimePicker();
            Save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 0;
            label1.Text = "معاد انتهاء الطالب المسجل هذا العام";
            // 
            // StudentExpire
            // 
            StudentExpire.Location = new Point(58, 35);
            StudentExpire.Name = "StudentExpire";
            StudentExpire.Size = new Size(200, 23);
            StudentExpire.TabIndex = 1;
            // 
            // Save
            // 
            Save.Location = new Point(12, 174);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 2;
            Save.Text = "حفظ";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 209);
            Controls.Add(Save);
            Controls.Add(StudentExpire);
            Controls.Add(label1);
            Name = "SettingsWindow";
            Text = "اعدادات الموقع";
            Load += SettingsWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker StudentExpire;
        private Button Save;
    }
}