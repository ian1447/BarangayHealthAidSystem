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
    public partial class FamilyPlanningAddForm : DevExpress.XtraEditors.XtraForm
    {
        public FamilyPlanningAddForm()
        {
            InitializeComponent();
        }

        private void rgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            rgSub.Enabled = rgType.SelectedIndex == 1 ? true: false;
            rgFpReason.Enabled = rgType.SelectedIndex == 0 ? true : false;
        }

        private void rgFpReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOthers.Enabled = rgFpReason.SelectedIndex == 2 ? true : false;
        }

        private void rgCMReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtChangeMethodOthers.Enabled = rgCMReason.SelectedIndex == 1 ? true : false;
        }

        private void rgSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            rgCMReason.Enabled = rgSub.SelectedIndex == 0 ? true : false;
            rgCurMeth.Enabled = rgSub.SelectedIndex == 0 ? true : false;
        }

        private void rgSub_EnabledChanged(object sender, EventArgs e)
        {
            if (!rgSub.Enabled)
                rgSub.SelectedIndex = -1;
        }

        private void rgFpReason_EnabledChanged(object sender, EventArgs e)
        {
            if (!rgFpReason.Enabled)
                rgFpReason.SelectedIndex = -1;
        }

        private void rgCMReason_EnabledChanged(object sender, EventArgs e)
        {
            if (!rgCMReason.Enabled)
                rgCMReason.SelectedIndex = -1;
        }

        private void txtOthers_EnabledChanged(object sender, EventArgs e)
        {
            if (!txtOthers.Enabled)
                txtOthers.Text = "";
        }

        private void txtChangeMethodOthers_EnabledChanged(object sender, EventArgs e)
        {
            if (!txtChangeMethodOthers.Enabled)
                txtChangeMethodOthers.Text = "";
        }

        private void rgCurMeth_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCurMeth.Enabled = rgCurMeth.SelectedIndex == 12 ? true : false;
        }

        private void txtCurMeth_EnabledChanged(object sender, EventArgs e)
        {
            if (!txtCurMeth.Enabled)
                txtCurMeth.Text = "";
        }

        private void rgCurMeth_EnabledChanged(object sender, EventArgs e)
        {
            if (!rgCurMeth.Enabled)
                rgCurMeth.SelectedIndex = -1;
        }
    }
}