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

        public static string GetMaternalHealthRecordHistoryErrorMessage;
        public static bool GetMaternalHealthRecordHistoryIsSuccessful;
        public static DataTable GetMaternalHealthRecordHistory(int _maternal_health_record_id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_maternal_health_history_get", con);
                    cmd.Parameters.Add(new MySqlParameter("_maternal_health_record_id", _maternal_health_record_id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetMaternalHealthRecordHistoryIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                GetMaternalHealthRecordHistoryIsSuccessful = false;
                GetMaternalHealthRecordHistoryErrorMessage = ex.Message + "\nFunction : Get Patient Maternal Health Record History";
                return null;
            }
        }

        public static string AddMaternalHealthRecordErrorMessage;
        public static bool AddMaternalHealthRecordIsSuccessful;
        public static void AddMaternalHealthRecord(int _patient_id, string _name, string _age, string _dob, string _height, string _husband_name, string _occupation, string _address, string _contact_no, string _no_children_born_alive, string _living_children, string _abortion, string _fetal_deaths, string _type_last_delivery, string _largebabies, string _diabetes, string _previous_illness, string _allergy, string _previous_hospitalization, string _gravida, string _PARA, string _A, string _stillbirth, string _LMP, string _EDC, string _where_to_deliver, string _attended_by, string _new_born_screening_plan, string _risk_codes, string _tt1, string _tt2, string _tt3, string _tt4, string _tt5, string _urinalysis, string _hbs_antigen, string _CBC, string _RPR, string _blood_typing, string _HIV, string _prev_pregnancy_complic, string _checklist, string _vit_a_date_given, string _vit_a_prescribed, string _iron_folic_4, string _iron_folic_5, string _iron_folic_6, string _iron_folic_7, string _iron_folic_8, string _iron_folic_9)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_maternal_health_record_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_patient_id", _patient_id));
                    cmd.Parameters.Add(new MySqlParameter("_name", _name));
                    cmd.Parameters.Add(new MySqlParameter("_age", _age));
                    cmd.Parameters.Add(new MySqlParameter("_dob", _dob));
                    cmd.Parameters.Add(new MySqlParameter("_height", _height));
                    cmd.Parameters.Add(new MySqlParameter("_husband_name", _husband_name));
                    cmd.Parameters.Add(new MySqlParameter("_occupation", _occupation));
                    cmd.Parameters.Add(new MySqlParameter("_address", _address));
                    cmd.Parameters.Add(new MySqlParameter("_contact_no", _contact_no));
                    cmd.Parameters.Add(new MySqlParameter("_no_children_born_alive", _no_children_born_alive));
                    cmd.Parameters.Add(new MySqlParameter("_living_children", _living_children));
                    cmd.Parameters.Add(new MySqlParameter("_abortion", _abortion));
                    cmd.Parameters.Add(new MySqlParameter("_fetal_deaths", _fetal_deaths));
                    cmd.Parameters.Add(new MySqlParameter("_type_last_delivery", _type_last_delivery));
                    cmd.Parameters.Add(new MySqlParameter("_largebabies", _largebabies));
                    cmd.Parameters.Add(new MySqlParameter("_diabetes", _diabetes));
                    cmd.Parameters.Add(new MySqlParameter("_previous_illness", _previous_illness));
                    cmd.Parameters.Add(new MySqlParameter("_allergy", _allergy));
                    cmd.Parameters.Add(new MySqlParameter("_previous_hospitalization", _previous_hospitalization));
                    cmd.Parameters.Add(new MySqlParameter("_gravida", _gravida));
                    cmd.Parameters.Add(new MySqlParameter("_PARA", _PARA));
                    cmd.Parameters.Add(new MySqlParameter("_A", _A));
                    cmd.Parameters.Add(new MySqlParameter("_stillbirth", _stillbirth));
                    cmd.Parameters.Add(new MySqlParameter("_LMP", _LMP));
                    cmd.Parameters.Add(new MySqlParameter("_EDC", _EDC));
                    cmd.Parameters.Add(new MySqlParameter("_where_to_deliver", _where_to_deliver));
                    cmd.Parameters.Add(new MySqlParameter("_attended_by", _attended_by));
                    cmd.Parameters.Add(new MySqlParameter("_new_born_screening_plan", _new_born_screening_plan));
                    cmd.Parameters.Add(new MySqlParameter("_risk_codes", _risk_codes));
                    cmd.Parameters.Add(new MySqlParameter("_tt1", _tt1));
                    cmd.Parameters.Add(new MySqlParameter("_tt2", _tt2));
                    cmd.Parameters.Add(new MySqlParameter("_tt3", _tt3));
                    cmd.Parameters.Add(new MySqlParameter("_tt4", _tt4));
                    cmd.Parameters.Add(new MySqlParameter("_tt5", _tt5));
                    cmd.Parameters.Add(new MySqlParameter("_urinalysis", _urinalysis));
                    cmd.Parameters.Add(new MySqlParameter("_hbs_antigen", _hbs_antigen));
                    cmd.Parameters.Add(new MySqlParameter("_CBC", _CBC));
                    cmd.Parameters.Add(new MySqlParameter("_RPR", _RPR));
                    cmd.Parameters.Add(new MySqlParameter("_blood_typing", _blood_typing));
                    cmd.Parameters.Add(new MySqlParameter("_HIV", _HIV));
                    cmd.Parameters.Add(new MySqlParameter("_prev_pregnancy_complic", _prev_pregnancy_complic));
                    cmd.Parameters.Add(new MySqlParameter("_checklist", _checklist));
                    cmd.Parameters.Add(new MySqlParameter("_vit_a_date_given", _vit_a_date_given));
                    cmd.Parameters.Add(new MySqlParameter("_vit_a_prescribed", _vit_a_prescribed));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_4", _iron_folic_4));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_5", _iron_folic_5));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_6", _iron_folic_6));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_7", _iron_folic_7));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_8", _iron_folic_8));
                    cmd.Parameters.Add(new MySqlParameter("_iron_folic_9", _iron_folic_9));
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

        public static string AddMaternalHealthRecordHistoryErrorMessage;
        public static bool AddMaternalHealthRecordHistoryIsSuccessful;
        public static void AddMaternalHealthRecordHistory(int _maternal_health_record_id, string _aog, string _weight, string _bp, string _fh, string _fhb, string _presenting_part_of_fetus, string _findings, string _notes)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_maternal_health_history_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_maternal_health_record_id", _maternal_health_record_id));
                    cmd.Parameters.Add(new MySqlParameter("_aog", _aog));
                    cmd.Parameters.Add(new MySqlParameter("_weight", _weight));
                    cmd.Parameters.Add(new MySqlParameter("_bp", _bp));
                    cmd.Parameters.Add(new MySqlParameter("_fh", _fh));
                    cmd.Parameters.Add(new MySqlParameter("_fhb", _fhb));
                    cmd.Parameters.Add(new MySqlParameter("_presenting_part_of_fetus", _presenting_part_of_fetus));
                    cmd.Parameters.Add(new MySqlParameter("_findings", _findings));
                    cmd.Parameters.Add(new MySqlParameter("_notes", _notes));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    AddMaternalHealthRecordHistoryIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                AddMaternalHealthRecordHistoryIsSuccessful = false;
                AddMaternalHealthRecordHistoryErrorMessage = ex.Message + "\nFunction : Add Maternal Health Record History";
            }
        }
    }
}
