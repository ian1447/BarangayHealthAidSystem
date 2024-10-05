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

namespace BarangayHealthAid.OutPatient
{
    public partial class OutPatientAddForm2 : DevExpress.XtraEditors.XtraForm
    {
        public OutPatientAddForm2()
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

        public string patient_type;
        private int patient_id;
        public bool isAdd = true;
        private void txtPatient_Click(object sender, EventArgs e)
        {
            SelectPatientForm spf = new SelectPatientForm();
            spf.patient_type = patient_type;
            spf.ShowDialog();
            txtPatient.Text = spf.patient_name;
            patient_id = spf.patient_id;
            txtWeight.Text = spf.patient_weight;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNutStat.Text == "" || txtPurok.Text == "" || txtPatient.Text == "" || txtNutStat.Text == "" || txtPurok.Text == "" || txtWeight.Text == "")
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
                    //if (!bwEditOutPatient.IsBusy)
                    //{
                    //    ShowLoading("Editing Data...");
                    //    bwEditOutPatient.RunWorkerAsync();
                    //}
                }
            }
        }

        private void bwAddOutPatient_DoWork(object sender, DoWorkEventArgs e)
        {
            OPT.OutPatientAdd(txtPurok.Text, patient_id, "", patient_type, "", "0","0", txtWeight.Text, txtNutStat.Text, meRemarks.Text);
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
                MsgBox.Error(OPT.OutPatientAddErrorMessage);
        }
    }
}