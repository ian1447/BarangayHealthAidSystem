namespace BarangayHealthAid.Backend
{
    partial class UserManagementForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceChangePass = new DevExpress.XtraEditors.CheckEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeactivate = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnProceed = new DevExpress.XtraEditors.SimpleButton();
            this.ceShowPass = new DevExpress.XtraEditors.CheckEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtLast = new DevExpress.XtraEditors.TextEdit();
            this.txtMiddle = new DevExpress.XtraEditors.TextEdit();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.dtUsers = new DevExpress.XtraGrid.GridControl();
            this.gvUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.is_active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.added_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.added_on = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.middlename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lgcDetails = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcChangePass = new DevExpress.XtraLayout.LayoutControlItem();
            this.lgcUsers = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BarangayHealthAid.WaitForm1), true, true);
            this.bwGetUsers = new System.ComponentModel.BackgroundWorker();
            this.bwAddUsers = new System.ComponentModel.BackgroundWorker();
            this.bwEditUser = new System.ComponentModel.BackgroundWorker();
            this.bwDeactivate = new System.ComponentModel.BackgroundWorker();
            this.barManagerUser = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tsbtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.tsbtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsbtnDeactivate = new DevExpress.XtraBars.BarButtonItem();
            this.tsbtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuUser = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceChangePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLast.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgcDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcChangePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgcUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuUser)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ceChangePass);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnDeactivate);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnProceed);
            this.layoutControl1.Controls.Add(this.ceShowPass);
            this.layoutControl1.Controls.Add(this.txtPassword);
            this.layoutControl1.Controls.Add(this.txtUsername);
            this.layoutControl1.Controls.Add(this.txtLast);
            this.layoutControl1.Controls.Add(this.txtMiddle);
            this.layoutControl1.Controls.Add(this.txtFirstName);
            this.layoutControl1.Controls.Add(this.dtUsers);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(619, 234, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1094, 519);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceChangePass
            // 
            this.ceChangePass.Location = new System.Drawing.Point(818, 213);
            this.ceChangePass.Name = "ceChangePass";
            this.ceChangePass.Properties.Caption = "Change Password";
            this.ceChangePass.Size = new System.Drawing.Size(252, 19);
            this.ceChangePass.StyleController = this.layoutControl1;
            this.ceChangePass.TabIndex = 9;
            this.ceChangePass.CheckedChanged += new System.EventHandler(this.ceChangePass_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(684, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 12;
            this.btnAdd.ToolTip = "Add User";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(714, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(26, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 12;
            this.btnEdit.ToolTip = "Edit User";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Image = ((System.Drawing.Image)(resources.GetObject("btnDeactivate.Image")));
            this.btnDeactivate.Location = new System.Drawing.Point(744, 12);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(26, 22);
            this.btnDeactivate.StyleController = this.layoutControl1;
            this.btnDeactivate.TabIndex = 12;
            this.btnDeactivate.ToolTip = "Deactivate User";
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(774, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(26, 22);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.ToolTip = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(818, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Image = ((System.Drawing.Image)(resources.GetObject("btnProceed.Image")));
            this.btnProceed.Location = new System.Drawing.Point(946, 302);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(124, 22);
            this.btnProceed.StyleController = this.layoutControl1;
            this.btnProceed.TabIndex = 9;
            this.btnProceed.Text = "Save";
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // ceShowPass
            // 
            this.ceShowPass.Location = new System.Drawing.Point(946, 279);
            this.ceShowPass.Name = "ceShowPass";
            this.ceShowPass.Properties.Caption = "Show Password";
            this.ceShowPass.Size = new System.Drawing.Size(124, 19);
            this.ceShowPass.StyleController = this.layoutControl1;
            this.ceShowPass.TabIndex = 8;
            this.ceShowPass.CheckedChanged += new System.EventHandler(this.ceShowPass_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(818, 255);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(252, 20);
            this.txtPassword.StyleController = this.layoutControl1;
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(818, 189);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 20);
            this.txtUsername.StyleController = this.layoutControl1;
            this.txtUsername.TabIndex = 6;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(818, 146);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(252, 20);
            this.txtLast.StyleController = this.layoutControl1;
            this.txtLast.TabIndex = 6;
            // 
            // txtMiddle
            // 
            this.txtMiddle.Location = new System.Drawing.Point(818, 103);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(252, 20);
            this.txtMiddle.StyleController = this.layoutControl1;
            this.txtMiddle.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(818, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(252, 20);
            this.txtFirstName.StyleController = this.layoutControl1;
            this.txtFirstName.TabIndex = 5;
            // 
            // dtUsers
            // 
            this.dtUsers.Location = new System.Drawing.Point(24, 69);
            this.dtUsers.MainView = this.gvUsers;
            this.dtUsers.Name = "dtUsers";
            this.dtUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dtUsers.Size = new System.Drawing.Size(764, 426);
            this.dtUsers.TabIndex = 4;
            this.dtUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsers});
            this.dtUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtUsers_MouseDown);
            // 
            // gvUsers
            // 
            this.gvUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.name,
            this.username,
            this.role,
            this.is_active,
            this.added_by,
            this.added_on,
            this.firstname,
            this.middlename,
            this.lastname});
            this.gvUsers.GridControl = this.dtUsers;
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.OptionsBehavior.Editable = false;
            this.gvUsers.OptionsFind.AlwaysVisible = true;
            this.gvUsers.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvUsers.OptionsView.RowAutoHeight = true;
            this.gvUsers.OptionsView.ShowGroupPanel = false;
            this.gvUsers.OptionsView.ShowIndicator = false;
            this.gvUsers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvUsers_FocusedRowChanged);
            // 
            // name
            // 
            this.name.AppearanceHeader.Options.UseTextOptions = true;
            this.name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.name.Caption = "Name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            // 
            // username
            // 
            this.username.AppearanceHeader.Options.UseTextOptions = true;
            this.username.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.username.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.username.Caption = "Username";
            this.username.FieldName = "username";
            this.username.Name = "username";
            this.username.Visible = true;
            this.username.VisibleIndex = 1;
            // 
            // role
            // 
            this.role.AppearanceHeader.Options.UseTextOptions = true;
            this.role.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.role.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.role.Caption = "Role";
            this.role.FieldName = "role";
            this.role.Name = "role";
            this.role.Visible = true;
            this.role.VisibleIndex = 2;
            // 
            // is_active
            // 
            this.is_active.AppearanceHeader.Options.UseTextOptions = true;
            this.is_active.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.is_active.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.is_active.Caption = "Active";
            this.is_active.FieldName = "is_active";
            this.is_active.Name = "is_active";
            this.is_active.Visible = true;
            this.is_active.VisibleIndex = 5;
            // 
            // added_by
            // 
            this.added_by.AppearanceHeader.Options.UseTextOptions = true;
            this.added_by.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.added_by.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.added_by.Caption = "Added By";
            this.added_by.FieldName = "added_by";
            this.added_by.Name = "added_by";
            this.added_by.Visible = true;
            this.added_by.VisibleIndex = 3;
            // 
            // added_on
            // 
            this.added_on.AppearanceHeader.Options.UseTextOptions = true;
            this.added_on.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.added_on.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.added_on.Caption = "Added On";
            this.added_on.FieldName = "added_on";
            this.added_on.Name = "added_on";
            this.added_on.Visible = true;
            this.added_on.VisibleIndex = 4;
            // 
            // firstname
            // 
            this.firstname.Caption = "gridColumn1";
            this.firstname.FieldName = "firstname";
            this.firstname.Name = "firstname";
            // 
            // middlename
            // 
            this.middlename.Caption = "gridColumn1";
            this.middlename.FieldName = "middlename";
            this.middlename.Name = "middlename";
            // 
            // lastname
            // 
            this.lastname.Caption = "lastname";
            this.lastname.Name = "lastname";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowCustomizeChildren = false;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleSeparator1,
            this.emptySpaceItem3,
            this.lgcDetails,
            this.lgcUsers,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem13});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1094, 519);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(792, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(2, 499);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(672, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lgcDetails
            // 
            this.lgcDetails.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.lcChangePass});
            this.lgcDetails.Location = new System.Drawing.Point(794, 0);
            this.lgcDetails.Name = "lgcDetails";
            this.lgcDetails.Size = new System.Drawing.Size(280, 499);
            this.lgcDetails.Text = "Details";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 285);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(256, 171);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtFirstName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(256, 43);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(256, 43);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(256, 43);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "First Name:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtMiddle;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 43);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(256, 41);
            this.layoutControlItem3.Text = "Middle Name: ";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtLast;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(256, 43);
            this.layoutControlItem4.Text = "Last Name:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.txtUsername;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 127);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(256, 43);
            this.layoutControlItem5.Text = "Username:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.txtPassword;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 193);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(256, 43);
            this.layoutControlItem6.Text = "Password:";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(85, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 236);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(128, 23);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ceShowPass;
            this.layoutControlItem7.Location = new System.Drawing.Point(128, 236);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(128, 23);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnProceed;
            this.layoutControlItem8.Location = new System.Drawing.Point(128, 259);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(82, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(128, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnCancel;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 259);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(82, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(128, 26);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // lcChangePass
            // 
            this.lcChangePass.Control = this.ceChangePass;
            this.lcChangePass.Location = new System.Drawing.Point(0, 170);
            this.lcChangePass.Name = "lcChangePass";
            this.lcChangePass.Size = new System.Drawing.Size(256, 23);
            this.lcChangePass.TextSize = new System.Drawing.Size(0, 0);
            this.lcChangePass.TextVisible = false;
            this.lcChangePass.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lgcUsers
            // 
            this.lgcUsers.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgcUsers.Location = new System.Drawing.Point(0, 26);
            this.lgcUsers.Name = "lgcUsers";
            this.lgcUsers.Size = new System.Drawing.Size(792, 473);
            this.lgcUsers.Text = "Users";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtUsers;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(768, 430);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnRefresh;
            this.layoutControlItem10.Location = new System.Drawing.Point(762, 0);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(30, 26);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnDeactivate;
            this.layoutControlItem11.Location = new System.Drawing.Point(732, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnEdit;
            this.layoutControlItem12.Location = new System.Drawing.Point(702, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.btnAdd;
            this.layoutControlItem13.Location = new System.Drawing.Point(672, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // bwGetUsers
            // 
            this.bwGetUsers.WorkerSupportsCancellation = true;
            this.bwGetUsers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetUsers_DoWork);
            this.bwGetUsers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetUsers_RunWorkerCompleted);
            // 
            // bwAddUsers
            // 
            this.bwAddUsers.WorkerSupportsCancellation = true;
            this.bwAddUsers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAddUsers_DoWork);
            this.bwAddUsers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAddUsers_RunWorkerCompleted);
            // 
            // bwEditUser
            // 
            this.bwEditUser.WorkerSupportsCancellation = true;
            this.bwEditUser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwEditUser_DoWork);
            this.bwEditUser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwEditUser_RunWorkerCompleted);
            // 
            // bwDeactivate
            // 
            this.bwDeactivate.WorkerSupportsCancellation = true;
            this.bwDeactivate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDeactivate_DoWork);
            this.bwDeactivate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDeactivate_RunWorkerCompleted);
            // 
            // barManagerUser
            // 
            this.barManagerUser.DockControls.Add(this.barDockControlTop);
            this.barManagerUser.DockControls.Add(this.barDockControlBottom);
            this.barManagerUser.DockControls.Add(this.barDockControlLeft);
            this.barManagerUser.DockControls.Add(this.barDockControlRight);
            this.barManagerUser.Form = this;
            this.barManagerUser.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tsbtnAdd,
            this.tsbtnEdit,
            this.tsbtnDeactivate,
            this.tsbtnRefresh});
            this.barManagerUser.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1094, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 519);
            this.barDockControlBottom.Size = new System.Drawing.Size(1094, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 519);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1094, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 519);
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Caption = "Add User";
            this.tsbtnAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Glyph")));
            this.tsbtnAdd.Id = 0;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbtnAdd_ItemClick);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Caption = "Edit User";
            this.tsbtnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Glyph")));
            this.tsbtnEdit.Id = 1;
            this.tsbtnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.LargeGlyph")));
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbtnEdit_ItemClick);
            // 
            // tsbtnDeactivate
            // 
            this.tsbtnDeactivate.Caption = "Activate User";
            this.tsbtnDeactivate.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbtnDeactivate.Glyph")));
            this.tsbtnDeactivate.Id = 2;
            this.tsbtnDeactivate.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbtnDeactivate.LargeGlyph")));
            this.tsbtnDeactivate.Name = "tsbtnDeactivate";
            this.tsbtnDeactivate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbtnDeactivate_ItemClick);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Caption = "Refresh";
            this.tsbtnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Glyph")));
            this.tsbtnRefresh.Id = 3;
            this.tsbtnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.LargeGlyph")));
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbtnRefresh_ItemClick);
            // 
            // popupMenuUser
            // 
            this.popupMenuUser.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbtnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.tsbtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.tsbtnDeactivate),
            new DevExpress.XtraBars.LinkPersistInfo(this.tsbtnRefresh)});
            this.popupMenuUser.Manager = this.barManagerUser;
            this.popupMenuUser.Name = "popupMenuUser";
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 519);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Management";
            this.Shown += new System.EventHandler(this.UserManagementForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceChangePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLast.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgcDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcChangePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgcUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlGroup lgcDetails;
        private DevExpress.XtraLayout.LayoutControlGroup lgcUsers;
        private DevExpress.XtraGrid.GridControl dtUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsers;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtLast;
        private DevExpress.XtraEditors.TextEdit txtMiddle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.CheckEdit ceShowPass;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnProceed;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDeactivate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn username;
        private DevExpress.XtraGrid.Columns.GridColumn is_active;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn role;
        private DevExpress.XtraGrid.Columns.GridColumn added_by;
        private DevExpress.XtraGrid.Columns.GridColumn added_on;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwGetUsers;
        private System.ComponentModel.BackgroundWorker bwAddUsers;
        private DevExpress.XtraGrid.Columns.GridColumn firstname;
        private DevExpress.XtraGrid.Columns.GridColumn middlename;
        private DevExpress.XtraGrid.Columns.GridColumn lastname;
        private System.ComponentModel.BackgroundWorker bwEditUser;
        private DevExpress.XtraEditors.CheckEdit ceChangePass;
        private DevExpress.XtraLayout.LayoutControlItem lcChangePass;
        private System.ComponentModel.BackgroundWorker bwDeactivate;
        private DevExpress.XtraBars.BarManager barManagerUser;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenuUser;
        private DevExpress.XtraBars.BarButtonItem tsbtnAdd;
        private DevExpress.XtraBars.BarButtonItem tsbtnEdit;
        private DevExpress.XtraBars.BarButtonItem tsbtnDeactivate;
        private DevExpress.XtraBars.BarButtonItem tsbtnRefresh;
    }
}