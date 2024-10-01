﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using BarangayHealthAid.Core;
using System.Data;

namespace BarangayHealthAid.Dal
{
    public class Purok
    {
        private static string ConnectionString()
        {
            return PublicVariables.ConnectionString;
        }

        public static string GetPurokErrorMessage;
        public static bool GetPurokIsSuccessful;
        public static DataTable GetPurok()
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_get", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetPurokIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                GetPurokIsSuccessful = false;
                GetPurokErrorMessage = ex.Message + "\nFunction : Get Purok";
                return null;
            }
        }

        public static string GetPurokMembersErrorMessage;
        public static bool GetPurokMembersIsSuccessful;
        public static DataTable GetPurokMembers(int _purok_id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_members_get", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_id", _purok_id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetPurokMembersIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                GetPurokMembersIsSuccessful = false;
                GetPurokMembersErrorMessage = ex.Message + "\nFunction : Get Purok Members";
                return null;
            }
        }

        public static string GetPurokFamilyMembersErrorMessage;
        public static bool GetPurokFamilyMembersIsSuccessful;
        public static DataTable GetPurokFamilyMembers(int _purok_members_id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_family_members_get", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_members_id", _purok_members_id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetPurokFamilyMembersIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                GetPurokFamilyMembersIsSuccessful = false;
                GetPurokFamilyMembersErrorMessage = ex.Message + "\nFunction : Get Purok Family Members";
                return null;
            }
        }

        public static string AddPurokErrorMessage;
        public static bool AddPurokIsSuccessful;
        public static void AddPurok(string _purok_name)
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
                    AddPurokIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                AddPurokIsSuccessful = false;
                AddPurokErrorMessage = ex.Message + "\nFunction : Add Purok";
            }
        }

        public static string AddPurokMemberErrorMessage;
        public static bool AddPurokMemberIsSuccessful;
        public static void AddPurokMember(int _purok_id, string _name)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_members_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_id", _purok_id));
                    cmd.Parameters.Add(new MySqlParameter("_name", _name));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    AddPurokMemberIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                AddPurokMemberIsSuccessful = false;
                AddPurokMemberErrorMessage = ex.Message + "\nFunction : Add Purok Member";
            }
        }

        public static string AddPurokFamilyMemberErrorMessage;
        public static bool AddPurokFamilyMemberIsSuccessful;
        public static void AddPurokFamilyMember(int _purok_members_id, string _name, string _description, string _birthday, string _age, string _sex)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_family_member_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_members_id", _purok_members_id));
                    cmd.Parameters.Add(new MySqlParameter("_name", _name));
                    cmd.Parameters.Add(new MySqlParameter("_description", _description));
                    cmd.Parameters.Add(new MySqlParameter("_birthday", _birthday));
                    cmd.Parameters.Add(new MySqlParameter("_age", _age));
                    cmd.Parameters.Add(new MySqlParameter("_sex", _sex));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    AddPurokFamilyMemberIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                AddPurokFamilyMemberIsSuccessful = false;
                AddPurokFamilyMemberErrorMessage = ex.Message + "\nFunction : Add Purok Family Member";
            }
        }

        public static string EditPurokErrorMessage;
        public static bool EditPurokIsSuccessful;
        public static void EditPurok(string _purok_name, int _id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_edit", con);
                    cmd.Parameters.Add(new MySqlParameter("_purok_name", _purok_name));
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    EditPurokIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                EditPurokIsSuccessful = false;
                EditPurokErrorMessage = ex.Message + "\nFunction : Edit Purok";
            }
        }

        public static string EditPurokMemberErrorMessage;
        public static bool EditPurokMemberIsSuccessful;
        public static void EditPurokMember(int _id, string _name)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_members_edit", con);
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.Parameters.Add(new MySqlParameter("_name", _name));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    EditPurokMemberIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                EditPurokMemberIsSuccessful = false;
                EditPurokMemberErrorMessage = ex.Message + "\nFunction : Edit Purok Member";
            }
        }

        public static string EditPurokFamilyMemberErrorMessage;
        public static bool EditPurokFamilyMemberIsSuccessful;
        public static void EditPurokFamilyMember(int _id, string _name, string _description, string _birthday, string _age, string _sex)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_family_member_edit", con);
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.Parameters.Add(new MySqlParameter("_name", _name));
                    cmd.Parameters.Add(new MySqlParameter("_description", _description));
                    cmd.Parameters.Add(new MySqlParameter("_birthday", _birthday));
                    cmd.Parameters.Add(new MySqlParameter("_age", _age));
                    cmd.Parameters.Add(new MySqlParameter("_sex", _sex));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    EditPurokFamilyMemberIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                EditPurokFamilyMemberIsSuccessful = false;
                EditPurokFamilyMemberErrorMessage = ex.Message + "\nFunction : Edit Purok Family Member";
            }
        }

        public static string DeletePurokErrorMessage;
        public static bool DeletePurokIsSuccessful;
        public static void DeletePurok(int _id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_delete", con);
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    DeletePurokIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                DeletePurokIsSuccessful = false;
                DeletePurokErrorMessage = ex.Message + "\nFunction : Deleting Purok";
            }
        }

        public static string DeletePurokMemberErrorMessage;
        public static bool DeletePurokMemberIsSuccessful;
        public static void DeletePurokMember(int _id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_members_delete", con);
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    DeletePurokMemberIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                DeletePurokMemberIsSuccessful = false;
                DeletePurokMemberErrorMessage = ex.Message + "\nFunction : Deleting Purok Member";
            }
        }

        public static string DeletePurokFamilyMemberErrorMessage;
        public static bool DeletePurokFamilyMemberIsSuccessful;
        public static void DeletePurokFamilyMember(int _id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_purok_family_member_delete", con);
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    DeletePurokFamilyMemberIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                DeletePurokFamilyMemberIsSuccessful = false;
                DeletePurokFamilyMemberErrorMessage = ex.Message + "\nFunction : Deleting Purok Family Member";
            }
        }
    }
}
