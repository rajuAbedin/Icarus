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
            string firstname = shopNametxt.Text;
            string surname = shopNametxt.Text;
            string contactNumber = shopNametxt.Text;
            string username = shopNametxt.Text;
            string password = shopNametxt.Text;
            string confPassword = shopNametxt.Text;
            string key = shopNametxt.Text;

            if (String.IsNullOrEmpty(shopName) || String.IsNullOrEmpty(firstname) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(contactNumber) || 
                String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confPassword) || String.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please feel all the box");
            }
            else
            {
                if (password.Equals(confPassword))
                {
                    MessageBox.Show("Working!!");
                }
            }
        }
    }
}
