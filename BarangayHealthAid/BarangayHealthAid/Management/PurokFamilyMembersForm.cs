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
using BarangayHealthAid.Management;

namespace BarangayHealthAid.Management
{
    public partial class PurokFamilyMembersForm : DevExpress.XtraEditors.XtraForm
    {
        public PurokFamilyMembersForm()
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
                if (!gvMembers.IsGroupRow(gvMembers.FocusedRowHandle))
                {
                    if (gvMembers.SelectedRowsCount > 0)
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

        public int purok_member_id;
        DataTable PurokFamilyMembers = new DataTable();
        private int selected_id;

        private void PurokFamilyMembersForm_Load(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
        }

        private void PurokFamilyMembersForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetPurokFamilyMembers.IsBusy)
            {
                ShowLoading("Loading Data...");
                bwGetPurokFamilyMembers.RunWorkerAsync();
            }
        }

        private void bwGetPurokFamilyMembers_DoWork(object sender, DoWorkEventArgs e)
        {
            PurokFamilyMembers = Purok.GetPurokFamilyMembers(purok_member_id);
            bwGetPurokFamilyMembers.CancelAsync();
        }

        private void bwGetPurokFamilyMembers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.GetPurokFamilyMembersIsSuccessful)
            {
                dtMembers.DataSource = PurokFamilyMembers.Rows.Count > 0 ? PurokFamilyMembers : new DataTable();
            }
            else
                MsgBox.Error(Purok.GetPurokFamilyMembersErrorMessage);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PurokFamilyMemberAddForm pfma = new PurokFamilyMemberAddForm();
            pfma.purok_member_id = purok_member_id;
            pfma.ShowDialog();
            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                selected_id = Convert.ToInt32(gvMembers.GetFocusedRowCellValue("id").ToString());
                if (!bwDeletePurokFamilyMember.IsBusy)
                {
                    ShowLoading("Deleting Family Member.");
                    bwDeletePurokFamilyMember.RunWorkerAsync();
                }
            }
            else
                MsgBox.Error("No member selected.");
        }

        private void bwDeletePurokFamilyMember_DoWork(object sender, DoWorkEventArgs e)
        {
            Purok.DeletePurokFamilyMember(selected_id);
            bwDeletePurokFamilyMember.CancelAsync();
        }

        private void bwDeletePurokFamilyMember_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.DeletePurokFamilyMemberIsSuccessful)
            {
                MsgBox.Information("Family Member Deleted.");
                LoadData();
            }
            else
                MsgBox.Error(Purok.DeletePurokFamilyMemberErrorMessage);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                selected_id = Convert.ToInt32(gvMembers.GetFocusedRowCellValue("id").ToString());
                DataRow[] filtered = PurokFamilyMembers.Select(String.Format("id = {0}", selected_id));
                PurokFamilyMemberAddForm pfma = new PurokFamilyMemberAddForm();
                pfma.purok_member_id = purok_member_id;
                pfma.is_add = false;
                pfma.txtType.Text = gvMembers.GetFocusedRowCellValue("description").ToString();
                pfma.txtAge.Text = gvMembers.GetFocusedRowCellValue("age").ToString();
                pfma.cbSex.Text = gvMembers.GetFocusedRowCellValue("sex").ToString();
                try
                {
                    pfma.dtDob.EditValue = Convert.ToDateTime(gvMembers.GetFocusedRowCellValue("formated_dob").ToString());
                }
                catch
                {
                }
                pfma.txtlastname.Text = filtered[0]["last_name"].ToString();
                pfma.txtfirstname.Text = filtered[0]["first_name"].ToString();
                pfma.txtNameExt.Text = filtered[0]["name_ext"].ToString();
                pfma.txtMiddleName.Text = filtered[0]["middle_name"].ToString();
                pfma.txtPlaceofBirth.Text = filtered[0]["place_of_birth"].ToString();
                pfma.cbCivilStatus.Text = filtered[0]["civil_status"].ToString();
                pfma.txtReligion.Text = filtered[0]["religion"].ToString();
                pfma.txtContact.Text = filtered[0]["contact_no"].ToString();
                pfma.txtPurok.Text = filtered[0]["purok"].ToString();
                pfma.txtBarangay.Text = filtered[0]["barangay"].ToString();
                pfma.txtMunicipality.Text = filtered[0]["municipality"].ToString();
                pfma.txtProvince.Text = filtered[0]["province"].ToString();
                pfma.txtCountry.Text = filtered[0]["country"].ToString();
                pfma.txtZip.Text = filtered[0]["zip_code"].ToString();
                pfma.edit_id = selected_id;
                pfma.ShowDialog();
                LoadData();
            }
            else
                MsgBox.Error("No member selected.");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                selected_id = Convert.ToInt32(gvMembers.GetFocusedRowCellValue("id").ToString());
                DataRow[] filtered = PurokFamilyMembers.Select(String.Format("id = {0}", selected_id));
                PurokFamilyMemberAddForm pfma = new PurokFamilyMemberAddForm();
                pfma.purok_member_id = purok_member_id;
                pfma.is_add = false;
                pfma.txtType.Text = gvMembers.GetFocusedRowCellValue("description").ToString();
                pfma.txtAge.Text = gvMembers.GetFocusedRowCellValue("age").ToString();
                pfma.cbSex.Text = gvMembers.GetFocusedRowCellValue("sex").ToString();
                try
                {
                    pfma.dtDob.EditValue = Convert.ToDateTime(gvMembers.GetFocusedRowCellValue("formated_dob").ToString());
                }
                catch
                {
                }
                pfma.txtlastname.Text = filtered[0]["last_name"].ToString();
                pfma.txtfirstname.Text = filtered[0]["first_name"].ToString();
                pfma.txtNameExt.Text = filtered[0]["name_ext"].ToString();
                pfma.txtMiddleName.Text = filtered[0]["middle_name"].ToString();
                pfma.txtPlaceofBirth.Text = filtered[0]["place_of_birth"].ToString();
                pfma.cbCivilStatus.Text = filtered[0]["civil_status"].ToString();
                pfma.txtReligion.Text = filtered[0]["religion"].ToString();
                pfma.txtContact.Text = filtered[0]["contact_no"].ToString();
                pfma.txtPurok.Text = filtered[0]["purok"].ToString();
                pfma.txtBarangay.Text = filtered[0]["barangay"].ToString();
                pfma.txtMunicipality.Text = filtered[0]["municipality"].ToString();
                pfma.txtProvince.Text = filtered[0]["province"].ToString();
                pfma.txtCountry.Text = filtered[0]["country"].ToString();
                pfma.txtZip.Text = filtered[0]["zip_code"].ToString();
                pfma.edit_id = selected_id;
                pfma.is_view = true;
                pfma.ShowDialog();
            }
            else
                MsgBox.Error("No member selected.");
        
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                selected_id = Convert.ToInt32(gvMembers.GetFocusedRowCellValue("id").ToString());
                if (!bwDeactivateMember.IsBusy)
                {
                    ShowLoading("Updating Member status...");
                    bwDeactivateMember.RunWorkerAsync();
                }
            }
        }

        private void bwDeactivateMember_DoWork(object sender, DoWorkEventArgs e)
        {
            Purok.DeactFamilyMember(selected_id);
            bwDeactivateMember.CancelAsync();
        }

        private void bwDeactivateMember_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.DeactFamilyMemberIsSuccessful)
            {
                MsgBox.Information("Updating status done.");
                btnRefresh.PerformClick();
            }
            else
                MsgBox.Error(Purok.DeactFamilyMemberErrorMessage);
        }

        private void gvMembers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (SelectionPass())
            {
                btnDeactivate.Text = gvMembers.GetFocusedRowCellValue("is_active").ToString() == "True" ? "Deactivate" : "Activate";
            }
        }
      
    }
}