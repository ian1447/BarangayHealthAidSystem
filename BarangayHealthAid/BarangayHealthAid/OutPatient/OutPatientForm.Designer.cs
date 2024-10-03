namespace BarangayHealthAid.OutPatient
{
    partial class OutPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutPatientForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbdateperiod = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dtOutPatient = new DevExpress.XtraGrid.GridControl();
            this.gvOutPatient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.purok_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name_of_child = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Formatbirthdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.age_in_months = new DevExpress.XtraGrid.Columns.GridColumn();
            this.height = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nutritional_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BarangayHealthAid.WaitForm1), true, true);
            this.bwGetOutPatientData = new System.ComponentModel.BackgroundWorker();
            this.pnlDates = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtpTo = new DevExpress.XtraEditors.DateEdit();
            this.dtpFrom = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbdateperiod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOutPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOutPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDates)).BeginInit();
            this.pnlDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cmbdateperiod);
            this.layoutControl1.Controls.Add(this.cmbCategory);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.dtOutPatient);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(836, 289, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1003, 570);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbdateperiod
            // 
            this.cmbdateperiod.Location = new System.Drawing.Point(225, 12);
            this.cmbdateperiod.Margin = new System.Windows.Forms.Padding(4);
            this.cmbdateperiod.Name = "cmbdateperiod";
            this.cmbdateperiod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdateperiod.Properties.Appearance.Options.UseFont = true;
            this.cmbdateperiod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbdateperiod.Properties.View = this.gridView1;
            this.cmbdateperiod.Size = new System.Drawing.Size(135, 20);
            this.cmbdateperiod.StyleController = this.layoutControl1;
            this.cmbdateperiod.TabIndex = 396;
            this.cmbdateperiod.Popup += new System.EventHandler(this.cmbdateperiod_Popup);
            this.cmbdateperiod.EditValueChanged += new System.EventHandler(this.cmbdateperiod_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.EditValue = "Child";
            this.cmbCategory.Location = new System.Drawing.Point(64, 12);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategory.Properties.Items.AddRange(new object[] {
            "Child",
            "Family Planning",
            "Maternal"});
            this.cmbCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCategory.Size = new System.Drawing.Size(105, 20);
            this.cmbCategory.StyleController = this.layoutControl1;
            this.cmbCategory.TabIndex = 12;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(664, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(556, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(772, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 22);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(885, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtOutPatient
            // 
            this.dtOutPatient.Location = new System.Drawing.Point(24, 69);
            this.dtOutPatient.MainView = this.gvOutPatient;
            this.dtOutPatient.Name = "dtOutPatient";
            this.dtOutPatient.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dtOutPatient.Size = new System.Drawing.Size(955, 477);
            this.dtOutPatient.TabIndex = 7;
            this.dtOutPatient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOutPatient});
            // 
            // gvOutPatient
            // 
            this.gvOutPatient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.purok_no,
            this.name_of_child,
            this.Formatbirthdate,
            this.age_in_months,
            this.height,
            this.nutritional_status,
            this.weight});
            this.gvOutPatient.GridControl = this.dtOutPatient;
            this.gvOutPatient.Name = "gvOutPatient";
            this.gvOutPatient.OptionsBehavior.Editable = false;
            this.gvOutPatient.OptionsFind.AlwaysVisible = true;
            this.gvOutPatient.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvOutPatient.OptionsView.RowAutoHeight = true;
            this.gvOutPatient.OptionsView.ShowGroupPanel = false;
            this.gvOutPatient.OptionsView.ShowIndicator = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // purok_no
            // 
            this.purok_no.AppearanceCell.Options.UseTextOptions = true;
            this.purok_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.purok_no.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.purok_no.AppearanceHeader.Options.UseTextOptions = true;
            this.purok_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.purok_no.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.purok_no.Caption = "Purok No.";
            this.purok_no.FieldName = "purok_no";
            this.purok_no.Name = "purok_no";
            this.purok_no.Visible = true;
            this.purok_no.VisibleIndex = 0;
            // 
            // name_of_child
            // 
            this.name_of_child.AppearanceCell.Options.UseTextOptions = true;
            this.name_of_child.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.name_of_child.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.name_of_child.AppearanceHeader.Options.UseTextOptions = true;
            this.name_of_child.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.name_of_child.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.name_of_child.Caption = "Name of Child";
            this.name_of_child.FieldName = "name_of_child";
            this.name_of_child.Name = "name_of_child";
            this.name_of_child.Visible = true;
            this.name_of_child.VisibleIndex = 1;
            // 
            // Formatbirthdate
            // 
            this.Formatbirthdate.AppearanceCell.Options.UseTextOptions = true;
            this.Formatbirthdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Formatbirthdate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Formatbirthdate.AppearanceHeader.Options.UseTextOptions = true;
            this.Formatbirthdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Formatbirthdate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Formatbirthdate.Caption = "Birthdate";
            this.Formatbirthdate.FieldName = "Formatbirthdate";
            this.Formatbirthdate.Name = "Formatbirthdate";
            this.Formatbirthdate.Visible = true;
            this.Formatbirthdate.VisibleIndex = 2;
            // 
            // age_in_months
            // 
            this.age_in_months.AppearanceCell.Options.UseTextOptions = true;
            this.age_in_months.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.age_in_months.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.age_in_months.AppearanceHeader.Options.UseTextOptions = true;
            this.age_in_months.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.age_in_months.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.age_in_months.Caption = "Age in Months";
            this.age_in_months.FieldName = "age_in_months";
            this.age_in_months.Name = "age_in_months";
            this.age_in_months.Visible = true;
            this.age_in_months.VisibleIndex = 3;
            // 
            // height
            // 
            this.height.AppearanceCell.Options.UseTextOptions = true;
            this.height.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.height.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.height.AppearanceHeader.Options.UseTextOptions = true;
            this.height.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.height.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.height.Caption = "Height";
            this.height.FieldName = "height";
            this.height.Name = "height";
            this.height.Visible = true;
            this.height.VisibleIndex = 4;
            // 
            // nutritional_status
            // 
            this.nutritional_status.AppearanceCell.Options.UseTextOptions = true;
            this.nutritional_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nutritional_status.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.nutritional_status.AppearanceHeader.Options.UseTextOptions = true;
            this.nutritional_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nutritional_status.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.nutritional_status.Caption = "Nutritional Status";
            this.nutritional_status.FieldName = "nutritional_status";
            this.nutritional_status.Name = "nutritional_status";
            this.nutritional_status.Visible = true;
            this.nutritional_status.VisibleIndex = 6;
            // 
            // weight
            // 
            this.weight.AppearanceCell.Options.UseTextOptions = true;
            this.weight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.weight.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.weight.AppearanceHeader.Options.UseTextOptions = true;
            this.weight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.weight.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.weight.Caption = "Weight";
            this.weight.FieldName = "weight";
            this.weight.Name = "weight";
            this.weight.Visible = true;
            this.weight.VisibleIndex = 5;
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
            this.emptySpaceItem1,
            this.layoutControlGroup2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1003, 570);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(352, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(192, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(983, 524);
            this.layoutControlGroup2.Text = "Out Patient Details";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtOutPatient;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(959, 481);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnPrint;
            this.layoutControlItem2.Location = new System.Drawing.Point(873, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(110, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(110, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(110, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnRefresh;
            this.layoutControlItem3.Location = new System.Drawing.Point(760, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(113, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(113, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(113, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAdd;
            this.layoutControlItem4.Location = new System.Drawing.Point(544, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(108, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(108, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(108, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(652, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(108, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(108, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(108, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cmbCategory;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(161, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(161, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "Category:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cmbdateperiod;
            this.layoutControlItem6.Location = new System.Drawing.Point(161, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(191, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(191, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(191, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "Period:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(49, 13);
            // 
            // bwGetOutPatientData
            // 
            this.bwGetOutPatientData.WorkerSupportsCancellation = true;
            this.bwGetOutPatientData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetOutPatientData_DoWork);
            this.bwGetOutPatientData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetOutPatientData_RunWorkerCompleted);
            // 
            // pnlDates
            // 
            this.pnlDates.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlDates.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pnlDates.Appearance.Options.UseBackColor = true;
            this.pnlDates.Appearance.Options.UseFont = true;
            this.pnlDates.Controls.Add(this.labelControl8);
            this.pnlDates.Controls.Add(this.btnSearch);
            this.pnlDates.Controls.Add(this.labelControl6);
            this.pnlDates.Controls.Add(this.dtpTo);
            this.pnlDates.Controls.Add(this.dtpFrom);
            this.pnlDates.Location = new System.Drawing.Point(295, 256);
            this.pnlDates.Name = "pnlDates";
            this.pnlDates.Size = new System.Drawing.Size(413, 59);
            this.pnlDates.TabIndex = 398;
            this.pnlDates.Visible = false;
            this.pnlDates.VisibleChanged += new System.EventHandler(this.pnlDates_VisibleChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(14, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 370;
            this.labelControl8.Text = "From :";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(326, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 365;
            this.btnSearch.Text = "Load";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(170, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(19, 13);
            this.labelControl6.TabIndex = 369;
            this.labelControl6.Text = "To :";
            // 
            // dtpTo
            // 
            this.dtpTo.EditValue = null;
            this.dtpTo.Location = new System.Drawing.Point(170, 26);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpTo.Properties.Appearance.Options.UseFont = true;
            this.dtpTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTo.Properties.DisplayFormat.FormatString = "MMM. dd, yyyy";
            this.dtpTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTo.Properties.EditFormat.FormatString = "MMM. dd, yyyy";
            this.dtpTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTo.Properties.Mask.EditMask = "MMM. dd, yyyy";
            this.dtpTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpTo.Size = new System.Drawing.Size(148, 24);
            this.dtpTo.TabIndex = 364;
            // 
            // dtpFrom
            // 
            this.dtpFrom.EditValue = null;
            this.dtpFrom.Location = new System.Drawing.Point(14, 26);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpFrom.Properties.Appearance.Options.UseFont = true;
            this.dtpFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFrom.Properties.DisplayFormat.FormatString = "MMM. dd, yyyy";
            this.dtpFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFrom.Properties.EditFormat.FormatString = "MMM. dd, yyyy";
            this.dtpFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFrom.Properties.Mask.EditMask = "MMM. dd, yyyy";
            this.dtpFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpFrom.Size = new System.Drawing.Size(148, 24);
            this.dtpFrom.TabIndex = 362;
            // 
            // OutPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 570);
            this.Controls.Add(this.pnlDates);
            this.Controls.Add(this.layoutControl1);
            this.Name = "OutPatientForm";
            this.Text = "Out Patient";
            this.Shown += new System.EventHandler(this.OutPatientForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbdateperiod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOutPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOutPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDates)).EndInit();
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl dtOutPatient;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOutPatient;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn purok_no;
        private DevExpress.XtraGrid.Columns.GridColumn name_of_child;
        private DevExpress.XtraGrid.Columns.GridColumn Formatbirthdate;
        private DevExpress.XtraGrid.Columns.GridColumn age_in_months;
        private DevExpress.XtraGrid.Columns.GridColumn height;
        private DevExpress.XtraGrid.Columns.GridColumn nutritional_status;
        private DevExpress.XtraGrid.Columns.GridColumn weight;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwGetOutPatientData;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCategory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbdateperiod;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.PanelControl pnlDates;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtpTo;
        private DevExpress.XtraEditors.DateEdit dtpFrom;
    }
}