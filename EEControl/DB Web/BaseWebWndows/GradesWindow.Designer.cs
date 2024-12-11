namespace EEControl.DB_Web.BaseWebWndows
{
    partial class GradesWindow
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
            TypeOfLearnLB = new ListBox();
            Add = new Button();
            DeleteSelected = new Button();
            desc = new RichTextBox();
            GOfYear = new ListBox();
            AddIntSpace = new DesktopSupport.FixedIntBox();
            SuspendLayout();
            // 
            // TypeOfLearnLB
            // 
            TypeOfLearnLB.FormattingEnabled = true;
            TypeOfLearnLB.ItemHeight = 15;
            TypeOfLearnLB.Location = new Point(12, 12);
            TypeOfLearnLB.Name = "TypeOfLearnLB";
            TypeOfLearnLB.Size = new Size(120, 214);
            TypeOfLearnLB.TabIndex = 0;
            TypeOfLearnLB.SelectedIndexChanged += TypeOfLearnLB_SelectedIndexChanged;
            // 
            // Add
            // 
            Add.Location = new Point(138, 158);
            Add.Name = "Add";
            Add.Size = new Size(120, 23);
            Add.TabIndex = 1;
            Add.Text = "اضافة";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // DeleteSelected
            // 
            DeleteSelected.Location = new Point(138, 189);
            DeleteSelected.Name = "DeleteSelected";
            DeleteSelected.Size = new Size(120, 36);
            DeleteSelected.TabIndex = 3;
            DeleteSelected.Text = "حذف المختار";
            DeleteSelected.UseVisualStyleBackColor = true;
            DeleteSelected.Click += DeleteSelected_Click;
            // 
            // desc
            // 
            desc.Location = new Point(264, 12);
            desc.Name = "desc";
            desc.Size = new Size(181, 213);
            desc.TabIndex = 4;
            desc.Text = "";
            // 
            // GOfYear
            // 
            GOfYear.FormattingEnabled = true;
            GOfYear.ItemHeight = 15;
            GOfYear.Location = new Point(138, 12);
            GOfYear.Name = "GOfYear";
            GOfYear.Size = new Size(120, 109);
            GOfYear.TabIndex = 5;
            GOfYear.SelectedIndexChanged += GOfYear_SelectedIndexChanged;
            // 
            // AddIntSpace
            // 
            AddIntSpace.Font = new Font("Tahoma", 10F);
            AddIntSpace.Location = new Point(138, 127);
            AddIntSpace.Name = "AddIntSpace";
            AddIntSpace.Size = new Size(120, 24);
            AddIntSpace.TabIndex = 6;
            AddIntSpace.Value = 0;
            // 
            // GradesWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 246);
            Controls.Add(AddIntSpace);
            Controls.Add(GOfYear);
            Controls.Add(desc);
            Controls.Add(DeleteSelected);
            Controls.Add(Add);
            Controls.Add(TypeOfLearnLB);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "GradesWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "التخصصات";
            Load += TypeOfLearnWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox TypeOfLearnLB;
        private Button Add;
        private Button DeleteSelected;
        private RichTextBox desc;
        private ListBox GOfYear;
        private DesktopSupport.FixedIntBox AddIntSpace;
    }
}