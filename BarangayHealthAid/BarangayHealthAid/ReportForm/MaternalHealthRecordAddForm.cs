using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BarangayHealthAid.ReportForm
{
    public partial class MaternalHealthRecordAddForm : DevExpress.XtraEditors.XtraForm
    {
        public MaternalHealthRecordAddForm()
        {
            InitializeComponent();
        }

        private void MaternalHealthRecordAddForm_Load(object sender, EventArgs e)
        {
            layoutControl1.AllowCustomization = false;
        }
    }
}