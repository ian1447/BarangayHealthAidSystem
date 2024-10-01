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

        public int purok_member_id,edit_id;
        public bool is_add = true;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
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
            Purok.AddPurokFamilyMember(purok_member_id, txtName.Text,txtType.Text,dtDob.Text,txtAge.Text,cbSex.Text);
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
            Purok.EditPurokFamilyMember(edit_id, txtName.Text, txtType.Text, dtDob.Text, txtAge.Text, cbSex.Text);
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
    }
}