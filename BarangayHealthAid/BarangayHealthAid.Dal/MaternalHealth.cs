using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using BarangayHealthAid.Core;
using System.Data;

namespace BarangayHealthAid.Dal
{
    public class MaternalHealth
    {
        private static string ConnectionString()
        {
            return PublicVariables.ConnectionString;
        }

        public static string GetMaternalHealthRecordErrorMessage;
        public static bool GetMaternalHealthRecordIsSuccessful;
        public static DataTable GetMaternalHealthRecord()
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_maternal_health_record_get", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetMaternalHealthRecordIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                GetMaternalHealthRecordIsSuccessful = false;
                GetMaternalHealthRecordErrorMessage = ex.Message + "\nFunction : Get Patient Maternal Health Record";
                return null;
            }
        }

        public static string AddMaternalHealthRecordErrorMessage;
        public static bool AddMaternalHealthRecordIsSuccessful;
        public static void AddMaternalHealthRecord(string _last_name, string dob)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_maternal_health_record_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_patient_id", 0));
                    cmd.Parameters.Add(new MySqlParameter("_name", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_age", 21));
                    cmd.Parameters.Add(new MySqlParameter("_dob", dob));
                    cmd.Parameters.Add(new MySqlParameter("_height", 158));
                    cmd.Parameters.Add(new MySqlParameter("_husband_name", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_occupation", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_address", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_contact_no", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_no_children_born_alive", 1));
                    cmd.Parameters.Add(new MySqlParameter("_living_children", 1));
                    cmd.Parameters.Add(new MySqlParameter("_abortion", 0));
                    cmd.Parameters.Add(new MySqlParameter("_fetal_deaths", 0));
                    cmd.Parameters.Add(new MySqlParameter("_largebabies", 0));
                    cmd.Parameters.Add(new MySqlParameter("_diabetes", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_previous_illness", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_allergy", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_previous_hospitalization", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_gravida", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_PARA", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_A", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_LMP", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_EDC", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_where_to_deliver", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_attended_by", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_new_born_screening_plan", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_risk_codes", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_tt1", dob));
                    cmd.Parameters.Add(new MySqlParameter("_tt2", dob));
                    cmd.Parameters.Add(new MySqlParameter("_tt3", dob));
                    cmd.Parameters.Add(new MySqlParameter("_tt4", dob));
                    cmd.Parameters.Add(new MySqlParameter("_tt5", dob));
                    cmd.Parameters.Add(new MySqlParameter("_urinalysis", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_hbs_antigen", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_CBC", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_RPR", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_blood_typing", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_HIV", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_prev_pregnancy_complic", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_checklist", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_vit_a_date_given", dob));
                    cmd.Parameters.Add(new MySqlParameter("_vit_a_prescribed", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_4", dob));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_5", dob));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_6", dob));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_7", dob));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_8", dob));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_9", dob));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    AddMaternalHealthRecordIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                AddMaternalHealthRecordIsSuccessful = false;
                AddMaternalHealthRecordErrorMessage = ex.Message + "\nFunction : Add Maternal Health Record";
            }
        }
    }
}
