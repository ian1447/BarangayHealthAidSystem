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
    public partial class PatientHistoricalRecordForm : DevExpress.XtraEditors.XtraForm
    {
        public PatientHistoricalRecordForm()
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
        DataTable PatientHistory = new DataTable();
        private void PatientHistoricalRecordForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetPatientHistory.IsBusy)
            {
                ShowLoading("Loading History...");
                bwGetPatientHistory.RunWorkerAsync();
            }
        }

        private void bwGetPatientHistory_DoWork(object sender, DoWorkEventArgs e)
        {
            PatientHistory = PatientRecord.GetPatientHistory(patient_id);
            bwGetPatientHistory.CancelAsync();
        }

        private void bwGetPatientHistory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (PatientRecord.GetPatientHistoryIsSuccessful)
            {
                dtClinicalHistory.DataSource = PatientHistory.Rows.Count > 0 ? PatientHistory : new DataTable();
            }
            else
                MsgBox.Error(PatientRecord.GetPatientHistoryErrorMessage);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClinicalRecordAddHistoryForm crah = new ClinicalRecordAddHistoryForm();
            crah.patient_id = patient_id;
            crah.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}