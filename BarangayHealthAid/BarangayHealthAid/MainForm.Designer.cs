namespace BarangayHealthAid
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnFamilyPlanning = new DevExpress.XtraBars.BarButtonItem();
            this.btnForm4b = new DevExpress.XtraBars.BarButtonItem();
            this.btnMaternalHealth = new DevExpress.XtraBars.BarButtonItem();
            this.btnClinicalRecord = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserManagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnPurok = new DevExpress.XtraBars.BarButtonItem();
            this.btnOpt = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgOPT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgManagement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBackend = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnFamilyPlanning,
            this.btnForm4b,
            this.btnMaternalHealth,
            this.btnClinicalRecord,
            this.btnUserManagement,
            this.btnPurok,
            this.btnOpt,
            this.btnLogout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.btnLogout);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMain});
            this.ribbon.Size = new System.Drawing.Size(1060, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnFamilyPlanning
            // 
            this.btnFamilyPlanning.Caption = "Family Planning";
            this.btnFamilyPlanning.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFamilyPlanning.Glyph")));
            this.btnFamilyPlanning.Id = 1;
            this.btnFamilyPlanning.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnFamilyPlanning.LargeGlyph")));
            this.btnFamilyPlanning.Name = "btnFamilyPlanning";
            this.btnFamilyPlanning.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFamilyPlanning_ItemClick);
            // 
            // btnForm4b
            // 
            this.btnForm4b.Caption = "Form 4B";
            this.btnForm4b.Glyph = ((System.Drawing.Image)(resources.GetObject("btnForm4b.Glyph")));
            this.btnForm4b.Id = 2;
            this.btnForm4b.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnForm4b.LargeGlyph")));
            this.btnForm4b.Name = "btnForm4b";
            this.btnForm4b.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnForm4b.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnForm4b_ItemClick);
            // 
            // btnMaternalHealth
            // 
            this.btnMaternalHealth.Caption = "Maternal Health Record";
            this.btnMaternalHealth.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMaternalHealth.Glyph")));
            this.btnMaternalHealth.Id = 3;
            this.btnMaternalHealth.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMaternalHealth.LargeGlyph")));
            this.btnMaternalHealth.Name = "btnMaternalHealth";
            this.btnMaternalHealth.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMaternalHealth_ItemClick);
            // 
            // btnClinicalRecord
            // 
            this.btnClinicalRecord.Caption = "Clinical Record";
            this.btnClinicalRecord.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClinicalRecord.Glyph")));
            this.btnClinicalRecord.Id = 4;
            this.btnClinicalRecord.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnClinicalRecord.LargeGlyph")));
            this.btnClinicalRecord.Name = "btnClinicalRecord";
            this.btnClinicalRecord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClinicalRecord_ItemClick);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Caption = "User Management";
            this.btnUserManagement.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUserManagement.Glyph")));
            this.btnUserManagement.Id = 5;
            this.btnUserManagement.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUserManagement.LargeGlyph")));
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUserManagement_ItemClick);
            // 
            // btnPurok
            // 
            this.btnPurok.Caption = "Purok Management";
            this.btnPurok.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPurok.Glyph")));
            this.btnPurok.Id = 6;
            this.btnPurok.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPurok.LargeGlyph")));
            this.btnPurok.Name = "btnPurok";
            this.btnPurok.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPurok_ItemClick);
            // 
            // btnOpt
            // 
            this.btnOpt.Caption = "Out Patient";
            this.btnOpt.Glyph = ((System.Drawing.Image)(resources.GetObject("btnOpt.Glyph")));
            this.btnOpt.Id = 7;
            this.btnOpt.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnOpt.LargeGlyph")));
            this.btnOpt.Name = "btnOpt";
            this.btnOpt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOpt_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "btnLogout";
            this.btnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.Glyph")));
            this.btnLogout.Id = 8;
            this.btnLogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.LargeGlyph")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // rpMain
            // 
            this.rpMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgReports,
            this.rpgOPT,
            this.rpgManagement,
            this.rpgBackend});
            this.rpMain.Name = "rpMain";
            this.rpMain.Text = "Main";
            // 
            // rpgReports
            // 
            this.rpgReports.AllowTextClipping = false;
            this.rpgReports.ItemLinks.Add(this.btnFamilyPlanning);
            this.rpgReports.ItemLinks.Add(this.btnForm4b);
            this.rpgReports.ItemLinks.Add(this.btnMaternalHealth);
            this.rpgReports.ItemLinks.Add(this.btnClinicalRecord);
            this.rpgReports.Name = "rpgReports";
            this.rpgReports.ShowCaptionButton = false;
            this.rpgReports.Text = "Reports";
            // 
            // rpgOPT
            // 
            this.rpgOPT.AllowTextClipping = false;
            this.rpgOPT.ItemLinks.Add(this.btnOpt);
            this.rpgOPT.Name = "rpgOPT";
            this.rpgOPT.ShowCaptionButton = false;
            this.rpgOPT.Text = "Out Patient";
            // 
            // rpgManagement
            // 
            this.rpgManagement.AllowTextClipping = false;
            this.rpgManagement.ItemLinks.Add(this.btnPurok);
            this.rpgManagement.Name = "rpgManagement";
            this.rpgManagement.ShowCaptionButton = false;
            this.rpgManagement.Text = "Management";
            // 
            // rpgBackend
            // 
            this.rpgBackend.AllowTextClipping = false;
            this.rpgBackend.ItemLinks.Add(this.btnUserManagement);
            this.rpgBackend.Name = "rpgBackend";
            this.rpgBackend.ShowCaptionButton = false;
            this.rpgBackend.Text = "Back End";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1060, 31);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Mainform";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReports;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnFamilyPlanning;
        private DevExpress.XtraBars.BarButtonItem btnForm4b;
        private DevExpress.XtraBars.BarButtonItem btnMaternalHealth;
        private DevExpress.XtraBars.BarButtonItem btnClinicalRecord;
        private DevExpress.XtraBars.BarButtonItem btnUserManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBackend;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgManagement;
        private DevExpress.XtraBars.BarButtonItem btnPurok;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgOPT;
        private DevExpress.XtraBars.BarButtonItem btnOpt;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
    }
}