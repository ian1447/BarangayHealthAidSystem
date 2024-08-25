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

namespace BarangayHealthAid.Backend
{
    public partial class UserManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public UserManagementForm()
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
                if (!gvUsers.IsGroupRow(gvUsers.FocusedRowHandle))
                {
                    if (gvUsers.SelectedRowsCount > 0)
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

        DataTable UsersTable = new DataTable();
        private int user_id;
        private bool is_edit = false;
        private void UserManagementForm_Shown(object sender, EventArgs e)
        {
            lgcDetails.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetUsers.IsBusy)
            {
                ShowLoading("Loading Users");
                bwGetUsers.RunWorkerAsync();
            }
        }

        private void bwGetUsers_DoWork(object sender, DoWorkEventArgs e)
        {
            UsersTable = Users.GetUsers();
            bwGetUsers.CancelAsync();
        }

        private void bwGetUsers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.GetUsersIsSuccessful)
            {
                dtUsers.DataSource = UsersTable;
            }
            else
                MsgBox.Error(Users.GetUsersErrorMessage);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            is_edit = false;
            lgcDetails.Enabled = true;
            lgcUsers.Enabled = false; 
            ResetTextFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFields();
            if (is_edit)
            {
                lcChangePass.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                txtPassword.Enabled = true;
                ceShowPass.Enabled = true;
            }
        }

        private void ResetFields()
        {
            lgcUsers.Enabled = true;
            lgcDetails.Enabled = false;
            ResetTextFields();
        }

        private void ResetTextFields()
        {
            txtFirstName.Text = "";
            txtLast.Text = "";
            txtMiddle.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            ceShowPass.Checked = false;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (!is_edit)
            {
                if (!bwAddUsers.IsBusy)
                {
                    ShowLoading("Loading Data...");
                    bwAddUsers.RunWorkerAsync();
                }
            }
            else
            {
                if (!bwEditUser.IsBusy)
                {
                    ShowLoading("Editing Users...");
                    bwEditUser.RunWorkerAsync();
                }
            }
        }

        private void bwAddUsers_DoWork(object sender, DoWorkEventArgs e)
        {
            Users.AddUser(txtUsername.Text,txtPassword.Text,txtFirstName.Text,txtMiddle.Text,txtLast.Text);
            bwAddUsers.CancelAsync();
        }

        private void bwAddUsers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.AddUserIsSuccessful)
            {
                MsgBox.Information("Users added succesfully.");
                ResetFields();
                btnRefresh.PerformClick();
            }
            else
                MsgBox.Error(Users.AddUserErrorMessage);
        }

        private void gvUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetRowDetails();
        }

        private void GetRowDetails()
        {
            if (SelectionPass())
            {
                user_id = Convert.ToInt32(gvUsers.GetFocusedRowCellValue("id").ToString());
                txtFirstName.Text = gvUsers.GetFocusedRowCellValue("firstname").ToString();
                txtMiddle.Text = gvUsers.GetFocusedRowCellValue("middlename").ToString();
                txtLast.Text = gvUsers.GetFocusedRowCellValue("lastname").ToString();
                txtUsername.Text = gvUsers.GetFocusedRowCellValue("username").ToString();
                btnDeactivate.ToolTip = gvUsers.GetFocusedRowCellValue("is_active").ToString() == "True" ? "Deactivate User" : "Activate User";
                tsbtnDeactivate.Caption = gvUsers.GetFocusedRowCellValue("is_active").ToString() == "True" ? "Deactivate User" : "Activate User";
            }
            else
                user_id = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GetRowDetails();
            if (user_id != 0)
            {
                is_edit = true;
                txtPassword.Enabled = false;
                lgcDetails.Enabled = true;
                lgcUsers.Enabled = false;
                lcChangePass.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                ceChangePass.Checked = false;
                txtPassword.Enabled = ceChangePass.Checked ? true : false;
                ceShowPass.Enabled = ceChangePass.Checked ? true : false;
                ceShowPass.Checked = false;
            }
        }

        private void bwEditUser_DoWork(object sender, DoWorkEventArgs e)
        {
            Users.EditUser(txtUsername.Text, txtPassword.Text, txtFirstName.Text, txtMiddle.Text, txtLast.Text, user_id);
            bwEditUser.CancelAsync();
        }

        private void bwEditUser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.EditUserIsSuccessful)
            {
                MsgBox.Information("Editing User success.");
                lcChangePass.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                ResetFields();
                btnRefresh.PerformClick();
            }
            else
                MsgBox.Error(Users.EditUserErrorMessage);
        }

        private void ceChangePass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = ceChangePass.Checked? true: false;
            ceShowPass.Enabled = ceChangePass.Checked ? true : false;
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            GetRowDetails();
            if (user_id != 0)
            {
                MsgBox.QuestionWarning("Are you sure you want to " + btnDeactivate.ToolTip.ToString() + " " + txtUsername.Text);
                if (MsgBox.isYes)
                {
                    if (!bwDeactivate.IsBusy)
                    {
                        ShowLoading(btnDeactivate.ToolTip == "Deactivate User" ? "Deactivate " : "Activate ");
                        bwDeactivate.RunWorkerAsync();
                    }
                }
            }
            else
                MsgBox.Error("Please select a user to " + btnDeactivate.ToolTip == "Deactivate User" ? "Deactivate.":"Activate.");
        }

        private void bwDeactivate_DoWork(object sender, DoWorkEventArgs e)
        {
            Users.DeactivateUser(user_id);
            bwDeactivate.CancelAsync();
        }

        private void bwDeactivate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.DeactivateUserIsSuccessful)
            {
                MsgBox.Information(btnDeactivate.ToolTip == "Deactivate User" ? "Deactivation Finished." : "Activation Finished.");
                btnRefresh.PerformClick();
            }
            else
                MsgBox.Error(Users.DeactivateUserErrorMessage);
        }

        private void ceShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Properties.PasswordChar = ceShowPass.Checked ? '\0' : '*';
        }

        private void dtUsers_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var rowH = gvUsers.FocusedRowHandle;
                    var focusRowView = (DataRowView)gvUsers.GetFocusedRow();
                    popupMenuUser.ShowPopup(barManagerUser, new Point(MousePosition.X, MousePosition.Y));
                }
            }
            catch { }
        }

        private void tsbtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void tsbtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void tsbtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void tsbtnDeactivate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDeactivate.PerformClick();
        }


    }
}