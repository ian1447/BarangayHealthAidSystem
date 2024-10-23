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
                    //pcaf.txtExtension.Text = filtered[0]["name_extension"].ToString();
                    //pcaf.txtMiddleName.Text = filtered[0]["middle_name"].ToString();
                    //pcaf.txtMaidenLastName.Text = filtered[0]["maiden_last_name"].ToString();
                    //pcaf.txtMaidenFirstName.Text = filtered[0]["maiden_first_name"].ToString();
                    //pcaf.txtMaidenExtension.Text = filtered[0]["maiden_name_extension"].ToString();
                    //pcaf.txtMaidenMiddleName.Text = filtered[0]["maiden_middle_name"].ToString();
                    //pcaf.dtDob.EditValue = Convert.ToDateTime(filtered[0]["format_birthdate"].ToString());
                    //pcaf.txtAge.Text = filtered[0]["age"].ToString();
                    //pcaf.txtPlaceofBirth.Text = filtered[0]["place_of_birth"].ToString();
                    //pcaf.cbSex.Text = filtered[0]["sex"].ToString();
                    //pcaf.cbCivilStatus.Text = filtered[0]["civil_status"].ToString();
                    //pcaf.txtReligion.Text = filtered[0]["religion"].ToString();
                    //pcaf.txtBloodType.Text = filtered[0]["blood_type"].ToString();
                    //pcaf.txtContactNum.Text = filtered[0]["contact_number"].ToString();
                    //pcaf.txtPurok.Text = filtered[0]["address_purok"].ToString();
                    //pcaf.txtBarangay.Text = filtered[0]["address_barangay"].ToString();
                    //pcaf.txtMunicipality.Text = filtered[0]["address_mun"].ToString();
                    //pcaf.txtProvince.Text = filtered[0]["address_province"].ToString();
                    //pcaf.txtCountry.Text = filtered[0]["address_country"].ToString();
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
    }
}