namespace Udemy.Restaurant.Core.Function
{
    partial class FrmSetupConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetupConnection));
            this.chkWindows = new DevExpress.XtraEditors.CheckButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chkSql = new DevExpress.XtraEditors.CheckButton();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnBaglantiTest = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkWindows
            // 
            this.chkWindows.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkWindows.Appearance.Options.UseFont = true;
            this.chkWindows.Checked = true;
            this.chkWindows.GroupIndex = 1;
            this.chkWindows.ImageOptions.ImageIndex = 1;
            this.chkWindows.ImageOptions.ImageList = this.ımageList1;
            this.chkWindows.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.chkWindows.Location = new System.Drawing.Point(13, 1);
            this.chkWindows.Name = "chkWindows";
            this.chkWindows.Size = new System.Drawing.Size(200, 158);
            this.chkWindows.TabIndex = 0;
            this.chkWindows.Text = "Windows Oturumu";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "SQL Server.png");
            this.ımageList1.Images.SetKeyName(1, "Windows.png");
            // 
            // chkSql
            // 
            this.chkSql.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSql.Appearance.Options.UseFont = true;
            this.chkSql.GroupIndex = 1;
            this.chkSql.ImageOptions.ImageIndex = 0;
            this.chkSql.ImageOptions.ImageList = this.ımageList1;
            this.chkSql.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.chkSql.Location = new System.Drawing.Point(222, 1);
            this.chkSql.Name = "chkSql";
            this.chkSql.Size = new System.Drawing.Size(200, 158);
            this.chkSql.TabIndex = 1;
            this.chkSql.TabStop = false;
            this.chkSql.Text = "SQL Server Oturumu";
            this.chkSql.CheckedChanged += new System.EventHandler(this.chkSql_CheckedChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(12, 165);
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtServer.Properties.Appearance.Options.UseFont = true;
            this.txtServer.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtServer.Properties.ContextImageOptions.Image")));
            this.txtServer.Size = new System.Drawing.Size(409, 36);
            this.txtServer.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(12, 207);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUser.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtUser.Properties.ContextImageOptions.Image")));
            this.txtUser.Size = new System.Drawing.Size(409, 36);
            this.txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(13, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtPassword.Properties.ContextImageOptions.Image")));
            this.txtPassword.Size = new System.Drawing.Size(409, 36);
            this.txtPassword.TabIndex = 4;
            // 
            // btnBaglantiTest
            // 
            this.btnBaglantiTest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaglantiTest.ImageOptions.Image")));
            this.btnBaglantiTest.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnBaglantiTest.Location = new System.Drawing.Point(13, 291);
            this.btnBaglantiTest.Name = "btnBaglantiTest";
            this.btnBaglantiTest.Size = new System.Drawing.Size(133, 47);
            this.btnBaglantiTest.TabIndex = 5;
            this.btnBaglantiTest.Text = "Bağlantıyı Test Et";
            this.btnBaglantiTest.Click += new System.EventHandler(this.btnBaglantiTest_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKaydet.Location = new System.Drawing.Point(152, 291);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 47);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Ayarları Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnKapat.Location = new System.Drawing.Point(288, 291);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(133, 47);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmSetupConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 348);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnBaglantiTest);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.chkSql);
            this.Controls.Add(this.chkWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetupConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSetupConnection";
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton chkWindows;
        private DevExpress.XtraEditors.CheckButton chkSql;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnBaglantiTest;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}