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
using BarangayHealthAid.Reports;
using BarangayHealthAid.ReportForm;
using DevExpress.XtraReports.UI;


namespace BarangayHealthAid.ReportForm
{
    public partial class FamilyPlanningForm : DevExpress.XtraEditors.XtraForm
    {
        public FamilyPlanningForm()
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
                if (!gvFamilyRecords.IsGroupRow(gvFamilyRecords.FocusedRowHandle))
                {
                    if (gvFamilyRecords.SelectedRowsCount > 0)
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

        private void FamilyPlanningForm_Shown(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FamilyPlanningAddForm fpa = new FamilyPlanningAddForm();
            fpa.ShowDialog();
        }
    }
}