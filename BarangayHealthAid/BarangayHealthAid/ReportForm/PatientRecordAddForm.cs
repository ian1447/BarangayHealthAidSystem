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

namespace BarangayHealthAid.ReportForm
{
    public partial class PatientRecordAddForm : DevExpress.XtraEditors.XtraForm
    {
        public PatientRecordAddForm()
        {
            InitializeComponent();
        }

        private void PatientRecordAddForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MsgBox.QuestionYesNo("Are you sure you want to cancel creation of Profile? \n Details inputed will not be saved.");
            if (MsgBox.isYes)
                this.Close();
        }
    }
}