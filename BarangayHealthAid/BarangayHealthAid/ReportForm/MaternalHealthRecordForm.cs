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
    public partial class MaternalHealthRecordForm : DevExpress.XtraEditors.XtraForm
    {
        public MaternalHealthRecordForm()
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
                if (!gvMaternal.IsGroupRow(gvMaternal.FocusedRowHandle))
                {
                    if (gvMaternal.SelectedRowsCount > 0)
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

        DataTable MaternalHealthTable = new DataTable();
        private void MaternalHealthRecordForm_Load(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
        }

        private void MaternalHealthRecordForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (bwGetMaternalRecord.IsBusy)
            {
                ShowLoading("Loading Data...");
                bwGetMaternalRecord.RunWorkerAsync();
            }
        }

        private void bwGetMaternalRecord_DoWork(object sender, DoWorkEventArgs e)
        {
            MaternalHealthTable = MaternalHealth.GetMaternalHealthRecord();
            bwGetMaternalRecord.CancelAsync();
        }

        private void bwGetMaternalRecord_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (MaternalHealth.GetMaternalHealthRecordIsSuccessful)
            {
                if (MaternalHealthTable.Rows.Count > 0)
                    dtMaternal.DataSource = MaternalHealthTable;
                else
                {
                    MsgBox.Warning("No data found.");
                    dtMaternal.DataSource = new DataTable();
                }
            }
            else
                MsgBox.Error(MaternalHealth.GetMaternalHealthRecordErrorMessage);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MaternalHealthRecord mhr = new MaternalHealthRecord();
            mhr.ShowPreviewDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaternalHealthRecordAddForm mhr = new MaternalHealthRecordAddForm();
            mhr.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}