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
                PurokFamilyMemberAddForm pfma = new PurokFamilyMemberAddForm();
                pfma.purok_member_id = purok_member_id;
                pfma.is_add = false;
                pfma.cbType.Text = gvMembers.GetFocusedRowCellValue("description").ToString();
                pfma.txtAge.Text = gvMembers.GetFocusedRowCellValue("age").ToString();
                pfma.cbSex.Text = gvMembers.GetFocusedRowCellValue("sex").ToString();
                try
                {
                    pfma.dtDob.EditValue = Convert.ToDateTime(gvMembers.GetFocusedRowCellValue("formated_dob").ToString());
                }
                catch
                {
                }
                pfma.txtName.Text = gvMembers.GetFocusedRowCellValue("name").ToString();
                pfma.edit_id = selected_id;
                pfma.ShowDialog();
                LoadData();
            }
            else
                MsgBox.Error("No member selected.");
        }
      
    }
}