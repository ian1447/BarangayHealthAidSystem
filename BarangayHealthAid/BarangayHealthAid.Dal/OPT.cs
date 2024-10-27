using System;
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
        public static DataSet GetOutPatientRecords(string _patient_type, DateTime _date_from, DateTime _date_to)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_out_patient_get", con);
                    cmd.Parameters.Add(new MySqlParameter("_patient_type", _patient_type));
                    cmd.Parameters.Add(new MySqlParameter("_date_from", _date_from));
                    cmd.Parameters.Add(new MySqlParameter("_date_to", _date_to));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetOutPatientRecordsIsSuccessful = true;
                    return dt;
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
        public static void OutPatientAdd(string _purok_no, int _patient_id, string _name_of_child, string _patient_type, string _birthdate, string _age_in_months, string _height, string _weight, string _nutritional_status, string _remarks)
        {
            _birthdate = _birthdate == "" ? null : _birthdate;
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_out_patient_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_no", _purok_no));
                    cmd.Parameters.Add(new MySqlParameter("_name_of_child", _name_of_child));
                    cmd.Parameters.Add(new MySqlParameter("_patient_type", _patient_type));
                    cmd.Parameters.Add(new MySqlParameter("_patient_id", _patient_id));
                    cmd.Parameters.Add(new MySqlParameter("_birthdate", _birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_age_in_months", _age_in_months));
                    cmd.Parameters.Add(new MySqlParameter("_height", _height));
                    cmd.Parameters.Add(new MySqlParameter("_weight", _weight));
                    cmd.Parameters.Add(new MySqlParameter("_nutritional_status", _nutritional_status));
                    cmd.Parameters.Add(new MySqlParameter("_remarks", _remarks));
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

        public static string OutPatientEditErrorMessage;
        public static bool OutPatientEditIsSuccessful;
        public static void OutPatientEdit(string _purok_no, int _patient_id, string _name_of_child, string _patient_type, string _birthdate, string _age_in_months, string _height, string _weight, string _nutritional_status, string _remarks, string _id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_out_patient_edit", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_no", _purok_no));
                    cmd.Parameters.Add(new MySqlParameter("_name_of_child", _name_of_child));
                    cmd.Parameters.Add(new MySqlParameter("_patient_type", _patient_type));
                    cmd.Parameters.Add(new MySqlParameter("_patient_id", _patient_id));
                    cmd.Parameters.Add(new MySqlParameter("_birthdate", _birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_age_in_months", _age_in_months));
                    cmd.Parameters.Add(new MySqlParameter("_height", _height));
                    cmd.Parameters.Add(new MySqlParameter("_weight", _weight));
                    cmd.Parameters.Add(new MySqlParameter("_nutritional_status", _nutritional_status));
                    cmd.Parameters.Add(new MySqlParameter("_remarks", _remarks));
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    OutPatientEditIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                OutPatientEditIsSuccessful = false;
                OutPatientEditErrorMessage = ex.Message + "\nFunction : Edit Out Patient";
            }
        }

        public static string ChildGetHistoryErrorMessage;
        public static bool ChildGetHistoryIsSuccessful;
        public static DataTable ChildGetHistory(int _mode, int _show_history)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_chlid_sub_opt_get", con);
                    cmd.Parameters.Add(new MySqlParameter("_mode", _mode));
                    cmd.Parameters.Add(new MySqlParameter("_show_history", _show_history));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    ChildGetHistoryIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                ChildGetHistoryIsSuccessful = false;
                ChildGetHistoryErrorMessage = ex.Message + "\nFunction : Get Child History";
                return null;    
            }
        }

        public static string ChildAddHistoryErrorMessage;
        public static bool ChildAddHistoryIsSuccessful;
        public static void ChildAddHistory(int _out_patient_id, string _remarks, int _mode)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_child_sub_opt_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_out_patient_id", _out_patient_id));
                    cmd.Parameters.Add(new MySqlParameter("_remarks", _remarks));
                    cmd.Parameters.Add(new MySqlParameter("_mode", _mode));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    ChildAddHistoryIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                ChildAddHistoryIsSuccessful = false;
                ChildAddHistoryErrorMessage = ex.Message + "\nFunction : Add Child History";
            }
        }
    }
}
