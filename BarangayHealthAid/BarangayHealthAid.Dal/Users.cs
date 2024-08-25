using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarangayHealthAid.Core;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace BarangayHealthAid.Dal
{
    public class Users
    {
        private static string ConnectionString()
        {
            return PublicVariables.ConnectionString;
        }

        public static string GetUsersErrorMessage;
        public static bool GetUsersIsSuccessful;
        public static DataTable GetUsers()
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_get_users", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetUsersIsSuccessful = true;
                    return dt.Tables[0];
                }
            }

            catch (Exception ex)
            {
                GetUsersIsSuccessful = false;
                GetUsersErrorMessage = ex.Message + "\nFunction : Get Users";
                return null;
            }
        }


        public static string AddUserErrorMessage;
        public static bool AddUserIsSuccessful;
        public static void AddUser(string _username, string _password, string _firstname, string _middlename, string _lastname) 
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_users_add", con);
                    cmd.Parameters.Add(new MySqlParameter("_username", _username));
                    cmd.Parameters.Add(new MySqlParameter("_password", _password));
                    cmd.Parameters.Add(new MySqlParameter("_firstname", _firstname));
                    cmd.Parameters.Add(new MySqlParameter("_middlename", _middlename));
                    cmd.Parameters.Add(new MySqlParameter("_lastname", _lastname));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    AddUserIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                AddUserIsSuccessful = false;
                AddUserErrorMessage = ex.Message + "\nFunction : Add User";
            }
        }

        public static string EditUserErrorMessage;
        public static bool EditUserIsSuccessful;
        public static void EditUser(string _username, string _password, string _firstname, string _middlename, string _lastname, int _id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_users_edit", con);
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.Parameters.Add(new MySqlParameter("_username", _username));
                    cmd.Parameters.Add(new MySqlParameter("_password", _password));
                    cmd.Parameters.Add(new MySqlParameter("_firstname", _firstname));
                    cmd.Parameters.Add(new MySqlParameter("_middlename", _middlename));
                    cmd.Parameters.Add(new MySqlParameter("_lastname", _lastname));
                    cmd.Parameters.Add(new MySqlParameter("_added_by", PublicVariables.Userid));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    EditUserIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                EditUserIsSuccessful = false;
                EditUserErrorMessage = ex.Message + "\nFunction : Edit User";
            }
        }


        public static string DeactivateUserErrorMessage;
        public static bool DeactivateUserIsSuccessful;
        public static void DeactivateUser(int _id)
        {
            DataSet dt = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_users_deactivate", con);
                    cmd.Parameters.Add(new MySqlParameter("_id", _id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    DeactivateUserIsSuccessful = true;
                }
            }

            catch (Exception ex)
            {
                DeactivateUserIsSuccessful = false;
                DeactivateUserErrorMessage = ex.Message + "\nFunction : Deactivate User";
            }
        }
    }
}
