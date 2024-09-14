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
    public partial class PurokManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public PurokManagementForm()
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
                if (!gvPurok.IsGroupRow(gvPurok.FocusedRowHandle))
                {
                    if (gvPurok.SelectedRowsCount > 0)
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

        private bool SelectionPass2()
        {
            try
            {
                if (!gvPurokMember.IsGroupRow(gvPurokMember.FocusedRowHandle))
                {
                    if (gvPurokMember.SelectedRowsCount > 0)
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

        DataTable PurokTable = new DataTable();
        DataTable PurokMembersTable = new DataTable();

        private int purok_id,member_id;
        private string member_name,_purok_name;
        private void PurokManagementForm_Shown(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
            LoadPurok();
        }

        private void LoadPurok()
        {
            if (!bwGetPurok.IsBusy)
            {
                ShowLoading("Loading Purok...");
                bwGetPurok.RunWorkerAsync();
            }
        }

        private void GetRowDetails()
        {
            if (SelectionPass())
            {
                purok_id = Convert.ToInt32(gvPurok.GetFocusedRowCellValue("id").ToString());
                _purok_name = gvPurok.GetFocusedRowCellValue("purok_name").ToString();
            }
            else
                purok_id = 0;
        }

        private void GetRowDetailsMember()
        {
            if (SelectionPass2())
            {
                member_id = Convert.ToInt32(gvPurokMember.GetFocusedRowCellValue("id").ToString());
                member_name = gvPurokMember.GetFocusedRowCellValue("name").ToString();
            }
            else
                member_id = 0;
        }

        private void bwGetPurok_DoWork(object sender, DoWorkEventArgs e)
        {
            PurokTable = Purok.GetPurok();
            bwGetPurok.CancelAsync();
        }

        private void bwGetPurok_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.GetPurokIsSuccessful)
            {
                if (PurokTable.Rows.Count > 0)
                {
                    dtPurok.DataSource = PurokTable;
                    purok_id = Convert.ToInt32(PurokTable.Rows[0]["id"].ToString());
                    LoadMembers();
                }
            }
            else
                MsgBox.Error(Purok.GetPurokErrorMessage);
        }

        private void LoadMembers()
        {
            if (!bwGetPurokMember.IsBusy)
            {
                ShowLoading("Loading Memebers...");
                bwGetPurokMember.RunWorkerAsync();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PurokAddForm paf = new PurokAddForm();
            paf.ShowDialog();
            LoadPurok();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPurok();
        }

        private void gvPurok_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetRowDetails();
            LoadMembers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MsgBox.QuestionYesNo("Are you sure you want to edit this purok?");
            if (MsgBox.isYes)
            {
                GetRowDetails();
                PurokAddForm paf = new PurokAddForm();
                paf.purok_id = purok_id;
                paf.is_add = false;
                paf.txtPurokName.Text = _purok_name;
                paf.ShowDialog();
                LoadPurok();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MsgBox.QuestionYesNo("Are you sure you want to delete this purok?");
            if (MsgBox.isYes)
            {
                GetRowDetails();
                if (!bwDeletePurok.IsBusy)
                {
                    ShowLoading("Deleting Purok");
                    bwDeletePurok.RunWorkerAsync();
                }
            }
        }

        private void bwDeletePurok_DoWork(object sender, DoWorkEventArgs e)
        {
            Purok.DeletePurok(purok_id);
            bwDeletePurok.CancelAsync();
        }

        private void bwDeletePurok_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.DeletePurokIsSuccessful)
            {
                MsgBox.Information("Deletion Done...");
                LoadPurok();
            }
            else
                MsgBox.Error(Purok.DeletePurokErrorMessage);
        }

        private void bwGetPurokMember_DoWork(object sender, DoWorkEventArgs e)
        {
            PurokMembersTable = Purok.GetPurokMembers(purok_id);
            bwGetPurokMember.CancelAsync();
        }

        private void bwGetPurokMember_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.GetPurokMembersIsSuccessful)
            {
                if (PurokMembersTable.Rows.Count > 0)
                {
                    dtPurokMember.DataSource = PurokMembersTable;
                }
                else
                    dtPurokMember.DataSource = new DataTable();
            }
            else
                MsgBox.Error(Purok.GetPurokMembersErrorMessage);
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            PurokMemberAddForm pmaf = new PurokMemberAddForm();
            pmaf.purok_id = purok_id;
            pmaf.ShowDialog();
            LoadMembers();
        }

        private void gvPurokMember_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetRowDetailsMember();
        }

        private void bwDeletePurokMember_DoWork(object sender, DoWorkEventArgs e)
        {
            Purok.DeletePurokMember(member_id);
            bwDeletePurok.CancelAsync();
        }

        private void bwDeletePurokMember_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.DeletePurokMemberIsSuccessful)
            {
                MsgBox.Information("Member Deleted");
                LoadMembers();
            }
            else
                MsgBox.Error(Purok.DeletePurokMemberErrorMessage);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (SelectionPass2())
            {
                MsgBox.QuestionYesNo("Are you sure you want to delete this purok member?");
                if (MsgBox.isYes)
                {
                    GetRowDetailsMember();
                    if (!bwDeletePurokMember.IsBusy)
                    {
                        ShowLoading("Deleting Member");
                        bwDeletePurokMember.RunWorkerAsync();
                    }
                }
            }
            else
                MsgBox.Error("No Purok Member Selected.");
        }

        private void btnAddFamily_Click(object sender, EventArgs e)
        {
            if (SelectionPass2())
            {
                GetRowDetailsMember();
                PurokFamilyMembersForm pfm = new PurokFamilyMembersForm();
                pfm.purok_member_id = member_id;
                pfm.lblHeadName.Text = "Purok Member Name: " + member_name;
                pfm.ShowDialog();
            }
            else
                MsgBox.Error("No Purok Member Selected.");
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            if (SelectionPass2())
            {
                MsgBox.QuestionYesNo("Are you sure you want to edit this purok member?");
                if (MsgBox.isYes)
                {
                    GetRowDetailsMember();
                    PurokMemberAddForm pmaf = new PurokMemberAddForm();
                    pmaf.purok_member_id = member_id;
                    pmaf.is_add = false;
                    pmaf.txtName.Text = member_name;
                    pmaf.ShowDialog();
                    LoadMembers();
                }
            }
            else
                MsgBox.Error("No Purok Member Selected.");
        }
    }
}