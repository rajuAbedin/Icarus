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
    public partial class CustomMessabeBox : Form
    {
        public CustomMessabeBox()
        {
            InitializeComponent();
        }
        public void messageText(string info)
        {
            messageTextLbl.Text = info;
        }
        public void messageType(string type)
        {
            messageTypeLbl.Text = type;
        }
        public void messagebarColour(string colorName)
        {
            messageBar.BackColor = Color.FromName(colorName);
        }
        private void signUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
