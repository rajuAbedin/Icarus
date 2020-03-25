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
            InitializeComponent();
            checkLicense();
            //DatabaseConnection.InsetDataDB("ShopInfo", "OwnerName, OwnerSurname, Key, Validated", "Raju, Minhajul Abedin, 22SDGDSFG5FHHHV2, 1");
        }
        public void checkLicense()
        {
            DataSet data = DatabaseConnection.GetDataDB("*", "ShopInfo", "ID = 1");
            if(data.Tables[0].Rows.Count == 0)
            {
                InitialForm initialForm = new InitialForm();
                initialForm.ShowDialog();
            }
            
        }
    }
}
