using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Icarus
{
    public class DatabaseConnection
    {
        public static DataSet GetDataDB(string query)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(ConnectionString()))
            {
                DataSet dataSet = new DataSet();
                try
                {
                    var sqlAdapter = new SQLiteDataAdapter(query, cnn);
                    var builder = new SQLiteCommandBuilder(sqlAdapter);
                    
                    sqlAdapter.Fill(dataSet, "info");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return dataSet;
            }
        }
        public static void InsetDataDB(string query)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConnectionString()))
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
        private static string ConnectionString(string id = "Icarus")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
