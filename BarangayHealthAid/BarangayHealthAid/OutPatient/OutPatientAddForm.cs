﻿using System;
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

namespace BarangayHealthAid.OutPatient
{
    public partial class OutPatientAddForm : DevExpress.XtraEditors.XtraForm
    {
        public OutPatientAddForm()
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

        public bool isAdd = true;
        public string _edit_id;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MsgBox.QuestionYesNo("Are you sure you want to close this form?\nDetails won't be saved as drafts.");
            if (MsgBox.isYes)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAge.Text == "" || txtChildName.Text == "" || txtHeight.Text == "" || txtNutStat.Text == "" || txtPurok.Text == "" || txtWeight.Text == "" || dtDob.Text == "")
                MsgBox.Warning("Please Fill up Form.");
            else
            {
                if (isAdd)
                {
                    if (!bwAddOutPatient.IsBusy)
                    {
                        ShowLoading("Adding Data...");
                        bwAddOutPatient.RunWorkerAsync();
                    }
                }
                else
                {
                    if (!bwEditOutPatient.IsBusy)
                    {
                        ShowLoading("Editing Data...");
                        bwEditOutPatient.RunWorkerAsync();
                    }
                }
            }
        }

        private void bwAddOutPatient_DoWork(object sender, DoWorkEventArgs e)
        {
            OPT.OutPatientAdd(txtPurok.Text,0, txtChildName.Text,"Child",dtDob.Text,txtAge.Text,txtHeight.Text,txtWeight.Text,txtNutStat.Text,txtRemarks.Text);
            bwAddOutPatient.CancelAsync();
        }

        private void bwAddOutPatient_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (OPT.OutPatientAddIsSuccessful)
            {
                MsgBox.Information("Adding Completed...");
                this.Close();
            }
            else
                MsgBox.Error(OPT.GetOutPatientRecordsErrorMessage);
        }

        private void bwEditOutPatient_DoWork(object sender, DoWorkEventArgs e)
        {
            OPT.OutPatientEdit(txtPurok.Text,0, txtChildName.Text,"Child",dtDob.Text, txtAge.Text, txtHeight.Text, txtWeight.Text, txtNutStat.Text, txtRemarks.Text, _edit_id);
            bwEditOutPatient.CancelAsync();
        }

        private void bwEditOutPatient_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (OPT.OutPatientEditIsSuccessful)
            {
                MsgBox.Information("Data successfully Edited.");
                this.Close();
            }
            else
                MsgBox.Error(OPT.OutPatientEditErrorMessage);
        }

        private void dtDob_EditValueChanged(object sender, EventArgs e)
        {
            int year_age = (DateTime.Now.Year - dtDob.DateTime.Year);
            int month_age = (DateTime.Now.Month - dtDob.DateTime.Month);

            txtAge.Text = month_age.ToString();
        }

        private void txtChildName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
    }
}