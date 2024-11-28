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
    public partial class FamilyPlanningForm : DevExpress.XtraEditors.XtraForm
    {
        public FamilyPlanningForm()
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
                if (!gvFamilyRecords.IsGroupRow(gvFamilyRecords.FocusedRowHandle))
                {
                    if (gvFamilyRecords.SelectedRowsCount > 0)
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

        DataTable familyRecords = new DataTable();
        private void FamilyPlanningForm_Shown(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetFamilyRecords.IsBusy)
            {
                ShowLoading("Loading data...");
                bwGetFamilyRecords.RunWorkerAsync();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FamilyPlanningAddForm fpa = new FamilyPlanningAddForm();
            fpa.ShowDialog();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                int id = Convert.ToInt32(gvFamilyRecords.GetFocusedRowCellValue("id").ToString());
                DataRow[] filtered = familyRecords.Select(String.Format("id = {0}", id));
                if (filtered.Count() > 0)
                {
                    FamilyPlanningAddForm fpa = new FamilyPlanningAddForm();
                    fpa.edit_id = id;
                    fpa.txtFirstName.Text = filtered[0]["given_name"].ToString();
                    fpa.txtLastName.Text = filtered[0]["last_name"].ToString();
                    fpa.txtMiddleInitial.Text = filtered[0]["middle_initial"].ToString();
                    fpa.dtDob.EditValue = Convert.ToDateTime(filtered[0]["dob"].ToString());
                    fpa.txtAge.Text = filtered[0]["age"].ToString();
                    fpa.txtEducAttain.Text = filtered[0]["educ_attain"].ToString();
                    fpa.txtOccup.Text = filtered[0]["occupation"].ToString();
                    fpa.txtAddressNo.Text = filtered[0]["address_no"].ToString();
                    fpa.txtAddressSt.Text = filtered[0]["address_street"].ToString();
                    fpa.txtAddressBarangay.Text = filtered[0]["address_barangay"].ToString();
                    fpa.txtAddressMun.Text = filtered[0]["address_mun/city"].ToString();
                    fpa.txtAddressProvince.Text = filtered[0]["address_prov"].ToString();
                    fpa.txtContactNo.Text = filtered[0]["contact_number"].ToString();
                    fpa.txtCivilStatus.Text = filtered[0]["civil_status"].ToString();
                    fpa.txtReligion.Text = filtered[0]["religion"].ToString();
                    fpa.txtSpouseLastName.Text = filtered[0]["spouse_last_name"].ToString();
                    fpa.txtSpouseFirstName.Text = filtered[0]["spouse_given_name"].ToString();
                    fpa.txtSpouseMiddle.Text = filtered[0]["spouse_middle_inital"].ToString();
                    fpa.dtSpouseDob.EditValue = Convert.ToDateTime(filtered[0]["spouse_dob"].ToString());
                    fpa.txtSpouseAge.Text = filtered[0]["spouse_age"].ToString();
                    fpa.txtSpouseOccupation.Text = filtered[0]["spouse_occupation"].ToString();
                    fpa.txtLivingChil.Text = filtered[0]["living_children"].ToString();
                    fpa.cePlanMoreChildren.Checked = Convert.ToBoolean(filtered[0]["plan_more_children"].ToString());
                    fpa.txtMonthlyIncome.Text = filtered[0]["average_monthly_income"].ToString();
                    fpa.rgType.SelectedIndex = filtered[0]["type_of_client"].ToString() == "New Acceptor"? 0:1;
                    fpa.rgFpReason.SelectedIndex = filtered[0]["reason_for_FP"].ToString() == "spacing" ? 0 : filtered[0]["reason_for_FP"].ToString() == "limiting" ? 1: filtered[0]["reason_for_FP"].ToString() == "others" ? 2 : -1;
                    fpa.txtOthers.Text = filtered[0]["others"].ToString();
                    fpa.rgSub.SelectedIndex = filtered[0]["current_user_type"].ToString() == "Changing Method" ? 0 : filtered[0]["current_user_type"].ToString() == "Changing Clinic" ? 1 : filtered[0]["current_user_type"].ToString() == "Dropout/Restart" ? 2 : -1;
                    fpa.rgCMReason.SelectedIndex = filtered[0]["changin_method_resaon"].ToString() == "medical condition" ? 0 : filtered[0]["changin_method_resaon"].ToString() == "side effects" ? 1 : -1;
                    fpa.txtChangeMethodOthers.Text = filtered[0]["side_effects"].ToString();
                    switch (filtered[0]["currently_used_changing_methods"].ToString())
                    {
                        case ("COC"):
                            fpa.rgCurMeth.SelectedIndex = 0;
                            break;
                        case ("POP"):
                            fpa.rgCurMeth.SelectedIndex = 1;
                            break;
                        case ("Injectable"):
                            fpa.rgCurMeth.SelectedIndex = 2;
                            break;
                        case ("Implant"):
                            fpa.rgCurMeth.SelectedIndex = 3;
                            break;
                        case ("IUD-Internal"):
                            fpa.rgCurMeth.SelectedIndex = 4;
                            break;
                        case ("IUD-Post-Partum"):
                            fpa.rgCurMeth.SelectedIndex = 5;
                            break;
                        case ("Condom"):
                            fpa.rgCurMeth.SelectedIndex = 6;
                            break;
                        case ("BOM/CMM"):
                            fpa.rgCurMeth.SelectedIndex = 7;
                            break;
                        case ("BBT"):
                            fpa.rgCurMeth.SelectedIndex = 8;
                            break;
                        case ("STM"):
                            fpa.rgCurMeth.SelectedIndex = 9;
                            break;
                        case ("SDM"):
                            fpa.rgCurMeth.SelectedIndex = 10;
                            break;
                        case ("LAM"):
                            fpa.rgCurMeth.SelectedIndex = 11;
                            break;
                        case ("others"):
                            fpa.rgCurMeth.SelectedIndex = 12;
                            break;
                        default:
                            fpa.rgCurMeth.SelectedIndex = -1;
                            break;
                    }
                    fpa.rgCurMeth.Text = filtered[0]["currently_used_changing_methods"].ToString();
                    fpa.txtCurMeth.Text = filtered[0]["changing_method_others"].ToString();
                    string[] medHistArray =  filtered[0]["medical_history"].ToString().Split('$');
                    foreach (string str in medHistArray)
                    {
                        for (int i = 0; i < fpa.clbMedHistory.Items.Count; i++)
                        {
                            if (fpa.clbMedHistory.Items[i].Value.ToString() == str)
                            {
                                fpa.clbMedHistory.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                    fpa.txtMedOthers.Text = filtered[0]["med_history_specify"].ToString();
                    fpa.txtG.Text = filtered[0]["pregnancies_G"].ToString();
                    fpa.txtP.Text = filtered[0]["pregnancies_P"].ToString();
                    fpa.txtFullterm.Text = filtered[0]["pregnancy_full_term"].ToString();
                    fpa.txtAbortion.Text = filtered[0]["pregnancy_abortion"].ToString();
                    fpa.txtPremature.Text = filtered[0]["pregnancy_premature"].ToString();
                    fpa.txtLivingChildren.Text = filtered[0]["pregnancy_living"].ToString();
                    fpa.dtLastdel.EditValue = Convert.ToDateTime(filtered[0]["date_last_delivery"].ToString());
                    fpa.cbLastDel.Text = filtered[0]["type_last_delivery"].ToString();
                    fpa.dtLastmens.EditValue = Convert.ToDateTime(filtered[0]["last_menstrual_period"].ToString());
                    fpa.dtPrevMens.EditValue = Convert.ToDateTime(filtered[0]["previous_mentrual_period"].ToString());
                    fpa.cbFlow.SelectedIndex = filtered[0]["menstrual_flow"].ToString() == "Scanty" ? 0 : filtered[0]["menstrual_flow"].ToString() == "moderate" ? 1 : 2;
                    fpa.ceDysmen.Checked = Convert.ToBoolean(filtered[0]["dysmenorrhea"].ToString());
                    fpa.ceHydatid.Checked = Convert.ToBoolean(filtered[0]["hydatidiform_mole"].ToString());
                    fpa.ceEctopic.Checked = Convert.ToBoolean(filtered[0]["ectopitic_pregnancy"].ToString());
                    string[] risksArray = filtered[0]["sexually_transmitted_infections_risk"].ToString().Split(',');
                    fpa.cedischange.Checked = risksArray[0] == "1" ? true:false;
                    fpa.cbGenitalDischarge.Text = (filtered[0]["genital_area_yes"].ToString());
                    fpa.ceulcers.Checked = risksArray[1] == "1" ? true : false;
                    fpa.cePain.Checked = risksArray[2] == "1" ? true : false;
                    fpa.ceInfections.Checked = risksArray[3] == "1" ? true : false;
                    fpa.ceHIV.Checked = risksArray[4] == "1" ? true : false;

                    string[] VAWArray = filtered[0]["VAW"].ToString().Split(',');
                    foreach (string str in VAWArray)
                    {
                        for (int i = 0; i < fpa.clbVAW.Items.Count; i++)
                        {
                            if (fpa.clbVAW.Items[i].Value.ToString() == str)
                            {
                                fpa.clbVAW.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                    fpa.cbReferredTo.Text = filtered[0]["referred_to"].ToString();
                    fpa.txtReferOthers.Text = filtered[0]["referred_to"].ToString() == "Others" ? filtered[0]["referred_to"].ToString() : "";
                    fpa.txtWeight.Text = filtered[0]["weight"].ToString();
                    fpa.txtheight.Text = filtered[0]["height"].ToString();
                    fpa.txtBp.Text = filtered[0]["bp"].ToString();
                    fpa.txtPulseRate.Text = filtered[0]["pulse_rate"].ToString();
                    fpa.cbSkin.Text = filtered[0]["skin"].ToString();
                    fpa.cbConjunctiva.Text = filtered[0]["conjunctiva"].ToString();
                    fpa.cbNeck.Text = filtered[0]["neck"].ToString();
                    fpa.cbBreast.Text = filtered[0]["breast"].ToString();
                    fpa.cbAbdomen.Text = filtered[0]["abdomen"].ToString();
                    fpa.cbExtremites.Text = filtered[0]["extremities"].ToString();

                    string[] pelvicArray = filtered[0]["pelvic_examination"].ToString().Split(',');
                    foreach (string str in pelvicArray)
                    {
                        for (int i = 0; i < fpa.clbPelvicExamination.Items.Count; i++)
                        {
                            if (fpa.clbPelvicExamination.Items[i].Description.ToString() == str)
                            {
                                fpa.clbPelvicExamination.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                    fpa.cbCervicalAbno.Text = filtered[0]["cervical_abnormalities"].ToString();
                    fpa.cbCervicalConsis.Text = filtered[0]["cervical_consistency"].ToString();
                    fpa.cbUterinePos.Text = filtered[0]["uterine_position"].ToString();
                    fpa.txtUterineDepth.Text = filtered[0]["uterine_depth"].ToString();
                    fpa.is_add = false;
                    fpa.ShowDialog();
                    LoadData();
                }
            }
        }

        private void bwGetFamilyRecords_DoWork(object sender, DoWorkEventArgs e)
        {
            familyRecords = FamilyPlanning.GetFamilyPlanningRecord();
            bwGetFamilyRecords.CancelAsync();
        }

        private void bwGetFamilyRecords_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (FamilyPlanning.GetFamilyPlanningRecordIsSuccessful)
            {
                dtFamilyRecords.DataSource = familyRecords.Rows.Count > 0 ? familyRecords : new DataTable();
            }
            else
                MsgBox.Error(FamilyPlanning.GetFamilyPlanningRecordErrorMessage);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                int id = Convert.ToInt32(gvFamilyRecords.GetFocusedRowCellValue("id").ToString());
                DataRow[] filtered = familyRecords.Select(String.Format("id = {0}", id));
                if (filtered.Count() > 0)
                {
                    FamilyPlanningAddForm fpa = new FamilyPlanningAddForm();
                    fpa.edit_id = id;
                    fpa.txtFirstName.Text = filtered[0]["given_name"].ToString();
                    fpa.txtLastName.Text = filtered[0]["last_name"].ToString();
                    fpa.txtMiddleInitial.Text = filtered[0]["middle_initial"].ToString();
                    fpa.dtDob.EditValue = Convert.ToDateTime(filtered[0]["dob"].ToString());
                    fpa.txtAge.Text = filtered[0]["age"].ToString();
                    fpa.txtEducAttain.Text = filtered[0]["educ_attain"].ToString();
                    fpa.txtOccup.Text = filtered[0]["occupation"].ToString();
                    fpa.txtAddressNo.Text = filtered[0]["address_no"].ToString();
                    fpa.txtAddressSt.Text = filtered[0]["address_street"].ToString();
                    fpa.txtAddressBarangay.Text = filtered[0]["address_barangay"].ToString();
                    fpa.txtAddressMun.Text = filtered[0]["address_mun/city"].ToString();
                    fpa.txtAddressProvince.Text = filtered[0]["address_prov"].ToString();
                    fpa.txtContactNo.Text = filtered[0]["contact_number"].ToString();
                    fpa.txtCivilStatus.Text = filtered[0]["civil_status"].ToString();
                    fpa.txtReligion.Text = filtered[0]["religion"].ToString();
                    fpa.txtSpouseLastName.Text = filtered[0]["spouse_last_name"].ToString();
                    fpa.txtSpouseFirstName.Text = filtered[0]["spouse_given_name"].ToString();
                    fpa.txtSpouseMiddle.Text = filtered[0]["spouse_middle_inital"].ToString();
                    fpa.dtSpouseDob.EditValue = Convert.ToDateTime(filtered[0]["spouse_dob"].ToString());
                    fpa.txtSpouseAge.Text = filtered[0]["spouse_age"].ToString();
                    fpa.txtSpouseOccupation.Text = filtered[0]["spouse_occupation"].ToString();
                    fpa.txtLivingChil.Text = filtered[0]["living_children"].ToString();
                    fpa.cePlanMoreChildren.Checked = Convert.ToBoolean(filtered[0]["plan_more_children"].ToString());
                    fpa.txtMonthlyIncome.Text = filtered[0]["average_monthly_income"].ToString();
                    fpa.rgType.SelectedIndex = filtered[0]["type_of_client"].ToString() == "New Acceptor" ? 0 : 1;
                    fpa.rgFpReason.Text = filtered[0]["reason_for_FP"].ToString();
                    fpa.rgSub.Text = filtered[0]["current_user_type"].ToString();
                    fpa.rgCMReason.Text = filtered[0]["reason_for_FP"].ToString();
                    fpa.txtOthers.Text = filtered[0]["others"].ToString();
                    fpa.txtChangeMethodOthers.Text = filtered[0]["side_effects"].ToString();
                    fpa.rgCurMeth.Text = filtered[0]["currently_used_changing_methods"].ToString();
                    fpa.txtCurMeth.Text = filtered[0]["changing_method_others"].ToString();
                    string[] medHistArray = filtered[0]["medical_history"].ToString().Split('$');
                    foreach (string str in medHistArray)
                    {
                        for (int i = 0; i < fpa.clbMedHistory.Items.Count; i++)
                        {
                            if (fpa.clbMedHistory.Items[i].Value.ToString() == str)
                            {
                                fpa.clbMedHistory.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                    fpa.txtMedOthers.Text = filtered[0]["med_history_specify"].ToString();
                    fpa.txtG.Text = filtered[0]["pregnancies_G"].ToString();
                    fpa.txtP.Text = filtered[0]["pregnancies_P"].ToString();
                    fpa.txtFullterm.Text = filtered[0]["pregnancy_full_term"].ToString();
                    fpa.txtAbortion.Text = filtered[0]["pregnancy_abortion"].ToString();
                    fpa.txtPremature.Text = filtered[0]["pregnancy_premature"].ToString();
                    fpa.txtLivingChildren.Text = filtered[0]["pregnancy_living"].ToString();
                    fpa.dtLastdel.EditValue = Convert.ToDateTime(filtered[0]["date_last_delivery"].ToString());
                    fpa.cbLastDel.Text = filtered[0]["type_last_delivery"].ToString();
                    fpa.dtLastmens.EditValue = Convert.ToDateTime(filtered[0]["last_menstrual_period"].ToString());
                    fpa.dtPrevMens.EditValue = Convert.ToDateTime(filtered[0]["previous_mentrual_period"].ToString());
                    fpa.cbFlow.SelectedIndex = filtered[0]["menstrual_flow"].ToString() == "Scanty" ? 0 : filtered[0]["menstrual_flow"].ToString() == "moderate" ? 1 : 2;
                    fpa.ceDysmen.Checked = Convert.ToBoolean(filtered[0]["dysmenorrhea"].ToString());
                    fpa.ceHydatid.Checked = Convert.ToBoolean(filtered[0]["hydatidiform_mole"].ToString());
                    fpa.ceEctopic.Checked = Convert.ToBoolean(filtered[0]["ectopitic_pregnancy"].ToString());
                    string[] risksArray = filtered[0]["sexually_transmitted_infections_risk"].ToString().Split(',');
                    fpa.cedischange.Checked = risksArray[0] == "1" ? true : false;
                    fpa.cbGenitalDischarge.Text =   (filtered[0]["genital_area_yes"].ToString());
                    fpa.ceulcers.Checked = risksArray[1] == "1" ? true : false;
                    fpa.cePain.Checked = risksArray[2] == "1" ? true : false;
                    fpa.ceInfections.Checked = risksArray[3] == "1" ? true : false;
                    fpa.ceHIV.Checked = risksArray[4] == "1" ? true : false;

                    string[] VAWArray = filtered[0]["VAW"].ToString().Split(',');
                    foreach (string str in VAWArray)
                    {
                        for (int i = 0; i < fpa.clbVAW.Items.Count; i++)
                        {
                            if (fpa.clbVAW.Items[i].Value.ToString() == str)
                            {
                                fpa.clbVAW.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                    fpa.cbReferredTo.Text = filtered[0]["referred_to"].ToString();
                    fpa.txtReferOthers.Text = filtered[0]["referred_to"].ToString() == "Others" ? filtered[0]["referred_to"].ToString() : "";
                    fpa.txtWeight.Text = filtered[0]["weight"].ToString();
                    fpa.txtheight.Text = filtered[0]["height"].ToString();
                    fpa.txtBp.Text = filtered[0]["bp"].ToString();
                    fpa.txtPulseRate.Text = filtered[0]["pulse_rate"].ToString();
                    fpa.cbSkin.Text = filtered[0]["skin"].ToString();
                    fpa.cbConjunctiva.Text = filtered[0]["conjunctiva"].ToString();
                    fpa.cbNeck.Text = filtered[0]["neck"].ToString();
                    fpa.cbBreast.Text = filtered[0]["breast"].ToString();
                    fpa.cbAbdomen.Text = filtered[0]["abdomen"].ToString();
                    fpa.cbExtremites.Text = filtered[0]["extremities"].ToString();

                    string[] pelvicArray = filtered[0]["pelvic_examination"].ToString().Split(',');
                    foreach (string str in pelvicArray)
                    {
                        for (int i = 0; i < fpa.clbPelvicExamination.Items.Count; i++)
                        {
                            if (fpa.clbPelvicExamination.Items[i].Description.ToString() == str)
                            {
                                fpa.clbPelvicExamination.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                    fpa.cbCervicalAbno.Text = filtered[0]["cervical_abnormalities"].ToString();
                    fpa.cbCervicalConsis.Text = filtered[0]["cervical_consistency"].ToString();
                    fpa.cbUterinePos.Text = filtered[0]["uterine_position"].ToString();
                    fpa.txtUterineDepth.Text = filtered[0]["uterine_depth"].ToString();
                    fpa.is_view = true;
                    fpa.ShowDialog();
                    LoadData();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                int id = Convert.ToInt32(gvFamilyRecords.GetFocusedRowCellValue("id").ToString());
                DataRow[] filtered = familyRecords.Select(String.Format("id = {0}", id));
                if (filtered.Count() > 0)
                {
                    FamilyPlanningReportForm fpf = new FamilyPlanningReportForm();
                    fpf.lblLastName.Text = filtered[0]["last_name"].ToString();
                    fpf.lblGivenName.Text = filtered[0]["given_name"].ToString();
                    fpf.lblMiddleInitial.Text = filtered[0]["given_name"].ToString();
                    fpf.lbldob.Text = filtered[0]["dob"].ToString();
                    fpf.lblage.Text = filtered[0]["age"].ToString();
                    fpf.lblEduc.Text = filtered[0]["educ_attain"].ToString();
                    fpf.lblOccup.Text = filtered[0]["occupation"].ToString();
                    fpf.lblAddNo.Text = filtered[0]["address_no"].ToString();
                    fpf.lblAddStr.Text = filtered[0]["address_street"].ToString();
                    fpf.lblAddBar.Text = filtered[0]["address_barangay"].ToString();
                    //fpf.lbladdmu.Text = filtered[0]["address_mun/city"].ToString();
                    fpf.lblAddPro.Text = filtered[0]["address_prov"].ToString();
                    fpf.lblContact.Text = filtered[0]["contact_number"].ToString();
                    fpf.lblCivil.Text = filtered[0]["civil_status"].ToString();
                    fpf.lblReligion.Text = filtered[0]["religion"].ToString();
                    fpf.lblSpouseLast.Text = filtered[0]["spouse_last_name"].ToString();
                    fpf.lblSpouseGiven.Text = filtered[0]["spouse_given_name"].ToString();
                    fpf.lblSpouseMid.Text = filtered[0]["spouse_middle_inital"].ToString();
                    fpf.lblSpouseDob.Text = filtered[0]["spouse_dob"].ToString();
                    fpf.lblSpouseAge.Text = filtered[0]["spouse_age"].ToString();
                    fpf.lblSpouseOcc.Text = filtered[0]["spouse_occupation"].ToString();
                    fpf.lblLiving.Text = filtered[0]["living_children"].ToString();
                    fpf.lblAveIncome.Text = filtered[0]["average_monthly_income"].ToString();
                    fpf.lblG.Text = filtered[0]["pregnancies_G"].ToString();
                    fpf.lblP.Text = filtered[0]["pregnancies_P"].ToString();
                    fpf.lblFull.Text = filtered[0]["pregnancy_full_term"].ToString();
                    fpf.lblAbort.Text = filtered[0]["pregnancy_abortion"].ToString();
                    fpf.lblPre.Text = filtered[0]["pregnancy_premature"].ToString();
                    fpf.lblLivingChildren.Text = filtered[0]["pregnancy_living"].ToString();
                    fpf.lblDateLastDel.Text = filtered[0]["date_last_delivery"].ToString();
                    fpf.lblLastMens.Text = filtered[0]["last_menstrual_period"].ToString();
                    fpf.lblPrevMens.Text = filtered[0]["previous_mentrual_period"].ToString();
                    fpf.lblWeight.Text = filtered[0]["weight"].ToString();
                    fpf.lblHeight.Text = filtered[0]["height"].ToString();
                    fpf.lblBp.Text = filtered[0]["bp"].ToString();
                    fpf.lblPulse.Text = filtered[0]["pulse_rate"].ToString();
                    fpf.lblReasonOthers.Text = filtered[0]["side_effects"].ToString();
                    fpf.cePlanY.Checked = Convert.ToBoolean(filtered[0]["plan_more_children"].ToString());
                    fpf.cePlanN.Checked = !Convert.ToBoolean(filtered[0]["plan_more_children"].ToString());
                    fpf.ceNewAcc.Checked = filtered[0]["type_of_client"].ToString() == "New Acceptor" ? true : false;
                    fpf.ceCurrUser.Checked = filtered[0]["type_of_client"].ToString() == "New Acceptor" ? false : true;
                    fpf.lblFPOthers.Text = filtered[0]["others"].ToString();
                    fpf.ceLimiting.Checked = filtered[0]["reason_for_FP"].ToString() == "limiting" ? true : false;
                    fpf.ceSpacing.Checked = filtered[0]["reason_for_FP"].ToString() == "spacing" ? true : false;
                    fpf.ceOthers.Checked = filtered[0]["reason_for_FP"].ToString() == "others" ? true : false;
                    fpf.ceChaningClinic.Checked = filtered[0]["current_user_type"].ToString() == "Changing Clinic" ? true : false;
                    fpf.ceChangingmethod.Checked = filtered[0]["current_user_type"].ToString() == "Changing Method" ? true : false;
                    fpf.ceDropOut.Checked = filtered[0]["current_user_type"].ToString() == "Dropout/Restart" ? true : false;
                    fpf.ceSideEffect.Checked = filtered[0]["changin_method_resaon"].ToString() == "side effects" ? true : false;
                    fpf.ceMedCondition.Checked = filtered[0]["changin_method_resaon"].ToString() == "medical condition" ? true : false;
                    string[] medHistArray = filtered[0]["medical_history"].ToString().Split('$');

                    switch (filtered[0]["currently_used_changing_methods"].ToString())
                    {
                        case ("COC"):
                            fpf.ceCoc.Checked = true;
                            break;
                        case ("POP"):
                            fpf.cePop.Checked = true;
                            break;
                        case ("Injectable"):
                            fpf.ceInjectable.Checked = true;
                            break;
                        case ("Implant"):
                            fpf.ceImplant.Checked = true;
                            break;
                        case ("IUD-Internal"):
                            fpf.ceIUD1.Checked = true;
                            break;
                        case ("IUD-Post-Partum"):
                            fpf.ceIUD2.Checked = true;
                            break;
                        case ("Condom"):
                            fpf.ceCondom.Checked = true;
                            break;
                        case ("BOM/CMM"):
                            fpf.ceBOM.Checked = true;
                            break;
                        case ("BBT"):
                            fpf.ceBBT.Checked = true;
                            break;
                        case ("STM"):
                            fpf.ceStm.Checked = true;
                            break;
                        case ("SDM"):
                            fpf.ceSdm.Checked = true;
                            break;
                        case ("LAM"):
                            fpf.ceLam.Checked = true;
                            break;
                        case ("others"):
                            fpf.ceOthers.Checked = true;
                            break;
                        default:
                            break;
                    }


                    for (int i = 1; i <= 12; i++)
                    {
                        bool isChecked = medHistArray.Contains(i.ToString());

                        DevExpress.XtraReports.UI.XRCheckBox yesCheckBox =
        fpf.FindControl(string.Format("ce{0}y", i), true) as DevExpress.XtraReports.UI.XRCheckBox;
                        DevExpress.XtraReports.UI.XRCheckBox noCheckBox =
                            fpf.FindControl(string.Format("ce{0}n", i), true) as DevExpress.XtraReports.UI.XRCheckBox;

                        if (yesCheckBox != null && noCheckBox != null)
                        {
                            yesCheckBox.Checked = isChecked;
                            noCheckBox.Checked = !isChecked;
                        }
                    }

                    fpf.ceVaginal.Checked = filtered[0]["type_last_delivery"].ToString() == "Vaginal" ? true : false;
                    fpf.ceCesarean.Checked = filtered[0]["type_last_delivery"].ToString() == "Vaginal" ? false : true;

                    string mens_flow = filtered[0]["menstrual_flow"].ToString();
                    if (mens_flow == "Scanty")
                        fpf.ceScanty.Checked = true;
                    else if (mens_flow == "moderate")
                        fpf.ceModerate.Checked = true;
                    else if (mens_flow == "heavy")
                        fpf.ceHeavy.Checked = true;
                    fpf.ceDysme.Checked = Convert.ToBoolean(filtered[0]["dysmenorrhea"].ToString());
                    fpf.ceHydalid.Checked = Convert.ToBoolean(filtered[0]["hydatidiform_mole"].ToString());
                    fpf.ceHistory.Checked = Convert.ToBoolean(filtered[0]["ectopitic_pregnancy"].ToString());

                    int counter = 0;
                    string[] transmittedRisk = filtered[0]["sexually_transmitted_infections_risk"].ToString().Split(',');
                    for (int index = 0; index < Math.Min(transmittedRisk.Length, 5); index++)
                    {
                        string str = transmittedRisk[index];
                        if (counter == 0)
                        {
                            if (str != "0")
                            {
                                fpf.ce13y.Checked = true;
                                fpf.ce13n.Checked = false;
                            }
                        }
                        else if (counter == 1)
                        {
                            if (str != "0")
                            {
                                fpf.ce14y.Checked = true;
                                fpf.ce14n.Checked = false;
                                fpf.cePenis.Checked = filtered[0]["genital_area_yes"].ToString() == "Penis" ? true : false;
                                fpf.ceVagina2.Checked = filtered[0]["genital_area_yes"].ToString() == "Vagina" ? true : false;
                            }
                        }
                        else if (counter == 2)
                        {
                            if (str != "0")
                            {
                                fpf.ce15y.Checked = true;
                                fpf.ce15n.Checked = false;
                            }
                        }
                        else if (counter == 3)
                        {
                            if (str != "0")
                            {
                                fpf.ce16y.Checked = true;
                                fpf.ce16n.Checked = false;
                            }
                        }
                        else if (counter == 4)
                        {
                            if (str != "0")
                            {
                                fpf.ce17y.Checked = true;
                                fpf.ce17n.Checked = false;
                            }
                        }
                        counter += 1;
                    }

                    string[] VAWArray = filtered[0]["VAW"].ToString().Split(',');
                    counter = 0;
                    foreach (string str in VAWArray)
                    {
                        if (counter == 0)
                        {
                            if (str == "1")
                            {
                                fpf.ce18y.Checked = true;
                                fpf.ce18n.Checked = false;
                            }
                        }
                        else if (counter == 1)
                        {
                            if (str == "1")
                            {
                                fpf.ce19y.Checked = true;
                                fpf.ce19n.Checked = false;
                            }
                        }
                        else if (counter == 2)
                        {
                            if (str == "1")
                            {
                                fpf.ce20y.Checked = true;
                                fpf.ce20n.Checked = false;
                            }
                        }
                        counter += 1;
                        break;
                    }

                    switch (filtered[0]["referred_to"].ToString())
                    {
                        case ("DSWD"):
                            fpf.ceDSWD.Checked = true;
                            break;
                        case ("WCPU"):
                            fpf.ceWCPU.Checked = true;
                            break;
                        case ("NGOs"):
                            fpf.ceNGO.Checked = true;
                            break;
                        case ("Others"):
                            fpf.ceOtherss.Checked = true;
                            break;
                    }

                    switch (filtered[0]["skin"].ToString())
                    {
                        case ("normal"):
                            fpf.ceSkinNormal.Checked = true;
                            break;
                        case ("yellowish"):
                            fpf.ceSkinYellow.Checked = true;
                            break;
                        case ("hematoma"):
                            fpf.ceSkinHema.Checked = true;
                            break;
                        case ("pale"):
                            fpf.ceSkinePale.Checked = true;
                            break;
                    }
                    switch (filtered[0]["conjunctiva"].ToString())
                    {
                        case ("normal"):
                            fpf.ceConjNormal.Checked = true;
                            break;
                        case ("yellowish"):
                            fpf.ceConjYellow.Checked = true;
                            break;
                        case ("pale"):
                            fpf.ceConjPale.Checked = true;
                            break;
                    }
                    switch (filtered[0]["neck"].ToString())
                    {
                        case ("normal"):
                            fpf.ceNeckNormal.Checked = true;
                            break;
                        case ("neck mass"):
                            fpf.ceNeckMass.Checked = true;
                            break;
                        case ("enlarged lymph nodes"):
                            fpf.ceNeckNodes.Checked = true;
                            break;
                    }
                    switch (filtered[0]["breast"].ToString())
                    {
                        case ("normal"):
                            fpf.ceBreastNormal.Checked = true;
                            break;
                        case ("mass"):
                            fpf.ceBreastMass.Checked = true;
                            break;
                        case ("nipple discharge"):
                            fpf.ceBreastNip.Checked = true;
                            break;
                    }
                    switch (filtered[0]["abdomen"].ToString())
                    {
                        case ("normal"):
                            fpf.ceAbdomenNormal.Checked = true;
                            break;
                        case ("abdominal mass"):
                            fpf.ceAbdomenmass.Checked = true;
                            break;
                        case ("varicosities"):
                            fpf.ceAbdomenVari.Checked = true;
                            break;
                    }
                    switch (filtered[0]["extremities"].ToString())
                    {
                        case ("normal"):
                            fpf.ceExtreNormal.Checked = true;
                            break;
                        case ("edema"):
                            fpf.ceExtreEdema.Checked = true;
                            break;
                        case ("varicosities"):
                            fpf.ceExtreVari.Checked = true;
                            break;
                    }

                    switch (filtered[0]["pelvic_examination"].ToString())
                    {
                        case ("normal"):
                            fpf.cePelvNormal.Checked = true;
                            break;
                        case ("mass"):
                            fpf.cePelvMass.Checked = true;
                            break;
                        case ("abnormal discharge"):
                            fpf.cePelvAdne.Checked = true;
                            break;
                        case ("cervical abnormalities"):
                            fpf.cePelvAbnor.Checked = true;
                            break;
                        case ("cervical consistency"):
                            fpf.cePelvCons.Checked = true;
                            break;
                        case ("cervical tenderness"):
                            fpf.cePelvTender.Checked = true;
                            break;
                        case ("adnexal mass/tenderness"):
                            fpf.cePelvTender.Checked = true;
                            break;
                        case ("uterine position"):
                            fpf.cePelvPosi.Checked = true;
                            break;
                        case ("uterine depth"):
                            fpf.cePelvDepth.Checked = true;
                            break;
                    }

                    switch (filtered[0]["cervical_abnormalities"].ToString())
                    {
                        case ("warts"):
                            fpf.ceAbnoWarts.Checked = true;
                            break;
                        case ("polyp or cyst"):
                            fpf.ceAbnoCyst.Checked = true;
                            break;
                        case ("inflammation or erosion"):
                            fpf.ceAbnoInflam.Checked = true;
                            break;
                        case ("bloody discharges"):
                            fpf.ceAbnoDischarge.Checked = true;
                            break;
                    }
                    switch (filtered[0]["cervical_consistency"].ToString())
                    {
                        case ("firm"):
                            fpf.ceConsisFirm.Checked = true;
                            break;
                        case ("soft"):
                            fpf.ceConsisSoft.Checked = true;
                            break;
                    }
                    switch (filtered[0]["uterine_position"].ToString())
                    {
                        case ("mid"):
                            fpf.cePosiMid.Checked = true;
                            break;
                        case ("anteflexed"):
                            fpf.cePosiAnte.Checked = true;
                            break;
                        case ("retroflexed"):
                            fpf.cePosiRetro.Checked = true;
                            break;
                    }

                    fpf.lblDepth.Text = filtered[0]["uterine_depth"].ToString();
                    fpf.DataMember = "CustomSqlQuery";
                    fpf.ShowPreviewDialog();
                }
            }
        }
    }
}