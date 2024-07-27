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
    public partial class ConnectionSettingsForm : DevExpress.XtraEditors.XtraForm
    {
        public ConnectionSettingsForm()
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

        string connstring;

        private void ConnectionSettingsForm_Load(object sender, EventArgs e)
        {
            lblProjectName.Text = PublicVariables.ProjectName + " - " + PublicVariables.ProjectVersion;
        }

        private void btnTestConnectionDG_Click(object sender, EventArgs e)
        {
            connstring = "SERVER = " + txtServerDG.Text + "; DATABASE =" + txtDatabaseDG.Text + "; Uid =" + txtUsernameDG.Text + "; Pwd =" + txtPasswordDG.Text + "; PORT =" + txtPortDG.Text + ";";
            checkConn();
        }

        private void checkConn()
        {
            if (!bwCheckConnection.IsBusy)
            {
                ShowLoading("checking connection...");
                bwCheckConnection.RunWorkerAsync();
            }
        }

        private void bwCheckConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            Login.testconnection(connstring);
            bwCheckConnection.CancelAsync();
        }

        private void bwCheckConnection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Login.ConnectionIsGood)
            {
                lblConnectionStringStatusDG.Text = "Connection is valid";
                lblConnectionStringStatusDG.Visible = true;
                lblConnectionStringStatusDG.ForeColor = Color.Green;

                //buttons
                btnSaveDG.Enabled = true;
            }
            else
            {
                lblConnectionStringStatusDG.Text = "Connection is invalid";
                btnSaveDG.Enabled = false;
                lblConnectionStringStatusDG.ForeColor = Color.IndianRed;
                lblConnectionStringStatusDG.Visible = true;
            }
        }

        private void chkChangeDatabaseDG_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangeDatabaseDG.Checked)
                txtDatabaseDG.Enabled = true;
            else
                txtDatabaseDG.Enabled = false;
        }

        private void btnSaveDG_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerConnString = connstring.EncryptString();
            Properties.Settings.Default.Save();
            MsgBox.Information("Connection saved!");
            Application.Restart();
        }
    }
}