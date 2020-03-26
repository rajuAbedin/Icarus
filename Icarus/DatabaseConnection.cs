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
        public static DataSet GetDataDB(string value, string tableName, string credential)
        {
            string query = "Select " + value + " from " + tableName;
            if (!credential.Equals(""))
            {
                query = query + " where " + credential;
            }
            using (SQLiteConnection cnn = new SQLiteConnection(ConnectionString()))
            {
                DataSet dataSet = new DataSet();
                try
                {
                    var sqlAdapter = new SQLiteDataAdapter(query, cnn);
                    var builder = new SQLiteCommandBuilder(sqlAdapter);
                    
                    sqlAdapter.Fill(dataSet, "data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return dataSet;
            }
        }
        public static void InsetDataDB(string tableName, string variableName, string variableValue)
        {
            string query = "Insert into " + tableName + " (" + variableName + ") values (" + ValueSplitter(variableValue) + " );";
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
        private static string ValueSplitter(string Values)
        {
            String[] array = Values.Split(',');
            String variables = "";
            for(int i = 0; i < array.Length; i++)
            {
                variables = variables + "'" + array[i];
                if(i < array.Length -1)
                {
                    variables = variables + "', ";
                }
                else
                {
                    variables = variables + "'";
                }
            }
            return variables;
        }
        private static string ConnectionString(string id = "Icarus")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
