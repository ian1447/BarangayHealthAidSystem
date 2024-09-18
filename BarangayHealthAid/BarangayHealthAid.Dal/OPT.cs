﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using BarangayHealthAid.Core;
using System.Data;

namespace BarangayHealthAid.Dal
{
    public class OPT
    {
        private static string ConnectionString()
        {
            return PublicVariables.ConnectionString;
        }

        public static string GetOutPatientRecordsErrorMessage;
        public static bool GetOutPatientRecordsIsSuccessful;
        public static DataTable GetOutPatientRecords()
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_out_patient_get", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetOutPatientRecordsIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                GetOutPatientRecordsIsSuccessful = false;
                GetOutPatientRecordsErrorMessage = ex.Message + "\nFunction : Get Out Patient Records";
                return null;
            }
        }

        public static string OutPatientAddErrorMessage;
        public static bool OutPatientAddIsSuccessful;
        public static void OutPatientAdd(string _purok_no, string _name_of_child, string _birthdate, string _age_in_months, string _height, string _weight, string _nutritional_status)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_out_patient_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_no", _purok_no));
                    cmd.Parameters.Add(new MySqlParameter("_name_of_child", _name_of_child));
                    cmd.Parameters.Add(new MySqlParameter("_birthdate", _birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_age_in_months", _age_in_months));
                    cmd.Parameters.Add(new MySqlParameter("_height", _height));
                    cmd.Parameters.Add(new MySqlParameter("_weight", _weight));
                    cmd.Parameters.Add(new MySqlParameter("_nutritional_status", _nutritional_status));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    OutPatientAddIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                OutPatientAddIsSuccessful = false;
                OutPatientAddErrorMessage = ex.Message + "\nFunction : Add Out Patient";
            }
        }
    }
}
