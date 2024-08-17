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

        private void btnClinicalRecord_ItemClick(object sender, ItemClickEventArgs e)
        {
            PatientClinicalRecord pcr = new PatientClinicalRecord();
            pcr.ShowPreviewDialog();
        }
    }
}