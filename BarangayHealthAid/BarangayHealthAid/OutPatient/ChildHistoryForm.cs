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
using DevExpress.XtraGrid.Columns;

namespace BarangayHealthAid.OutPatient
{
    public partial class ChildHistoryForm : DevExpress.XtraEditors.XtraForm
    {
        public ChildHistoryForm()
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

        public int selected_id;
        DataTable ChildHistory = new DataTable();
        private void ChildHistoryForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetChildHistory.IsBusy)
            {
                ShowLoading("Loading Data...");
                bwGetChildHistory.RunWorkerAsync();
            }
        }

        private void bwGetChildHistory_DoWork(object sender, DoWorkEventArgs e)
        {
            ChildHistory = OPT.ChildGetHistory(cmbCategory.Text == "Vitamins" ? 0 : 1, ceShowHistory.Checked ? 1 : 0);
            bwGetChildHistory.CancelAsync();
        }

        private void bwGetChildHistory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (OPT.ChildGetHistoryIsSuccessful)
            {
                dtOutPatientHistory.DataSource = ChildHistory.Rows.Count > 0 ? ChildHistory :new DataTable();
            }
            else
                MsgBox.Error(OPT.ChildGetHistoryErrorMessage);
        }

        private void btnAddHistory_Click(object sender, EventArgs e)
        {
            ChildHistoryAddForm cha = new ChildHistoryAddForm();
            cha.selected_id = selected_id;
            cha.mode_type = cmbCategory.Text == "Vitamins" ? 0 : 1;
            cha.lblType.Text = cmbCategory.Text == "Vitamins" ? "Type: Vitamins" : "Type: Deworming";
            cha.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ceShowHistory_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}