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

namespace BarangayHealthAid.OutPatient
{
    public partial class OutPatientAddForm : DevExpress.XtraEditors.XtraForm
    {
        public OutPatientAddForm()
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

        public bool isAdd = true;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MsgBox.QuestionYesNo("Are you sure you want to close this form?\nDetails won't be saved as drafts.");
            if (MsgBox.isYes)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAge.Text == "" || txtChildName.Text == "" || txtHeight.Text == "" || txtNutStat.Text == "" || txtPurok.Text == "" || txtWeight.Text == "" || dtDob.Text == "")
                MsgBox.Warning("Please Fill up Form.");
            else
            {
                if (isAdd)
                {
                    if (!bwAddOutPatient.IsBusy)
                    {
                        ShowLoading("Adding Data...");
                        bwAddOutPatient.RunWorkerAsync();
                    }
                }
            }
        }

        private void bwAddOutPatient_DoWork(object sender, DoWorkEventArgs e)
        {
            OPT.OutPatientAdd(txtPurok.Text, txtChildName.Text,dtDob.Text,txtAge.Text,txtHeight.Text,txtWeight.Text,txtNutStat.Text);
            bwAddOutPatient.CancelAsync();
        }

        private void bwAddOutPatient_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (OPT.OutPatientAddIsSuccessful)
            {
                MsgBox.Information("Adding Completed...");
                this.Close();
            }
            else
                MsgBox.Error(OPT.GetOutPatientRecordsErrorMessage);
        }
    }
}