using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using BarangayHealthAid.Core;
using System.Data;

namespace BarangayHealthAid.Dal
{
    public class SQL
    {
        private static string ConnectionString()
        {
            return PublicVariables.ConnectionString;
        }

        public static bool GetServerDatetimeIsGood = false;
        public static string GetServerDatetimeErrorMessage;
        public static DateTime GetServerDatetime()
        {
            DataTable table = new DataTable();
            DateTime date = new DateTime();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT CURRENT_TIMESTAMP;", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(table);
                    con.Close();
                    GetServerDatetimeIsGood = true;
                    if (table.Rows.Count > 0)
                    {
                        date = Convert.ToDateTime(table.Rows[0]["CURRENT_TIMESTAMP"]);
                        return date;
                    }
                    else
                    {
                        return date;
                    }
                }
            }
            catch (Exception ex)
            {
                GetServerDatetimeErrorMessage = ex.Message;
                return date;
            }
        }
    }
}
