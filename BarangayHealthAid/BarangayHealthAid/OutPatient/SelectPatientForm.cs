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

namespace BarangayHealthAid.OutPatient
{
    public partial class SelectPatientForm : DevExpress.XtraEditors.XtraForm
    {
        public SelectPatientForm()
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

        private bool SelectionPass()
        {
            try
            {
                if (!gvPatients.IsGroupRow(gvPatients.FocusedRowHandle))
                {
                    if (gvPatients.SelectedRowsCount > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch { return false; }
        }

        public int patient_id;
        public string patient_type, patient_name, patient_weight;
        DataTable patientsTable = new DataTable();
        private void SelectPatientForm_Load(object sender, EventArgs e)
        {
            lblType.Text = "Type: " + patient_type; 
        }

        private void SelectPatientForm_Shown(object sender, EventArgs e)
        {
            if (patient_type == "Maternal")
            {
                if (!bwGetMaternalRecord.IsBusy)
                {
                    ShowLoading("Loading Patients...");
                    bwGetMaternalRecord.RunWorkerAsync();
                }
            }
        }

        private void bwGetMaternalRecord_DoWork(object sender, DoWorkEventArgs e)
        {
            patientsTable = MaternalHealth.GetMaternalHealthRecord();
            bwGetMaternalRecord.CancelAsync();
        }

        private void bwGetMaternalRecord_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (MaternalHealth.GetMaternalHealthRecordIsSuccessful)
            {
                dtPatients.DataSource = patientsTable.Rows.Count > 0 ? patientsTable : new DataTable();
            }
            else
                MsgBox.Error(MaternalHealth.GetMaternalHealthRecordErrorMessage);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                patient_id = Convert.ToInt32(gvPatients.GetFocusedRowCellValue("id").ToString());
                patient_name = gvPatients.GetFocusedRowCellValue("name").ToString();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}