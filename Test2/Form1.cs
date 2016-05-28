using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        public void button1_Click(object sender, EventArgs e)
        {
          /*----- ADD USER BUTTON -------- */
            User nextOne = new User(
                firstNameBox.Text,
                lastNameBox.Text,
                birthDateBox.Text,
                cityBox.Text,
                addressBox.Text,
                phoneNumberBox.Text,
                genderBox.Text,
                emailBox.Text
            );

            addressBook.AddUser(nextOne);
            bookBox.Text= addressBook.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*----REMOVE USER BUTTON -------- */
            User b = new User(firstNameDeleteBox.Text, lastNameDeleteBox.Text, "", "", "", "", "", "");
            addressBook.RemoveUser(b);
            bookBox.Text=addressBook.Print();
        }

        private void AddText(string message)
        {
            logBox.Text += message + "\n";
        }
    }
}
