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
    public partial class SelectPurokFamilyMemberForm : DevExpress.XtraEditors.XtraForm
    {
        public SelectPurokFamilyMemberForm()
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
                if (!gvPatients.IsGroupRow(gvPatients.FocusedRowHandle))
                {
                    if (gvPatients.SelectedRowsCount > 0)
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

        DataTable PurokFamilyMembers = new DataTable();
        public DataRow[] filtered;
        public int _purok_family_member_id;
        private void SelectPurokFamilyMemberForm_Shown(object sender, EventArgs e)
        {
            if (!bwGetPurokMembers.IsBusy)
            {
                ShowLoading("Loading members");
                bwGetPurokMembers.RunWorkerAsync();
            }
        }

        private void bwGetPurokMembers_DoWork(object sender, DoWorkEventArgs e)
        {
            PurokFamilyMembers = Purok.GetAllPurokMembers();
            bwGetPurokMembers.CancelAsync();
        }

        private void bwGetPurokMembers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.GetAllPurokMembersIsSuccessful)
            {
                dtPatients.DataSource = PurokFamilyMembers.Rows.Count > 0 ? PurokFamilyMembers : new DataTable();
            }
            else
                MsgBox.Error(Purok.GetAllPurokMembersErrorMessage);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                _purok_family_member_id = Convert.ToInt32(gvPatients.GetFocusedRowCellValue("id").ToString());
                filtered = PurokFamilyMembers.Select(String.Format("id = {0}", _purok_family_member_id));
                this.Close();
            }
            else
                MsgBox.Warning("No selected patient.");
        }

        private void gvPatients_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lblName.Text =SelectionPass() ? "Name: " + gvPatients.GetFocusedRowCellValue("name").ToString(): "Name: ";
        }
    }
}