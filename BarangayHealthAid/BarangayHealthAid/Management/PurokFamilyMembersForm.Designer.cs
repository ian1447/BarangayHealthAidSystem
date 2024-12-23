﻿namespace BarangayHealthAid.Management
{
    partial class PurokFamilyMembersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurokFamilyMembersForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDeactivate = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.dtMembers = new DevExpress.XtraGrid.GridControl();
            this.gvMembers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.family_member_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.description_case = new DevExpress.XtraGrid.Columns.GridColumn();
            this.formated_dob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.is_active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblHeadName = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BarangayHealthAid.WaitForm1), true, true);
            this.bwGetPurokFamilyMembers = new System.ComponentModel.BackgroundWorker();
            this.bwDeletePurokFamilyMember = new System.ComponentModel.BackgroundWorker();
            this.bwDeactivateMember = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeadName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDeactivate);
            this.layoutControl1.Controls.Add(this.btnView);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnRemove);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.dtMembers);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(649, 248, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(642, 585);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Image = ((System.Drawing.Image)(resources.GetObject("btnDeactivate.Image")));
            this.btnDeactivate.Location = new System.Drawing.Point(349, 32);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(93, 22);
            this.btnDeactivate.StyleController = this.layoutControl1;
            this.btnDeactivate.TabIndex = 12;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnView
            // 
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(268, 32);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(77, 22);
            this.btnView.StyleController = this.layoutControl1;
            this.btnView.TabIndex = 11;
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(86, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(182, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(446, 32);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 22);
            this.btnRemove.StyleController = this.layoutControl1;
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(538, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 22);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtMembers
            // 
            this.dtMembers.Location = new System.Drawing.Point(12, 58);
            this.dtMembers.MainView = this.gvMembers;
            this.dtMembers.Name = "dtMembers";
            this.dtMembers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dtMembers.Size = new System.Drawing.Size(618, 515);
            this.dtMembers.TabIndex = 6;
            this.dtMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMembers});
            // 
            // gvMembers
            // 
            this.gvMembers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.family_member_name,
            this.description_case,
            this.formated_dob,
            this.age,
            this.sex,
            this.is_active,
            this.id});
            this.gvMembers.GridControl = this.dtMembers;
            this.gvMembers.GroupCount = 1;
            this.gvMembers.Name = "gvMembers";
            this.gvMembers.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvMembers.OptionsBehavior.Editable = false;
            this.gvMembers.OptionsFind.AlwaysVisible = true;
            this.gvMembers.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMembers.OptionsView.RowAutoHeight = true;
            this.gvMembers.OptionsView.ShowGroupPanel = false;
            this.gvMembers.OptionsView.ShowIndicator = false;
            this.gvMembers.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.description_case, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvMembers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMembers_FocusedRowChanged);
            // 
            // family_member_name
            // 
            this.family_member_name.AppearanceHeader.Options.UseTextOptions = true;
            this.family_member_name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.family_member_name.Caption = "Family Member Name";
            this.family_member_name.FieldName = "name";
            this.family_member_name.Name = "family_member_name";
            this.family_member_name.Visible = true;
            this.family_member_name.VisibleIndex = 0;
            this.family_member_name.Width = 239;
            // 
            // description_case
            // 
            this.description_case.Caption = "Member Type";
            this.description_case.FieldName = "description_case";
            this.description_case.Name = "description_case";
            this.description_case.Visible = true;
            this.description_case.VisibleIndex = 1;
            // 
            // formated_dob
            // 
            this.formated_dob.Caption = "Birthday";
            this.formated_dob.FieldName = "formated_dob";
            this.formated_dob.Name = "formated_dob";
            this.formated_dob.Visible = true;
            this.formated_dob.VisibleIndex = 1;
            this.formated_dob.Width = 84;
            // 
            // age
            // 
            this.age.AppearanceCell.Options.UseTextOptions = true;
            this.age.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.age.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.age.Caption = "Age";
            this.age.FieldName = "age";
            this.age.Name = "age";
            this.age.Visible = true;
            this.age.VisibleIndex = 2;
            this.age.Width = 84;
            // 
            // sex
            // 
            this.sex.Caption = "Sex";
            this.sex.FieldName = "sex";
            this.sex.Name = "sex";
            this.sex.Visible = true;
            this.sex.VisibleIndex = 3;
            this.sex.Width = 88;
            // 
            // is_active
            // 
            this.is_active.Caption = "Active";
            this.is_active.FieldName = "is_active";
            this.is_active.Name = "is_active";
            this.is_active.Visible = true;
            this.is_active.VisibleIndex = 4;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
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
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.lblHeadName,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(642, 585);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 20);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(74, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtMembers;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(622, 519);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnRefresh;
            this.layoutControlItem2.Location = new System.Drawing.Point(526, 20);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(96, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(96, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(96, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnRemove;
            this.layoutControlItem3.Location = new System.Drawing.Point(434, 20);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(92, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(92, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(92, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(170, 20);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(86, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(86, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(86, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnAdd;
            this.layoutControlItem5.Location = new System.Drawing.Point(74, 20);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(96, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(96, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(96, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // lblHeadName
            // 
            this.lblHeadName.AllowHotTrack = false;
            this.lblHeadName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadName.AppearanceItemCaption.Options.UseFont = true;
            this.lblHeadName.Location = new System.Drawing.Point(0, 0);
            this.lblHeadName.Name = "lblHeadName";
            this.lblHeadName.Size = new System.Drawing.Size(622, 20);
            this.lblHeadName.TextSize = new System.Drawing.Size(116, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnView;
            this.layoutControlItem6.Location = new System.Drawing.Point(256, 20);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(81, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(81, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(81, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnDeactivate;
            this.layoutControlItem7.Location = new System.Drawing.Point(337, 20);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(97, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(97, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(97, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // bwGetPurokFamilyMembers
            // 
            this.bwGetPurokFamilyMembers.WorkerSupportsCancellation = true;
            this.bwGetPurokFamilyMembers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetPurokFamilyMembers_DoWork);
            this.bwGetPurokFamilyMembers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetPurokFamilyMembers_RunWorkerCompleted);
            // 
            // bwDeletePurokFamilyMember
            // 
            this.bwDeletePurokFamilyMember.WorkerSupportsCancellation = true;
            this.bwDeletePurokFamilyMember.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDeletePurokFamilyMember_DoWork);
            this.bwDeletePurokFamilyMember.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDeletePurokFamilyMember_RunWorkerCompleted);
            // 
            // bwDeactivateMember
            // 
            this.bwDeactivateMember.WorkerSupportsCancellation = true;
            this.bwDeactivateMember.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDeactivateMember_DoWork);
            this.bwDeactivateMember.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDeactivateMember_RunWorkerCompleted);
            // 
            // PurokFamilyMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 585);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurokFamilyMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Purok Family Members";
            this.Load += new System.EventHandler(this.PurokFamilyMembersForm_Load);
            this.Shown += new System.EventHandler(this.PurokFamilyMembersForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeadName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.GridControl dtMembers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMembers;
        private DevExpress.XtraGrid.Columns.GridColumn family_member_name;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwGetPurokFamilyMembers;
        private System.ComponentModel.BackgroundWorker bwDeletePurokFamilyMember;
        public DevExpress.XtraLayout.SimpleLabelItem lblHeadName;
        private DevExpress.XtraGrid.Columns.GridColumn description_case;
        private DevExpress.XtraGrid.Columns.GridColumn formated_dob;
        private DevExpress.XtraGrid.Columns.GridColumn age;
        private DevExpress.XtraGrid.Columns.GridColumn sex;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnDeactivate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.ComponentModel.BackgroundWorker bwDeactivateMember;
        private DevExpress.XtraGrid.Columns.GridColumn is_active;
    }
}