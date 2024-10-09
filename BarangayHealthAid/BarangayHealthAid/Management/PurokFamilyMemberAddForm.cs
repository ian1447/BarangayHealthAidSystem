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

namespace BarangayHealthAid.Management
{
    public partial class PurokFamilyMemberAddForm : DevExpress.XtraEditors.XtraForm
    {
        public PurokFamilyMemberAddForm()
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

        #region validation

        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtNameExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        public int purok_member_id,edit_id;
        public bool is_add = true;
        public bool is_view = false;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtlastname.Text != "")
            {
                if (is_add)
                {
                    if (!bwAddFamilyMember.IsBusy)
                    {
                        ShowLoading("Adding Data...");
                        bwAddFamilyMember.RunWorkerAsync();
                    }
                }
                else
                {
                    if (!bwEditFamilyMember.IsBusy)
                    {
                        ShowLoading("Editing Data...");
                        bwEditFamilyMember.RunWorkerAsync();
                    }
                }
            }
            else
                MsgBox.Error("Please enter name.");
        }

        private void bwAddFamilyMember_DoWork(object sender, DoWorkEventArgs e)
        {
            Purok.AddPurokFamilyMember(purok_member_id,txtType.Text,txtlastname.Text,txtfirstname.Text,txtNameExt.Text, txtMiddleName.Text, dtDob.Text, txtAge.Text, txtPlaceofBirth.Text, cbSex.Text, cbCivilStatus.Text, txtReligion.Text, txtContact.Text, txtPurok.Text, txtBarangay.Text, txtMunicipality.Text, txtProvince.Text, txtCountry.Text, txtZip.Text);
            bwAddFamilyMember.CancelAsync();
        }

        private void bwAddFamilyMember_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.AddPurokFamilyMemberIsSuccessful)
            {
                MsgBox.Information("Adding family member complete.");
                this.Close();
            }
            else
                MsgBox.Error(Purok.AddPurokFamilyMemberErrorMessage);
        }

        private void bwEditFamilyMember_DoWork(object sender, DoWorkEventArgs e)
        {
            Purok.EditPurokFamilyMember(edit_id,txtType.Text,txtlastname.Text,txtfirstname.Text,txtNameExt.Text, txtMiddleName.Text, dtDob.Text, txtAge.Text, txtPlaceofBirth.Text, cbSex.Text, cbCivilStatus.Text, txtReligion.Text, txtContact.Text, txtPurok.Text, txtBarangay.Text, txtMunicipality.Text, txtProvince.Text, txtCountry.Text, txtZip.Text);
            bwEditFamilyMember.CancelAsync();
        }

        private void bwEditFamilyMember_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.EditPurokFamilyMemberIsSuccessful)
            {
                MsgBox.Information("Editing family member complete.");
                this.Close();
            }
            else
                MsgBox.Error(Purok.EditPurokFamilyMemberErrorMessage);
        }

        private void dtDob_EditValueChanged(object sender, EventArgs e)
        {
            int year_age = (DateTime.Now.Year - dtDob.DateTime.Year);
            if (DateTime.Now < dtDob.DateTime.AddYears(year_age))
                year_age--;

            txtAge.Text = year_age.ToString();
        }

        private void PurokFamilyMemberAddForm_Load(object sender, EventArgs e)
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
            }
            btnSave.Enabled = false;
            lciSave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            btnCancel.Text = "Close";
        }

    }
}