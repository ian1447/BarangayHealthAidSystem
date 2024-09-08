using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors;
using BarangayHealthAid.Core;
using BarangayHealthAid.Dal;

namespace BarangayHealthAid.ReportForm
{
    public partial class MaternalHealthRecordAddForm : DevExpress.XtraEditors.XtraForm
    {
        public MaternalHealthRecordAddForm()
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

        private void MaternalHealthRecordAddForm_Load(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MsgBox.QuestionYesNo("Are you sure you want to cancel creation of record?\nDetails inputed will not be saved.");
            if (MsgBox.isYes)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!bwAddRecord.IsBusy)
            {
                ShowLoading("Adding Record...");
                bwAddRecord.RunWorkerAsync();
            }
        }

        private void bwAddRecord_DoWork(object sender, DoWorkEventArgs e)
        {
            MaternalHealth.AddMaternalHealthRecord("asdf", "1999-05-28");
            bwAddRecord.CancelAsync();
        }

        private void bwAddRecord_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (MaternalHealth.AddMaternalHealthRecordIsSuccessful)
            {
                MsgBox.Information("Saving complete.");
                this.Close();
            }
            else
                MsgBox.Error(MaternalHealth.AddMaternalHealthRecordErrorMessage);
        }
    }
}