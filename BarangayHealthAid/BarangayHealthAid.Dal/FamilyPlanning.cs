using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using BarangayHealthAid.Core;
using System.Data;

namespace BarangayHealthAid.Dal
{
    public class FamilyPlanning
    {
        private static string ConnectionString()
        {
            return PublicVariables.ConnectionString;
        }

        public static string GetFamilyPlanningRecordErrorMessage;
        public static bool GetFamilyPlanningRecordIsSuccessful;
        public static DataTable GetFamilyPlanningRecord()
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_family_planning_get", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetFamilyPlanningRecordIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                GetFamilyPlanningRecordIsSuccessful = false;
                GetFamilyPlanningRecordErrorMessage = ex.Message + "\nFunction : Get Family Planning Record";
                return null;
            }
        }

        public static string AddFamilyPlanningRecordErrorMessage;
        public static bool AddFamilyPlanningRecordIsSuccessful;
        public static void AddFamilyPlanningRecord(string _last_name, string _given_name, string _middle_initial, string _dob, string _age, string _educ_attain, string _occupation, string _address_no, string _address_street, string _address_barangay, string _address_muncity, string _address_prov, string _contact_number, string _civil_status, string _religion, string _spouse_last_name, string _spouse_given_name, string _spouse_middle_inital, string _spouse_dob, string _spouse_age, string _spouse_occupation, string _living_children, string _plan_more_children, string _average_monthly_income, string _type_of_client, string _reason_for_FP, string _others, string _current_user_type, string _changin_method_resaon, string _side_effects, string _currently_used_changing_methods, string _changing_method_others, string _medical_history, string _med_history_specify, string _pregnancies_G, string _pregnancies_P, string _pregnancy_full_term, string _pregnancy_abortion, string _pregnancy_premature, string _pregnancy_living, string _date_last_delivery, string _type_last_delivery, string _last_menstrual_period, string _previous_mentrual_period, string _menstrual_flow, string _dysmenorrhea, string _hydatidiform_mole, string _ectopitic_pregnancy, string _sexually_transmitted_infections_risk, string _genital_area_yes, string _VAW, string _referred_to, string _weight, string _height, string _bp, string _pulse_rate, string _skin, string _conjunctiva, string _neck, string _breast, string _abdomen, string _extremities, string _pelvic_examination, string _cervical_abnormalities, string _cervical_consistency, string _uterine_position, string _uterine_depth)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_family_planning_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_last_name", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_given_name", _given_name));
                    cmd.Parameters.Add(new MySqlParameter("_middle_initial", _middle_initial));
                    cmd.Parameters.Add(new MySqlParameter("_dob", _dob));
                    cmd.Parameters.Add(new MySqlParameter("_age", _age));
                    cmd.Parameters.Add(new MySqlParameter("_educ_attain", _educ_attain));
                    cmd.Parameters.Add(new MySqlParameter("_occupation", _occupation));
                    cmd.Parameters.Add(new MySqlParameter("_address_no", _address_no));
                    cmd.Parameters.Add(new MySqlParameter("_address_street", _address_street));
                    cmd.Parameters.Add(new MySqlParameter("_address_barangay", _address_barangay));
                    cmd.Parameters.Add(new MySqlParameter("_address_muncity", _address_muncity));
                    cmd.Parameters.Add(new MySqlParameter("_address_prov", _address_prov));
                    cmd.Parameters.Add(new MySqlParameter("_contact_number", _contact_number));
                    cmd.Parameters.Add(new MySqlParameter("_civil_status", _civil_status));
                    cmd.Parameters.Add(new MySqlParameter("_religion", _religion));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_last_name", _spouse_last_name));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_given_name", _spouse_given_name));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_middle_inital", _spouse_middle_inital));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_dob", _spouse_dob));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_age", _spouse_age));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_occupation", _spouse_occupation));
                    cmd.Parameters.Add(new MySqlParameter("_living_children", _living_children));
                    cmd.Parameters.Add(new MySqlParameter("_plan_more_children", _plan_more_children));
                    cmd.Parameters.Add(new MySqlParameter("_average_monthly_income", _average_monthly_income));
                    cmd.Parameters.Add(new MySqlParameter("_type_of_client", _type_of_client));
                    cmd.Parameters.Add(new MySqlParameter("_reason_for_FP", _reason_for_FP));
                    cmd.Parameters.Add(new MySqlParameter("_others", _others));
                    cmd.Parameters.Add(new MySqlParameter("_current_user_type", _current_user_type));
                    cmd.Parameters.Add(new MySqlParameter("_changin_method_resaon", _changin_method_resaon));
                    cmd.Parameters.Add(new MySqlParameter("_side_effects", _side_effects));
                    cmd.Parameters.Add(new MySqlParameter("_currently_used_changing_methods", _currently_used_changing_methods));
                    cmd.Parameters.Add(new MySqlParameter("_changing_method_others", _changing_method_others));
                    cmd.Parameters.Add(new MySqlParameter("_medical_history", _medical_history));
                    cmd.Parameters.Add(new MySqlParameter("_med_history_specify", _med_history_specify));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancies_G", _pregnancies_G));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancies_P", _pregnancies_P));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancy_full_term", _pregnancy_full_term));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancy_abortion", _pregnancy_abortion));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancy_premature", _pregnancy_premature));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancy_living", _pregnancy_living));
                    cmd.Parameters.Add(new MySqlParameter("_date_last_delivery", _date_last_delivery));
                    cmd.Parameters.Add(new MySqlParameter("_type_last_delivery", _type_last_delivery));
                    cmd.Parameters.Add(new MySqlParameter("_last_menstrual_period", _last_menstrual_period));
                    cmd.Parameters.Add(new MySqlParameter("_previous_mentrual_period", _previous_mentrual_period));
                    cmd.Parameters.Add(new MySqlParameter("_menstrual_flow", _menstrual_flow));
                    cmd.Parameters.Add(new MySqlParameter("_dysmenorrhea", _dysmenorrhea));
                    cmd.Parameters.Add(new MySqlParameter("_hydatidiform_mole", _hydatidiform_mole));
                    cmd.Parameters.Add(new MySqlParameter("_ectopitic_pregnancy", _ectopitic_pregnancy));
                    cmd.Parameters.Add(new MySqlParameter("_sexually_transmitted_infections_risk", _sexually_transmitted_infections_risk));
                    cmd.Parameters.Add(new MySqlParameter("_genital_area_yes", _genital_area_yes));
                    cmd.Parameters.Add(new MySqlParameter("_VAW", _VAW));
                    cmd.Parameters.Add(new MySqlParameter("_referred_to", _referred_to));
                    cmd.Parameters.Add(new MySqlParameter("_weight", _weight));
                    cmd.Parameters.Add(new MySqlParameter("_height", _height));
                    cmd.Parameters.Add(new MySqlParameter("_bp", _bp));
                    cmd.Parameters.Add(new MySqlParameter("_pulse_rate", _pulse_rate));
                    cmd.Parameters.Add(new MySqlParameter("_skin", _skin));
                    cmd.Parameters.Add(new MySqlParameter("_conjunctiva", _conjunctiva));
                    cmd.Parameters.Add(new MySqlParameter("_neck", _neck));
                    cmd.Parameters.Add(new MySqlParameter("_breast", _breast));
                    cmd.Parameters.Add(new MySqlParameter("_abdomen", _abdomen));
                    cmd.Parameters.Add(new MySqlParameter("_extremities", _extremities));
                    cmd.Parameters.Add(new MySqlParameter("_pelvic_examination", _pelvic_examination));
                    cmd.Parameters.Add(new MySqlParameter("_cervical_abnormalities", _cervical_abnormalities));
                    cmd.Parameters.Add(new MySqlParameter("_cervical_consistency", _cervical_consistency));
                    cmd.Parameters.Add(new MySqlParameter("_uterine_position", _uterine_position));
                    cmd.Parameters.Add(new MySqlParameter("_uterine_depth", _uterine_depth));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    AddFamilyPlanningRecordIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                AddFamilyPlanningRecordIsSuccessful = false;
                AddFamilyPlanningRecordErrorMessage = ex.Message + "\nFunction : Add Family Planning Record";
            }
        }

        public static string UpdateFamilyPlanningRecordErrorMessage;
        public static bool UpdateFamilyPlanningRecordIsSuccessful;
        public static void UpdateFamilyPlanningRecord(string _last_name, string _given_name, string _middle_initial, string _dob, string _age, string _educ_attain, string _occupation, string _address_no, string _address_street, string _address_barangay, string _address_muncity, string _address_prov, string _contact_number, string _civil_status, string _religion, string _spouse_last_name, string _spouse_given_name, string _spouse_middle_inital, string _spouse_dob, string _spouse_age, string _spouse_occupation, string _living_children, string _plan_more_children, string _average_monthly_income, string _type_of_client, string _reason_for_FP, string _others, string _current_user_type, string _changin_method_resaon, string _side_effects, string _currently_used_changing_methods, string _changing_method_others, string _medical_history, string _med_history_specify, string _pregnancies_G, string _pregnancies_P, string _pregnancy_full_term, string _pregnancy_abortion, string _pregnancy_premature, string _pregnancy_living, string _date_last_delivery, string _type_last_delivery, string _last_menstrual_period, string _previous_mentrual_period, string _menstrual_flow, string _dysmenorrhea, string _hydatidiform_mole, string _ectopitic_pregnancy, string _sexually_transmitted_infections_risk, string _genital_area_yes, string _VAW, string _referred_to, string _weight, string _height, string _bp, string _pulse_rate, string _skin, string _conjunctiva, string _neck, string _breast, string _abdomen, string _extremities, string _pelvic_examination, string _cervical_abnormalities, string _cervical_consistency, string _uterine_position, string _uterine_depth, int _id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_family_planning_update", con);
                    cmd.Parameters.Add(new MySqlParameter("_last_name", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_given_name", _given_name));
                    cmd.Parameters.Add(new MySqlParameter("_middle_initial", _middle_initial));
                    cmd.Parameters.Add(new MySqlParameter("_dob", _dob));
                    cmd.Parameters.Add(new MySqlParameter("_age", _age));
                    cmd.Parameters.Add(new MySqlParameter("_educ_attain", _educ_attain));
                    cmd.Parameters.Add(new MySqlParameter("_occupation", _occupation));
                    cmd.Parameters.Add(new MySqlParameter("_address_no", _address_no));
                    cmd.Parameters.Add(new MySqlParameter("_address_street", _address_street));
                    cmd.Parameters.Add(new MySqlParameter("_address_barangay", _address_barangay));
                    cmd.Parameters.Add(new MySqlParameter("_address_muncity", _address_muncity));
                    cmd.Parameters.Add(new MySqlParameter("_address_prov", _address_prov));
                    cmd.Parameters.Add(new MySqlParameter("_contact_number", _contact_number));
                    cmd.Parameters.Add(new MySqlParameter("_civil_status", _civil_status));
                    cmd.Parameters.Add(new MySqlParameter("_religion", _religion));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_last_name", _spouse_last_name));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_given_name", _spouse_given_name));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_middle_inital", _spouse_middle_inital));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_dob", _spouse_dob));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_age", _spouse_age));
                    cmd.Parameters.Add(new MySqlParameter("_spouse_occupation", _spouse_occupation));
                    cmd.Parameters.Add(new MySqlParameter("_living_children", _living_children));
                    cmd.Parameters.Add(new MySqlParameter("_plan_more_children", _plan_more_children));
                    cmd.Parameters.Add(new MySqlParameter("_average_monthly_income", _average_monthly_income));
                    cmd.Parameters.Add(new MySqlParameter("_type_of_client", _type_of_client));
                    cmd.Parameters.Add(new MySqlParameter("_reason_for_FP", _reason_for_FP));
                    cmd.Parameters.Add(new MySqlParameter("_others", _others));
                    cmd.Parameters.Add(new MySqlParameter("_current_user_type", _current_user_type));
                    cmd.Parameters.Add(new MySqlParameter("_changin_method_resaon", _changin_method_resaon));
                    cmd.Parameters.Add(new MySqlParameter("_side_effects", _side_effects));
                    cmd.Parameters.Add(new MySqlParameter("_currently_used_changing_methods", _currently_used_changing_methods));
                    cmd.Parameters.Add(new MySqlParameter("_changing_method_others", _changing_method_others));
                    cmd.Parameters.Add(new MySqlParameter("_medical_history", _medical_history));
                    cmd.Parameters.Add(new MySqlParameter("_med_history_specify", _med_history_specify));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancies_G", _pregnancies_G));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancies_P", _pregnancies_P));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancy_full_term", _pregnancy_full_term));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancy_abortion", _pregnancy_abortion));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancy_premature", _pregnancy_premature));
                    cmd.Parameters.Add(new MySqlParameter("_pregnancy_living", _pregnancy_living));
                    cmd.Parameters.Add(new MySqlParameter("_date_last_delivery", _date_last_delivery));
                    cmd.Parameters.Add(new MySqlParameter("_type_last_delivery", _type_last_delivery));
                    cmd.Parameters.Add(new MySqlParameter("_last_menstrual_period", _last_menstrual_period));
                    cmd.Parameters.Add(new MySqlParameter("_previous_mentrual_period", _previous_mentrual_period));
                    cmd.Parameters.Add(new MySqlParameter("_menstrual_flow", _menstrual_flow));
                    cmd.Parameters.Add(new MySqlParameter("_dysmenorrhea", _dysmenorrhea));
                    cmd.Parameters.Add(new MySqlParameter("_hydatidiform_mole", _hydatidiform_mole));
                    cmd.Parameters.Add(new MySqlParameter("_ectopitic_pregnancy", _ectopitic_pregnancy));
                    cmd.Parameters.Add(new MySqlParameter("_sexually_transmitted_infections_risk", _sexually_transmitted_infections_risk));
                    cmd.Parameters.Add(new MySqlParameter("_genital_area_yes", _genital_area_yes));
                    cmd.Parameters.Add(new MySqlParameter("_VAW", _VAW));
                    cmd.Parameters.Add(new MySqlParameter("_referred_to", _referred_to));
                    cmd.Parameters.Add(new MySqlParameter("_weight", _weight));
                    cmd.Parameters.Add(new MySqlParameter("_height", _height));
                    cmd.Parameters.Add(new MySqlParameter("_bp", _bp));
                    cmd.Parameters.Add(new MySqlParameter("_pulse_rate", _pulse_rate));
                    cmd.Parameters.Add(new MySqlParameter("_skin", _skin));
                    cmd.Parameters.Add(new MySqlParameter("_conjunctiva", _conjunctiva));
                    cmd.Parameters.Add(new MySqlParameter("_neck", _neck));
                    cmd.Parameters.Add(new MySqlParameter("_breast", _breast));
                    cmd.Parameters.Add(new MySqlParameter("_abdomen", _abdomen));
                    cmd.Parameters.Add(new MySqlParameter("_extremities", _extremities));
                    cmd.Parameters.Add(new MySqlParameter("_pelvic_examination", _pelvic_examination));
                    cmd.Parameters.Add(new MySqlParameter("_cervical_abnormalities", _cervical_abnormalities));
                    cmd.Parameters.Add(new MySqlParameter("_cervical_consistency", _cervical_consistency));
                    cmd.Parameters.Add(new MySqlParameter("_uterine_position", _uterine_position));
                    cmd.Parameters.Add(new MySqlParameter("_uterine_depth", _uterine_depth));
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    UpdateFamilyPlanningRecordIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                UpdateFamilyPlanningRecordIsSuccessful = false;
                UpdateFamilyPlanningRecordErrorMessage = ex.Message + "\nFunction : Updating Family Planning Record";
            }
        }
    }
}
