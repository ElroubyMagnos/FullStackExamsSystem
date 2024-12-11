namespace EEControl.Exams
{
    partial class SummonQuesPanel
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
            AllLabel = new Label();
            ChooseCountBox = new DesktopSupport.FixedIntBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            restEssay = new DesktopSupport.FixedIntBox();
            label6 = new Label();
            EssayCountBox = new DesktopSupport.FixedIntBox();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            restRightWrong = new DesktopSupport.FixedIntBox();
            label4 = new Label();
            RightWrongCountBox = new DesktopSupport.FixedIntBox();
            label5 = new Label();
            restChoose = new DesktopSupport.FixedIntBox();
            label3 = new Label();
            EmbedQuestions = new DesktopSupport.SkyButton();
            All = new Label();
            TakenCount = new Label();
            label8 = new Label();
            restCount = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AllLabel
            // 
            AllLabel.AutoSize = true;
            AllLabel.Location = new Point(377, 9);
            AllLabel.Name = "AllLabel";
            AllLabel.RightToLeft = RightToLeft.Yes;
            AllLabel.Size = new Size(143, 15);
            AllLabel.TabIndex = 0;
            AllLabel.Text = "اجمالي عدد الاسئلة المتاحة: ";
            // 
            // ChooseCountBox
            // 
            ChooseCountBox.Font = new Font("Tahoma", 10F);
            ChooseCountBox.Location = new Point(286, 32);
            ChooseCountBox.Name = "ChooseCountBox";
            ChooseCountBox.RightToLeft = RightToLeft.Yes;
            ChooseCountBox.Size = new Size(100, 24);
            ChooseCountBox.TabIndex = 1;
            ChooseCountBox.Text = "0";
            ChooseCountBox.Value = 0;
            ChooseCountBox.TextChanged += ChooseCountBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 36);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "عدد الاختيارات";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(restEssay);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(EssayCountBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(restRightWrong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(RightWrongCountBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(restChoose);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ChooseCountBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 154);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "عدد المطلوب من كل فئة نوع من الاسئلة";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.arrowleft;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(132, 114);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 24);
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.arrowleft;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(242, 114);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(29, 24);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // restEssay
            // 
            restEssay.Font = new Font("Tahoma", 10F);
            restEssay.Location = new Point(15, 114);
            restEssay.Name = "restEssay";
            restEssay.ReadOnly = true;
            restEssay.RightToLeft = RightToLeft.Yes;
            restEssay.Size = new Size(100, 24);
            restEssay.TabIndex = 16;
            restEssay.Text = "0";
            restEssay.Value = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 118);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(42, 15);
            label6.TabIndex = 15;
            label6.Text = "ويتبقي";
            // 
            // EssayCountBox
            // 
            EssayCountBox.Font = new Font("Tahoma", 10F);
            EssayCountBox.Location = new Point(286, 114);
            EssayCountBox.Name = "EssayCountBox";
            EssayCountBox.RightToLeft = RightToLeft.Yes;
            EssayCountBox.Size = new Size(100, 24);
            EssayCountBox.TabIndex = 13;
            EssayCountBox.Text = "0";
            EssayCountBox.Value = 0;
            EssayCountBox.TextChanged += EssayCountBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 118);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(66, 15);
            label7.TabIndex = 14;
            label7.Text = "عدد المقالي";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.arrowleft;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(132, 74);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 24);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.arrowleft;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(132, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 24);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.arrowleft;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(242, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 24);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.arrowleft;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(242, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 24);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // restRightWrong
            // 
            restRightWrong.Font = new Font("Tahoma", 10F);
            restRightWrong.Location = new Point(15, 74);
            restRightWrong.Name = "restRightWrong";
            restRightWrong.ReadOnly = true;
            restRightWrong.RightToLeft = RightToLeft.Yes;
            restRightWrong.Size = new Size(100, 24);
            restRightWrong.TabIndex = 8;
            restRightWrong.Text = "0";
            restRightWrong.Value = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 78);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "ويتبقي";
            // 
            // RightWrongCountBox
            // 
            RightWrongCountBox.Font = new Font("Tahoma", 10F);
            RightWrongCountBox.Location = new Point(286, 74);
            RightWrongCountBox.Name = "RightWrongCountBox";
            RightWrongCountBox.RightToLeft = RightToLeft.Yes;
            RightWrongCountBox.Size = new Size(100, 24);
            RightWrongCountBox.TabIndex = 5;
            RightWrongCountBox.Text = "0";
            RightWrongCountBox.Value = 0;
            RightWrongCountBox.TextChanged += RightWrongCountBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 78);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(104, 15);
            label5.TabIndex = 6;
            label5.Text = "عدد الصواب والخطأ";
            // 
            // restChoose
            // 
            restChoose.Font = new Font("Tahoma", 10F);
            restChoose.Location = new Point(15, 32);
            restChoose.Name = "restChoose";
            restChoose.ReadOnly = true;
            restChoose.RightToLeft = RightToLeft.Yes;
            restChoose.Size = new Size(100, 24);
            restChoose.TabIndex = 4;
            restChoose.Text = "0";
            restChoose.Value = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 36);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "ويتبقي";
            // 
            // EmbedQuestions
            // 
            EmbedQuestions.BackColor = SystemColors.Highlight;
            EmbedQuestions.BackgroundImageLayout = ImageLayout.Stretch;
            EmbedQuestions.DefaultColor = SystemColors.Highlight;
            EmbedQuestions.FlatAppearance.BorderSize = 0;
            EmbedQuestions.FlatStyle = FlatStyle.Flat;
            EmbedQuestions.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmbedQuestions.ForeColor = SystemColors.Control;
            EmbedQuestions.Hover = Color.Empty;
            EmbedQuestions.Location = new Point(404, 276);
            EmbedQuestions.Name = "EmbedQuestions";
            EmbedQuestions.Size = new Size(122, 30);
            EmbedQuestions.TabIndex = 4;
            EmbedQuestions.Text = "اضافة الاسئلة";
            EmbedQuestions.UseVisualStyleBackColor = false;
            EmbedQuestions.Click += EmbedQuestions_Click;
            // 
            // All
            // 
            All.AutoSize = true;
            All.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            All.Location = new Point(347, 9);
            All.Name = "All";
            All.Size = new Size(14, 15);
            All.TabIndex = 5;
            All.Text = "0";
            // 
            // TakenCount
            // 
            TakenCount.AutoSize = true;
            TakenCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TakenCount.Location = new Point(150, 276);
            TakenCount.Name = "TakenCount";
            TakenCount.Size = new Size(14, 15);
            TakenCount.TabIndex = 7;
            TakenCount.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(180, 276);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(145, 15);
            label8.TabIndex = 6;
            label8.Text = "اجمالي عدد الاسئلة الماخوذة";
            // 
            // restCount
            // 
            restCount.AutoSize = true;
            restCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restCount.Location = new Point(347, 53);
            restCount.Name = "restCount";
            restCount.Size = new Size(14, 15);
            restCount.TabIndex = 9;
            restCount.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(377, 53);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(144, 15);
            label9.TabIndex = 8;
            label9.Text = "اجمالي عدد الاسئلة المتبقية:";
            // 
            // SummonQuesPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 321);
            Controls.Add(restCount);
            Controls.Add(label9);
            Controls.Add(TakenCount);
            Controls.Add(label8);
            Controls.Add(All);
            Controls.Add(EmbedQuestions);
            Controls.Add(groupBox1);
            Controls.Add(AllLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SummonQuesPanel";
            Text = "SummonQuesPanel";
            Load += SummonQuesPanel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AllLabel;
        private DesktopSupport.FixedIntBox ChooseCountBox;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private DesktopSupport.FixedIntBox restChoose;
        private DesktopSupport.FixedIntBox restRightWrong;
        private Label label4;
        private DesktopSupport.FixedIntBox RightWrongCountBox;
        private Label label5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private DesktopSupport.FixedIntBox restEssay;
        private Label label6;
        private DesktopSupport.FixedIntBox EssayCountBox;
        private Label label7;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DesktopSupport.SkyButton EmbedQuestions;
        private Label All;
        private Label TakenCount;
        private Label label8;
        private Label restCount;
        private Label label9;
    }
}