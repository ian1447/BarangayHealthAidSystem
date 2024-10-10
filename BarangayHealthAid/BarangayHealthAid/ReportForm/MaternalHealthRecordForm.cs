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
    public partial class MaternalHealthRecordForm : DevExpress.XtraEditors.XtraForm
    {
        public MaternalHealthRecordForm()
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
                if (!gvMaternal.IsGroupRow(gvMaternal.FocusedRowHandle))
                {
                    if (gvMaternal.SelectedRowsCount > 0)
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

        DataTable MaternalHealthTable = new DataTable();
        private void MaternalHealthRecordForm_Load(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
        }

        private void MaternalHealthRecordForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetMaternalRecord.IsBusy)
            {
                ShowLoading("Loading Data...");
                bwGetMaternalRecord.RunWorkerAsync();
            }
        }

        private void bwGetMaternalRecord_DoWork(object sender, DoWorkEventArgs e)
        {
            MaternalHealthTable = MaternalHealth.GetMaternalHealthRecord();
            bwGetMaternalRecord.CancelAsync();
        }

        private void bwGetMaternalRecord_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (MaternalHealth.GetMaternalHealthRecordIsSuccessful)
            {
                if (MaternalHealthTable.Rows.Count > 0)
                    dtMaternal.DataSource = MaternalHealthTable;
                else
                {
                    MsgBox.Warning("No data found.");
                    dtMaternal.DataSource = new DataTable();
                }
            }
            else
                MsgBox.Error(MaternalHealth.GetMaternalHealthRecordErrorMessage);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                int id = Convert.ToInt32(gvMaternal.GetFocusedRowCellValue("id").ToString());
                DataRow[] filtered = MaternalHealthTable.Select(String.Format("id = {0}", id));
                if (filtered.Count() > 0)
                {
                    MaternalHealthRecord mhr = new MaternalHealthRecord();
                    mhr.lblName.Text = filtered[0]["name"].ToString();
                    mhr.lblAge.Text = filtered[0]["age"].ToString();
                    mhr.lbldob.Text = filtered[0]["dob"].ToString();
                    mhr.lblHeight.Text = filtered[0]["height"].ToString();
                    mhr.lblHusband.Text = filtered[0]["husband_name"].ToString();
                    mhr.lblOccupation.Text = filtered[0]["occupation"].ToString();
                    mhr.lblAddress.Text = filtered[0]["address"].ToString();
                    mhr.lblContact.Text = filtered[0]["contact_no"].ToString();
                    mhr.lblBornAlive.Text = filtered[0]["no_children_born_alive"].ToString();
                    mhr.lblLiving.Text = filtered[0]["living_children"].ToString();
                    mhr.lblAbortion.Text = filtered[0]["abortion"].ToString();
                    mhr.lblFetal.Text = filtered[0]["fetal_deaths"].ToString();
                    mhr.lblLastDel.Text = filtered[0]["type_last_delivery"].ToString();
                    mhr.lblLargeBabies.Text = filtered[0]["largebabies"].ToString();
                    mhr.lblDiabetes.Text = filtered[0]["diabetes"].ToString();
                    mhr.lblPrevIll.Text = filtered[0]["previous_illness"].ToString();
                    mhr.lblAllergy.Text = filtered[0]["allergy"].ToString();
                    mhr.lblPrevHosp.Text = filtered[0]["previous_hospitalization"].ToString();
                    mhr.lblGravida.Text = filtered[0]["gravida"].ToString();
                    mhr.lblPara.Text = filtered[0]["PARA"].ToString();
                    mhr.lblA.Text = filtered[0]["A"].ToString();
                    mhr.lblStillBirth.Text = filtered[0]["stillbirth"].ToString();
                    mhr.lblLmp.Text = filtered[0]["LMP"].ToString();
                    mhr.lblEdc.Text = filtered[0]["EDC"].ToString();
                    mhr.lblWhereDel.Text = filtered[0]["where_to_deliver"].ToString();
                    mhr.lblAttBy.Text = filtered[0]["attended_by"].ToString();
                    mhr.lblScreening.Text = filtered[0]["new_born_screening_plan"].ToString();
                    mhr.lblRiskCodes.Text = filtered[0]["risk_codes"].ToString();
                    mhr.lbltt1.Text = filtered[0]["tt1"].ToString();
                    mhr.lbltt2.Text = filtered[0]["tt2"].ToString();
                    mhr.lbltt3.Text = filtered[0]["tt3"].ToString();
                    mhr.lbltt4.Text = filtered[0]["tt4"].ToString();
                    mhr.lbltt5.Text = filtered[0]["tt5"].ToString();
                    mhr.lblUrinalysis.Text = filtered[0]["urinalysis"].ToString();
                    mhr.lblHBS.Text = filtered[0]["hbs_antigen"].ToString();
                    mhr.lblCBC.Text = filtered[0]["CBC"].ToString();
                    mhr.lblRPR.Text = filtered[0]["RPR"].ToString();
                    mhr.lblBloodTyping.Text = filtered[0]["blood_typing"].ToString();
                    mhr.lblHIV.Text = filtered[0]["HIV"].ToString();
                    mhr.lblComplications.Text = filtered[0]["prev_pregnancy_complic"].ToString();
                    mhr.lblDateGiven.Text = filtered[0]["vit_a_date_given"].ToString();
                    mhr.lblDateGiven2.Text = filtered[0]["vit_a_date_given"].ToString();
                    mhr.lblPrescribed.Text = filtered[0]["vit_a_prescribed"].ToString();
                    mhr.lblFolic4.Text = filtered[0]["iron_folic_4"].ToString();
                    mhr.lblFolic5.Text = filtered[0]["iron_folic_5"].ToString();
                    mhr.lblFolic6.Text = filtered[0]["iron_folic_6"].ToString();
                    mhr.lblFolic7.Text = filtered[0]["iron_folic_7"].ToString();
                    mhr.lblFolic8.Text = filtered[0]["iron_folic_8"].ToString();
                    mhr.lblFolic9.Text = filtered[0]["iron_folic_9"].ToString();

                    if (filtered[0]["checklist"].ToString().Contains("Vaginal Bleeding"))
                        mhr.cb1.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Severe Headache"))
                        mhr.cb2.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Blurring of vision"))
                        mhr.cb3.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Abdominal Pain"))
                        mhr.cb4.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Severe vomiting"))
                        mhr.cb5.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Difficulty breathing"))
                        mhr.cb6.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Convulsion"))
                        mhr.cb7.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Edema"))
                        mhr.cb8.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("varicosities"))
                        mhr.cb9.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Dental carries"))
                        mhr.cb10.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Chills and fever"))
                        mhr.cb11.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Breast abnormalities"))
                        mhr.cb12.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("pain during urination"))
                        mhr.cb13.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("vaginal discharge"))
                        mhr.cb14.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("diabetes"))
                        mhr.cb15.Checked = true;
                    if (filtered[0]["checklist"].ToString().Contains("Escape of fluid from vagina"))
                        mhr.cb16.Checked = true;

                    mhr.ShowPreviewDialog();
                }
            }
            else
                MsgBox.Error("No Record Selected.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaternalHealthRecordAddForm mhr = new MaternalHealthRecordAddForm();
            mhr.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                int id = Convert.ToInt32(gvMaternal.GetFocusedRowCellValue("id").ToString());
                DataRow[] filtered = MaternalHealthTable.Select(String.Format("id = {0}", id));
                if (filtered.Count() > 0)
                {
                    MaternalHealthRecordAddForm mhaf = new MaternalHealthRecordAddForm();
                    mhaf.txtName.Text = filtered[0]["name"].ToString();
                    mhaf.txtAge.Text = filtered[0]["age"].ToString();

                    mhaf.dtDob.Text = filtered[0]["dob"].ToString();

                    mhaf.txtHeight.Text = filtered[0]["height"].ToString();
                    mhaf.txtHusbandName.Text = filtered[0]["husband_name"].ToString();
                    mhaf.txtOccupation.Text = filtered[0]["occupation"].ToString();
                    mhaf.txtAddress.Text = filtered[0]["address"].ToString();
                    mhaf.txtContactNo.Text = filtered[0]["contact_no"].ToString();
                    mhaf.txtbornalive.Text = filtered[0]["no_children_born_alive"].ToString();
                    mhaf.txtliving.Text = filtered[0]["living_children"].ToString();
                    mhaf.txtAbortion.Text = filtered[0]["abortion"].ToString();
                    mhaf.txtFetalDeaths.Text = filtered[0]["fetal_deaths"].ToString();
                    mhaf.txtLastDelivery.Text = filtered[0]["type_last_delivery"].ToString();
                    mhaf.txtLargeBabies.Text = filtered[0]["largebabies"].ToString();
                    mhaf.txtDiabetes.Text = filtered[0]["diabetes"].ToString();
                    mhaf.txtPrevIllness.Text = filtered[0]["previous_illness"].ToString();
                    mhaf.txtAllergy.Text = filtered[0]["allergy"].ToString();
                    mhaf.txtPrevHosp.Text = filtered[0]["previous_hospitalization"].ToString();
                    mhaf.txtGravida.Text = filtered[0]["gravida"].ToString();
                    mhaf.txtPara.Text = filtered[0]["PARA"].ToString();
                    mhaf.txtA.Text = filtered[0]["A"].ToString();
                    mhaf.txtStillBirth.Text = filtered[0]["stillbirth"].ToString();
                    mhaf.txtLMP.Text = filtered[0]["LMP"].ToString();
                    mhaf.txtEDC.Text = filtered[0]["EDC"].ToString();
                    mhaf.txtWhereDel.Text = filtered[0]["where_to_deliver"].ToString();
                    mhaf.txtAttended.Text = filtered[0]["attended_by"].ToString();
                    mhaf.txtScreeningPlan.Text = filtered[0]["new_born_screening_plan"].ToString();
                    mhaf.txtRiskCodes.Text = filtered[0]["risk_codes"].ToString();

                    mhaf.dtTT1.Text = filtered[0]["tt1"].ToString();
                    mhaf.dtTT2.Text = filtered[0]["tt2"].ToString();
                    mhaf.dtTT3.Text = filtered[0]["tt3"].ToString();
                    mhaf.dtTT4.Text = filtered[0]["tt4"].ToString();
                    mhaf.dtTT5.Text = filtered[0]["tt5"].ToString();

                    mhaf.txtUrinalysis.Text = filtered[0]["urinalysis"].ToString();
                    mhaf.txtHbsAntigen.Text = filtered[0]["hbs_antigen"].ToString();
                    mhaf.txtCBC.Text = filtered[0]["CBC"].ToString();
                    mhaf.txtRPR.Text = filtered[0]["RPR"].ToString();
                    mhaf.txtBloodTyping.Text = filtered[0]["blood_typing"].ToString();
                    mhaf.txtHIV.Text = filtered[0]["HIV"].ToString();
                    mhaf.txtComplications.Text = filtered[0]["prev_pregnancy_complic"].ToString();
                    mhaf.dtVitA.Text = filtered[0]["vit_a_date_given"].ToString();
                    mhaf.txtVitADescribed.Text = filtered[0]["vit_a_prescribed"].ToString();

                    mhaf.dtIronFolic4.Text = filtered[0]["iron_folic_4"].ToString();
                    mhaf.dtIronFolic5.Text = filtered[0]["iron_folic_5"].ToString();
                    mhaf.dtIronFolic6.Text = filtered[0]["iron_folic_6"].ToString();
                    mhaf.dtIronFolic7.Text = filtered[0]["iron_folic_7"].ToString();
                    mhaf.dtIronFolic8.Text = filtered[0]["iron_folic_8"].ToString();
                    mhaf.dtIronFolic9.Text = filtered[0]["iron_folic_9"].ToString();
                    mhaf.isAdd = false;
                    mhaf.ShowDialog();
                }
            }
            else
                MsgBox.Error("No Record Selected.");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                int id = Convert.ToInt32(gvMaternal.GetFocusedRowCellValue("id").ToString());
                DataRow[] filtered = MaternalHealthTable.Select(String.Format("id = {0}", id));
                if (filtered.Count() > 0)
                {
                    MaternalHealthRecordAddForm mhaf = new MaternalHealthRecordAddForm();
                    mhaf.txtName.Text = filtered[0]["name"].ToString();
                    mhaf.txtAge.Text = filtered[0]["age"].ToString();

                    mhaf.dtDob.Text = filtered[0]["dob"].ToString();

                    mhaf.txtHeight.Text = filtered[0]["height"].ToString();
                    mhaf.txtHusbandName.Text = filtered[0]["husband_name"].ToString();
                    mhaf.txtOccupation.Text = filtered[0]["occupation"].ToString();
                    mhaf.txtAddress.Text = filtered[0]["address"].ToString();
                    mhaf.txtContactNo.Text = filtered[0]["contact_no"].ToString();
                    mhaf.txtbornalive.Text = filtered[0]["no_children_born_alive"].ToString();
                    mhaf.txtliving.Text = filtered[0]["living_children"].ToString();
                    mhaf.txtAbortion.Text = filtered[0]["abortion"].ToString();
                    mhaf.txtFetalDeaths.Text = filtered[0]["fetal_deaths"].ToString();
                    mhaf.txtLastDelivery.Text = filtered[0]["type_last_delivery"].ToString();
                    mhaf.txtLargeBabies.Text = filtered[0]["largebabies"].ToString();
                    mhaf.txtDiabetes.Text = filtered[0]["diabetes"].ToString();
                    mhaf.txtPrevIllness.Text = filtered[0]["previous_illness"].ToString();
                    mhaf.txtAllergy.Text = filtered[0]["allergy"].ToString();
                    mhaf.txtPrevHosp.Text = filtered[0]["previous_hospitalization"].ToString();
                    mhaf.txtGravida.Text = filtered[0]["gravida"].ToString();
                    mhaf.txtPara.Text = filtered[0]["PARA"].ToString();
                    mhaf.txtA.Text = filtered[0]["A"].ToString();
                    mhaf.txtStillBirth.Text = filtered[0]["stillbirth"].ToString();
                    mhaf.txtLMP.Text = filtered[0]["LMP"].ToString();
                    mhaf.txtEDC.Text = filtered[0]["EDC"].ToString();
                    mhaf.txtWhereDel.Text = filtered[0]["where_to_deliver"].ToString();
                    mhaf.txtAttended.Text = filtered[0]["attended_by"].ToString();
                    mhaf.txtScreeningPlan.Text = filtered[0]["new_born_screening_plan"].ToString();
                    mhaf.txtRiskCodes.Text = filtered[0]["risk_codes"].ToString();

                    mhaf.dtTT1.Text = filtered[0]["tt1"].ToString();
                    mhaf.dtTT2.Text = filtered[0]["tt2"].ToString();
                    mhaf.dtTT3.Text = filtered[0]["tt3"].ToString();
                    mhaf.dtTT4.Text = filtered[0]["tt4"].ToString();
                    mhaf.dtTT5.Text = filtered[0]["tt5"].ToString();

                    mhaf.txtUrinalysis.Text = filtered[0]["urinalysis"].ToString();
                    mhaf.txtHbsAntigen.Text = filtered[0]["hbs_antigen"].ToString();
                    mhaf.txtCBC.Text = filtered[0]["CBC"].ToString();
                    mhaf.txtRPR.Text = filtered[0]["RPR"].ToString();
                    mhaf.txtBloodTyping.Text = filtered[0]["blood_typing"].ToString();
                    mhaf.txtHIV.Text = filtered[0]["HIV"].ToString();
                    mhaf.txtComplications.Text = filtered[0]["prev_pregnancy_complic"].ToString();
                    mhaf.dtVitA.Text = filtered[0]["vit_a_date_given"].ToString();
                    mhaf.txtVitADescribed.Text = filtered[0]["vit_a_prescribed"].ToString();

                    mhaf.dtIronFolic4.Text = filtered[0]["iron_folic_4"].ToString();
                    mhaf.dtIronFolic5.Text = filtered[0]["iron_folic_5"].ToString();
                    mhaf.dtIronFolic6.Text = filtered[0]["iron_folic_6"].ToString();
                    mhaf.dtIronFolic7.Text = filtered[0]["iron_folic_7"].ToString();
                    mhaf.dtIronFolic8.Text = filtered[0]["iron_folic_8"].ToString();
                    mhaf.dtIronFolic9.Text = filtered[0]["iron_folic_9"].ToString();
                    mhaf.is_view = true;
                    mhaf.ShowDialog();
                }
            }
            else
                MsgBox.Error("No Record Selected.");
        }
    }
}