namespace BarangayHealthAid.ReportForm
{
    partial class PatientRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRecordForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dtPatient = new DevExpress.XtraGrid.GridControl();
            this.gvPatient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.patient_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maiden_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.format_birthdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partner_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.father_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mother_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.civil_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.religion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contact_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.S = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BarangayHealthAid.WaitForm1), true, true);
            this.bwGetPatientData = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.dtPatient);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(823, 258, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1462, 576);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(1102, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit Patient";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(1221, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 22);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(1342, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(982, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Patient";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtPatient
            // 
            this.dtPatient.Location = new System.Drawing.Point(24, 71);
            this.dtPatient.MainView = this.gvPatient;
            this.dtPatient.Name = "dtPatient";
            this.dtPatient.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dtPatient.Size = new System.Drawing.Size(1414, 481);
            this.dtPatient.TabIndex = 6;
            this.dtPatient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatient});
            // 
            // gvPatient
            // 
            this.gvPatient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.patient_name,
            this.maiden_name,
            this.format_birthdate,
            this.address,
            this.partner_name,
            this.father_name,
            this.mother_name,
            this.age,
            this.sex,
            this.civil_status,
            this.religion,
            this.contact_number});
            this.gvPatient.GridControl = this.dtPatient;
            this.gvPatient.Name = "gvPatient";
            this.gvPatient.OptionsBehavior.Editable = false;
            this.gvPatient.OptionsFind.AlwaysVisible = true;
            this.gvPatient.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPatient.OptionsView.RowAutoHeight = true;
            this.gvPatient.OptionsView.ShowGroupPanel = false;
            this.gvPatient.OptionsView.ShowIndicator = false;
            this.gvPatient.DoubleClick += new System.EventHandler(this.gvPatient_DoubleClick);
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // patient_name
            // 
            this.patient_name.AppearanceHeader.Options.UseTextOptions = true;
            this.patient_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.patient_name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.patient_name.Caption = "Patient Name";
            this.patient_name.FieldName = "patient_name";
            this.patient_name.MinWidth = 150;
            this.patient_name.Name = "patient_name";
            this.patient_name.Visible = true;
            this.patient_name.VisibleIndex = 0;
            this.patient_name.Width = 150;
            // 
            // maiden_name
            // 
            this.maiden_name.AppearanceHeader.Options.UseTextOptions = true;
            this.maiden_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maiden_name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.maiden_name.Caption = "Maiden Name";
            this.maiden_name.FieldName = "maiden_name";
            this.maiden_name.MinWidth = 150;
            this.maiden_name.Name = "maiden_name";
            this.maiden_name.Visible = true;
            this.maiden_name.VisibleIndex = 1;
            this.maiden_name.Width = 150;
            // 
            // format_birthdate
            // 
            this.format_birthdate.AppearanceHeader.Options.UseTextOptions = true;
            this.format_birthdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.format_birthdate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.format_birthdate.Caption = "Birthday";
            this.format_birthdate.FieldName = "format_birthdate";
            this.format_birthdate.MinWidth = 80;
            this.format_birthdate.Name = "format_birthdate";
            this.format_birthdate.Visible = true;
            this.format_birthdate.VisibleIndex = 2;
            this.format_birthdate.Width = 80;
            // 
            // address
            // 
            this.address.AppearanceHeader.Options.UseTextOptions = true;
            this.address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.address.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.address.Caption = "Address";
            this.address.FieldName = "address";
            this.address.MinWidth = 200;
            this.address.Name = "address";
            this.address.Visible = true;
            this.address.VisibleIndex = 8;
            this.address.Width = 200;
            // 
            // partner_name
            // 
            this.partner_name.AppearanceHeader.Options.UseTextOptions = true;
            this.partner_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.partner_name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.partner_name.Caption = "Partner Name";
            this.partner_name.FieldName = "partner_name";
            this.partner_name.MinWidth = 150;
            this.partner_name.Name = "partner_name";
            this.partner_name.Visible = true;
            this.partner_name.VisibleIndex = 9;
            this.partner_name.Width = 154;
            // 
            // father_name
            // 
            this.father_name.AppearanceHeader.Options.UseTextOptions = true;
            this.father_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.father_name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.father_name.Caption = "Father\'s Name";
            this.father_name.FieldName = "father_name";
            this.father_name.MinWidth = 150;
            this.father_name.Name = "father_name";
            this.father_name.Visible = true;
            this.father_name.VisibleIndex = 10;
            this.father_name.Width = 150;
            // 
            // mother_name
            // 
            this.mother_name.AppearanceHeader.Options.UseTextOptions = true;
            this.mother_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mother_name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mother_name.Caption = "Mother\'s Name";
            this.mother_name.FieldName = "mother_name";
            this.mother_name.MinWidth = 150;
            this.mother_name.Name = "mother_name";
            this.mother_name.Visible = true;
            this.mother_name.VisibleIndex = 11;
            this.mother_name.Width = 150;
            // 
            // age
            // 
            this.age.AppearanceHeader.Options.UseTextOptions = true;
            this.age.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.age.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.age.Caption = "Age";
            this.age.FieldName = "age";
            this.age.MaxWidth = 40;
            this.age.MinWidth = 40;
            this.age.Name = "age";
            this.age.Visible = true;
            this.age.VisibleIndex = 3;
            this.age.Width = 40;
            // 
            // sex
            // 
            this.sex.AppearanceHeader.Options.UseTextOptions = true;
            this.sex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sex.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.sex.Caption = "Sex";
            this.sex.FieldName = "sex";
            this.sex.MaxWidth = 45;
            this.sex.MinWidth = 45;
            this.sex.Name = "sex";
            this.sex.Visible = true;
            this.sex.VisibleIndex = 4;
            this.sex.Width = 45;
            // 
            // civil_status
            // 
            this.civil_status.AppearanceHeader.Options.UseTextOptions = true;
            this.civil_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.civil_status.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.civil_status.Caption = "Civil Status";
            this.civil_status.FieldName = "civil_status";
            this.civil_status.Name = "civil_status";
            this.civil_status.Visible = true;
            this.civil_status.VisibleIndex = 5;
            this.civil_status.Width = 116;
            // 
            // religion
            // 
            this.religion.AppearanceHeader.Options.UseTextOptions = true;
            this.religion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.religion.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.religion.Caption = "Religion";
            this.religion.FieldName = "religion";
            this.religion.MinWidth = 77;
            this.religion.Name = "religion";
            this.religion.Visible = true;
            this.religion.VisibleIndex = 6;
            this.religion.Width = 77;
            // 
            // contact_number
            // 
            this.contact_number.AppearanceHeader.Options.UseTextOptions = true;
            this.contact_number.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.contact_number.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.contact_number.Caption = "Contact Number";
            this.contact_number.FieldName = "contact_number";
            this.contact_number.MinWidth = 100;
            this.contact_number.Name = "contact_number";
            this.contact_number.Visible = true;
            this.contact_number.VisibleIndex = 7;
            this.contact_number.Width = 100;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.S,
            this.simpleSeparator1,
            this.layoutControlGroup2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1462, 576);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // S
            // 
            this.S.AllowHotTrack = false;
            this.S.Location = new System.Drawing.Point(0, 0);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(970, 26);
            this.S.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 26);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(1442, 2);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowCustomizeChildren = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1442, 528);
            this.layoutControlGroup2.Text = "Patients";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtPatient;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1418, 485);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAdd;
            this.layoutControlItem2.Location = new System.Drawing.Point(970, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPrint;
            this.layoutControlItem3.Location = new System.Drawing.Point(1330, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(112, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(112, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnRefresh;
            this.layoutControlItem4.Location = new System.Drawing.Point(1209, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(121, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(121, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(121, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(1090, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(119, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(119, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(119, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // bwGetPatientData
            // 
            this.bwGetPatientData.WorkerSupportsCancellation = true;
            this.bwGetPatientData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetPatientData_DoWork);
            this.bwGetPatientData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetPatientData_RunWorkerCompleted);
            // 
            // PatientRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 576);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PatientRecordForm";
            this.Text = "Patient Record";
            this.Shown += new System.EventHandler(this.PatientRecordForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem S;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.GridControl dtPatient;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatient;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn patient_name;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn maiden_name;
        private DevExpress.XtraGrid.Columns.GridColumn format_birthdate;
        private DevExpress.XtraGrid.Columns.GridColumn address;
        private DevExpress.XtraGrid.Columns.GridColumn partner_name;
        private DevExpress.XtraGrid.Columns.GridColumn father_name;
        private DevExpress.XtraGrid.Columns.GridColumn mother_name;
        private DevExpress.XtraGrid.Columns.GridColumn age;
        private DevExpress.XtraGrid.Columns.GridColumn sex;
        private DevExpress.XtraGrid.Columns.GridColumn civil_status;
        private DevExpress.XtraGrid.Columns.GridColumn religion;
        private DevExpress.XtraGrid.Columns.GridColumn contact_number;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwGetPatientData;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}