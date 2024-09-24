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
using System.Globalization;

namespace BarangayHealthAid.ReportForm
{
    public partial class PatientRecordForm : DevExpress.XtraEditors.XtraForm
    {
        public PatientRecordForm()
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
                if (!gvPatient.IsGroupRow(gvPatient.FocusedRowHandle))
                {
                    if (gvPatient.SelectedRowsCount > 0)
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


        DataTable PatientsRecordTable = new DataTable();
        private int patientid;

        private void PatientRecordForm_Shown(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetPatientData.IsBusy)
            {
                ShowLoading("Loading data...");
                bwGetPatientData.RunWorkerAsync();
            }
        }

        private void bwGetPatientData_DoWork(object sender, DoWorkEventArgs e)
        {
            PatientsRecordTable = PatientRecord.GetPatientDetails();
            bwGetPatientData.CancelAsync();
        }

        private void bwGetPatientData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (PatientRecord.GetPatientDetailsIsSuccessful)
            {
                if (PatientsRecordTable.Rows.Count > 0)
                {
                    dtPatient.DataSource = PatientsRecordTable;
                    patientid = Convert.ToInt32(PatientsRecordTable.Rows[0]["id"].ToString());
                }
                else
                    dtPatient.DataSource = new DataTable();
            }
            else
                MsgBox.Error(PatientRecord.GetPatientDetailsErrorMessage);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                int id = Convert.ToInt32(gvPatient.GetFocusedRowCellValue("id").ToString());
                DataRow[] filtered = PatientsRecordTable.Select(String.Format("id = {0}", id));
                if (filtered.Count() > 0)
                {
                    PatientClinicalRecord pcr = new PatientClinicalRecord();
                    pcr.lblFirstName.Text = filtered[0]["first_name"].ToString();
                    pcr.lblLastName.Text = filtered[0]["last_name"].ToString();
                    pcr.lblAge.Text = " Age:  " + filtered[0]["age"].ToString();
                    pcr.lblExt.Text = filtered[0]["name_extension"].ToString();
                    pcr.lblMiddleName.Text = filtered[0]["middle_name"].ToString();
                    pcr.lblMaidenLastName.Text = filtered[0]["maiden_last_name"].ToString();
                    pcr.lblMaidenFirstName.Text = filtered[0]["maiden_first_name"].ToString();
                    pcr.lblMaidenExt.Text = filtered[0]["maiden_name_extension"].ToString();
                    pcr.lblMaidenMiddle.Text = filtered[0]["maiden_middle_name"].ToString();
                    pcr.lblDob.Text = filtered[0]["format_birthdate"].ToString();
                    pcr.lblPlaceofBirth.Text = filtered[0]["place_of_birth"].ToString();
                    pcr.lblReligion.Text = filtered[0]["religion"].ToString();
                    pcr.lblBloodType.Text = filtered[0]["blood_type"].ToString();
                    pcr.lblContactNumber.Text = filtered[0]["contact_number"].ToString();
                    pcr.lblPurok.Text = filtered[0]["address_purok"].ToString();
                    pcr.lblBarangay.Text = filtered[0]["address_barangay"].ToString();
                    pcr.lblMunicipality.Text = filtered[0]["address_mun"].ToString();
                    pcr.lblProvince.Text = filtered[0]["address_province"].ToString();
                    pcr.lblCountry.Text = filtered[0]["address_country"].ToString();
                    pcr.lblZip.Text = filtered[0]["address_zip_code"].ToString();
                    pcr.lblEducAtt.Text = filtered[0]["educational_attainment"].ToString();
                    pcr.lblEmploymentStat.Text = filtered[0]["employment_status"].ToString();
                    pcr.lblTin.Text = filtered[0]["TIN"].ToString();
                    pcr.lblPhicNo.Text = filtered[0]["phic_id_no"].ToString();
                    pcr.lbl4pNo.Text = filtered[0]["4p_id_no"].ToString();
                    pcr.lblPartnerLastName.Text = filtered[0]["partner_last_name"].ToString();
                    pcr.lblPartnerFirstName.Text = filtered[0]["partner_first_name"].ToString();
                    pcr.lblPartnerMiddleName.Text = filtered[0]["partner_middle_name"].ToString();
                    pcr.lblPartnerExt.Text = filtered[0]["partner_name_extension"].ToString();
                    pcr.lblPartnerSex.Text = filtered[0]["partner_sex"].ToString();
                    pcr.lblPartnerDob.Text = filtered[0]["partner_birthdate"].ToString();
                    pcr.lblPartnerPhicNo.Text = filtered[0]["partner_phic_id"].ToString();
                    pcr.lblFatherLastName.Text = filtered[0]["father_last_name"].ToString();
                    pcr.lblFatherFirstName.Text = filtered[0]["father_first_name"].ToString();
                    pcr.lblFatherMiddleName.Text = filtered[0]["father_middle_name"].ToString();
                    pcr.lblFatherExt.Text = filtered[0]["father_name_extension"].ToString();
                    pcr.lblFatherDisability.Text = filtered[0]["father_disability"].ToString();
                    pcr.lblFatherDob.Text = filtered[0]["father_birthdate"].ToString();
                    pcr.lblFatherPhicNo.Text = filtered[0]["father_phic_id"].ToString();
                    pcr.lblMotherLastName.Text = filtered[0]["mother_last_name"].ToString();
                    pcr.lblMotherFirstName.Text = filtered[0]["mother_first_name"].ToString();
                    pcr.lblMotherMiddleName.Text = filtered[0]["mother_middle_name"].ToString();
                    pcr.lblMotherExt.Text = filtered[0]["mother_name_extension"].ToString();
                    pcr.lblMotherDisability.Text = filtered[0]["mother_disability"].ToString();
                    pcr.lblMotherDob.Text = filtered[0]["mother_birthdate"].ToString();
                    pcr.lblMotherPhicNo.Text = filtered[0]["mother_phic_id"].ToString();

                    if (filtered[0]["sex"].ToString() == "Male")
                        pcr.ceMale.Checked = true;
                    else
                        pcr.ceFemale.Checked = true;

                    if (filtered[0]["civil_status"].ToString() == "Single")
                        pcr.ceSingle.Checked = true;
                    else if (filtered[0]["civil_status"].ToString() == "Married")
                        pcr.ceMarried.Checked = true;
                    else if (filtered[0]["civil_status"].ToString() == "Widow(er)")
                        pcr.ceWidow.Checked = true;
                    else if (filtered[0]["civil_status"].ToString() == "Habitation")
                        pcr.ceHabitation.Checked = true;

                    if (filtered[0]["ph_stat"].ToString() == "With PHIC")
                        pcr.ceWithPhic.Checked = true;
                    else
                        pcr.ceNoPhic.Checked = true;

                    pcr.ce4P.Checked = filtered[0]["is_4p"].ToString() == "True" ? true : false;

                    if (filtered[0]["phic_status_type"].ToString() == "Member")
                        pcr.cePhicMember.Checked = true;
                    else
                        pcr.cePhicDependent.Checked = true;

                    if (filtered[0]["4p_status_type"].ToString() == "Member")
                        pcr.ce4pMember.Checked = true;
                    else
                        pcr.ce4pDependent.Checked = true;

                    if (filtered[0]["membership_cat"].ToString() == "NHTS-PR")
                        pcr.ceCat1.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Govt-Permanent Regular")
                        pcr.ceCat2.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Govt-Contractual/Project Based")
                        pcr.ceCat3.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Govt-Casual")
                        pcr.ceCat4.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Self-Earning")
                        pcr.ceCat5.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Migrant Worker (Land)")
                        pcr.ceCat6.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Migrant Worker (Sea)")
                        pcr.ceCat7.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Enterprise Owner")
                        pcr.ceCat8.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Senior Citizen")
                        pcr.ceCat9.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Sponsored: LGU")
                        pcr.ceCat10.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Sponsored: NGA")
                        pcr.ceCat11.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Retiree: Pensioner")
                        pcr.ceCat12.Checked = true;
                    else if (filtered[0]["membership_cat"].ToString() == "Others")
                        pcr.ceCat13.Checked = true;

                    pcr.ShowPreviewDialog();
                }
                else
                    MsgBox.Error("No Data Found...");
            }
            else
                MsgBox.Warning("No Patient Selected...");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PatientRecordAddForm pcaf = new PatientRecordAddForm();
            pcaf.ShowDialog();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                int id = Convert.ToInt32(gvPatient.GetFocusedRowCellValue("id").ToString());
                DataRow[] filtered = PatientsRecordTable.Select(String.Format("id = {0}", id));
                if (filtered.Count() > 0)
                {
                    PatientRecordAddForm pcaf = new PatientRecordAddForm();
                    pcaf.is_add = false;
                    pcaf.txtFirstName.Text = filtered[0]["first_name"].ToString();
                    pcaf.txtLastName.Text = filtered[0]["last_name"].ToString();
                    pcaf.txtExtension.Text = filtered[0]["name_extension"].ToString();
                    pcaf.txtMiddleName.Text = filtered[0]["middle_name"].ToString();
                    pcaf.txtMaidenLastName.Text = filtered[0]["maiden_last_name"].ToString();
                    pcaf.txtMaidenFirstName.Text = filtered[0]["maiden_first_name"].ToString();
                    pcaf.txtMaidenExtension.Text = filtered[0]["maiden_name_extension"].ToString();
                    pcaf.txtMaidenMiddleName.Text = filtered[0]["maiden_middle_name"].ToString();
                    pcaf.dtDob.EditValue = Convert.ToDateTime(filtered[0]["format_birthdate"].ToString());
                    pcaf.txtAge.Text = filtered[0]["age"].ToString();
                    pcaf.txtPlaceofBirth.Text = filtered[0]["place_of_birth"].ToString();
                    pcaf.cbSex.Text = filtered[0]["sex"].ToString();
                    pcaf.cbCivilStatus.Text = filtered[0]["civil_status"].ToString();
                    pcaf.txtReligion.Text = filtered[0]["religion"].ToString();
                    pcaf.txtBloodType.Text = filtered[0]["blood_type"].ToString();
                    pcaf.txtContactNum.Text = filtered[0]["contact_number"].ToString();
                    pcaf.txtPurok.Text = filtered[0]["address_purok"].ToString();
                    pcaf.txtBarangay.Text = filtered[0]["address_barangay"].ToString();
                    pcaf.txtMunicipality.Text = filtered[0]["address_mun"].ToString();
                    pcaf.txtProvince.Text = filtered[0]["address_province"].ToString();
                    pcaf.txtCountry.Text = filtered[0]["address_country"].ToString();
                    pcaf.txtZip.Text = filtered[0]["address_zip_code"].ToString();
                    pcaf.txtEducAtt.Text = filtered[0]["educational_attainment"].ToString();
                    pcaf.txtEmploymentStat.Text = filtered[0]["employment_status"].ToString();
                    pcaf.txtTin.Text = filtered[0]["TIN"].ToString();
                    pcaf.txtPhicNo.Text = filtered[0]["phic_id_no"].ToString();
                    pcaf.txt4pIdNo.Text = filtered[0]["4p_id_no"].ToString();
                    pcaf.txtPartnerPhicId.Text = filtered[0]["partner_phic_id"].ToString();
                    pcaf.txtPartnerLastName.Text = filtered[0]["partner_last_name"].ToString();
                    pcaf.txtPartnerFirstName.Text = filtered[0]["partner_first_name"].ToString();
                    pcaf.txtPartnerMiddleName.Text = filtered[0]["partner_middle_name"].ToString();
                    pcaf.txtPartnerExt.Text = filtered[0]["partner_name_extension"].ToString();
                    pcaf.cbPartnerSex.Text = filtered[0]["partner_sex"].ToString();
                    pcaf.dtPartnerDob.Text = filtered[0]["partner_birthdate"].ToString();
                    pcaf.txtfatherLastname.Text = filtered[0]["father_last_name"].ToString();
                    pcaf.txtFatherFirstName.Text = filtered[0]["father_first_name"].ToString();
                    pcaf.txtFatherMiddleName.Text = filtered[0]["father_middle_name"].ToString();
                    pcaf.txtFatherExt.Text = filtered[0]["father_name_extension"].ToString();
                    pcaf.txtFatherDisability.Text = filtered[0]["father_disability"].ToString();
                    pcaf.dtFatherDob.Text = filtered[0]["father_birthdate"].ToString();
                    pcaf.txtfatherPhicid.Text = filtered[0]["father_phic_id"].ToString();
                    pcaf.txtMotherLastName.Text = filtered[0]["mother_last_name"].ToString();
                    pcaf.txtMotherFirstName.Text = filtered[0]["mother_first_name"].ToString();
                    pcaf.txtMotherMiddleName.Text = filtered[0]["mother_middle_name"].ToString();
                    pcaf.txtMotherExt.Text = filtered[0]["mother_name_extension"].ToString();
                    pcaf.txtMotherDisability.Text = filtered[0]["mother_disability"].ToString();
                    pcaf.dtMotherDob.Text = filtered[0]["mother_birthdate"].ToString();
                    pcaf.txtMotherPhicID.Text = filtered[0]["mother_phic_id"].ToString();
                    pcaf.rgPhicStat.EditValue = filtered[0]["ph_stat"].ToString();
                    pcaf.rgPhicType.EditValue = filtered[0]["phic_status_type"].ToString();
                    pcaf.rg4pType.EditValue = filtered[0]["4p_status_type"].ToString();
                    pcaf.rgMembershipCat.EditValue = filtered[0]["membership_cat"].ToString();
                    pcaf.ShowDialog();
                    LoadData();
                }
                else
                    MsgBox.Error("No Data Found...");
            }
            else
                MsgBox.Warning("No Patient Selected...");
            
        }

    }
}