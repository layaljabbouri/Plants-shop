namespace Cacti
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.clientRadioButton = new System.Windows.Forms.RadioButton();
            this.staffRadioButton = new System.Windows.Forms.RadioButton();
            this.emailTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.passwordTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new JImageButton.JImageButton();
            this.closeBtn = new JImageButton.JImageButton();
            this.signInBtn = new JThinButton.JThinButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.circularPictureBox1 = new Cacti.CircularPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientRadioButton
            // 
            this.clientRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientRadioButton.AutoSize = true;
            this.clientRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.clientRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.clientRadioButton.Location = new System.Drawing.Point(24, 20);
            this.clientRadioButton.Name = "clientRadioButton";
            this.clientRadioButton.Size = new System.Drawing.Size(68, 22);
            this.clientRadioButton.TabIndex = 2;
            this.clientRadioButton.Text = "Client";
            this.clientRadioButton.UseVisualStyleBackColor = false;
            // 
            // staffRadioButton
            // 
            this.staffRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffRadioButton.AutoSize = true;
            this.staffRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.staffRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.staffRadioButton.Location = new System.Drawing.Point(157, 20);
            this.staffRadioButton.Name = "staffRadioButton";
            this.staffRadioButton.Size = new System.Drawing.Size(60, 22);
            this.staffRadioButton.TabIndex = 1;
            this.staffRadioButton.Text = "Staff";
            this.staffRadioButton.UseVisualStyleBackColor = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColors = System.Drawing.Color.Gray;
            this.emailTextBox.HintText = null;
            this.emailTextBox.IsPassword = false;
            this.emailTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.emailTextBox.LineThickness = 2;
            this.emailTextBox.Location = new System.Drawing.Point(38, 338);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.emailTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.emailTextBox.ReadOnly = false;
            this.emailTextBox.Size = new System.Drawing.Size(382, 26);
            this.emailTextBox.TabIndex = 39;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTextBox.TextName = "someone@example.com";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.ForeColors = System.Drawing.Color.Gray;
            this.passwordTextBox.HintText = null;
            this.passwordTextBox.IsPassword = true;
            this.passwordTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.passwordTextBox.LineThickness = 2;
            this.passwordTextBox.Location = new System.Drawing.Point(38, 413);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.passwordTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(382, 21);
            this.passwordTextBox.TabIndex = 40;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TextName = "PassWorD";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(40, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(37, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.circularPictureBox1);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 188);
            this.panel1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sign In Now!";
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
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 30);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 35;
            this.backBtn.Zoom = 4;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(412, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 36;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.Transparent;
            this.signInBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.signInBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.signInBtn.BorderRadius = 20;
            this.signInBtn.ButtonText = "Sign In";
            this.signInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColors = System.Drawing.Color.White;
            this.signInBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.signInBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.signInBtn.HoverFontColor = System.Drawing.Color.White;
            this.signInBtn.LineThickness = 2;
            this.signInBtn.Location = new System.Drawing.Point(135, 488);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(191, 62);
            this.signInBtn.TabIndex = 42;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adminRadioButton);
            this.panel2.Controls.Add(this.staffRadioButton);
            this.panel2.Controls.Add(this.clientRadioButton);
            this.panel2.Location = new System.Drawing.Point(41, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 65);
            this.panel2.TabIndex = 43;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.adminRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.adminRadioButton.Location = new System.Drawing.Point(296, 20);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(71, 22);
            this.adminRadioButton.TabIndex = 3;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = false;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.Image = global::Cacti.Properties.Resources.login_80px;
            this.circularPictureBox1.Location = new System.Drawing.Point(190, 28);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(81, 83);
            this.circularPictureBox1.TabIndex = 37;
            this.circularPictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton clientRadioButton;
        private System.Windows.Forms.RadioButton staffRadioButton;
        private JImageButton.JImageButton backBtn;
        private JImageButton.JImageButton closeBtn;
        private JMaterialTextbox.JMaterialTextbox emailTextBox;
        private JMaterialTextbox.JMaterialTextbox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private JThinButton.JThinButton signInBtn;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton adminRadioButton;
    }
}