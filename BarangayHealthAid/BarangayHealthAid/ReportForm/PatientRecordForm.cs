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
    public partial class PatientRecordForm : DevExpress.XtraEditors.XtraForm
    {
        public PatientRecordForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PatientClinicalRecord pcr = new PatientClinicalRecord();
            pcr.ShowPreviewDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PatientRecordAddForm pcaf = new PatientRecordAddForm();
            pcaf.ShowDialog();
        }
    }
}