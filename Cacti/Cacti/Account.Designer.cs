namespace Cacti
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.changeEmailBtn = new JThinButton.JThinButton();
            this.changePasswordBtn = new JThinButton.JThinButton();
            this.changeAddressBtn = new JThinButton.JThinButton();
            this.changePhoneNumberBtn = new JThinButton.JThinButton();
            this.closeBtn = new JImageButton.JImageButton();
            this.signOutBtn = new JImageButton.JImageButton();
            this.cartBtn = new JImageButton.JImageButton();
            this.accountBtn = new JImageButton.JImageButton();
            this.homeBtn = new JImageButton.JImageButton();
            this.circularPictureBox1 = new Cacti.CircularPictureBox();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.leftPanel.Controls.Add(this.signOutBtn);
            this.leftPanel.Controls.Add(this.cartBtn);
            this.leftPanel.Controls.Add(this.accountBtn);
            this.leftPanel.Controls.Add(this.homeBtn);
            this.leftPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(60, 583);
            this.leftPanel.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.AddressLbl);
            this.panel1.Controls.Add(this.phoneNumberLbl);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.circularPictureBox1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(60, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 126);
            this.panel1.TabIndex = 42;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.ForeColor = System.Drawing.Color.White;
            this.AddressLbl.Location = new System.Drawing.Point(17, 86);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(116, 16);
            this.AddressLbl.TabIndex = 38;
            this.AddressLbl.Text = "Beirut, Lebanon";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLbl.ForeColor = System.Drawing.Color.White;
            this.phoneNumberLbl.Location = new System.Drawing.Point(17, 65);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(72, 16);
            this.phoneNumberLbl.TabIndex = 38;
            this.phoneNumberLbl.Text = "76123456";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(17, 23);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(179, 16);
            this.emailLbl.TabIndex = 38;
            this.emailLbl.Text = "someone@example.com";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(17, 43);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 16);
            this.nameLbl.TabIndex = 38;
            this.nameLbl.Text = "Name";
            // 
            // changeEmailBtn
            // 
            this.changeEmailBtn.BackColor = System.Drawing.Color.Transparent;
            this.changeEmailBtn.BackgroundColor = System.Drawing.Color.White;
            this.changeEmailBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.changeEmailBtn.BorderRadius = 20;
            this.changeEmailBtn.ButtonText = "Change Email";
            this.changeEmailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeEmailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeEmailBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeEmailBtn.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.changeEmailBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.changeEmailBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.changeEmailBtn.HoverFontColor = System.Drawing.Color.White;
            this.changeEmailBtn.LineThickness = 2;
            this.changeEmailBtn.Location = new System.Drawing.Point(112, 189);
            this.changeEmailBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.changeEmailBtn.Name = "changeEmailBtn";
            this.changeEmailBtn.Size = new System.Drawing.Size(308, 67);
            this.changeEmailBtn.TabIndex = 44;
            this.changeEmailBtn.Click += new System.EventHandler(this.changeEmailBtn_Click);
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.changePasswordBtn.BackgroundColor = System.Drawing.Color.White;
            this.changePasswordBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.changePasswordBtn.BorderRadius = 20;
            this.changePasswordBtn.ButtonText = "Change Password";
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.changePasswordBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.changePasswordBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.changePasswordBtn.HoverFontColor = System.Drawing.Color.White;
            this.changePasswordBtn.LineThickness = 2;
            this.changePasswordBtn.Location = new System.Drawing.Point(112, 276);
            this.changePasswordBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(308, 67);
            this.changePasswordBtn.TabIndex = 44;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // changeAddressBtn
            // 
            this.changeAddressBtn.BackColor = System.Drawing.Color.Transparent;
            this.changeAddressBtn.BackgroundColor = System.Drawing.Color.White;
            this.changeAddressBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.changeAddressBtn.BorderRadius = 20;
            this.changeAddressBtn.ButtonText = "Add/Change Location";
            this.changeAddressBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeAddressBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAddressBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAddressBtn.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.changeAddressBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.changeAddressBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.changeAddressBtn.HoverFontColor = System.Drawing.Color.White;
            this.changeAddressBtn.LineThickness = 2;
            this.changeAddressBtn.Location = new System.Drawing.Point(112, 363);
            this.changeAddressBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.changeAddressBtn.Name = "changeAddressBtn";
            this.changeAddressBtn.Size = new System.Drawing.Size(308, 67);
            this.changeAddressBtn.TabIndex = 44;
            this.changeAddressBtn.Click += new System.EventHandler(this.changeAddressBtn_Click);
            // 
            // changePhoneNumberBtn
            // 
            this.changePhoneNumberBtn.BackColor = System.Drawing.Color.Transparent;
            this.changePhoneNumberBtn.BackgroundColor = System.Drawing.Color.White;
            this.changePhoneNumberBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.changePhoneNumberBtn.BorderRadius = 20;
            this.changePhoneNumberBtn.ButtonText = "Add/Change Phone Number";
            this.changePhoneNumberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePhoneNumberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePhoneNumberBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePhoneNumberBtn.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.changePhoneNumberBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.changePhoneNumberBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.changePhoneNumberBtn.HoverFontColor = System.Drawing.Color.White;
            this.changePhoneNumberBtn.LineThickness = 2;
            this.changePhoneNumberBtn.Location = new System.Drawing.Point(112, 450);
            this.changePhoneNumberBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.changePhoneNumberBtn.Name = "changePhoneNumberBtn";
            this.changePhoneNumberBtn.Size = new System.Drawing.Size(308, 67);
            this.changePhoneNumberBtn.TabIndex = 44;
            this.changePhoneNumberBtn.Click += new System.EventHandler(this.changePhoneNumberBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.CausesValidation = false;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.ErrorImage")));
            this.closeBtn.Image = global::Cacti.Properties.Resources.Close;
            this.closeBtn.ImageHover = null;
            this.closeBtn.InitialImage = null;
            this.closeBtn.Location = new System.Drawing.Point(352, 13);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 36;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // signOutBtn
            // 
            this.signOutBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.signOutBtn.CausesValidation = false;
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("signOutBtn.ErrorImage")));
            this.signOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("signOutBtn.Image")));
            this.signOutBtn.ImageHover = null;
            this.signOutBtn.InitialImage = null;
            this.signOutBtn.Location = new System.Drawing.Point(0, 458);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(60, 30);
            this.signOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.signOutBtn.TabIndex = 32;
            this.signOutBtn.Zoom = 4;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // cartBtn
            // 
            this.cartBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cartBtn.BackColor = System.Drawing.Color.Transparent;
            this.cartBtn.CausesValidation = false;
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("cartBtn.ErrorImage")));
            this.cartBtn.Image = ((System.Drawing.Image)(resources.GetObject("cartBtn.Image")));
            this.cartBtn.ImageHover = null;
            this.cartBtn.InitialImage = null;
            this.cartBtn.Location = new System.Drawing.Point(0, 325);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(60, 30);
            this.cartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cartBtn.TabIndex = 32;
            this.cartBtn.Zoom = 4;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.accountBtn.BackColor = System.Drawing.Color.Transparent;
            this.accountBtn.CausesValidation = false;
            this.accountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("accountBtn.ErrorImage")));
            this.accountBtn.Image = ((System.Drawing.Image)(resources.GetObject("accountBtn.Image")));
            this.accountBtn.ImageHover = null;
            this.accountBtn.InitialImage = null;
            this.accountBtn.Location = new System.Drawing.Point(0, 64);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(60, 30);
            this.accountBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.accountBtn.TabIndex = 32;
            this.accountBtn.Zoom = 4;
            // 
            // homeBtn
            // 
            this.homeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.CausesValidation = false;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.ErrorImage")));
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageHover = null;
            this.homeBtn.InitialImage = null;
            this.homeBtn.Location = new System.Drawing.Point(0, 192);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(60, 30);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homeBtn.TabIndex = 32;
            this.homeBtn.Zoom = 4;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.Image = global::Cacti.Properties.Resources.account_70px;
            this.circularPictureBox1.Location = new System.Drawing.Point(264, 23);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(82, 79);
            this.circularPictureBox1.TabIndex = 37;
            this.circularPictureBox1.TabStop = false;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 583);
            this.Controls.Add(this.changePhoneNumberBtn);
            this.Controls.Add(this.changeAddressBtn);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.changeEmailBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private JImageButton.JImageButton signOutBtn;
        private JImageButton.JImageButton cartBtn;
        private JImageButton.JImageButton accountBtn;
        private JImageButton.JImageButton homeBtn;
        private System.Windows.Forms.Panel panel1;
        private CircularPictureBox circularPictureBox1;
        private JImageButton.JImageButton closeBtn;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label AddressLbl;
        private JThinButton.JThinButton changeEmailBtn;
        private JThinButton.JThinButton changePasswordBtn;
        private JThinButton.JThinButton changeAddressBtn;
        private JThinButton.JThinButton changePhoneNumberBtn;
    }
}