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

        private string Checklist = "";

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
            Checklist = "";
            CheckedListBoxControl checkedListBoxControl = this.clbChecklist;
            foreach (var checkedItem in checkedListBoxControl.CheckedItems)
            {
                Checklist = Checklist + checkedItem.ToString() + ",";
            }
            if (Checklist.Length > 0)
                Checklist = Checklist.Remove(Checklist.Length - 1);
            if (!bwAddRecord.IsBusy)
            {
                ShowLoading("Adding Record...");
                bwAddRecord.RunWorkerAsync();
            }
        }

        private void bwAddRecord_DoWork(object sender, DoWorkEventArgs e)
        {
            MaternalHealth.AddMaternalHealthRecord(txtName.Text,txtAge.Text,dtDob.Text,txtHeight.Text,txtHusbandName.Text,txtOccupation.Text,txtAddress.Text,txtContactNo.Text,
txtbornalive.Text, txtliving.Text, txtAbortion.Text, txtFetalDeaths.Text, txtLastDelivery.Text, txtLargeBabies.Text, txtDiabetes.Text, txtPrevIllness.Text, txtAllergy.Text, txtPrevHosp.Text, txtGravida.Text, txtPara.Text, txtA.Text, txtStillBirth.Text, txtLMP.Text, txtEDC.Text, txtWhereDel.Text, txtAttended.Text, txtScreeningPlan.Text, txtRiskCodes.Text, dtTT1.Text, dtTT2.Text, dtTT3.Text, dtTT4.Text, dtTT5.Text, txtUrinalysis.Text, txtHbsAntigen.Text, txtCBC.Text, txtRPR.Text, txtBloodTyping.Text, txtHIV.Text, txtComplications.Text, Checklist, dtVitA.Text, txtVitADescribed.Text, dtIronFolic4.Text, dtIronFolic5.Text, dtIronFolic6.Text, dtIronFolic7.Text, dtIronFolic8.Text, dtIronFolic9.Text);
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