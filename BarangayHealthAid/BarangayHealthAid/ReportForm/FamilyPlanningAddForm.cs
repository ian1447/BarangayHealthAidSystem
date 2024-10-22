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
using DevExpress.XtraEditors.Controls;

namespace BarangayHealthAid.ReportForm
{
    public partial class FamilyPlanningAddForm : DevExpress.XtraEditors.XtraForm
    {
        public FamilyPlanningAddForm()
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

        #region subCatOpen/close
        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            rgSub.Enabled = rgType.SelectedIndex == 1 ? true: false;
            rgFpReason.Enabled = rgType.SelectedIndex == 0 ? true : false;
        }

        private void rgFpReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOthers.Enabled = rgFpReason.SelectedIndex == 2 ? true : false;
        }

        private void rgCMReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtChangeMethodOthers.Enabled = rgCMReason.SelectedIndex == 1 ? true : false;
        }

        private void rgSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            rgCMReason.Enabled = rgSub.SelectedIndex == 0 ? true : false;
            rgCurMeth.Enabled = rgSub.SelectedIndex == 0 ? true : false;
        }

        private void rgSub_EnabledChanged(object sender, EventArgs e)
        {
            if (!rgSub.Enabled)
                rgSub.SelectedIndex = -1;
        }

        private void rgFpReason_EnabledChanged(object sender, EventArgs e)
        {
            if (!rgFpReason.Enabled)
                rgFpReason.SelectedIndex = -1;
        }

        private void rgCMReason_EnabledChanged(object sender, EventArgs e)
        {
            if (!rgCMReason.Enabled)
                rgCMReason.SelectedIndex = -1;
        }

        private void txtOthers_EnabledChanged(object sender, EventArgs e)
        {
            if (!txtOthers.Enabled)
                txtOthers.Text = "";
        }

        private void txtChangeMethodOthers_EnabledChanged(object sender, EventArgs e)
        {
            if (!txtChangeMethodOthers.Enabled)
                txtChangeMethodOthers.Text = "";
        }

        private void rgCurMeth_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCurMeth.Enabled = rgCurMeth.SelectedIndex == 12 ? true : false;
        }

        private void txtCurMeth_EnabledChanged(object sender, EventArgs e)
        {
            if (!txtCurMeth.Enabled)
                txtCurMeth.Text = "";
        }

        private void rgCurMeth_EnabledChanged(object sender, EventArgs e)
        {
            if (!rgCurMeth.Enabled)
                rgCurMeth.SelectedIndex = -1;
        }

        private void cbReferredTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtReferOthers.Enabled = cbReferredTo.Text == "Others" ? true : false;
        }

        private void clbPelvicExamination_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            var selectedItems = clbPelvicExamination.CheckedItems
.Cast<CheckedListBoxItem>()
.Select(item => item.Value.ToString())
.ToArray();
            lciabnormalities.Visibility = selectedItems.Contains("4") ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciconsistency.Visibility = selectedItems.Contains("5") ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciposition.Visibility = selectedItems.Contains("8") ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lcidepth.Visibility = selectedItems.Contains("9") ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
      
        #endregion

        public bool is_view = false;
        public bool is_add = true;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (is_add)
            {
                if (!bwAddRecord.IsBusy)
                {
                    ShowLoading("Adding Record...");
                    bwAddRecord.RunWorkerAsync();
                }
            }
        }

        private void bwAddRecord_DoWork(object sender, DoWorkEventArgs e)
        {
            FamilyPlanning.AddFamilyPlanningRecord(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text, dtDob.Text, txtAge.Text, txtEducAttain.Text, txtOccup.Text, txtAddressNo.Text, txtAddressSt.Text, txtAddressBarangay.Text, txtAddressMun.Text, txtAddressProvince.Text, txtContactNo.Text, txtCivilStatus.Text, txtReligion.Text, txtSpouseLastName.Text, txtSpouseFirstName.Text, txtSpouseMiddle.Text, dtSpouseDob.Text, txtSpouseAge.Text, txtSpouseOccupation.Text, txtLivingChil.Text, "1", txtMonthlyIncome.Text, rgType.Text, rgFpReason.Text, txtOthers.Text, rgSub.Text, rgCMReason.Text, txtChangeMethodOthers.Text, rgCurMeth.Text, txtCurMeth.Text, clbMedHistory.Text, txtMedOthers.Text, txtG.Text, txtP.Text, txtFullterm.Text, txtAbortion.Text, txtPremature.Text, txtLivingChildren.Text, dtLastdel.Text, cbLastDel.Text, dtLastmens.Text, dtPrevMens.Text, cbFlow.Text, "1", "1", "1", cedischange.Text,"1", clbVAW.Text, cbReferredTo.Text, txtWeight.Text, txtheight.Text, txtBp.Text, txtPulseRate.Text, cbSkin.Text, cbConjunctiva.Text, cbNeck.Text, cbBreast.Text, cbAbdomen.Text, cbExtremites.Text, clbPelvicExamination.Text, cbCervicalAbno.Text, cbCervicalConsis.Text, cbUterinePos.Text, txtUterineDepth.Text);
            bwAddRecord.CancelAsync();
        }

        private void bwAddRecord_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (FamilyPlanning.AddFamilyPlanningRecordIsSuccessful)
            {
                MsgBox.Information("Adding Record Completed.");
                this.Close();
            }
            else
                MsgBox.Error(FamilyPlanning.AddFamilyPlanningRecordErrorMessage);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!is_view)
            {
                MsgBox.QuestionYesNo("Are you sure you want to cancel creation of Profile?\nDetails inputed will not be saved.");
                if (MsgBox.isYes)
                    this.Close();
            }
            else
                this.Close();
        }
    }
}