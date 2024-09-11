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
    public partial class PurokMemberAddForm : DevExpress.XtraEditors.XtraForm
    {
        public PurokMemberAddForm()
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

        public int purok_id,purok_member_id;
        public bool is_add = true;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (is_add)
                {
                    if (!bwAddPurokMember.IsBusy)
                    {
                        ShowLoading("Adding Member...");
                        bwAddPurokMember.RunWorkerAsync();
                    }
                }
                else
                {
                    if (!bwEditPurokMember.IsBusy)
                    {
                        ShowLoading("Editing Member...");
                        bwEditPurokMember.RunWorkerAsync();
                    }
                }
            }
            else
                MsgBox.Warning("Please enter name.");
        }

        private void bwAddPurokMember_DoWork(object sender, DoWorkEventArgs e)
        {
            Purok.AddPurokMember(purok_id, txtName.Text);
            bwAddPurokMember.CancelAsync();
        }

        private void bwAddPurokMember_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.AddPurokMemberIsSuccessful)
            {
                MsgBox.Information("Adding Done.");
                this.Close();
            }
            else
                MsgBox.Error(Purok.AddPurokMemberErrorMessage);
        }

        private void bwEditPurokMember_DoWork(object sender, DoWorkEventArgs e)
        {
            Purok.EditPurokMember(purok_member_id,txtName.Text);
            bwEditPurokMember.CancelAsync();
        }

        private void bwEditPurokMember_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Purok.EditPurokMemberIsSuccessful)
            {
                MsgBox.Information("Editing complete.");
                this.Close();
            }
            else
                MsgBox.Error(Purok.EditPurokMemberErrorMessage);
        }

    }
}