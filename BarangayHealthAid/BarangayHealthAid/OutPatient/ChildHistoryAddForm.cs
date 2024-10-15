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
    public partial class ChildHistoryAddForm : DevExpress.XtraEditors.XtraForm
    {
        public ChildHistoryAddForm()
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

        public int mode_type, selected_id;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (meRemarks.Text != "")
            {
                if (!bwAddChildHistory.IsBusy)
                {
                    ShowLoading("Saving...");
                    bwAddChildHistory.RunWorkerAsync();
                }
            }
        }

        private void bwAddChildHistory_DoWork(object sender, DoWorkEventArgs e)
        {
            OPT.ChildAddHistory(selected_id,meRemarks.Text,mode_type);
            bwAddChildHistory.CancelAsync();
        }

        private void bwAddChildHistory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (OPT.ChildAddHistoryIsSuccessful)
            {
                MsgBox.Information("Added successfully.");
                this.Close();
            }
            else
                MsgBox.Error(OPT.ChildAddHistoryErrorMessage);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}