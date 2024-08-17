namespace BarangayHealthAid
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblErrorLogin = new DevExpress.XtraEditors.LabelControl();
            this.lblConnSettings = new DevExpress.XtraEditors.LabelControl();
            this.lblNoconnection = new DevExpress.XtraEditors.LabelControl();
            this.lblVersion = new DevExpress.XtraEditors.LabelControl();
            this.ceChange = new DevExpress.XtraEditors.CheckEdit();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BarangayHealthAid.WaitForm1), true, true);
            this.bwUsersLogin = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChange.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(51, 25);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(209, 173);
            this.pictureEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(39, 218);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(234, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "BARANGAY AID SYSTEM";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(26, 278);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(262, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 259);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Username: *";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 307);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Password: *";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(26, 326);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(262, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(26, 374);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(262, 37);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLogin.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLogin.Location = new System.Drawing.Point(71, 354);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(166, 14);
            this.lblErrorLogin.TabIndex = 7;
            this.lblErrorLogin.Text = "Invalid Username or Password!";
            this.lblErrorLogin.Visible = false;
            // 
            // lblConnSettings
            // 
            this.lblConnSettings.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnSettings.Location = new System.Drawing.Point(182, 446);
            this.lblConnSettings.Name = "lblConnSettings";
            this.lblConnSettings.Size = new System.Drawing.Size(123, 17);
            this.lblConnSettings.TabIndex = 18;
            this.lblConnSettings.Text = "[Connection Settings]";
            this.lblConnSettings.Click += new System.EventHandler(this.lblConnSettings_Click);
            // 
            // lblNoconnection
            // 
            this.lblNoconnection.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoconnection.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblNoconnection.Location = new System.Drawing.Point(201, 426);
            this.lblNoconnection.Name = "lblNoconnection";
            this.lblNoconnection.Size = new System.Drawing.Size(104, 14);
            this.lblNoconnection.TabIndex = 17;
            this.lblNoconnection.Text = "Invalid Connection!";
            this.lblNoconnection.Visible = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(12, 446);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(43, 13);
            this.lblVersion.TabIndex = 19;
            this.lblVersion.Text = "[Version]";
            // 
            // ceChange
            // 
            this.ceChange.Location = new System.Drawing.Point(228, 256);
            this.ceChange.Name = "ceChange";
            this.ceChange.Properties.Caption = "Change";
            this.ceChange.Size = new System.Drawing.Size(60, 19);
            this.ceChange.TabIndex = 20;
            this.ceChange.CheckedChanged += new System.EventHandler(this.ceChange_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(264, 326);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(24, 23);
            this.btnShow.TabIndex = 21;
            this.btnShow.Text = "S";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // bwUsersLogin
            // 
            this.bwUsersLogin.WorkerSupportsCancellation = true;
            this.bwUsersLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUsersLogin_DoWork);
            this.bwUsersLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUsersLogin_RunWorkerCompleted);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 473);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.ceChange);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblConnSettings);
            this.Controls.Add(this.lblNoconnection);
            this.Controls.Add(this.lblErrorLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barangay Aid System";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChange.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl lblErrorLogin;
        private DevExpress.XtraEditors.LabelControl lblConnSettings;
        private DevExpress.XtraEditors.LabelControl lblNoconnection;
        private DevExpress.XtraEditors.LabelControl lblVersion;
        private DevExpress.XtraEditors.CheckEdit ceChange;
        private DevExpress.XtraEditors.SimpleButton btnShow;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwUsersLogin;
    }
}