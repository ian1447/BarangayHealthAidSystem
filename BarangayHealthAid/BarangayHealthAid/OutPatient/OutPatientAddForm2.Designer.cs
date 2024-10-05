namespace BarangayHealthAid.OutPatient
{
    partial class OutPatientAddForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutPatientAddForm2));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtNutStat = new DevExpress.XtraEditors.TextEdit();
            this.txtPurok = new DevExpress.XtraEditors.TextEdit();
            this.txtWeight = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.meRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.txtPatient = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BarangayHealthAid.WaitForm1), true, true);
            this.bwAddOutPatient = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNutStat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtNutStat);
            this.layoutControl1.Controls.Add(this.txtPurok);
            this.layoutControl1.Controls.Add(this.txtWeight);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.meRemarks);
            this.layoutControl1.Controls.Add(this.txtPatient);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(600, 52, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(383, 176);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtNutStat
            // 
            this.txtNutStat.Location = new System.Drawing.Point(104, 60);
            this.txtNutStat.Name = "txtNutStat";
            this.txtNutStat.Size = new System.Drawing.Size(267, 20);
            this.txtNutStat.StyleController = this.layoutControl1;
            this.txtNutStat.TabIndex = 6;
            // 
            // txtPurok
            // 
            this.txtPurok.Location = new System.Drawing.Point(225, 36);
            this.txtPurok.Name = "txtPurok";
            this.txtPurok.Properties.EditFormat.FormatString = "n2";
            this.txtPurok.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPurok.Properties.Mask.EditMask = "n2";
            this.txtPurok.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPurok.Size = new System.Drawing.Size(146, 20);
            this.txtPurok.StyleController = this.layoutControl1;
            this.txtPurok.TabIndex = 9;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(60, 36);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Properties.EditFormat.FormatString = "n2";
            this.txtWeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWeight.Properties.Mask.EditMask = "n2";
            this.txtWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWeight.Size = new System.Drawing.Size(113, 20);
            this.txtWeight.StyleController = this.layoutControl1;
            this.txtWeight.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(237, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(124, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // meRemarks
            // 
            this.meRemarks.Location = new System.Drawing.Point(60, 84);
            this.meRemarks.Name = "meRemarks";
            this.meRemarks.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meRemarks.Size = new System.Drawing.Size(311, 54);
            this.meRemarks.StyleController = this.layoutControl1;
            this.meRemarks.TabIndex = 5;
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(60, 12);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Properties.ReadOnly = true;
            this.txtPatient.Size = new System.Drawing.Size(311, 20);
            this.txtPatient.StyleController = this.layoutControl1;
            this.txtPatient.TabIndex = 4;
            this.txtPatient.Click += new System.EventHandler(this.txtPatient_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(383, 176);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtPatient;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(363, 24);
            this.layoutControlItem1.Text = "Patient:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.meRemarks;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(363, 58);
            this.layoutControlItem2.Text = "Remarks:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCancel;
            this.layoutControlItem3.Location = new System.Drawing.Point(112, 130);
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
            this.layoutControlItem4.Control = this.btnSave;
            this.layoutControlItem4.Location = new System.Drawing.Point(225, 130);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(138, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(138, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(138, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 130);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(112, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtWeight;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(165, 24);
            this.layoutControlItem5.Text = "Weight:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtPurok;
            this.layoutControlItem7.Location = new System.Drawing.Point(165, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(198, 24);
            this.layoutControlItem7.Text = "Purok:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtNutStat;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(363, 24);
            this.layoutControlItem8.Text = "Nutritional Status:";
            this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(87, 13);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // bwAddOutPatient
            // 
            this.bwAddOutPatient.WorkerSupportsCancellation = true;
            this.bwAddOutPatient.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAddOutPatient_DoWork);
            this.bwAddOutPatient.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAddOutPatient_RunWorkerCompleted);
            // 
            // OutPatientAddForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 176);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutPatientAddForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Out Patient Add";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNutStat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtPatient;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.MemoEdit meRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        public DevExpress.XtraEditors.TextEdit txtWeight;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        public DevExpress.XtraEditors.TextEdit txtPurok;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        public DevExpress.XtraEditors.TextEdit txtNutStat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwAddOutPatient;
    }
}