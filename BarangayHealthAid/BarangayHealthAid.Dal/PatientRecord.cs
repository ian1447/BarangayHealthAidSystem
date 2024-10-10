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

        public static string GetPatientDetailsErrorMessage;
        public static bool GetPatientDetailsIsSuccessful;
        public static DataTable GetPatientDetails()
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_patient_details_get", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetPatientDetailsIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                GetPatientDetailsIsSuccessful = false;
                GetPatientDetailsErrorMessage = ex.Message + "\nFunction : Get Patient Details";
                return null;
            }
        }

        public static string AddPatientErrorMessage;
        public static bool AddPatientIsSuccessful;
        public static void AddPatient(string _last_name, string _first_name, string _name_extension, string _middle_name, string _maiden_last_name, string _maiden_first_name, string _maiden_name_extension, string _maiden_middle_name, string _birthdate, string _age, string _place_of_birth, string _sex, string _civil_status, string _religion, string _blood_type, string _contact_number, string _address_purok, string _address_barangay, string _address_mun, string _address_province, string _address_country, string _address_zip_zode, string _educational_attainment, string _employment_status, string _TIN, string _ph_stat, string _phic_id_no, string _phic_status_type, int _is_4p, string _4p_id_no, string _4p_status_type, string _membership_cat, string _partner_last_name, string _partner_first_name, string _partner_name_extension, string _partner_middle_name, string _partner_birthdate, string _partner_sex, string _partner_phic_id, string _father_last_name, string _father_first_name, string _father_name_extension, string _father_middle_name, string _father_birthdate, string _father_disability, string _father_phic_id, string _mother_last_name, string _mother_first_name, string _mother_name_extension, string _mother_middle_name, string _mother_birthdate, string _mother_disability, string _mother_phic_id, int _purok_family_member_id)
        {
            DataSet dt = new DataSet();
            _partner_birthdate = _partner_birthdate == "" ? null : _partner_birthdate;
            _father_birthdate = _father_birthdate == "" ? null : _father_birthdate;
            _mother_birthdate = _mother_birthdate == "" ? null : _mother_birthdate;
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_patient_details_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_family_member_id", _purok_family_member_id));
                    cmd.Parameters.Add(new MySqlParameter("_last_name", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_first_name", _first_name));
                    cmd.Parameters.Add(new MySqlParameter("_name_extension", _name_extension));
                    cmd.Parameters.Add(new MySqlParameter("_middle_name", _middle_name));
                    cmd.Parameters.Add(new MySqlParameter("_maiden_last_name", _maiden_last_name));
                    cmd.Parameters.Add(new MySqlParameter("_maiden_first_name", _maiden_first_name));
                    cmd.Parameters.Add(new MySqlParameter("_maiden_name_extension", _maiden_name_extension));
                    cmd.Parameters.Add(new MySqlParameter("_maiden_middle_name", _maiden_middle_name));
                    cmd.Parameters.Add(new MySqlParameter("_birthdate", _birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_age", _age));
                    cmd.Parameters.Add(new MySqlParameter("_place_of_birth", _place_of_birth));
                    cmd.Parameters.Add(new MySqlParameter("_sex", _sex));
                    cmd.Parameters.Add(new MySqlParameter("_civil_status", _civil_status));
                    cmd.Parameters.Add(new MySqlParameter("_religion", _religion));
                    cmd.Parameters.Add(new MySqlParameter("_blood_type", _blood_type));
                    cmd.Parameters.Add(new MySqlParameter("_contact_number", _contact_number));
                    cmd.Parameters.Add(new MySqlParameter("_address_purok", _address_purok));
                    cmd.Parameters.Add(new MySqlParameter("_address_barangay", _address_barangay));
                    cmd.Parameters.Add(new MySqlParameter("_address_mun", _address_mun));
                    cmd.Parameters.Add(new MySqlParameter("_address_province", _address_province));
                    cmd.Parameters.Add(new MySqlParameter("_address_country", _address_country));
                    cmd.Parameters.Add(new MySqlParameter("_address_zip_zode", _address_zip_zode));
                    cmd.Parameters.Add(new MySqlParameter("_educational_attainment", _educational_attainment));
                    cmd.Parameters.Add(new MySqlParameter("_employment_status", _employment_status));
                    cmd.Parameters.Add(new MySqlParameter("_TIN", _TIN));
                    cmd.Parameters.Add(new MySqlParameter("_ph_stat", _ph_stat));
                    cmd.Parameters.Add(new MySqlParameter("_phic_id_no", _phic_id_no));
                    cmd.Parameters.Add(new MySqlParameter("_phic_status_type", _phic_status_type));
                    cmd.Parameters.Add(new MySqlParameter("_is_4p", _is_4p));
                    cmd.Parameters.Add(new MySqlParameter("_4p_id_no", _4p_id_no));
                    cmd.Parameters.Add(new MySqlParameter("_4p_status_type", _4p_status_type));
                    cmd.Parameters.Add(new MySqlParameter("_membership_cat", _membership_cat));
                    cmd.Parameters.Add(new MySqlParameter("_partner_last_name", _partner_last_name));
                    cmd.Parameters.Add(new MySqlParameter("_partner_first_name", _partner_first_name));
                    cmd.Parameters.Add(new MySqlParameter("_partner_name_extension", _partner_name_extension));
                    cmd.Parameters.Add(new MySqlParameter("_partner_middle_name", _partner_middle_name));
                    cmd.Parameters.Add(new MySqlParameter("_partner_birthdate", _partner_birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_partner_sex", _partner_sex));
                    cmd.Parameters.Add(new MySqlParameter("_partner_phic_id", _partner_phic_id));
                    cmd.Parameters.Add(new MySqlParameter("_father_last_name", _father_last_name));
                    cmd.Parameters.Add(new MySqlParameter("_father_first_name", _father_first_name));
                    cmd.Parameters.Add(new MySqlParameter("_father_name_extension", _father_name_extension));
                    cmd.Parameters.Add(new MySqlParameter("_father_middle_name", _father_middle_name));
                    cmd.Parameters.Add(new MySqlParameter("_father_birthdate", _father_birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_father_disability", _father_disability));
                    cmd.Parameters.Add(new MySqlParameter("_father_phic_id", _father_phic_id));
                    cmd.Parameters.Add(new MySqlParameter("_mother_last_name", _mother_last_name));
                    cmd.Parameters.Add(new MySqlParameter("_mother_first_name", _mother_first_name));
                    cmd.Parameters.Add(new MySqlParameter("_mother_name_extension", _mother_name_extension));
                    cmd.Parameters.Add(new MySqlParameter("_mother_middle_name", _mother_middle_name));
                    cmd.Parameters.Add(new MySqlParameter("_mother_birthdate", _mother_birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_mother_disability", _mother_disability));
                    cmd.Parameters.Add(new MySqlParameter("_mother_phic_id", _mother_phic_id));
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
                AddPatientErrorMessage = ex.Message + "\nFunction : Add Patient Record";
            }
        }

        public static string UpdatePatientErrorMessage;
        public static bool UpdatePatientIsSuccessful;
        public static void UpdatePatient(string _last_name, string _first_name, string _name_extension, string _middle_name, string _maiden_last_name, string _maiden_first_name, string _maiden_name_extension, string _maiden_middle_name, string _birthdate, string _age, string _place_of_birth, string _sex, string _civil_status, string _religion, string _blood_type, string _contact_number, string _address_purok, string _address_barangay, string _address_mun, string _address_province, string _address_country, string _address_zip_zode, string _educational_attainment, string _employment_status, string _TIN, string _ph_stat, string _phic_id_no, string _phic_status_type, int _is_4p, string _4p_id_no, string _4p_status_type, string _membership_cat, string _partner_last_name, string _partner_first_name, string _partner_name_extension, string _partner_middle_name, string _partner_birthdate, string _partner_sex, string _partner_phic_id, string _father_last_name, string _father_first_name, string _father_name_extension, string _father_middle_name, string _father_birthdate, string _father_disability, string _father_phic_id, string _mother_last_name, string _mother_first_name, string _mother_name_extension, string _mother_middle_name, string _mother_birthdate, string _mother_disability, string _mother_phic_id, int _purok_family_member_id, int _id)
        {
            DataSet dt = new DataSet();
            _partner_birthdate = _partner_birthdate == "" ? null : _partner_birthdate;
            _father_birthdate = _father_birthdate == "" ? null : _father_birthdate;
            _mother_birthdate = _mother_birthdate == "" ? null : _mother_birthdate;
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_patient_details_edit", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_family_member_id", _purok_family_member_id));
                    cmd.Parameters.Add(new MySqlParameter("_last_name", _last_name));
                    cmd.Parameters.Add(new MySqlParameter("_first_name", _first_name));
                    cmd.Parameters.Add(new MySqlParameter("_name_extension", _name_extension));
                    cmd.Parameters.Add(new MySqlParameter("_middle_name", _middle_name));
                    cmd.Parameters.Add(new MySqlParameter("_maiden_last_name", _maiden_last_name));
                    cmd.Parameters.Add(new MySqlParameter("_maiden_first_name", _maiden_first_name));
                    cmd.Parameters.Add(new MySqlParameter("_maiden_name_extension", _maiden_name_extension));
                    cmd.Parameters.Add(new MySqlParameter("_maiden_middle_name", _maiden_middle_name));
                    cmd.Parameters.Add(new MySqlParameter("_birthdate", _birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_age", _age));
                    cmd.Parameters.Add(new MySqlParameter("_place_of_birth", _place_of_birth));
                    cmd.Parameters.Add(new MySqlParameter("_sex", _sex));
                    cmd.Parameters.Add(new MySqlParameter("_civil_status", _civil_status));
                    cmd.Parameters.Add(new MySqlParameter("_religion", _religion));
                    cmd.Parameters.Add(new MySqlParameter("_blood_type", _blood_type));
                    cmd.Parameters.Add(new MySqlParameter("_contact_number", _contact_number));
                    cmd.Parameters.Add(new MySqlParameter("_address_purok", _address_purok));
                    cmd.Parameters.Add(new MySqlParameter("_address_barangay", _address_barangay));
                    cmd.Parameters.Add(new MySqlParameter("_address_mun", _address_mun));
                    cmd.Parameters.Add(new MySqlParameter("_address_province", _address_province));
                    cmd.Parameters.Add(new MySqlParameter("_address_country", _address_country));
                    cmd.Parameters.Add(new MySqlParameter("_address_zip_zode", _address_zip_zode));
                    cmd.Parameters.Add(new MySqlParameter("_educational_attainment", _educational_attainment));
                    cmd.Parameters.Add(new MySqlParameter("_employment_status", _employment_status));
                    cmd.Parameters.Add(new MySqlParameter("_TIN", _TIN));
                    cmd.Parameters.Add(new MySqlParameter("_ph_stat", _ph_stat));
                    cmd.Parameters.Add(new MySqlParameter("_phic_id_no", _phic_id_no));
                    cmd.Parameters.Add(new MySqlParameter("_phic_status_type", _phic_status_type));
                    cmd.Parameters.Add(new MySqlParameter("_is_4p", _is_4p));
                    cmd.Parameters.Add(new MySqlParameter("_4p_id_no", _4p_id_no));
                    cmd.Parameters.Add(new MySqlParameter("_4p_status_type", _4p_status_type));
                    cmd.Parameters.Add(new MySqlParameter("_membership_cat", _membership_cat));
                    cmd.Parameters.Add(new MySqlParameter("_partner_last_name", _partner_last_name));
                    cmd.Parameters.Add(new MySqlParameter("_partner_first_name", _partner_first_name));
                    cmd.Parameters.Add(new MySqlParameter("_partner_name_extension", _partner_name_extension));
                    cmd.Parameters.Add(new MySqlParameter("_partner_middle_name", _partner_middle_name));
                    cmd.Parameters.Add(new MySqlParameter("_partner_birthdate", _partner_birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_partner_sex", _partner_sex));
                    cmd.Parameters.Add(new MySqlParameter("_partner_phic_id", _partner_phic_id));
                    cmd.Parameters.Add(new MySqlParameter("_father_last_name", _father_last_name));
                    cmd.Parameters.Add(new MySqlParameter("_father_first_name", _father_first_name));
                    cmd.Parameters.Add(new MySqlParameter("_father_name_extension", _father_name_extension));
                    cmd.Parameters.Add(new MySqlParameter("_father_middle_name", _father_middle_name));
                    cmd.Parameters.Add(new MySqlParameter("_father_birthdate", _father_birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_father_disability", _father_disability));
                    cmd.Parameters.Add(new MySqlParameter("_father_phic_id", _father_phic_id));
                    cmd.Parameters.Add(new MySqlParameter("_mother_last_name", _mother_last_name));
                    cmd.Parameters.Add(new MySqlParameter("_mother_first_name", _mother_first_name));
                    cmd.Parameters.Add(new MySqlParameter("_mother_name_extension", _mother_name_extension));
                    cmd.Parameters.Add(new MySqlParameter("_mother_middle_name", _mother_middle_name));
                    cmd.Parameters.Add(new MySqlParameter("_mother_birthdate", _mother_birthdate));
                    cmd.Parameters.Add(new MySqlParameter("_mother_disability", _mother_disability));
                    cmd.Parameters.Add(new MySqlParameter("_mother_phic_id", _mother_phic_id));
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    UpdatePatientIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                UpdatePatientIsSuccessful = false;
                UpdatePatientErrorMessage = ex.Message + "\nFunction : Update Patient Record";
            }
        }

        public static string AddPatientHistoryErrorMessage;
        public static bool AddPatientHistoryIsSuccessful;
        public static void AddPatientHistory(int _patient_details_id, string _weight, string _height, string _pr, string _rr, string _temp, string _bp, string _remarks) 
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_patient_details_history_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_patient_details_id", _patient_details_id));
                    cmd.Parameters.Add(new MySqlParameter("_weight", _weight));
                    cmd.Parameters.Add(new MySqlParameter("_height", _height));
                    cmd.Parameters.Add(new MySqlParameter("_pr", _pr));
                    cmd.Parameters.Add(new MySqlParameter("_rr", _rr));
                    cmd.Parameters.Add(new MySqlParameter("_temp", _temp));
                    cmd.Parameters.Add(new MySqlParameter("_bp", _bp));
                    cmd.Parameters.Add(new MySqlParameter("_remarks", _remarks));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    AddPatientHistoryIsSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                AddPatientHistoryIsSuccessful = false;
                AddPatientHistoryErrorMessage = ex.Message + "\nFunction : Add Patient History";
            }
        }

        public static string GetPatientHistoryErrorMessage;
        public static bool GetPatientHistoryIsSuccessful;
        public static DataTable GetPatientHistory(int _patient_details_id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_patient_details_history_get", con);
                    cmd.Parameters.Add(new MySqlParameter("_patient_details_id", _patient_details_id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetPatientHistoryIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                GetPatientHistoryIsSuccessful = false;
                GetPatientHistoryErrorMessage = ex.Message + "\nFunction : Get Patient History";
                return null;
            }
        }
    }
}
