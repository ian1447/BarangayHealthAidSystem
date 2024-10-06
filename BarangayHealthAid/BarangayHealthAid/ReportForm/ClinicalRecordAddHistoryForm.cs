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
using BarangayHealthAid.Reports;
using BarangayHealthAid.ReportForm;
using DevExpress.XtraReports.UI;
using System.Globalization;

namespace BarangayHealthAid.ReportForm
{
    public partial class ClinicalRecordAddHistoryForm : DevExpress.XtraEditors.XtraForm
    {
        public ClinicalRecordAddHistoryForm()
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

        public int patient_id;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbp.Text != "" && txtHeight.Text != "" && txtpr.Text != "" && txtrr.Text != "" && txttemp.Text != "" && txtWeight.Text != "" && meRemarks.Text != "")
            {
                if (!bwAddPatientHistory.IsBusy)
                {
                    ShowLoading("Adding Data...");
                    bwAddPatientHistory.RunWorkerAsync();
                }
            }
            else
                MsgBox.Warning("Fill out form.");
        }

        private void bwAddPatientHistory_DoWork(object sender, DoWorkEventArgs e)
        {
            PatientRecord.AddPatientHistory(patient_id, txtWeight.Text, txtHeight.Text, txtpr.Text, txtrr.Text, txttemp.Text, txtbp.Text, meRemarks.Text);
            bwAddPatientHistory.CancelAsync();
        }

        private void bwAddPatientHistory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (PatientRecord.AddPatientHistoryIsSuccessful)
            {
                MsgBox.Information("History Addedd.");
                this.Close();
            }
            else
                MsgBox.Error(PatientRecord.AddPatientHistoryErrorMessage);
        }
    }
}