namespace BarangayHealthAid
{
    partial class ConnectionSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionSettingsForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblProjectName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblConnectionStringStatusDG = new DevExpress.XtraEditors.LabelControl();
            this.txtPortDG = new DevExpress.XtraEditors.TextEdit();
            this.txtServerDG = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.chkChangeDatabaseDG = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDatabaseDG = new DevExpress.XtraEditors.TextEdit();
            this.btnTestConnectionDG = new DevExpress.XtraEditors.SimpleButton();
            this.txtPasswordDG = new DevExpress.XtraEditors.TextEdit();
            this.txtUsernameDG = new DevExpress.XtraEditors.TextEdit();
            this.btnSaveDG = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BarangayHealthAid.WaitForm1), true, true);
            this.bwCheckConnection = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChangeDatabaseDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsernameDG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.lblProjectName);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lblConnectionStringStatusDG);
            this.panelControl1.Controls.Add(this.txtPortDG);
            this.panelControl1.Controls.Add(this.txtServerDG);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.chkChangeDatabaseDG);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtDatabaseDG);
            this.panelControl1.Controls.Add(this.btnTestConnectionDG);
            this.panelControl1.Controls.Add(this.txtPasswordDG);
            this.panelControl1.Controls.Add(this.txtUsernameDG);
            this.panelControl1.Controls.Add(this.btnSaveDG);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Location = new System.Drawing.Point(11, 11);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(263, 298);
            this.panelControl1.TabIndex = 1;
            // 
            // lblProjectName
            // 
            this.lblProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblProjectName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblProjectName.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblProjectName.LineVisible = true;
            this.lblProjectName.Location = new System.Drawing.Point(0, 282);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Padding = new System.Windows.Forms.Padding(33, 0, 100, 0);
            this.lblProjectName.Size = new System.Drawing.Size(197, 13);
            this.lblProjectName.TabIndex = 229;
            this.lblProjectName.Text = "Project Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic);
            this.labelControl2.Location = new System.Drawing.Point(10, 9);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 15);
            this.labelControl2.TabIndex = 215;
            this.labelControl2.Text = "Server *";
            // 
            // lblConnectionStringStatusDG
            // 
            this.lblConnectionStringStatusDG.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStringStatusDG.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.lblConnectionStringStatusDG.Location = new System.Drawing.Point(10, 218);
            this.lblConnectionStringStatusDG.Margin = new System.Windows.Forms.Padding(2);
            this.lblConnectionStringStatusDG.Name = "lblConnectionStringStatusDG";
            this.lblConnectionStringStatusDG.Size = new System.Drawing.Size(142, 15);
            this.lblConnectionStringStatusDG.TabIndex = 228;
            this.lblConnectionStringStatusDG.Text = "Default Form Name Label";
            this.lblConnectionStringStatusDG.Visible = false;
            // 
            // txtPortDG
            // 
            this.txtPortDG.EditValue = "3306";
            this.txtPortDG.Location = new System.Drawing.Point(16, 141);
            this.txtPortDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtPortDG.Name = "txtPortDG";
            this.txtPortDG.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPortDG.Properties.Appearance.Options.UseFont = true;
            this.txtPortDG.Size = new System.Drawing.Size(125, 24);
            this.txtPortDG.TabIndex = 222;
            // 
            // txtServerDG
            // 
            this.txtServerDG.EditValue = "192.168.254.108";
            this.txtServerDG.Location = new System.Drawing.Point(16, 27);
            this.txtServerDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerDG.Name = "txtServerDG";
            this.txtServerDG.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtServerDG.Properties.Appearance.Options.UseFont = true;
            this.txtServerDG.Size = new System.Drawing.Size(232, 24);
            this.txtServerDG.TabIndex = 216;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic);
            this.labelControl6.Location = new System.Drawing.Point(10, 168);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 15);
            this.labelControl6.TabIndex = 223;
            this.labelControl6.Text = "Database *";
            // 
            // chkChangeDatabaseDG
            // 
            this.chkChangeDatabaseDG.Location = new System.Drawing.Point(145, 192);
            this.chkChangeDatabaseDG.Margin = new System.Windows.Forms.Padding(2);
            this.chkChangeDatabaseDG.Name = "chkChangeDatabaseDG";
            this.chkChangeDatabaseDG.Properties.Caption = "Change";
            this.chkChangeDatabaseDG.Size = new System.Drawing.Size(64, 19);
            this.chkChangeDatabaseDG.TabIndex = 227;
            this.chkChangeDatabaseDG.CheckedChanged += new System.EventHandler(this.chkChangeDatabaseDG_CheckedChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic);
            this.labelControl5.Location = new System.Drawing.Point(9, 127);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 15);
            this.labelControl5.TabIndex = 221;
            this.labelControl5.Text = "Port *";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic);
            this.labelControl3.Location = new System.Drawing.Point(9, 51);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 15);
            this.labelControl3.TabIndex = 217;
            this.labelControl3.Text = "Username *";
            // 
            // txtDatabaseDG
            // 
            this.txtDatabaseDG.EditValue = "barangay_aid";
            this.txtDatabaseDG.Enabled = false;
            this.txtDatabaseDG.Location = new System.Drawing.Point(16, 187);
            this.txtDatabaseDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatabaseDG.Name = "txtDatabaseDG";
            this.txtDatabaseDG.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDatabaseDG.Properties.Appearance.Options.UseFont = true;
            this.txtDatabaseDG.Size = new System.Drawing.Size(125, 24);
            this.txtDatabaseDG.TabIndex = 224;
            // 
            // btnTestConnectionDG
            // 
            this.btnTestConnectionDG.Image = ((System.Drawing.Image)(resources.GetObject("btnTestConnectionDG.Image")));
            this.btnTestConnectionDG.Location = new System.Drawing.Point(3, 244);
            this.btnTestConnectionDG.Margin = new System.Windows.Forms.Padding(2);
            this.btnTestConnectionDG.Name = "btnTestConnectionDG";
            this.btnTestConnectionDG.Size = new System.Drawing.Size(106, 24);
            this.btnTestConnectionDG.TabIndex = 226;
            this.btnTestConnectionDG.Text = "Test Connection";
            this.btnTestConnectionDG.Click += new System.EventHandler(this.btnTestConnectionDG_Click);
            // 
            // txtPasswordDG
            // 
            this.txtPasswordDG.EditValue = "system_admin";
            this.txtPasswordDG.Location = new System.Drawing.Point(16, 107);
            this.txtPasswordDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordDG.Name = "txtPasswordDG";
            this.txtPasswordDG.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPasswordDG.Properties.Appearance.Options.UseFont = true;
            this.txtPasswordDG.Properties.PasswordChar = '●';
            this.txtPasswordDG.Size = new System.Drawing.Size(232, 24);
            this.txtPasswordDG.TabIndex = 220;
            // 
            // txtUsernameDG
            // 
            this.txtUsernameDG.EditValue = "system_admin";
            this.txtUsernameDG.Location = new System.Drawing.Point(16, 68);
            this.txtUsernameDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsernameDG.Name = "txtUsernameDG";
            this.txtUsernameDG.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUsernameDG.Properties.Appearance.Options.UseFont = true;
            this.txtUsernameDG.Size = new System.Drawing.Size(232, 24);
            this.txtUsernameDG.TabIndex = 218;
            // 
            // btnSaveDG
            // 
            this.btnSaveDG.Enabled = false;
            this.btnSaveDG.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDG.Image")));
            this.btnSaveDG.Location = new System.Drawing.Point(113, 244);
            this.btnSaveDG.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveDG.Name = "btnSaveDG";
            this.btnSaveDG.Size = new System.Drawing.Size(147, 24);
            this.btnSaveDG.TabIndex = 225;
            this.btnSaveDG.Text = "Save and Exit";
            this.btnSaveDG.Click += new System.EventHandler(this.btnSaveDG_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic);
            this.labelControl4.Location = new System.Drawing.Point(9, 92);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 15);
            this.labelControl4.TabIndex = 219;
            this.labelControl4.Text = "Password *";
            // 
            // bwCheckConnection
            // 
            this.bwCheckConnection.WorkerSupportsCancellation = true;
            this.bwCheckConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCheckConnection_DoWork);
            this.bwCheckConnection.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCheckConnection_RunWorkerCompleted);
            // 
            // ConnectionSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 320);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Settings";
            this.Load += new System.EventHandler(this.ConnectionSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkChangeDatabaseDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsernameDG.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblProjectName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblConnectionStringStatusDG;
        private DevExpress.XtraEditors.TextEdit txtPortDG;
        private DevExpress.XtraEditors.TextEdit txtServerDG;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit chkChangeDatabaseDG;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDatabaseDG;
        private DevExpress.XtraEditors.SimpleButton btnTestConnectionDG;
        private DevExpress.XtraEditors.TextEdit txtPasswordDG;
        private DevExpress.XtraEditors.TextEdit txtUsernameDG;
        private DevExpress.XtraEditors.SimpleButton btnSaveDG;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwCheckConnection;
    }
}