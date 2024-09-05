using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using BarangayHealthAid.Core;
using System.Data;

namespace BarangayHealthAid.Dal
{
    public class PatientRecord
    {
        private static string ConnectionString()
        {
            return PublicVariables.ConnectionString;
        }

        public static string AddPatientErrorMessage;
        public static bool AddPatientIsSuccessful;
        public static void AddPatient(string _purok_name)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_name", _purok_name));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    AddPatientIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                AddPatientIsSuccessful = false;
                AddPatientErrorMessage = ex.Message + "\nFunction : Add Patient";
            }
        }
    }
}
