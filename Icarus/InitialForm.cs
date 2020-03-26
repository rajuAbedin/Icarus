using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Icarus
{
    public partial class InitialForm : Form
    {
        CustomMessabeBox messabeBox = new CustomMessabeBox();
        public InitialForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            string shopName = shopNametxt.Text;
            string firstname = firstnameTxt.Text;
            string surname = surnameTxt.Text;
            string contactNumber = contactNumberTxt.Text;
            string username = usernametxt.Text;
            string password = passwordTxt.Text;
            string confPassword = confPasswordTxt.Text;
            string key = keyTxt.Text;

            if (String.IsNullOrEmpty(shopName) || String.IsNullOrEmpty(firstname) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(contactNumber) || 
                String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confPassword) || String.IsNullOrEmpty(key))
            {
                messabeBox.messageText("Some information are empty!");
                messabeBox.messageType("Warning");
                messabeBox.messagebarColour("Red");
                messabeBox.ShowDialog();
            }
            else
            {
                if (password.Equals(confPassword))
                {
                    
                    DatabaseConnection.InsetDataDB("ShopInfo","ShopName,OwnerName,OwnerSurname,Key,Validated",
                        shopName + "," + firstname + "," + surname + "," + key + "," + "1");
                    DatabaseConnection.InsetDataDB("Users", "Firstname, Surname, Username, Password, Role, ContactNumber",
                        firstname + "," + surname + "," + username.ToLower() + "," + password + "," + "SuperAdmin" + "," + contactNumber);
                    this.Close();
                    messabeBox.messageText("Thank you for using Icarus");
                    messabeBox.ShowDialog();
                }
                else
                {
                    messabeBox.messageText("Password do not match!");
                    messabeBox.messageType("Warning");
                    messabeBox.messagebarColour("Red");
                    messabeBox.ShowDialog();
                }
            }
        }
    }
}
