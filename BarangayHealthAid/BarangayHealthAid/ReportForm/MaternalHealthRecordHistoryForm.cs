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
    public partial class MaternalHealthRecordHistoryForm : DevExpress.XtraEditors.XtraForm
    {
        public MaternalHealthRecordHistoryForm()
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

        public int _maternal_health_id;
        DataTable PatientHistory = new DataTable();

        private void MaternalHealthRecordHistoryForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetMaternalHistory.IsBusy)
            {
                ShowLoading("Loading history...");
                bwGetMaternalHistory.RunWorkerAsync();
            }
        }

        private void bwGetMaternalHistory_DoWork(object sender, DoWorkEventArgs e)
        {
            PatientHistory = MaternalHealth.GetMaternalHealthRecordHistory(_maternal_health_id);
            bwGetMaternalHistory.CancelAsync();
        }

        private void bwGetMaternalHistory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (MaternalHealth.GetMaternalHealthRecordHistoryIsSuccessful)
            {
                dtMaternalHistory.DataSource = PatientHistory.Rows.Count > 0 ? PatientHistory:new DataTable();
            }
            else
                MsgBox.Error(MaternalHealth.GetMaternalHealthRecordHistoryErrorMessage);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaternalHealthRecordAddHistoryForm mhra = new MaternalHealthRecordAddHistoryForm();
            mhra.maternal_health_id = _maternal_health_id;
            mhra.ShowDialog();
            LoadData();
        }

    }
}