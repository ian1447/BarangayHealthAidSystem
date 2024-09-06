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

namespace BarangayHealthAid.ReportForm
{
    public partial class PatientRecordForm : DevExpress.XtraEditors.XtraForm
    {
        public PatientRecordForm()
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

        DataTable PatientsRecordTable = new DataTable();
        private int patientid;

        private void PatientRecordForm_Shown(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetPatientData.IsBusy)
            {
                ShowLoading("Loading data...");
                bwGetPatientData.RunWorkerAsync();
            }
        }

        private void bwGetPatientData_DoWork(object sender, DoWorkEventArgs e)
        {
            PatientsRecordTable = PatientRecord.GetPatientDetails();
            bwGetPatientData.CancelAsync();
        }

        private void bwGetPatientData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (PatientRecord.GetPatientDetailsIsSuccessful)
            {
                if (PatientsRecordTable.Rows.Count > 0)
                {
                    dtPatient.DataSource = PatientsRecordTable;
                    patientid = Convert.ToInt32(PatientsRecordTable.Rows[0]["id"].ToString());
                }
                else
                    dtPatient.DataSource = new DataTable();
            }
            else
                MsgBox.Error(PatientRecord.GetPatientDetailsErrorMessage);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PatientClinicalRecord pcr = new PatientClinicalRecord();
            pcr.ShowPreviewDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PatientRecordAddForm pcaf = new PatientRecordAddForm();
            pcaf.ShowDialog();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}