namespace Cacti
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.signUpBtn = new JThinButton.JThinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.agreeCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.closeBtn = new JImageButton.JImageButton();
            this.backBtn = new JImageButton.JImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.emailTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.reEnterPasswordTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.SuspendLayout();
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.signUpBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.signUpBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.signUpBtn.BorderRadius = 20;
            this.signUpBtn.ButtonText = "Sign Up";
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColors = System.Drawing.Color.White;
            this.signUpBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.signUpBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.signUpBtn.HoverFontColor = System.Drawing.Color.White;
            this.signUpBtn.LineThickness = 2;
            this.signUpBtn.Location = new System.Drawing.Point(125, 497);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(196, 50);
            this.signUpBtn.TabIndex = 28;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(172, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sign Up";
            // 
            // agreeCheckBox
            // 
            this.agreeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agreeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.agreeCheckBox.Location = new System.Drawing.Point(37, 432);
            this.agreeCheckBox.Name = "agreeCheckBox";
            this.agreeCheckBox.Size = new System.Drawing.Size(17, 13);
            this.agreeCheckBox.TabIndex = 31;
            this.agreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.label6.Location = new System.Drawing.Point(55, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "I Agree To The Terms And Conditions";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.closeBtn.CausesValidation = false;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.ErrorImage")));
            this.closeBtn.Image = global::Cacti.Properties.Resources.Close;
            this.closeBtn.ImageHover = null;
            this.closeBtn.InitialImage = null;
            this.closeBtn.Location = new System.Drawing.Point(388, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 40;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // backBtn
            // 
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.backBtn.CausesValidation = false;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("backBtn.ErrorImage")));
            this.backBtn.Image = global::Cacti.Properties.Resources.back_25px;
            this.backBtn.ImageHover = null;
            this.backBtn.InitialImage = null;
            this.backBtn.Location = new System.Drawing.Point(16, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 30);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 39;
            this.backBtn.Zoom = 4;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Full Name:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.fullNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fullNameTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fullNameTextBox.ForeColors = System.Drawing.Color.Gray;
            this.fullNameTextBox.HintText = null;
            this.fullNameTextBox.IsPassword = false;
            this.fullNameTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.fullNameTextBox.LineThickness = 2;
            this.fullNameTextBox.Location = new System.Drawing.Point(34, 138);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullNameTextBox.MaxLength = 32767;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.fullNameTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.fullNameTextBox.ReadOnly = false;
            this.fullNameTextBox.Size = new System.Drawing.Size(382, 28);
            this.fullNameTextBox.TabIndex = 0;
            this.fullNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fullNameTextBox.TextName = "Full Name";
            this.fullNameTextBox.Enter += new System.EventHandler(this.fullNameTextBox_Enter);
            this.fullNameTextBox.Leave += new System.EventHandler(this.fullNameTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(34, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(34, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.ForeColors = System.Drawing.Color.Gray;
            this.passwordTextBox.HintText = null;
            this.passwordTextBox.IsPassword = true;
            this.passwordTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.passwordTextBox.LineThickness = 2;
            this.passwordTextBox.Location = new System.Drawing.Point(34, 292);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.passwordTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(382, 21);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TextName = "PassWorD";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColors = System.Drawing.Color.Gray;
            this.emailTextBox.HintText = null;
            this.emailTextBox.IsPassword = false;
            this.emailTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.emailTextBox.LineThickness = 2;
            this.emailTextBox.Location = new System.Drawing.Point(34, 217);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.emailTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.emailTextBox.ReadOnly = false;
            this.emailTextBox.Size = new System.Drawing.Size(382, 26);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTextBox.TextName = "someone@example.com";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(34, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Re-Enter Password:";
            // 
            // reEnterPasswordTextBox
            // 
            this.reEnterPasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.reEnterPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reEnterPasswordTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reEnterPasswordTextBox.ForeColors = System.Drawing.Color.Gray;
            this.reEnterPasswordTextBox.HintText = null;
            this.reEnterPasswordTextBox.IsPassword = true;
            this.reEnterPasswordTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.reEnterPasswordTextBox.LineThickness = 2;
            this.reEnterPasswordTextBox.Location = new System.Drawing.Point(34, 373);
            this.reEnterPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reEnterPasswordTextBox.MaxLength = 32767;
            this.reEnterPasswordTextBox.Name = "reEnterPasswordTextBox";
            this.reEnterPasswordTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.reEnterPasswordTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.reEnterPasswordTextBox.ReadOnly = false;
            this.reEnterPasswordTextBox.Size = new System.Drawing.Size(382, 21);
            this.reEnterPasswordTextBox.TabIndex = 3;
            this.reEnterPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reEnterPasswordTextBox.TextName = "PassWorD";
            this.reEnterPasswordTextBox.Enter += new System.EventHandler(this.reEnterPassword_Enter);
            this.reEnterPasswordTextBox.Leave += new System.EventHandler(this.reEnterPassword_Leave);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 583);
            this.Controls.Add(this.reEnterPasswordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agreeCheckBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private JThinButton.JThinButton signUpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox agreeCheckBox;
        private System.Windows.Forms.Label label6;
        private JImageButton.JImageButton backBtn;
        private JImageButton.JImageButton closeBtn;
        private System.Windows.Forms.Label label2;
        private JMaterialTextbox.JMaterialTextbox fullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private JMaterialTextbox.JMaterialTextbox passwordTextBox;
        private JMaterialTextbox.JMaterialTextbox emailTextBox;
        private System.Windows.Forms.Label label5;
        private JMaterialTextbox.JMaterialTextbox reEnterPasswordTextBox;
    }
}