using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BarangayHealthAid.Core;
using BarangayHealthAid.Dal;
using BarangayHealthAid.Reports;
using DevExpress.XtraReports.UI;
using BarangayHealthAid.Backend;
using BarangayHealthAid.Management;
using BarangayHealthAid.ReportForm;

namespace BarangayHealthAid
{
    public partial class Mainform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnFamilyPlanning_ItemClick(object sender, ItemClickEventArgs e)
        {
            FamilyPlanningForm fpf = new FamilyPlanningForm();
            fpf.ShowPreviewDialog();
        }

        private void btnForm4b_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form4B f4b = new Form4B();
            f4b.ShowPreviewDialog();
        }

        private void btnMaternalHealth_ItemClick(object sender, ItemClickEventArgs e)
        {
            MaternalHealthRecord mhr = new MaternalHealthRecord();
            mhr.ShowPreviewDialog();
        }

        public static bool PatientRecordFormIsOpen = false;
        private void btnClinicalRecord_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!PatientRecordFormIsOpen)
            {
                PatientRecordFormIsOpen = true;
                PatientRecordForm ppf = new PatientRecordForm();
                ppf.MdiParent = this;
                ppf.WindowState = FormWindowState.Maximized;
                ppf.Show();
            }
            else
            {
                Form fc = Application.OpenForms["PatientRecordForm"];
                if (fc == null)
                {
                    PatientRecordForm a1 = new PatientRecordForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }

        private void btnUserManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserManagementForm umf = new UserManagementForm();
            umf.ShowDialog();
        }

        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public static bool PurokManagementFormIsOpen = false;
        private void btnPurok_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!PurokManagementFormIsOpen)
            {
                PurokManagementFormIsOpen = true;
                PurokManagementForm pmf = new PurokManagementForm();
                pmf.MdiParent = this;
                pmf.WindowState = FormWindowState.Maximized;
                pmf.Show();
            }
            else
            {
                Form fc = Application.OpenForms["PurokManagementForm"];
                if (fc == null)
                {
                    PurokManagementForm a1 = new PurokManagementForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }
    }
}