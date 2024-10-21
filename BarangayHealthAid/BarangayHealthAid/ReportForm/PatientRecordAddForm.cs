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
using DevExpress.XtraLayout;

namespace BarangayHealthAid.ReportForm
{
    public partial class PatientRecordAddForm : DevExpress.XtraEditors.XtraForm
    {
        public PatientRecordAddForm()
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

        private int is4p = 0;
        public bool is_add = true;
        public bool is_view = false;
        private int _purok_family_member_id;
        public int edit_id;
        DataRow[] filtered;
        private void PatientRecordAddForm_Load(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
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
            layoutControl1.Select();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (is_add)
                {
                    if (!bwAddPatient.IsBusy)
                    {
                        ShowLoading("Adding Data...");
                        bwAddPatient.RunWorkerAsync();
                    }
                }
                else
                {
                    if (!bwEditPatient.IsBusy)
                    {
                        ShowLoading("Updating Data...");
                        bwEditPatient.RunWorkerAsync();
                    }
                }
            }
        }

        private void bwAddPatient_DoWork(object sender, DoWorkEventArgs e)
        {
            PatientRecord.AddPatient(txtLastName.Text, txtFirstName.Text, txtExtension.Text, txtMiddleName.Text, txtMaidenLastName.Text, txtMaidenFirstName.Text, txtMaidenExtension.Text, txtMaidenMiddleName.Text, dtDob.Text, txtAge.Text, txtPlaceofBirth.Text, cbSex.Text, cbCivilStatus.Text, txtReligion.Text, txtBloodType.Text, txtContactNum.Text, txtPurok.Text, txtBarangay.Text, txtMunicipality.Text, txtProvince.Text, txtCountry.Text, txtZip.Text, txtEducAtt.Text, txtEmploymentStat.Text, txtTin.Text, rgPhicType.Text, txtPhicNo.Text, rgPhicStat.Text, is4p, txt4pIdNo.Text, rg4pType.Text, rgMembershipCat.Text, txtPartnerLastName.Text, txtPartnerFirstName.Text, txtPartnerExt.Text, txtPartnerMiddleName.Text, dtPartnerDob.Text, cbPartnerSex.Text, txtPartnerPhicId.Text, txtfatherLastname.Text, txtFatherFirstName.Text, txtFatherExt.Text, txtFatherMiddleName.Text, dtFatherDob.Text, txtFatherDisability.Text, txtfatherPhicid.Text, txtMotherLastName.Text, txtMotherFirstName.Text, txtMotherExt.Text, txtMotherMiddleName.Text, dtMotherDob.Text, txtMotherDisability.Text, txtMotherPhicID.Text, _purok_family_member_id);
            bwAddPatient.CancelAsync();
        }

        private void bwAddPatient_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (PatientRecord.AddPatientIsSuccessful)
            {
                MsgBox.Information("Adding Patient Details successful.");
                this.Close();
            }
            else
                MsgBox.Error(PatientRecord.AddPatientErrorMessage);
        }

        private void ce4p_CheckedChanged(object sender, EventArgs e)
        {
            is4p = ce4p.Checked ? 1 : 0; 
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            if (!is_view)
            {
                if (txtLastName.Properties.ReadOnly)
                {
                    SelectPurokFamilyMemberForm spf = new SelectPurokFamilyMemberForm();
                    spf.ShowDialog();
                    filtered = spf.filtered;
                    _purok_family_member_id = spf._purok_family_member_id;
                    if (filtered != null && filtered.Count() > 0)
                    {
                        txtLastName.Text = filtered[0]["last_name"].ToString();
                        txtFirstName.Text = filtered[0]["first_name"].ToString();
                        txtExtension.Text = filtered[0]["name_ext"].ToString();
                        txtMiddleName.Text = filtered[0]["middle_name"].ToString();
                        dtDob.EditValue = Convert.ToDateTime(filtered[0]["formated_dob"].ToString());
                        txtAge.Text = filtered[0]["age"].ToString();
                        txtPlaceofBirth.Text = filtered[0]["place_of_birth"].ToString();
                        cbSex.Text = filtered[0]["sex"].ToString();
                        cbCivilStatus.Text = filtered[0]["civil_status"].ToString();
                        txtReligion.Text = filtered[0]["religion"].ToString();
                        txtContactNum.Text = filtered[0]["contact_no"].ToString();
                        txtPurok.Text = filtered[0]["purok"].ToString();
                        txtBarangay.Text = filtered[0]["barangay"].ToString();
                        txtMunicipality.Text = filtered[0]["municipality"].ToString();
                        txtProvince.Text = filtered[0]["province"].ToString();
                        txtCountry.Text = filtered[0]["country"].ToString();
                        txtZip.Text = filtered[0]["zip_code"].ToString();
                    }
                }
            }
        }

        private void bwEditPatient_DoWork(object sender, DoWorkEventArgs e)
        {
            PatientRecord.UpdatePatient(txtLastName.Text, txtFirstName.Text, txtExtension.Text, txtMiddleName.Text, txtMaidenLastName.Text, txtMaidenFirstName.Text, txtMaidenExtension.Text, txtMaidenMiddleName.Text, dtDob.Text, txtAge.Text, txtPlaceofBirth.Text, cbSex.Text, cbCivilStatus.Text, txtReligion.Text, txtBloodType.Text, txtContactNum.Text, txtPurok.Text, txtBarangay.Text, txtMunicipality.Text, txtProvince.Text, txtCountry.Text, txtZip.Text, txtEducAtt.Text, txtEmploymentStat.Text, txtTin.Text, rgPhicStat.Text, txtPhicNo.Text,rgPhicType.Text, is4p, txt4pIdNo.Text, rg4pType.Text, rgMembershipCat.Text, txtPartnerLastName.Text, txtPartnerFirstName.Text, txtPartnerExt.Text, txtPartnerMiddleName.Text, dtPartnerDob.Text, cbPartnerSex.Text, txtPartnerPhicId.Text, txtfatherLastname.Text, txtFatherFirstName.Text, txtFatherExt.Text, txtFatherMiddleName.Text, dtFatherDob.Text, txtFatherDisability.Text, txtfatherPhicid.Text, txtMotherLastName.Text, txtMotherFirstName.Text, txtMotherExt.Text, txtMotherMiddleName.Text, dtMotherDob.Text, txtMotherDisability.Text, txtMotherPhicID.Text, _purok_family_member_id, edit_id);
            bwEditPatient.CancelAsync();
        }

        private void bwEditPatient_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (PatientRecord.UpdatePatientIsSuccessful)
            {
                MsgBox.Information("Updating complete.");
                this.Close();
            }
            else
                MsgBox.Error(PatientRecord.UpdatePatientErrorMessage);
        }

        private void ceOverride_CheckedChanged(object sender, EventArgs e)
        {
            if (ceOverride.Checked)
            {
                MsgBox.QuestionYesNo("Are you sure you want to override details?");
                if (!MsgBox.isYes)
                {
                    ceOverride.Checked = false;
                    txtLastName.Properties.ReadOnly = true;
                    txtFirstName.Properties.ReadOnly = true;
                    txtMiddleName.Properties.ReadOnly = true;
                    txtExtension.Properties.ReadOnly = true;
                }
                else
                {
                    txtLastName.Properties.ReadOnly = false;
                    txtFirstName.Properties.ReadOnly = false;
                    txtMiddleName.Properties.ReadOnly = false;
                    txtExtension.Properties.ReadOnly = false;
                }
            }
        }
    }
}