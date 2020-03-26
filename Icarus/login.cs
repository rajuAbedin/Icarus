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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUp_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(usernametxt.Text) || String.IsNullOrEmpty(passwordTxt.Text))
            {
                CustomMessabeBox customMessabeBox = new CustomMessabeBox();
                customMessabeBox.messageText("Please enter both credential!");
                customMessabeBox.messageType("Warning");
                customMessabeBox.messagebarColour("Red");
                customMessabeBox.ShowDialog();
            }
            else
            {               
                DataSet data = DatabaseConnection.GetDataDB("*", "Users", "Username = '" + usernametxt.Text + "'");
                if (data.Tables[0].Rows.Count == 0)
                {
                    CustomMessabeBox customMessabeBox = new CustomMessabeBox();
                    customMessabeBox.messageText("Wrong credential inputed!");
                    customMessabeBox.messageType("Warning");
                    customMessabeBox.messagebarColour("Red");
                    customMessabeBox.ShowDialog();
                }
                else
                {
                    login login = new login();
                    login.ShowDialog();
                }
            }
        }
    }
}
