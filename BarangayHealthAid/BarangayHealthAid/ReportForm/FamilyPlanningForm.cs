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
                    fpa.rgFpReason.Text = filtered[0]["reason_for_FP"].ToString();
                    fpa.rgSub.Text = filtered[0]["current_user_type"].ToString();
                    fpa.rgCMReason.Text = filtered[0]["reason_for_FP"].ToString();
                    fpa.txtOthers.Text = filtered[0]["others"].ToString();
                    fpa.txtChangeMethodOthers.Text = filtered[0]["side_effects"].ToString();
                    fpa.rgCurMeth.Text = filtered[0]["currently_used_changing_methods"].ToString();
                    fpa.txtCurMeth.Text = filtered[0]["changing_method_others"].ToString();
                    string[] medHistArray =  filtered[0]["medical_history"].ToString().Split(',');
                    foreach (string str in medHistArray)
                    {
                        for (int i = 0; i < fpa.clbMedHistory.Items.Count; i++)
                        {
                            if (fpa.clbMedHistory.Items[i].Description.ToString() == str)
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
                    fpa.cbGenitalDischarge.SelectedIndex = Convert.ToInt32(filtered[0]["genital_area_yes"].ToString());
                    fpa.ceulcers.Checked = risksArray[1] == "1" ? true : false;
                    fpa.cePain.Checked = risksArray[2] == "1" ? true : false;
                    fpa.ceInfections.Checked = risksArray[3] == "1" ? true : false;
                    fpa.ceHIV.Checked = risksArray[4] == "1" ? true : false;

                    string[] VAWArray = filtered[0]["VAW"].ToString().Split(',');
                    foreach (string str in VAWArray)
                    {
                        for (int i = 0; i < fpa.clbVAW.Items.Count; i++)
                        {
                            if (fpa.clbVAW.Items[i].Description.ToString() == str)
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
                    string[] medHistArray = filtered[0]["medical_history"].ToString().Split(',');
                    foreach (string str in medHistArray)
                    {
                        for (int i = 0; i < fpa.clbMedHistory.Items.Count; i++)
                        {
                            if (fpa.clbMedHistory.Items[i].Description.ToString() == str)
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
                    fpa.cbGenitalDischarge.SelectedIndex = Convert.ToInt32(filtered[0]["genital_area_yes"].ToString());
                    fpa.ceulcers.Checked = risksArray[1] == "1" ? true : false;
                    fpa.cePain.Checked = risksArray[2] == "1" ? true : false;
                    fpa.ceInfections.Checked = risksArray[3] == "1" ? true : false;
                    fpa.ceHIV.Checked = risksArray[4] == "1" ? true : false;

                    string[] VAWArray = filtered[0]["VAW"].ToString().Split(',');
                    foreach (string str in VAWArray)
                    {
                        for (int i = 0; i < fpa.clbVAW.Items.Count; i++)
                        {
                            if (fpa.clbVAW.Items[i].Description.ToString() == str)
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
    }
}