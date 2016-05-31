using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook;



namespace Test2
{
    public partial class Form1 : Form
    {
        AddressBook.AddressBook addressBook = AddressBook.AddressBook.Book;

        public Form1()
        {
            InitializeComponent();
            addressBook.SetLogger(new Logger.Logger(message => AddText(message)));
            //this.Controls.Add(emailBox);
            //emailBox.KeyPress += new KeyPressEventHandler(keypressed);
            //this.Controls.Add(birthDateBox);
            //birthDateBox.KeyPress += new KeyPressEventHandler(keypress);
            FAge.Visible = false;
            TAge.Visible = false;
            FromAgeText.Visible = false;
            ToAgeText.Visible = false;
            FromCity.Visible = false;
            FromCityL.Visible = false;
            FindGenderKey.Visible = false;
            FindKeyBox.Visible = false;
        }

        //private void keypressed(Object o, KeyPressEventArgs e)
        //{          
        //        // Проверка на правильность почты
        //        if (!IsValidEmail(emailBox.Text))
        //        {
        //            e.Handled = true;
        //            MessageBox.Show("Incorrect email format : ******@****.*** Please reenter  your credits");
        //        }
        //}

        //private void keypress(Object o, KeyPressEventArgs e)
        //{
        //    // Проверка на правильность почты
        //    if (birthDateBox.Text==null)
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("Please Fill in all fields");
        //    }
        //}
        public void button1_Click(object sender, EventArgs e)
        {
            /*----- ADD USER BUTTON -------- */
            
            DateTime enteredDate = DateTime.Parse(birthDateBox.Text);
            MailAddress enteredMail=new MailAddress(emailBox.Text);
          
            User nextOne = new User(
                firstNameBox.Text,
                lastNameBox.Text,
                enteredDate,
                cityBox.Text,
                addressBox.Text,
                phoneNumberBox.Text,
                genderBox.Text,
                enteredMail
                );
            

            addressBook.AddUser(nextOne);
            bookBox.Text= addressBook.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*----REMOVE USER BUTTON -------- */
            User b = new User(firstNameDeleteBox.Text, lastNameDeleteBox.Text, DateTime.Now, " ", " ", " ", " ", new MailAddress("dfgh@mail.com"));
            addressBook.RemoveUser(b);
            bookBox.Text=addressBook.Print();
        }

        private void AddText(string message)
        {
            logBox.Text += message + "\n";
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void firstNameDeleteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (comboBox1.SelectedIndex == 5)
            {
                FAge.Visible = true;
                TAge.Visible = true;
                FromAgeText.Visible = true;
                ToAgeText.Visible = true;
                FromCity.Visible = false;
                FromCityL.Visible = false;
                FindGenderKey.Visible = false;
                FindKeyBox.Visible = false;
                FindGenderKey.Visible = false;
                FindKeyBox.Visible = false;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                FromCity.Visible = true;
                FromCityL.Visible = true;
                FAge.Visible = false;
                TAge.Visible = false;
                FromAgeText.Visible = false;
                ToAgeText.Visible = false;
                FindGenderKey.Visible = false;
                FindKeyBox.Visible = false;

            }
            if (comboBox1.SelectedIndex == 4)
            {
                FAge.Visible = false;
                TAge.Visible = false;
                FromAgeText.Visible = false;
                ToAgeText.Visible = false;
                FromCity.Visible = false;
                FromCityL.Visible = false;
                FindGenderKey.Visible = true;
                FindKeyBox.Visible = true;
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            RedOfSearchBox.Text = null;
            var res = new List<User>();
            if (comboBox1.SelectedIndex == 0)
            {
                res = addressBook.FindUserOlderEighteenFromKyiv();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                 res = addressBook.FindUserByGmail();                               
            }
            if (comboBox1.SelectedIndex == 2)
            {
                res = addressBook.FindUserGirlsForLastTenDays();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                res = addressBook.FindUserBirthInJanuary();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                if (FindKeyBox.SelectedIndex == 0)
                {
                    res = addressBook.FindUserByGender("man");
                }
                if (FindKeyBox.SelectedIndex == 1)
                {
                    res = addressBook.FindUserByGender("woman");
                }
            }
            if (comboBox1.SelectedIndex == 5)
            {
                res = addressBook.FindUserFromAgeToAge(Convert.ToInt16(FromAgeText.Text),
                    Convert.ToInt16(ToAgeText.Text));
            }
            if (comboBox1.SelectedIndex == 6)
            {
                res = addressBook.FindUserByFromCityAndBirthday(FromCity.Text);
            }

            foreach (User u in res)
            {
                RedOfSearchBox.Text += u.ToString() + "\n";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void genderBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bookBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
