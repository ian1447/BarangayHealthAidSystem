﻿using System;
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
using DevExpress.XtraLayout;

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
            if (rgType.SelectedIndex == 1)
            {
                rgSub.Enabled = true;
            }
            else
            {
                rgSub.Enabled = false;
                rgSub.SelectedIndex = -1;
            }

            if (rgType.SelectedIndex == 0)
            {
                rgFpReason.Enabled = true;
            }
            else
            {
                rgFpReason.Enabled = false;
                rgFpReason.SelectedIndex = -1;
            }
        }

        private void rgFpReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgFpReason.SelectedIndex == 2)
            {
                txtOthers.Enabled = true;
            }
            else
            {
                txtOthers.Enabled = false;
                txtOthers.Text = "";
            }
        }

        private void rgCMReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgCMReason.SelectedIndex == 1)
            {
                txtChangeMethodOthers.Enabled = true;
            }
            else
            {
                txtChangeMethodOthers.Enabled = false;
                txtChangeMethodOthers.Text = "";
            }
        }

        private void rgSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgSub.SelectedIndex == 0)
            {
                rgCMReason.Enabled = true;
            }
            else
            {
                rgCMReason.Enabled = false;
                rgCMReason.SelectedIndex = -1;
            }
            if (rgSub.SelectedIndex == 0)
            {
                rgCurMeth.Enabled = true;
            }
            else
            {
                rgCurMeth.Enabled = false; 
                rgCurMeth.SelectedIndex = -1;
            }
        }

        private void rgCurMeth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgCurMeth.SelectedIndex == 12)
            {
                txtCurMeth.Enabled = true;
            }
            else
            {
                txtCurMeth.Enabled = false;
                txtCurMeth.Text = "";
            }
        }

        //private void rgCurMeth_EnabledChanged(object sender, EventArgs e)
        //{
        //    if (!rgCurMeth.Enabled)
        //        rgCurMeth.SelectedIndex = -1;
        //}

        private void cbReferredTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtReferOthers.Enabled = cbReferredTo.Text == "Others" ? true : false;
        }

        private void clbPelvicExamination_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.State == CheckState.Checked)
            {
                for (int i = 0; i < clbPelvicExamination.Items.Count; i++)
                {
                    if (i != e.Index) // Uncheck all other items
                    {
                        clbPelvicExamination.SetItemChecked(i, false);
                    }
                }
            }
            var selectedItems = clbPelvicExamination.CheckedItems
            .Cast<CheckedListBoxItem>()
            .Select(item => item.Value.ToString())
            .ToArray();
            lciabnormalities.Visibility = selectedItems.Contains("4") ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            cbCervicalAbno.Text = selectedItems.Contains("4") ? cbCervicalAbno.Text : "";
            lciconsistency.Visibility = selectedItems.Contains("5") ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            cbCervicalConsis.Text = selectedItems.Contains("5") ? cbCervicalConsis.Text : "";
            lciposition.Visibility = selectedItems.Contains("8") ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            cbUterinePos.Text = selectedItems.Contains("8") ? cbUterinePos.Text : "";
            lcidepth.Visibility = selectedItems.Contains("9") ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            txtUterineDepth.Text = selectedItems.Contains("9") ? txtUterineDepth.Text : "0.00";
        }

        private void cedischange_CheckedChanged(object sender, EventArgs e)
        {
            cbGenitalDischarge.Enabled = cedischange.Checked;
        }
      
        #endregion

        public bool is_view = false;
        public bool is_add = true;
        public int edit_id;
        private string menstual_flow, plan_more_chil, _dysmenorrhea, _hydatidiform_mole, _ectopitic_pregnancy, sexually_transmitted, referred_to, depth;
        private string fpReason, concatenatedString, VawString, PelvicExam;
        private void btnSave_Click(object sender, EventArgs e)
        {
            menstual_flow = cbFlow.Text.ToString() == "scanty (1-2 pads per day)" ? "Scanty" : cbFlow.Text.ToString() == "moderate(3-5 pads per day)" ? "moderate" : "heavy";
            plan_more_chil = cePlanMoreChildren.Checked ? "1" : "0";
            _dysmenorrhea = ceDysmen.Checked ? "1" : "0";
            _hydatidiform_mole = ceHydatid.Checked ? "1" : "0";
            _ectopitic_pregnancy = ceEctopic.Checked ? "1" : "0";
            sexually_transmitted = cedischange.Checked ? "1" : "0";
            sexually_transmitted = sexually_transmitted + "," + (ceulcers.Checked ? "1" : "0");
            sexually_transmitted = sexually_transmitted + "," + (cePain.Checked ? "1" : "0");
            sexually_transmitted = sexually_transmitted + "," + (ceInfections.Checked ? "1" : "0");
            sexually_transmitted = sexually_transmitted + "," + (ceHIV.Checked ? "1" : "0");
            referred_to = cbReferredTo.Text == "Others" ? txtReferOthers.Text : cbReferredTo.Text;
            depth = txtUterineDepth.Text == "" ? "0.00" : txtUterineDepth.Text;
            fpReason = rgFpReason.Text;

            List<string> checkedItemsValues = new List<string>();

            foreach (int index in clbMedHistory.CheckedIndices)
            {
                object value = clbMedHistory.GetItemValue(index);
                checkedItemsValues.Add(value != null ? value.ToString() : string.Empty);
            }

            concatenatedString = string.Join("$", checkedItemsValues.ToArray());

            List<string> checkedItemsVAW = new List<string>();

            foreach (int index in clbVAW.CheckedIndices)
            {
                object value = clbVAW.GetItemValue(index);
                checkedItemsVAW.Add(value != null ? value.ToString() : string.Empty);
            }

            VawString = string.Join(",", checkedItemsVAW.ToArray());

            //List<string> checkedItemsPelvicExamination = new List<string>();

            //foreach (int index in clbVAW.CheckedIndices)
            //{
            //    object value = clbVAW.GetItemValue(index);
            //    checkedItemsVAW.Add(value != null ? value.ToString() : string.Empty);
            //}

            //VawString = string.Join(",", checkedItemsVAW.ToArray());

            if (is_add)
            {
                if (!bwAddRecord.IsBusy)
                {
                    ShowLoading("Adding Record...");
                    bwAddRecord.RunWorkerAsync();
                }
            }
            else
            {
                if (!bwUpdateRecord.IsBusy)
                {
                    ShowLoading("Updating Record...");
                    bwUpdateRecord.RunWorkerAsync();
                }
            }
        }

        private void bwAddRecord_DoWork(object sender, DoWorkEventArgs e)
        {
            FamilyPlanning.AddFamilyPlanningRecord(_purok_family_member_id, txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text, dtDob.Text, txtAge.Text, txtEducAttain.Text, txtOccup.Text, txtAddressNo.Text, txtAddressSt.Text, txtAddressBarangay.Text, txtAddressMun.Text, txtAddressProvince.Text, txtContactNo.Text, txtCivilStatus.Text, txtReligion.Text, txtSpouseLastName.Text, txtSpouseFirstName.Text, txtSpouseMiddle.Text, dtSpouseDob.Text, txtSpouseAge.Text, txtSpouseOccupation.Text, txtLivingChil.Text, plan_more_chil, txtMonthlyIncome.Text, rgType.Text, fpReason, txtOthers.Text, rgSub.Text, rgCMReason.Text, txtChangeMethodOthers.Text, rgCurMeth.Text, txtCurMeth.Text, concatenatedString, txtMedOthers.Text, txtG.Text, txtP.Text, txtFullterm.Text, txtAbortion.Text, txtPremature.Text, txtLivingChildren.Text, dtLastdel.Text, cbLastDel.Text, dtLastmens.Text, dtPrevMens.Text, menstual_flow, _dysmenorrhea, _hydatidiform_mole, _ectopitic_pregnancy, sexually_transmitted, cbGenitalDischarge.Text, VawString, cbReferredTo.Text, txtWeight.Text, txtheight.Text, txtBp.Text, txtPulseRate.Text, cbSkin.Text, cbConjunctiva.Text, cbNeck.Text, cbBreast.Text, cbAbdomen.Text, cbExtremites.Text, clbPelvicExamination.Text, cbCervicalAbno.Text, cbCervicalConsis.Text, cbUterinePos.Text, depth);
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

        private void FamilyPlanningAddForm_Load(object sender, EventArgs e)
        {
            if (is_view)
            {
                foreach (BaseLayoutItem item in layoutControl1.Items)
                {
                    LayoutControlItem layoutControlItem = item as LayoutControlItem;
                    if (layoutControlItem != null)
                    {
                        BaseEdit component = layoutControlItem.Control as BaseEdit;
                        if (component != null)
                        {
                            component.Properties.ReadOnly = true;
                        }
                    }
                }
                btnSave.Enabled = false;
                lciSave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                btnCancel.Text = "Close";
            }
        }

        private void bwUpdateRecord_DoWork(object sender, DoWorkEventArgs e)
        {
            FamilyPlanning.UpdateFamilyPlanningRecord(_purok_family_member_id, txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text, dtDob.Text, txtAge.Text, txtEducAttain.Text, txtOccup.Text, txtAddressNo.Text, txtAddressSt.Text, txtAddressBarangay.Text, txtAddressMun.Text, txtAddressProvince.Text, txtContactNo.Text, txtCivilStatus.Text, txtReligion.Text, txtSpouseLastName.Text, txtSpouseFirstName.Text, txtSpouseMiddle.Text, dtSpouseDob.Text, txtSpouseAge.Text, txtSpouseOccupation.Text, txtLivingChil.Text, plan_more_chil, txtMonthlyIncome.Text, rgType.Text, fpReason, txtOthers.Text, rgSub.Text, rgCMReason.Text, txtChangeMethodOthers.Text, rgCurMeth.Text, txtCurMeth.Text, concatenatedString, txtMedOthers.Text, txtG.Text, txtP.Text, txtFullterm.Text, txtAbortion.Text, txtPremature.Text, txtLivingChildren.Text, dtLastdel.Text, cbLastDel.Text, dtLastmens.Text, dtPrevMens.Text, menstual_flow, _dysmenorrhea, _hydatidiform_mole, _ectopitic_pregnancy, sexually_transmitted, cbGenitalDischarge.Text, VawString, cbReferredTo.Text, txtWeight.Text, txtheight.Text, txtBp.Text, txtPulseRate.Text, cbSkin.Text, cbConjunctiva.Text, cbNeck.Text, cbBreast.Text, cbAbdomen.Text, cbExtremites.Text, clbPelvicExamination.Text, cbCervicalAbno.Text, cbCervicalConsis.Text, cbUterinePos.Text, depth, edit_id);
            bwUpdateRecord.CancelAsync();

        }

        private void bwUpdateRecord_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (FamilyPlanning.UpdateFamilyPlanningRecordIsSuccessful)
            {
                MsgBox.Information("Record Updated Successfully.");
                this.Close();
            }
            else
                MsgBox.Error(FamilyPlanning.UpdateFamilyPlanningRecordErrorMessage);
        }

        DataRow[] filtered;
        private int _purok_family_member_id;
        private void txtLastName_Click(object sender, EventArgs e)
        {
            if (!is_view)
            {
                SelectPurokFamilyMemberForm spf = new SelectPurokFamilyMemberForm();
                spf.ShowDialog();
                filtered = spf.filtered;
                _purok_family_member_id = spf._purok_family_member_id;
                if (filtered != null && filtered.Count() > 0)
                {
                    txtFirstName.Text = filtered[0]["first_name"].ToString();
                    txtLastName.Text = filtered[0]["last_name"].ToString();
                    txtMiddleInitial.Text = filtered[0]["middle_name"].ToString().Length > 0 ? filtered[0]["middle_name"].ToString().Substring(0, 1) : "";
                    dtDob.EditValue = Convert.ToDateTime(filtered[0]["birthday"].ToString());
                    txtAge.Text = filtered[0]["age"].ToString();
                }
            }
        }

        private void clbMedHistory_Click(object sender, EventArgs e)
        {
            
        }

    }
}