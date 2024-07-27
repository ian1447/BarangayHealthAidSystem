using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BarangayHealthAid.Core;
using BarangayHealthAid.Dal;
using BarangayHealthAid.Sop;

namespace BarangayHealthAid
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region UTIL
        bool loadingIsAlreadyShowing = false;
        private void ShowLoading(string message)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                if (!loadingIsAlreadyShowing)
                {
                    loadingIsAlreadyShowing = true;
                    splashScreenManager1.ShowWaitForm();
                }
                splashScreenManager1.SetWaitFormDescription(message);
            }
            catch { }
        }

        private void HideLoading()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }

                loadingIsAlreadyShowing = false;
                splashScreenManager1.CloseWaitForm();
            }
            catch { }
        }

        #endregion

        private void lblConnSettings_Click(object sender, EventArgs e)
        {
            ConnectionSettingsForm csf = new ConnectionSettingsForm();
            csf.ShowDialog();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastLogin))
            {
                ceChange.Checked = false;
                txtUsername.Text = Properties.Settings.Default.LastLogin;
                txtUsername.Enabled = false;
                //Msgbox.Information(Properties.Settings.Default.LastLogin);
            }
            else
                ceChange.Checked = true;
            try
            {
                PublicVariables.ConnectionString = Properties.Settings.Default.ServerConnString.DecryptString();
                PublicVariables.ConnectionString = PublicVariables.ConnectionString + "Allow Zero Datetime=True;";
            }
            catch (Exception ex)
            {
                MsgBox.Error("Error Establishing connection to database!" + ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.Text == "S")
            {
                btnShow.Text = "H";
                txtPassword.Properties.PasswordChar = '\0';
            }
            else
            {
                btnShow.Text = "S";
                txtPassword.Properties.PasswordChar = '*';
            }
        }

        private void ceChange_CheckedChanged(object sender, EventArgs e)
        {
            if (ceChange.Checked == true)
                txtUsername.Enabled = true;
            else
                txtUsername.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginSuccess();
        }

        private void LoginSuccess()
        {
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    if (!bwUsersLogin.IsBusy)
                    {
                        ShowLoading("Logging in...");
                        bwUsersLogin.RunWorkerAsync();
                    }
                }
                else
                {
                    MsgBox.Information("Please enter a password!");
                    txtPassword.Focus();
                }
            }
            else
            {
                MsgBox.Information("Please enter a username!");
                txtUsername.Focus();
            }

        }

        private void bwUsersLogin_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bwUsersLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}