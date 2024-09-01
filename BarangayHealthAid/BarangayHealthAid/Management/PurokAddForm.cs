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

namespace BarangayHealthAid.Management
{
    public partial class PurokAddForm : DevExpress.XtraEditors.XtraForm
    {
        public PurokAddForm()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtPurokName.Text != "")
            {
                if (!bwAddPurok.IsBusy)
                {
                    ShowLoading("Adding Data...");
                    bwAddPurok.RunWorkerAsync();
                }
            }
            else
                MsgBox.Warning("Please enter purok name.");
        }

        private void bwAddPurok_DoWork(object sender, DoWorkEventArgs e)
        {
            Purok.AddPurok(txtPurokName.Text);
            bwAddPurok.CancelAsync();
        }

        private void bwAddPurok_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.AddPurokIsSuccessful)
            {
                MsgBox.Information("Adding Done.");
                this.Close();
            }
            else
                MsgBox.Error(Purok.AddPurokErrorMessage);
        }
    }
}