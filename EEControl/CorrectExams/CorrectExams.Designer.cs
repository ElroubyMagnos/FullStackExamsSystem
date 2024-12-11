namespace EEControl.CorrectExams
{
    partial class CorrectExams
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
            StudentsGrid = new DataGridView();
            EssayCorrectContainer = new FlowLayoutPanel();
            ShowResults = new DesktopSupport.SkyButton();
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).BeginInit();
            SuspendLayout();
            // 
            // StudentsGrid
            // 
            StudentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsGrid.Location = new Point(467, 26);
            StudentsGrid.Name = "StudentsGrid";
            StudentsGrid.Size = new Size(376, 384);
            StudentsGrid.TabIndex = 0;
            StudentsGrid.SelectionChanged += StudentsGrid_SelectionChanged;
            // 
            // EssayCorrectContainer
            // 
            EssayCorrectContainer.AutoScroll = true;
            EssayCorrectContainer.Location = new Point(12, 26);
            EssayCorrectContainer.Name = "EssayCorrectContainer";
            EssayCorrectContainer.Size = new Size(435, 384);
            EssayCorrectContainer.TabIndex = 1;
            // 
            // ShowResults
            // 
            ShowResults.BackColor = SystemColors.Highlight;
            ShowResults.BackgroundImageLayout = ImageLayout.Stretch;
            ShowResults.DefaultColor = SystemColors.Highlight;
            ShowResults.FlatAppearance.BorderSize = 0;
            ShowResults.FlatStyle = FlatStyle.Flat;
            ShowResults.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowResults.ForeColor = SystemColors.Control;
            ShowResults.Hover = Color.Empty;
            ShowResults.Location = new Point(362, 422);
            ShowResults.Name = "ShowResults";
            ShowResults.Size = new Size(195, 30);
            ShowResults.TabIndex = 3;
            ShowResults.Text = "اظهار النتائج";
            ShowResults.UseVisualStyleBackColor = false;
            ShowResults.Click += ShowResults_Click;
            // 
            // CorrectExams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 464);
            Controls.Add(ShowResults);
            Controls.Add(EssayCorrectContainer);
            Controls.Add(StudentsGrid);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "CorrectExams";
            Text = "تصحيح الاسئلة المقالية";
            Load += CorrectExams_Load;
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel EssayCorrectContainer;
        private DesktopSupport.SkyButton ShowResults;
        public DataGridView StudentsGrid;
    }
}