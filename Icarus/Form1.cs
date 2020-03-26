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
    public partial class Form1 : Form
    {
        public Form1()
        {
            checkLicense();
            InitializeComponent();
            changeTitle();
            this.WindowState = FormWindowState.Maximized;

        }
        public void checkLicense()
        {
            DataSet data = DatabaseConnection.GetDataDB("*", "ShopInfo", "");
            if(data.Tables[0].Rows.Count == 0)
            {
                InitialForm initialForm = new InitialForm();
                initialForm.ShowDialog();
            }
            
        }
        private void changeTitle()
        {
            DataSet data = DatabaseConnection.GetDataDB("*", "ShopInfo", "");
            this.Text = data.Tables["data"].Rows[0][1].ToString() + " | Powered by Icarus";
        }
    }
}
