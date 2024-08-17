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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnFamilyPlanning = new DevExpress.XtraBars.BarButtonItem();
            this.btnForm4b = new DevExpress.XtraBars.BarButtonItem();
            this.btnMaternalHealth = new DevExpress.XtraBars.BarButtonItem();
            this.btnClinicalRecord = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
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
            this.btnClinicalRecord});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMain});
            this.ribbon.Size = new System.Drawing.Size(1060, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // rpMain
            // 
            this.rpMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgReports});
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1060, 31);
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
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Mainform";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
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
    }
}