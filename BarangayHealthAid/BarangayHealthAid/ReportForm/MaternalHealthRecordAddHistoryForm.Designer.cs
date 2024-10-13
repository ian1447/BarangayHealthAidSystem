namespace BarangayHealthAid.ReportForm
{
    partial class MaternalHealthRecordAddHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaternalHealthRecordAddHistoryForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.meNotes = new DevExpress.XtraEditors.MemoEdit();
            this.txtFindings = new DevExpress.XtraEditors.TextEdit();
            this.txtFetus = new DevExpress.XtraEditors.TextEdit();
            this.txtfhb = new DevExpress.XtraEditors.TextEdit();
            this.txtfh = new DevExpress.XtraEditors.TextEdit();
            this.txtWeight = new DevExpress.XtraEditors.TextEdit();
            this.txtbp = new DevExpress.XtraEditors.TextEdit();
            this.txtAog = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BarangayHealthAid.WaitForm1), true, true);
            this.bwAddMaternalHistory = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFindings.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFetus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfhb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.meNotes);
            this.layoutControl1.Controls.Add(this.txtFindings);
            this.layoutControl1.Controls.Add(this.txtFetus);
            this.layoutControl1.Controls.Add(this.txtfhb);
            this.layoutControl1.Controls.Add(this.txtfh);
            this.layoutControl1.Controls.Add(this.txtWeight);
            this.layoutControl1.Controls.Add(this.txtbp);
            this.layoutControl1.Controls.Add(this.txtAog);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(656, 26, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(419, 247);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(12, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(211, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(196, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // meNotes
            // 
            this.meNotes.Location = new System.Drawing.Point(12, 150);
            this.meNotes.Name = "meNotes";
            this.meNotes.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meNotes.Size = new System.Drawing.Size(395, 59);
            this.meNotes.StyleController = this.layoutControl1;
            this.meNotes.TabIndex = 9;
            // 
            // txtFindings
            // 
            this.txtFindings.Location = new System.Drawing.Point(176, 110);
            this.txtFindings.Name = "txtFindings";
            this.txtFindings.Properties.Mask.EditMask = "f";
            this.txtFindings.Size = new System.Drawing.Size(231, 20);
            this.txtFindings.StyleController = this.layoutControl1;
            this.txtFindings.TabIndex = 8;
            // 
            // txtFetus
            // 
            this.txtFetus.Location = new System.Drawing.Point(12, 110);
            this.txtFetus.Name = "txtFetus";
            this.txtFetus.Properties.Mask.EditMask = "f";
            this.txtFetus.Size = new System.Drawing.Size(160, 20);
            this.txtFetus.StyleController = this.layoutControl1;
            this.txtFetus.TabIndex = 7;
            // 
            // txtfhb
            // 
            this.txtfhb.Location = new System.Drawing.Point(176, 68);
            this.txtfhb.Name = "txtfhb";
            this.txtfhb.Properties.Mask.EditMask = "f";
            this.txtfhb.Size = new System.Drawing.Size(231, 20);
            this.txtfhb.StyleController = this.layoutControl1;
            this.txtfhb.TabIndex = 6;
            // 
            // txtfh
            // 
            this.txtfh.Location = new System.Drawing.Point(12, 68);
            this.txtfh.Name = "txtfh";
            this.txtfh.Properties.Mask.EditMask = "f";
            this.txtfh.Size = new System.Drawing.Size(160, 20);
            this.txtfh.StyleController = this.layoutControl1;
            this.txtfh.TabIndex = 6;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(146, 28);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Properties.Mask.EditMask = "f";
            this.txtWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWeight.Size = new System.Drawing.Size(136, 20);
            this.txtWeight.StyleController = this.layoutControl1;
            this.txtWeight.TabIndex = 6;
            // 
            // txtbp
            // 
            this.txtbp.Location = new System.Drawing.Point(286, 28);
            this.txtbp.Name = "txtbp";
            this.txtbp.Properties.Mask.EditMask = "f";
            this.txtbp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtbp.Size = new System.Drawing.Size(121, 20);
            this.txtbp.StyleController = this.layoutControl1;
            this.txtbp.TabIndex = 6;
            // 
            // txtAog
            // 
            this.txtAog.Location = new System.Drawing.Point(12, 28);
            this.txtAog.Name = "txtAog";
            this.txtAog.Properties.Mask.EditMask = "f";
            this.txtAog.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAog.Size = new System.Drawing.Size(130, 20);
            this.txtAog.StyleController = this.layoutControl1;
            this.txtAog.TabIndex = 5;
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
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(419, 247);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtAog;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(134, 40);
            this.layoutControlItem1.Text = "AOG:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtbp;
            this.layoutControlItem2.Location = new System.Drawing.Point(274, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(125, 40);
            this.layoutControlItem2.Text = "BP";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtWeight;
            this.layoutControlItem3.Location = new System.Drawing.Point(134, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(140, 40);
            this.layoutControlItem3.Text = "Weight:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtfh;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(164, 40);
            this.layoutControlItem4.Text = "FH:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtfhb;
            this.layoutControlItem5.Location = new System.Drawing.Point(164, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(235, 40);
            this.layoutControlItem5.Text = "FHB:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtFetus;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(164, 42);
            this.layoutControlItem6.Text = "Presenting part of the Fetus:";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(140, 13);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtFindings;
            this.layoutControlItem7.Location = new System.Drawing.Point(164, 80);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(235, 42);
            this.layoutControlItem7.Text = "Findings:";
            this.layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(43, 13);
            this.layoutControlItem7.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.meNotes;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(399, 79);
            this.layoutControlItem8.Text = "Nurses/Midwife notes:";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnSave;
            this.layoutControlItem9.Location = new System.Drawing.Point(199, 201);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(200, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnCancel;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 201);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(199, 26);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // bwAddMaternalHistory
            // 
            this.bwAddMaternalHistory.WorkerSupportsCancellation = true;
            this.bwAddMaternalHistory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAddMaternalHistory_DoWork);
            this.bwAddMaternalHistory.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAddMaternalHistory_RunWorkerCompleted);
            // 
            // MaternalHealthRecordAddHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 247);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaternalHealthRecordAddHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maternal Health Record History";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFindings.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFetus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfhb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtAog;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtWeight;
        private DevExpress.XtraEditors.TextEdit txtbp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtFindings;
        private DevExpress.XtraEditors.TextEdit txtFetus;
        private DevExpress.XtraEditors.TextEdit txtfhb;
        private DevExpress.XtraEditors.TextEdit txtfh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.MemoEdit meNotes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwAddMaternalHistory;
    }
}