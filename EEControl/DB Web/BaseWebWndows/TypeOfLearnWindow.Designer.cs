namespace EEControl.DB_Web.BaseWebWndows
{
    partial class TypeOfLearnWindow
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
            AddSpace = new TextBox();
            DeleteSelected = new Button();
            desc = new RichTextBox();
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
            // AddSpace
            // 
            AddSpace.Location = new Point(138, 129);
            AddSpace.Name = "AddSpace";
            AddSpace.Size = new Size(120, 23);
            AddSpace.TabIndex = 2;
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
            desc.Location = new Point(138, 12);
            desc.Name = "desc";
            desc.Size = new Size(120, 111);
            desc.TabIndex = 4;
            desc.Text = "";
            // 
            // TypeOfLearnWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 246);
            Controls.Add(desc);
            Controls.Add(DeleteSelected);
            Controls.Add(AddSpace);
            Controls.Add(Add);
            Controls.Add(TypeOfLearnLB);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "TypeOfLearnWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "التخصصات";
            Load += TypeOfLearnWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox TypeOfLearnLB;
        private Button Add;
        private TextBox AddSpace;
        private Button DeleteSelected;
        private RichTextBox desc;
    }
}