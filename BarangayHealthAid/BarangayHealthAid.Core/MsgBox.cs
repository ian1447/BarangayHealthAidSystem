using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace BarangayHealthAid.Core
{
    public class MsgBox
    {
        public static void Error(string message)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(message, PublicVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Warning(string message)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(message, PublicVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Information(string message)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(message, PublicVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //no icon
        public static void Show(string message)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(message, PublicVariables.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public static bool isYes = false;
        public static void QuestionYesNo(string message)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show(message, PublicVariables.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                isYes = true;
            else
                isYes = false;
        }
        public static void QuestionWarning(string message)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show(message, PublicVariables.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                isYes = true;
            else
                isYes = false;
        }

        public static bool isOk = false;
        public static void QuestionOkCancel(string message)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show(message, PublicVariables.ProjectName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                isOk = true;
            else
                isOk = false;
        }
    }
}
