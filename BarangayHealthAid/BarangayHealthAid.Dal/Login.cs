using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarangayHealthAid.Core;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BarangayHealthAid.Dal
{
    public class Login
    {
        private static string ConnectionString()
        {
            return PublicVariables.ConnectionString;
        }

        public static string TestConnectionErrorMessage;
        public static bool ConnectionIsGood = false;
        public static bool testconnection(string conn)
        {

            try
            {
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    ConnectionIsGood = true;
                    return true;
                }
            }
            catch (Exception ex)
            {
                TestConnectionErrorMessage = ex.Message + " Function: Check Server Connection";
                ConnectionIsGood = false;
                return false;
            }
        }
    }
}
