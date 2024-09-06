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
        private void PatientRecordAddForm_Load(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MsgBox.QuestionYesNo("Are you sure you want to cancel creation of Profile?\nDetails inputed will not be saved.");
            if (MsgBox.isYes)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!bwAddPatient.IsBusy)
                {
                    ShowLoading("Adding Data...");
                    bwAddPatient.RunWorkerAsync();
                }
            }
        }

        private void bwAddPatient_DoWork(object sender, DoWorkEventArgs e)
        {
            PatientRecord.AddPatient(txtLastName.Text, txtFirstName.Text, txtExtension.Text, txtMiddleName.Text, txtMaidenLastName.Text, txtMaidenFirstName.Text, txtMaidenExtension.Text, txtMaidenMiddleName.Text, dtDob.Text, txtAge.Text, txtPlaceofBirth.Text, cbSex.Text, cbCivilStatus.Text, txtReligion.Text, txtBloodType.Text, txtContactNum.Text, txtPurok.Text, txtBarangay.Text, txtMunicipality.Text, txtProvince.Text, txtCountry.Text, txtZip.Text, txtEducAtt.Text, txtEmploymentStat.Text, txtTin.Text, rgPhicType.Text, txtPhicNo.Text, rgPhicStat.Text, is4p, txt4pIdNo.Text, rg4pType.Text, rgMembershipCat.Text, txtPartnerLastName.Text, txtPartnerFirstName.Text, txtPartnerExt.Text, txtPartnerMiddleName.Text, dtPartnerDob.Text, cbPartnerSex.Text, txtPartnerPhicId.Text, txtfatherLastname.Text, txtFatherFirstName.Text, txtFatherExt.Text, txtFatherMiddleName.Text, dtFatherDob.Text, txtFatherDisability.Text, txtfatherPhicid.Text, txtMotherLastName.Text, txtMotherFirstName.Text, txtMotherExt.Text, txtMotherMiddleName.Text, dtMotherDob.Text, txtMotherDisability.Text, txtMotherPhicID.Text);
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

        #region validation
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            { 
                e.Cancel = true;
                errorProvider.SetError(txtLastName, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtLastName, null);
                e.Cancel = false;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtFirstName, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtFirstName, null);
                e.Cancel = false;
            }
        }

        private void dtDob_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtDob.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(dtDob, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(dtDob, null);
                e.Cancel = false;
            }
        }

        private void cbSex_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbSex.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cbSex, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(cbSex, null);
                e.Cancel = false;
            }
        }

        private void cbCivilStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbCivilStatus.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cbCivilStatus, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(cbCivilStatus, null);
                e.Cancel = false;
            }
        }

        private void txtReligion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtReligion.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtReligion, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtReligion, null);
                e.Cancel = false;
            }
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAge, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtAge, null);
                e.Cancel = false;
            }
        }

        private void txtPlaceofBirth_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlaceofBirth.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPlaceofBirth, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtPlaceofBirth, null);
                e.Cancel = false;
            }
        }

        private void txtBloodType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBloodType.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBloodType, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtBloodType, null);
                e.Cancel = false;
            }
        }

        private void txtContactNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtContactNum.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtContactNum, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtContactNum, null);
                e.Cancel = false;
            }
        }

        private void txtEmploymentStat_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmploymentStat.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmploymentStat, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtEmploymentStat, null);
                e.Cancel = false;
            }
        }

        private void txtPurok_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPurok.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPurok, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtPurok, null);
                e.Cancel = false;
            }
        }

        private void txtBarangay_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarangay.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBarangay, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtBarangay, null);
                e.Cancel = false;
            }
        }

        private void txtMunicipality_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMunicipality.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMunicipality, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtMunicipality, null);
                e.Cancel = false;
            }
        }

        private void txtProvince_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtProvince.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtProvince, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtProvince, null);
                e.Cancel = false;
            }
        }

        private void txtCountry_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCountry.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCountry, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtCountry, null);
                e.Cancel = false;
            }
        }

        private void txtZip_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtZip.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtZip, "Please fill up.");
            }
            else
            {
                errorProvider.SetError(txtZip, null);
                e.Cancel = false;
            }
        }

        #endregion

        private void ce4p_CheckedChanged(object sender, EventArgs e)
        {
            is4p = ce4p.Checked ? 1 : 0; 
        }
    }
}