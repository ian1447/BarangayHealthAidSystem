using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using BarangayHealthAid.Core;
using BarangayHealthAid.Dal;

namespace BarangayHealthAid.ReportForm
{
    public partial class MaternalHealthRecordAddHistoryForm : DevExpress.XtraEditors.XtraForm
    {
        public MaternalHealthRecordAddHistoryForm()
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

        public int maternal_health_id;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                if (!bwAddMaternalHistory.IsBusy)
                {
                    ShowLoading("Adding History...");
                    bwAddMaternalHistory.RunWorkerAsync();
                }
            }
            else
                MsgBox.Warning("Please fill up form.");
        }

        private bool CheckValidate()
        {
            foreach (BaseLayoutItem item in layoutControl1.Items)
            {
                LayoutControlItem layoutControlItem = item as LayoutControlItem;
                if (layoutControlItem != null)
                {
                    BaseEdit component = layoutControlItem.Control as BaseEdit;
                    if (component != null)
                    {
                        if (string.IsNullOrEmpty(component.Text.ToString()))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void bwAddMaternalHistory_DoWork(object sender, DoWorkEventArgs e)
        {
            MaternalHealth.AddMaternalHealthRecordHistory(maternal_health_id, txtAog.Text, txtWeight.Text, txtbp.Text, txtfh.Text, txtfhb.Text, txtFetus.Text, txtFindings.Text, meNotes.Text);
            bwAddMaternalHistory.CancelAsync();
        }

        private void bwAddMaternalHistory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (MaternalHealth.AddMaternalHealthRecordHistoryIsSuccessful)
            {
                MsgBox.Information("Adding history successful.");
                this.Close();
            }
            else
                MsgBox.Error(MaternalHealth.AddMaternalHealthRecordHistoryErrorMessage);
        }


    }
}