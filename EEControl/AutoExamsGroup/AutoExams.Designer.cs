namespace EEControl.AutoExams
{
    partial class AutoExams
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
            ExamSpace = new FlowLayoutPanel();
            From = new DateTimePicker();
            To = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            Status = new Label();
            Append = new Button();
            SuspendLayout();
            // 
            // ExamSpace
            // 
            ExamSpace.AutoScroll = true;
            ExamSpace.Location = new Point(12, 12);
            ExamSpace.Name = "ExamSpace";
            ExamSpace.Size = new Size(554, 184);
            ExamSpace.TabIndex = 0;
            // 
            // From
            // 
            From.CustomFormat = "hh/dd/MM/yyyy";
            From.Enabled = false;
            From.Format = DateTimePickerFormat.Custom;
            From.Location = new Point(338, 202);
            From.Name = "From";
            From.RightToLeft = RightToLeft.Yes;
            From.Size = new Size(200, 23);
            From.TabIndex = 1;
            From.ValueChanged += FromAndTo_ValueChanged;
            // 
            // To
            // 
            To.CustomFormat = "hh/dd/MM/yyyy";
            To.Enabled = false;
            To.Format = DateTimePickerFormat.Custom;
            To.Location = new Point(338, 231);
            To.Name = "To";
            To.RightToLeft = RightToLeft.Yes;
            To.Size = new Size(200, 23);
            To.TabIndex = 2;
            To.ValueChanged += FromAndTo_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 206);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 3;
            label1.Text = "من";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 237);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 4;
            label2.Text = "الي";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.ForeColor = Color.Red;
            Status.Location = new Point(187, 216);
            Status.Name = "Status";
            Status.Size = new Size(0, 15);
            Status.TabIndex = 5;
            // 
            // Append
            // 
            Append.Location = new Point(12, 204);
            Append.Name = "Append";
            Append.Size = new Size(75, 50);
            Append.TabIndex = 6;
            Append.Text = "تعيين";
            Append.UseVisualStyleBackColor = true;
            Append.Click += Append_Click;
            // 
            // AutoExams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 265);
            Controls.Add(Append);
            Controls.Add(Status);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(To);
            Controls.Add(From);
            Controls.Add(ExamSpace);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AutoExams";
            Text = "AutoExams";
            Load += AutoExams_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel ExamSpace;
        private Label label1;
        private Label label2;
        public DateTimePicker From;
        public DateTimePicker To;
        private Label Status;
        private Button Append;
    }
}