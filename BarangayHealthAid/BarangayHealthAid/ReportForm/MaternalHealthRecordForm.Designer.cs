﻿namespace BarangayHealthAid.ReportForm
{
    partial class MaternalHealthRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaternalHealthRecordForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dtMaternal = new DevExpress.XtraGrid.GridControl();
            this.gvMaternal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BarangayHealthAid.WaitForm1), true, true);
            this.bwGetMaternalRecord = new System.ComponentModel.BackgroundWorker();
            this.format_birthdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.husband_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.height = new DevExpress.XtraGrid.Columns.GridColumn();
            this.occupation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contact_no = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMaternal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaternal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.dtMaternal);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(732, 405, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1188, 584);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(931, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 22);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(1051, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(125, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(756, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Maternal Patient";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtMaternal
            // 
            this.dtMaternal.Location = new System.Drawing.Point(24, 69);
            this.dtMaternal.MainView = this.gvMaternal;
            this.dtMaternal.Name = "dtMaternal";
            this.dtMaternal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dtMaternal.Size = new System.Drawing.Size(1140, 491);
            this.dtMaternal.TabIndex = 7;
            this.dtMaternal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaternal});
            // 
            // gvMaternal
            // 
            this.gvMaternal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.name,
            this.format_birthdate,
            this.husband_name,
            this.age,
            this.height,
            this.occupation,
            this.address,
            this.contact_no});
            this.gvMaternal.GridControl = this.dtMaternal;
            this.gvMaternal.Name = "gvMaternal";
            this.gvMaternal.OptionsBehavior.Editable = false;
            this.gvMaternal.OptionsFind.AlwaysVisible = true;
            this.gvMaternal.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMaternal.OptionsView.RowAutoHeight = true;
            this.gvMaternal.OptionsView.ShowGroupPanel = false;
            this.gvMaternal.OptionsView.ShowIndicator = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AppearanceHeader.Options.UseTextOptions = true;
            this.name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.name.Caption = "Name";
            this.name.FieldName = "name";
            this.name.MinWidth = 150;
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            this.name.Width = 150;
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
            this.emptySpaceItem2,
            this.simpleSeparator1,
            this.layoutControlGroup2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1188, 584);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(744, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 24);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(744, 2);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1168, 538);
            this.layoutControlGroup2.Text = "Maternal Health Patients";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtMaternal;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1144, 495);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAdd;
            this.layoutControlItem2.Location = new System.Drawing.Point(744, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(175, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(175, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(175, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPrint;
            this.layoutControlItem3.Location = new System.Drawing.Point(1039, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(129, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(129, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(129, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnRefresh;
            this.layoutControlItem4.Location = new System.Drawing.Point(919, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // bwGetMaternalRecord
            // 
            this.bwGetMaternalRecord.WorkerSupportsCancellation = true;
            this.bwGetMaternalRecord.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetMaternalRecord_DoWork);
            this.bwGetMaternalRecord.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetMaternalRecord_RunWorkerCompleted);
            // 
            // format_birthdate
            // 
            this.format_birthdate.Caption = "Birthday";
            this.format_birthdate.FieldName = "format_birthdate";
            this.format_birthdate.Name = "format_birthdate";
            this.format_birthdate.Visible = true;
            this.format_birthdate.VisibleIndex = 3;
            // 
            // husband_name
            // 
            this.husband_name.Caption = "Husband";
            this.husband_name.FieldName = "husband_name";
            this.husband_name.Name = "husband_name";
            this.husband_name.Visible = true;
            this.husband_name.VisibleIndex = 4;
            // 
            // age
            // 
            this.age.Caption = "Age";
            this.age.FieldName = "age";
            this.age.Name = "age";
            this.age.Visible = true;
            this.age.VisibleIndex = 1;
            // 
            // height
            // 
            this.height.Caption = "Height";
            this.height.FieldName = "height";
            this.height.Name = "height";
            this.height.Visible = true;
            this.height.VisibleIndex = 2;
            // 
            // occupation
            // 
            this.occupation.Caption = "Occupation";
            this.occupation.FieldName = "occupation";
            this.occupation.Name = "occupation";
            this.occupation.Visible = true;
            this.occupation.VisibleIndex = 5;
            // 
            // address
            // 
            this.address.Caption = "Address";
            this.address.FieldName = "address";
            this.address.Name = "address";
            this.address.Visible = true;
            this.address.VisibleIndex = 6;
            // 
            // contact_no
            // 
            this.contact_no.Caption = "Contact No.";
            this.contact_no.FieldName = "contact_no";
            this.contact_no.Name = "contact_no";
            this.contact_no.Visible = true;
            this.contact_no.VisibleIndex = 7;
            // 
            // MaternalHealthRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 584);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MaternalHealthRecordForm";
            this.Text = "Maternal Health Record";
            this.Load += new System.EventHandler(this.MaternalHealthRecordForm_Load);
            this.Shown += new System.EventHandler(this.MaternalHealthRecordForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtMaternal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaternal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraGrid.GridControl dtMaternal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMaternal;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.ComponentModel.BackgroundWorker bwGetMaternalRecord;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn format_birthdate;
        private DevExpress.XtraGrid.Columns.GridColumn husband_name;
        private DevExpress.XtraGrid.Columns.GridColumn age;
        private DevExpress.XtraGrid.Columns.GridColumn height;
        private DevExpress.XtraGrid.Columns.GridColumn occupation;
        private DevExpress.XtraGrid.Columns.GridColumn address;
        private DevExpress.XtraGrid.Columns.GridColumn contact_no;
    }
}