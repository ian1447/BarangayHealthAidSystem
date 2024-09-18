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
    public partial class OutPatientForm : DevExpress.XtraEditors.XtraForm
    {
        public OutPatientForm()
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
                if (!gvOutPatient.IsGroupRow(gvOutPatient.FocusedRowHandle))
                {
                    if (gvOutPatient.SelectedRowsCount > 0)
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

        DataTable OutPatientTable = new DataTable();
        private void OutPatientForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetOutPatientData.IsBusy)
            {
                ShowLoading("Loading data...");
                bwGetOutPatientData.RunWorkerAsync();
            }
        }

        private void bwGetOutPatientData_DoWork(object sender, DoWorkEventArgs e)
        {
            OutPatientTable = OPT.GetOutPatientRecords();
            bwGetOutPatientData.CancelAsync();
        }

        private void bwGetOutPatientData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (OPT.GetOutPatientRecordsIsSuccessful)
            {
                if (OutPatientTable.Rows.Count > 0)
                {
                    dtOutPatient.DataSource = OutPatientTable;
                }
                else
                    MsgBox.Error("No Data Available.");
            }
            else
                MsgBox.Error(OPT.GetOutPatientRecordsErrorMessage);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OutPatientReportForm opr = new OutPatientReportForm();
            opr.DataSource = OutPatientTable;
            opr.DataMember = "CustomeSqlQuery";
            opr.ShowPreviewDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OutPatientAddForm opa = new OutPatientAddForm();
            opa.ShowDialog();
        }
    }
}