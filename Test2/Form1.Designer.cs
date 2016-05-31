namespace Test2
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
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.bookBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameDeleteBox = new System.Windows.Forms.TextBox();
            this.lastNameDeleteBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.birthDateBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FindBtn = new System.Windows.Forms.Button();
            this.RedOfSearchBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.FromAgeText = new System.Windows.Forms.TextBox();
            this.ToAgeText = new System.Windows.Forms.TextBox();
            this.FAge = new System.Windows.Forms.Label();
            this.TAge = new System.Windows.Forms.Label();
            this.FromCityL = new System.Windows.Forms.Label();
            this.FromCity = new System.Windows.Forms.TextBox();
            this.FindKeyBox = new System.Windows.Forms.ComboBox();
            this.FindGenderKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(17, 127);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(346, 30);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "AddUser";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 203);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(351, 28);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "RemoveUser";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // bookBox
            // 
            this.bookBox.Location = new System.Drawing.Point(402, 42);
            this.bookBox.Name = "bookBox";
            this.bookBox.ReadOnly = true;
            this.bookBox.Size = new System.Drawing.Size(293, 115);
            this.bookBox.TabIndex = 4;
            this.bookBox.Text = "";
            this.bookBox.TextChanged += new System.EventHandler(this.bookBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "AddressBook";
            // 
            // firstNameDeleteBox
            // 
            this.firstNameDeleteBox.Location = new System.Drawing.Point(72, 181);
            this.firstNameDeleteBox.Name = "firstNameDeleteBox";
            this.firstNameDeleteBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameDeleteBox.TabIndex = 7;
            this.firstNameDeleteBox.TextChanged += new System.EventHandler(this.firstNameDeleteBox_TextChanged);
            // 
            // lastNameDeleteBox
            // 
            this.lastNameDeleteBox.Location = new System.Drawing.Point(263, 181);
            this.lastNameDeleteBox.Name = "lastNameDeleteBox";
            this.lastNameDeleteBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameDeleteBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "LastName";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(263, 41);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberBox.TabIndex = 11;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(72, 12);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 12;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(72, 38);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 13;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(263, 15);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 20);
            this.addressBox.TabIndex = 14;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(263, 67);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 15;
            // 
            // birthDateBox
            // 
            this.birthDateBox.Location = new System.Drawing.Point(72, 64);
            this.birthDateBox.Name = "birthDateBox";
            this.birthDateBox.Size = new System.Drawing.Size(100, 20);
            this.birthDateBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "FirstName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "LastName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "BirthDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "PhoneNumber";
            // 
            // genderBox
            // 
            this.genderBox.Location = new System.Drawing.Point(72, 103);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(100, 20);
            this.genderBox.TabIndex = 23;
            this.genderBox.TextChanged += new System.EventHandler(this.genderBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(263, 93);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Gender(man/woman)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(15, 262);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(348, 119);
            this.logBox.TabIndex = 27;
            this.logBox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "LogBox";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "старше 18 лет из Киева",
            "domain почты gmail.com",
            "пользователи девушки - добавленные  за последние 10 дней",
            "родились в январе",
            "словарь по ключу man/woman",
            "от _возраста до _ возраста",
            "количество пользователей из города _ у которых ДР"});
            this.comboBox1.Location = new System.Drawing.Point(402, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(602, 166);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(93, 39);
            this.FindBtn.TabIndex = 30;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // RedOfSearchBox
            // 
            this.RedOfSearchBox.Location = new System.Drawing.Point(413, 262);
            this.RedOfSearchBox.Name = "RedOfSearchBox";
            this.RedOfSearchBox.Size = new System.Drawing.Size(271, 119);
            this.RedOfSearchBox.TabIndex = 31;
            this.RedOfSearchBox.Text = "";
            this.RedOfSearchBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(422, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Result";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(399, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Find";
            // 
            // FromAgeText
            // 
            this.FromAgeText.Location = new System.Drawing.Point(446, 211);
            this.FromAgeText.Name = "FromAgeText";
            this.FromAgeText.Size = new System.Drawing.Size(77, 20);
            this.FromAgeText.TabIndex = 34;
            // 
            // ToAgeText
            // 
            this.ToAgeText.Location = new System.Drawing.Point(602, 211);
            this.ToAgeText.Name = "ToAgeText";
            this.ToAgeText.Size = new System.Drawing.Size(76, 20);
            this.ToAgeText.TabIndex = 35;
            this.ToAgeText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FAge
            // 
            this.FAge.AutoSize = true;
            this.FAge.Location = new System.Drawing.Point(389, 214);
            this.FAge.Name = "FAge";
            this.FAge.Size = new System.Drawing.Size(51, 13);
            this.FAge.TabIndex = 36;
            this.FAge.Text = "From age";
            this.FAge.Click += new System.EventHandler(this.label15_Click);
            // 
            // TAge
            // 
            this.TAge.AutoSize = true;
            this.TAge.Location = new System.Drawing.Point(545, 218);
            this.TAge.Name = "TAge";
            this.TAge.Size = new System.Drawing.Size(41, 13);
            this.TAge.TabIndex = 37;
            this.TAge.Text = "To age";
            // 
            // FromCityL
            // 
            this.FromCityL.AutoSize = true;
            this.FromCityL.Location = new System.Drawing.Point(474, 218);
            this.FromCityL.Name = "FromCityL";
            this.FromCityL.Size = new System.Drawing.Size(49, 13);
            this.FromCityL.TabIndex = 38;
            this.FromCityL.Text = "From city";
            this.FromCityL.Click += new System.EventHandler(this.label15_Click_1);
            // 
            // FromCity
            // 
            this.FromCity.Location = new System.Drawing.Point(536, 218);
            this.FromCity.Name = "FromCity";
            this.FromCity.Size = new System.Drawing.Size(100, 20);
            this.FromCity.TabIndex = 39;
            // 
            // FindKeyBox
            // 
            this.FindKeyBox.AutoCompleteCustomSource.AddRange(new string[] {
            "man",
            "woman"});
            this.FindKeyBox.Items.AddRange(new object[] {
            "man",
            "woman"});
            this.FindKeyBox.Location = new System.Drawing.Point(475, 215);
            this.FindKeyBox.Name = "FindKeyBox";
            this.FindKeyBox.Size = new System.Drawing.Size(121, 21);
            this.FindKeyBox.TabIndex = 40;
            // 
            // FindGenderKey
            // 
            this.FindGenderKey.AutoSize = true;
            this.FindGenderKey.Location = new System.Drawing.Point(418, 223);
            this.FindGenderKey.Name = "FindGenderKey";
            this.FindGenderKey.Size = new System.Drawing.Size(42, 13);
            this.FindGenderKey.TabIndex = 41;
            this.FindGenderKey.Text = "Gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 393);
            this.Controls.Add(this.FindGenderKey);
            this.Controls.Add(this.FindKeyBox);
            this.Controls.Add(this.FromCity);
            this.Controls.Add(this.FromCityL);
            this.Controls.Add(this.TAge);
            this.Controls.Add(this.FAge);
            this.Controls.Add(this.ToAgeText);
            this.Controls.Add(this.FromAgeText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.RedOfSearchBox);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birthDateBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameDeleteBox);
            this.Controls.Add(this.firstNameDeleteBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.RichTextBox bookBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameDeleteBox;
        private System.Windows.Forms.TextBox lastNameDeleteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox birthDateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.RichTextBox RedOfSearchBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox FromAgeText;
        private System.Windows.Forms.TextBox ToAgeText;
        private System.Windows.Forms.Label FAge;
        private System.Windows.Forms.Label TAge;
        private System.Windows.Forms.Label FromCityL;
        private System.Windows.Forms.TextBox FromCity;
        private System.Windows.Forms.ComboBox FindKeyBox;
        private System.Windows.Forms.Label FindGenderKey;
    }
}

