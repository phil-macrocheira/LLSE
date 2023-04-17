
namespace LLSE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.open_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.health_box = new System.Windows.Forms.TextBox();
            this.health_text = new System.Windows.Forms.Label();
            this.wealth_text = new System.Windows.Forms.Label();
            this.wealth_box = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.day_box = new System.Windows.Forms.TextBox();
            this.month_text = new System.Windows.Forms.Label();
            this.month_box = new System.Windows.Forms.ComboBox();
            this.day_text = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BirthMonthBox = new System.Windows.Forms.ComboBox();
            this.BirthdayText = new System.Windows.Forms.Label();
            this.BirthDayBox = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.TraitBox = new System.Windows.Forms.ComboBox();
            this.TraitText = new System.Windows.Forms.Label();
            this.HairColorBox = new System.Windows.Forms.ComboBox();
            this.HairColorText = new System.Windows.Forms.Label();
            this.HairstyleBox = new System.Windows.Forms.ComboBox();
            this.HairText = new System.Windows.Forms.Label();
            this.ExpressionBox = new System.Windows.Forms.ComboBox();
            this.ExpressionText = new System.Windows.Forms.Label();
            this.SkinToneBox = new System.Windows.Forms.NumericUpDown();
            this.SkinToneText = new System.Windows.Forms.Label();
            this.IMAGEHERE = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.GenderText = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RoomText = new System.Windows.Forms.Label();
            this.RoommateText = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkinToneBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(27, 28);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(140, 50);
            this.open_btn.TabIndex = 0;
            this.open_btn.Text = "Open Save File";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // health_box
            // 
            this.health_box.Location = new System.Drawing.Point(32, 126);
            this.health_box.MaxLength = 9;
            this.health_box.Name = "health_box";
            this.health_box.Size = new System.Drawing.Size(100, 26);
            this.health_box.TabIndex = 1;
            this.health_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // health_text
            // 
            this.health_text.AutoSize = true;
            this.health_text.Location = new System.Drawing.Point(24, 103);
            this.health_text.Name = "health_text";
            this.health_text.Size = new System.Drawing.Size(118, 20);
            this.health_text.TabIndex = 2;
            this.health_text.Text = "Max Happiness";
            this.health_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // wealth_text
            // 
            this.wealth_text.AutoSize = true;
            this.wealth_text.Location = new System.Drawing.Point(54, 176);
            this.wealth_text.Name = "wealth_text";
            this.wealth_text.Size = new System.Drawing.Size(59, 20);
            this.wealth_text.TabIndex = 3;
            this.wealth_text.Text = "Wealth";
            this.wealth_text.Click += new System.EventHandler(this.wealth_text_Click);
            // 
            // wealth_box
            // 
            this.wealth_box.Location = new System.Drawing.Point(34, 199);
            this.wealth_box.MaxLength = 9;
            this.wealth_box.Name = "wealth_box";
            this.wealth_box.Size = new System.Drawing.Size(100, 26);
            this.wealth_box.TabIndex = 4;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(27, 105);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(140, 50);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // day_box
            // 
            this.day_box.Location = new System.Drawing.Point(358, 81);
            this.day_box.MaxLength = 2;
            this.day_box.Name = "day_box";
            this.day_box.Size = new System.Drawing.Size(34, 26);
            this.day_box.TabIndex = 6;
            // 
            // month_text
            // 
            this.month_text.AutoSize = true;
            this.month_text.Location = new System.Drawing.Point(256, 58);
            this.month_text.Name = "month_text";
            this.month_text.Size = new System.Drawing.Size(54, 20);
            this.month_text.TabIndex = 7;
            this.month_text.Text = "Month";
            this.month_text.Click += new System.EventHandler(this.date_text_Click);
            // 
            // month_box
            // 
            this.month_box.FormattingEnabled = true;
            this.month_box.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month_box.Location = new System.Drawing.Point(226, 81);
            this.month_box.Name = "month_box";
            this.month_box.Size = new System.Drawing.Size(113, 28);
            this.month_box.TabIndex = 8;
            this.month_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // day_text
            // 
            this.day_text.AutoSize = true;
            this.day_text.Location = new System.Drawing.Point(357, 58);
            this.day_text.Name = "day_text";
            this.day_text.Size = new System.Drawing.Size(37, 20);
            this.day_text.TabIndex = 9;
            this.day_text.Text = "Day";
            this.day_text.Click += new System.EventHandler(this.day_text_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 448);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.open_btn);
            this.tabPage1.Controls.Add(this.day_text);
            this.tabPage1.Controls.Add(this.save_btn);
            this.tabPage1.Controls.Add(this.month_box);
            this.tabPage1.Controls.Add(this.month_text);
            this.tabPage1.Controls.Add(this.day_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BirthMonthBox);
            this.tabPage2.Controls.Add(this.BirthdayText);
            this.tabPage2.Controls.Add(this.BirthDayBox);
            this.tabPage2.Controls.Add(this.NameText);
            this.tabPage2.Controls.Add(this.NameBox);
            this.tabPage2.Controls.Add(this.TraitBox);
            this.tabPage2.Controls.Add(this.TraitText);
            this.tabPage2.Controls.Add(this.HairColorBox);
            this.tabPage2.Controls.Add(this.HairColorText);
            this.tabPage2.Controls.Add(this.HairstyleBox);
            this.tabPage2.Controls.Add(this.HairText);
            this.tabPage2.Controls.Add(this.ExpressionBox);
            this.tabPage2.Controls.Add(this.ExpressionText);
            this.tabPage2.Controls.Add(this.SkinToneBox);
            this.tabPage2.Controls.Add(this.SkinToneText);
            this.tabPage2.Controls.Add(this.IMAGEHERE);
            this.tabPage2.Controls.Add(this.GenderBox);
            this.tabPage2.Controls.Add(this.GenderText);
            this.tabPage2.Controls.Add(this.health_text);
            this.tabPage2.Controls.Add(this.health_box);
            this.tabPage2.Controls.Add(this.wealth_text);
            this.tabPage2.Controls.Add(this.wealth_box);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Player";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BirthMonthBox
            // 
            this.BirthMonthBox.FormattingEnabled = true;
            this.BirthMonthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.BirthMonthBox.Location = new System.Drawing.Point(24, 368);
            this.BirthMonthBox.Name = "BirthMonthBox";
            this.BirthMonthBox.Size = new System.Drawing.Size(113, 28);
            this.BirthMonthBox.TabIndex = 26;
            // 
            // BirthdayText
            // 
            this.BirthdayText.AutoSize = true;
            this.BirthdayText.Location = new System.Drawing.Point(75, 334);
            this.BirthdayText.Name = "BirthdayText";
            this.BirthdayText.Size = new System.Drawing.Size(67, 20);
            this.BirthdayText.TabIndex = 25;
            this.BirthdayText.Text = "Birthday";
            // 
            // BirthDayBox
            // 
            this.BirthDayBox.Location = new System.Drawing.Point(156, 368);
            this.BirthDayBox.MaxLength = 2;
            this.BirthDayBox.Name = "BirthDayBox";
            this.BirthDayBox.Size = new System.Drawing.Size(34, 26);
            this.BirthDayBox.TabIndex = 24;
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Location = new System.Drawing.Point(54, 30);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(51, 20);
            this.NameText.TabIndex = 23;
            this.NameText.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(31, 53);
            this.NameBox.MaxLength = 9;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 26);
            this.NameBox.TabIndex = 22;
            // 
            // TraitBox
            // 
            this.TraitBox.FormattingEnabled = true;
            this.TraitBox.Items.AddRange(new object[] {
            "Great Cook",
            "Winning Smile",
            "Stiff Upper Lip",
            "Fashionissimo",
            "Free Spirit",
            "Sweet Tooth",
            "Smooth Talker",
            "Child at Heart"});
            this.TraitBox.Location = new System.Drawing.Point(28, 278);
            this.TraitBox.Name = "TraitBox";
            this.TraitBox.Size = new System.Drawing.Size(113, 28);
            this.TraitBox.TabIndex = 21;
            // 
            // TraitText
            // 
            this.TraitText.AutoSize = true;
            this.TraitText.Location = new System.Drawing.Point(64, 255);
            this.TraitText.Name = "TraitText";
            this.TraitText.Size = new System.Drawing.Size(40, 20);
            this.TraitText.TabIndex = 20;
            this.TraitText.Text = "Trait";
            this.TraitText.Click += new System.EventHandler(this.TraitText_Click);
            // 
            // HairColorBox
            // 
            this.HairColorBox.FormattingEnabled = true;
            this.HairColorBox.Items.AddRange(new object[] {
            "Caramel Brown",
            "Whip White",
            "Ash Gray",
            "Jet Black",
            "Chestnut Brown",
            "Cocoa Brown",
            "Honey Blonde",
            "Tomato Red",
            "Ocean Blue",
            "Tangerine",
            "Grass Green"});
            this.HairColorBox.Location = new System.Drawing.Point(310, 357);
            this.HairColorBox.Name = "HairColorBox";
            this.HairColorBox.Size = new System.Drawing.Size(113, 28);
            this.HairColorBox.TabIndex = 19;
            // 
            // HairColorText
            // 
            this.HairColorText.AutoSize = true;
            this.HairColorText.Location = new System.Drawing.Point(327, 334);
            this.HairColorText.Name = "HairColorText";
            this.HairColorText.Size = new System.Drawing.Size(79, 20);
            this.HairColorText.TabIndex = 18;
            this.HairColorText.Text = "Hair Color";
            // 
            // HairstyleBox
            // 
            this.HairstyleBox.FormattingEnabled = true;
            this.HairstyleBox.Items.AddRange(new object[] {
            "Long Locks",
            "Pixie Cut",
            "Pigtails",
            "Inverted Bob",
            "Shoulder Length",
            "Long & Silky",
            "Floppy Hair",
            "Mohawk",
            "Flattop",
            "Pompadour",
            "Mullet",
            "Sideburns",
            "Traditional",
            "Trendy Cut",
            "Bowl Cut"});
            this.HairstyleBox.Location = new System.Drawing.Point(307, 281);
            this.HairstyleBox.Name = "HairstyleBox";
            this.HairstyleBox.Size = new System.Drawing.Size(113, 28);
            this.HairstyleBox.TabIndex = 17;
            // 
            // HairText
            // 
            this.HairText.AutoSize = true;
            this.HairText.Location = new System.Drawing.Point(329, 258);
            this.HairText.Name = "HairText";
            this.HairText.Size = new System.Drawing.Size(70, 20);
            this.HairText.TabIndex = 16;
            this.HairText.Text = "Hairstyle";
            this.HairText.Click += new System.EventHandler(this.HairText_Click);
            // 
            // ExpressionBox
            // 
            this.ExpressionBox.FormattingEnabled = true;
            this.ExpressionBox.Items.AddRange(new object[] {
            "Neutral",
            "McGrumpington",
            "Determined",
            "Elated",
            "Sleepy",
            "Smiley",
            "Surprised",
            "Shy",
            "Mellow",
            "Scaredy-Cat",
            "Worrywart",
            "Sternfaced"});
            this.ExpressionBox.Location = new System.Drawing.Point(307, 205);
            this.ExpressionBox.Name = "ExpressionBox";
            this.ExpressionBox.Size = new System.Drawing.Size(113, 28);
            this.ExpressionBox.TabIndex = 15;
            // 
            // ExpressionText
            // 
            this.ExpressionText.AutoSize = true;
            this.ExpressionText.Location = new System.Drawing.Point(322, 182);
            this.ExpressionText.Name = "ExpressionText";
            this.ExpressionText.Size = new System.Drawing.Size(87, 20);
            this.ExpressionText.TabIndex = 14;
            this.ExpressionText.Text = "Expression";
            this.ExpressionText.Click += new System.EventHandler(this.FaceText_Click);
            // 
            // SkinToneBox
            // 
            this.SkinToneBox.Location = new System.Drawing.Point(307, 127);
            this.SkinToneBox.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.SkinToneBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SkinToneBox.Name = "SkinToneBox";
            this.SkinToneBox.Size = new System.Drawing.Size(120, 26);
            this.SkinToneBox.TabIndex = 13;
            this.SkinToneBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SkinToneText
            // 
            this.SkinToneText.AutoSize = true;
            this.SkinToneText.Location = new System.Drawing.Point(329, 103);
            this.SkinToneText.Name = "SkinToneText";
            this.SkinToneText.Size = new System.Drawing.Size(80, 20);
            this.SkinToneText.TabIndex = 11;
            this.SkinToneText.Text = "Skin Tone";
            // 
            // IMAGEHERE
            // 
            this.IMAGEHERE.AutoSize = true;
            this.IMAGEHERE.Location = new System.Drawing.Point(539, 182);
            this.IMAGEHERE.Name = "IMAGEHERE";
            this.IMAGEHERE.Size = new System.Drawing.Size(180, 20);
            this.IMAGEHERE.TabIndex = 10;
            this.IMAGEHERE.Text = "PLAYER IMAGE HERE";
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.GenderBox.Location = new System.Drawing.Point(307, 53);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(113, 28);
            this.GenderBox.TabIndex = 9;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // GenderText
            // 
            this.GenderText.AutoSize = true;
            this.GenderText.Location = new System.Drawing.Point(329, 30);
            this.GenderText.Name = "GenderText";
            this.GenderText.Size = new System.Drawing.Size(63, 20);
            this.GenderText.TabIndex = 5;
            this.GenderText.Text = "Gender";
            this.GenderText.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RoommateText);
            this.tabPage3.Controls.Add(this.RoomText);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(793, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Room";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(793, 415);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quests";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RoomText
            // 
            this.RoomText.AutoSize = true;
            this.RoomText.Location = new System.Drawing.Point(12, 85);
            this.RoomText.MaximumSize = new System.Drawing.Size(200, 200);
            this.RoomText.Name = "RoomText";
            this.RoomText.Size = new System.Drawing.Size(104, 20);
            this.RoomText.TabIndex = 0;
            this.RoomText.Text = "Room Items: ";
            this.RoomText.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // RoommateText
            // 
            this.RoommateText.AutoSize = true;
            this.RoommateText.Location = new System.Drawing.Point(12, 32);
            this.RoommateText.MaximumSize = new System.Drawing.Size(200, 200);
            this.RoommateText.Name = "RoommateText";
            this.RoommateText.Size = new System.Drawing.Size(96, 20);
            this.RoommateText.TabIndex = 1;
            this.RoommateText.Text = "Roommate: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Professor Layton London Life Save Editor (Beta v0.1)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkinToneBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox health_box;
        private System.Windows.Forms.Label health_text;
        private System.Windows.Forms.Label wealth_text;
        private System.Windows.Forms.TextBox wealth_box;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox day_box;
        private System.Windows.Forms.Label month_text;
        private System.Windows.Forms.ComboBox month_box;
        private System.Windows.Forms.Label day_text;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label GenderText;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Label SkinToneText;
        private System.Windows.Forms.Label IMAGEHERE;
        private System.Windows.Forms.NumericUpDown SkinToneBox;
        private System.Windows.Forms.ComboBox ExpressionBox;
        private System.Windows.Forms.Label ExpressionText;
        private System.Windows.Forms.ComboBox HairstyleBox;
        private System.Windows.Forms.Label HairText;
        private System.Windows.Forms.ComboBox HairColorBox;
        private System.Windows.Forms.Label HairColorText;
        private System.Windows.Forms.ComboBox TraitBox;
        private System.Windows.Forms.Label TraitText;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox BirthMonthBox;
        private System.Windows.Forms.Label BirthdayText;
        private System.Windows.Forms.TextBox BirthDayBox;
        private System.Windows.Forms.Label RoomText;
        private System.Windows.Forms.Label RoommateText;
    }
}

