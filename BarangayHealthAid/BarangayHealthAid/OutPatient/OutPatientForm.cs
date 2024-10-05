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
using DevExpress.XtraGrid.Columns;

namespace BarangayHealthAid.OutPatient
{
    public partial class OutPatientForm : DevExpress.XtraEditors.XtraForm
    {
        public OutPatientForm()
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
                if (!gvOutPatient.IsGroupRow(gvOutPatient.FocusedRowHandle))
                {
                    if (gvOutPatient.SelectedRowsCount > 0)
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

        DataTable OutPatientTable = new DataTable();
        DataTable dataPeriod = new DataTable();
        DateTime dateFrom = new DateTime();
        DateTime dateTo = new DateTime();
        private void OutPatientForm_Shown(object sender, EventArgs e)
        {
            dataPeriod.Columns.Add("Period", typeof(string));
            dataPeriod.Rows.Add("Today's Record");
            dataPeriod.Rows.Add("This Week's Record");
            dataPeriod.Rows.Add("This Month's Record");
            dataPeriod.Rows.Add("All Records");
            dataPeriod.Rows.Add("Pick a date..");
            cmbdateperiod.Properties.DataSource = dataPeriod;
            cmbdateperiod.Properties.DisplayMember = "Period";
            cmbdateperiod.Properties.ValueMember = "Period";
            cmbdateperiod.EditValue = "Today's Record";
            pnlDates.Location = new Point(
               this.ClientSize.Width / 2 - pnlDates.Size.Width / 2,
               this.ClientSize.Height / 5 - pnlDates.Size.Height / 2);
            //pnlDates.Visible = true;
            LoadData();
        }

        private void LoadData()
        {
            if (!bwGetOutPatientData.IsBusy)
            {
                ShowLoading("Loading data...");
                bwGetOutPatientData.RunWorkerAsync();
            }
        }

        private void bwGetOutPatientData_DoWork(object sender, DoWorkEventArgs e)
        {
            OutPatientTable = OPT.GetOutPatientRecords(cmbCategory.Text, dateFrom, dateTo);
            bwGetOutPatientData.CancelAsync();
        }

        private void bwGetOutPatientData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (OPT.GetOutPatientRecordsIsSuccessful)
            {
                if (OutPatientTable.Rows.Count > 0)
                {
                    dtOutPatient.DataSource = OutPatientTable;
                }
                else
                {
                    dtOutPatient.DataSource = new DataTable();
                    //MsgBox.Error("No Data Available.");
                }
            }
            else
                MsgBox.Error(OPT.GetOutPatientRecordsErrorMessage);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OutPatientReportForm opr = new OutPatientReportForm();
            opr.lblPreparedBy.Text = PublicVariables.UserFullName;
            opr.DataSource = OutPatientTable;
            opr.DataMember = "CustomeSqlQuery";
            opr.ShowPreviewDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "Child")
            {
                OutPatientAddForm opa = new OutPatientAddForm();
                opa.ShowDialog();
                LoadData();
            }
            else
            {
                OutPatientAddForm2 opa2 = new OutPatientAddForm2();
                opa2.patient_type = cmbCategory.Text;
                opa2.ShowDialog();
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
            {
                OutPatientAddForm opa = new OutPatientAddForm();
                opa.isAdd = false;
                opa._edit_id = gvOutPatient.GetFocusedRowCellValue("id").ToString();
                opa.txtAge.Text = gvOutPatient.GetFocusedRowCellValue("age_in_months").ToString();
                opa.dtDob.DateTime = Convert.ToDateTime(gvOutPatient.GetFocusedRowCellValue("Formatbirthdate").ToString());
                opa.txtChildName.Text = gvOutPatient.GetFocusedRowCellValue("name_of_child").ToString();
                opa.txtHeight.Text = gvOutPatient.GetFocusedRowCellValue("height").ToString();
                opa.txtNutStat.Text = gvOutPatient.GetFocusedRowCellValue("nutritional_status").ToString();
                opa.txtPurok.Text = gvOutPatient.GetFocusedRowCellValue("purok_no").ToString();
                opa.txtWeight.Text = gvOutPatient.GetFocusedRowCellValue("weight").ToString();
                opa.txtRemarks.Text = gvOutPatient.GetFocusedRowCellValue("remarks").ToString();
                opa.ShowDialog();
                LoadData();
            }
            else
                MsgBox.Warning("No Out Patient Selected.");
        }

        private void cmbdateperiod_EditValueChanged(object sender, EventArgs e)
        {
            pnlDates.Visible = cmbdateperiod.Text.Equals("Pick a date..") ? true : false;
            DateTime baseDate = DateTime.Now;
            cmbdateperiod.Properties.DisplayMember = "Period";

            if (cmbdateperiod.Text.Equals("Today's Record"))
            {
                dtpTo.EditValue = DateTime.Now;
                dtpFrom.EditValue = DateTime.Now;

                dateFrom = DateTime.Now;
                dateTo = DateTime.Now;
                LoadData();
            }
            else if (cmbdateperiod.Text.Equals("This Week's Record"))
            {
                dtpFrom.EditValue = baseDate.AddDays(-(int)baseDate.DayOfWeek);
                dtpTo.EditValue = Convert.ToDateTime(dtpFrom.EditValue).AddDays(7).AddSeconds(-1);

                dateFrom = baseDate.AddDays(-(int)baseDate.DayOfWeek);
                dateTo = Convert.ToDateTime(dtpFrom.EditValue).AddDays(7).AddSeconds(-1);
                LoadData();
            }
            else if (cmbdateperiod.Text.Equals("This Month's Record"))
            {
                dtpFrom.EditValue = baseDate.AddDays(1 - baseDate.Day);
                dtpTo.EditValue = Convert.ToDateTime(dtpFrom.EditValue).AddMonths(1).AddSeconds(-1);

                dateFrom = baseDate.AddDays(1 - baseDate.Day);
                dateTo = Convert.ToDateTime(dtpFrom.EditValue).AddMonths(1).AddSeconds(-1);
                LoadData();
            }
            else if (cmbdateperiod.Text.Equals("All Records"))
            {
                dtpFrom.EditValue = baseDate.AddYears(-100);
                dtpTo.EditValue = Convert.ToDateTime(dtpFrom.EditValue).AddYears(100);

                dateFrom = baseDate.AddYears(-100);
                dateTo = Convert.ToDateTime(dtpFrom.EditValue).AddYears(100);
                LoadData();
            }
            else
            {
                dtpFrom.EditValue = baseDate.AddYears(-10);
                dtpTo.EditValue = Convert.ToDateTime(dtpFrom.EditValue).AddYears(10);

                dateFrom = baseDate.AddYears(-10);
                dateTo = Convert.ToDateTime(dtpFrom.EditValue).AddYears(10);
            }
        }

        private void pnlDates_VisibleChanged(object sender, EventArgs e)
        {
            layoutControl1.Enabled = !pnlDates.Visible;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlDates.Visible = false; 
            LoadData();
        }

        private void cmbdateperiod_Popup(object sender, EventArgs e)
        {
            pnlDates.Visible = cmbdateperiod.Text.Equals("Pick a date..") ? true : false;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "Maternal")
            {
                GridColumn column = gvOutPatient.Columns[2];
                column.FieldName = "name";
                GridColumn column2 = gvOutPatient.Columns[4];
                column2.FieldName = "age";
                column2.Caption = "Age";
            }
            else
            {
                GridColumn column = gvOutPatient.Columns[2];
                column.FieldName = "name_of_child";
                GridColumn column2 = gvOutPatient.Columns[4];
                column2.FieldName = "age_in_months";
                column2.Caption = "Age in months";
            }
            gvOutPatient.RefreshData();
            LoadData();
        }
    }
}