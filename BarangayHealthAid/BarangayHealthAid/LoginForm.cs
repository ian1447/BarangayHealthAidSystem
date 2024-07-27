using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BarangayHealthAid
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblConnSettings_Click(object sender, EventArgs e)
        {
            ConnectionSettingsForm csf = new ConnectionSettingsForm();
            csf.ShowDialog();
        }
    }
}