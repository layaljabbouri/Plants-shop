namespace Cacti
{
    partial class WorkerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularPictureBox1 = new Cacti.CircularPictureBox();
            this.closeBtn = new JImageButton.JImageButton();
            this.backBtn = new JImageButton.JImageButton();
            this.newEmailTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.reEnterNewPasswordTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveEmailBtn = new JThinButton.JThinButton();
            this.currentPasswordTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.savePasswordBtn = new JThinButton.JThinButton();
            this.nameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.circularPictureBox1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 99);
            this.panel1.TabIndex = 43;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.Image = global::Cacti.Properties.Resources.account_70px;
            this.circularPictureBox1.Location = new System.Drawing.Point(350, 26);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(66, 67);
            this.circularPictureBox1.TabIndex = 37;
            this.circularPictureBox1.TabStop = false;
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
            this.closeBtn.Location = new System.Drawing.Point(418, 13);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 36;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.CausesValidation = false;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("backBtn.ErrorImage")));
            this.backBtn.Image = global::Cacti.Properties.Resources.back_25px;
            this.backBtn.ImageHover = null;
            this.backBtn.InitialImage = null;
            this.backBtn.Location = new System.Drawing.Point(1, 13);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(32, 30);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 42;
            this.backBtn.Zoom = 4;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // newEmailTextBox
            // 
            this.newEmailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.newEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmailTextBox.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmailTextBox.ForeColors = System.Drawing.Color.Gray;
            this.newEmailTextBox.HintText = null;
            this.newEmailTextBox.IsPassword = false;
            this.newEmailTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.newEmailTextBox.LineThickness = 2;
            this.newEmailTextBox.Location = new System.Drawing.Point(29, 161);
            this.newEmailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newEmailTextBox.MaxLength = 32767;
            this.newEmailTextBox.Name = "newEmailTextBox";
            this.newEmailTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.newEmailTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.newEmailTextBox.ReadOnly = false;
            this.newEmailTextBox.Size = new System.Drawing.Size(382, 26);
            this.newEmailTextBox.TabIndex = 49;
            this.newEmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newEmailTextBox.TextName = "someone@example.com";
            this.newEmailTextBox.Enter += new System.EventHandler(this.newEmailTextBox_Enter);
            this.newEmailTextBox.Leave += new System.EventHandler(this.newEmailTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(29, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "New Email:";
            // 
            // reEnterNewPasswordTextBox
            // 
            this.reEnterNewPasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.reEnterNewPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reEnterNewPasswordTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reEnterNewPasswordTextBox.ForeColors = System.Drawing.Color.Gray;
            this.reEnterNewPasswordTextBox.HintText = null;
            this.reEnterNewPasswordTextBox.IsPassword = true;
            this.reEnterNewPasswordTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.reEnterNewPasswordTextBox.LineThickness = 2;
            this.reEnterNewPasswordTextBox.Location = new System.Drawing.Point(29, 458);
            this.reEnterNewPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reEnterNewPasswordTextBox.MaxLength = 32767;
            this.reEnterNewPasswordTextBox.Name = "reEnterNewPasswordTextBox";
            this.reEnterNewPasswordTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.reEnterNewPasswordTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.reEnterNewPasswordTextBox.ReadOnly = false;
            this.reEnterNewPasswordTextBox.Size = new System.Drawing.Size(382, 21);
            this.reEnterNewPasswordTextBox.TabIndex = 52;
            this.reEnterNewPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reEnterNewPasswordTextBox.TextName = "PassWorD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(29, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Re-Enter Password:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newPasswordTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newPasswordTextBox.ForeColors = System.Drawing.Color.Gray;
            this.newPasswordTextBox.HintText = null;
            this.newPasswordTextBox.IsPassword = true;
            this.newPasswordTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.newPasswordTextBox.LineThickness = 2;
            this.newPasswordTextBox.Location = new System.Drawing.Point(29, 386);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newPasswordTextBox.MaxLength = 32767;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.newPasswordTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.newPasswordTextBox.ReadOnly = false;
            this.newPasswordTextBox.Size = new System.Drawing.Size(382, 21);
            this.newPasswordTextBox.TabIndex = 51;
            this.newPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newPasswordTextBox.TextName = "PassWorD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(29, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "New Password:";
            // 
            // saveEmailBtn
            // 
            this.saveEmailBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveEmailBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.saveEmailBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.saveEmailBtn.BorderRadius = 19;
            this.saveEmailBtn.ButtonText = "Save Changes";
            this.saveEmailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveEmailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEmailBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEmailBtn.ForeColors = System.Drawing.Color.White;
            this.saveEmailBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.saveEmailBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.saveEmailBtn.HoverFontColor = System.Drawing.Color.White;
            this.saveEmailBtn.LineThickness = 2;
            this.saveEmailBtn.Location = new System.Drawing.Point(290, 215);
            this.saveEmailBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveEmailBtn.Name = "saveEmailBtn";
            this.saveEmailBtn.Size = new System.Drawing.Size(124, 42);
            this.saveEmailBtn.TabIndex = 55;
            this.saveEmailBtn.Click += new System.EventHandler(this.saveEmailBtn_Click);
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.currentPasswordTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.currentPasswordTextBox.ForeColors = System.Drawing.Color.Gray;
            this.currentPasswordTextBox.HintText = null;
            this.currentPasswordTextBox.IsPassword = true;
            this.currentPasswordTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.currentPasswordTextBox.LineThickness = 2;
            this.currentPasswordTextBox.Location = new System.Drawing.Point(29, 315);
            this.currentPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentPasswordTextBox.MaxLength = 32767;
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.currentPasswordTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.currentPasswordTextBox.ReadOnly = false;
            this.currentPasswordTextBox.Size = new System.Drawing.Size(382, 21);
            this.currentPasswordTextBox.TabIndex = 56;
            this.currentPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.currentPasswordTextBox.TextName = "PassWorD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(29, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Current Password:";
            // 
            // savePasswordBtn
            // 
            this.savePasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.savePasswordBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.savePasswordBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.savePasswordBtn.BorderRadius = 19;
            this.savePasswordBtn.ButtonText = "Save Changes";
            this.savePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePasswordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePasswordBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePasswordBtn.ForeColors = System.Drawing.Color.White;
            this.savePasswordBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.savePasswordBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.savePasswordBtn.HoverFontColor = System.Drawing.Color.White;
            this.savePasswordBtn.LineThickness = 2;
            this.savePasswordBtn.Location = new System.Drawing.Point(290, 507);
            this.savePasswordBtn.Margin = new System.Windows.Forms.Padding(4);
            this.savePasswordBtn.Name = "savePasswordBtn";
            this.savePasswordBtn.Size = new System.Drawing.Size(124, 42);
            this.savePasswordBtn.TabIndex = 55;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(64, 40);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(51, 16);
            this.nameLbl.TabIndex = 43;
            this.nameLbl.Text = "label3";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(64, 65);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(51, 16);
            this.emailLbl.TabIndex = 44;
            this.emailLbl.Text = "label3";
            // 
            // WorkerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 583);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savePasswordBtn);
            this.Controls.Add(this.saveEmailBtn);
            this.Controls.Add(this.reEnterNewPasswordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newEmailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerProfile";
            this.Load += new System.EventHandler(this.WorkerProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CircularPictureBox circularPictureBox1;
        private JImageButton.JImageButton closeBtn;
        private JImageButton.JImageButton backBtn;
        private JMaterialTextbox.JMaterialTextbox newEmailTextBox;
        private System.Windows.Forms.Label label1;
        private JMaterialTextbox.JMaterialTextbox reEnterNewPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private JMaterialTextbox.JMaterialTextbox newPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private JThinButton.JThinButton saveEmailBtn;
        private JMaterialTextbox.JMaterialTextbox currentPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private JThinButton.JThinButton savePasswordBtn;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label nameLbl;
    }
}