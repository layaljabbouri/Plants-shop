namespace Cacti
{
    partial class ChangeAddressOrPhoneNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeAddressOrPhoneNumber));
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveChangesBtn = new JThinButton.JThinButton();
            this.newTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.newLbl = new System.Windows.Forms.Label();
            this.OldTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.OldLbl = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new Cacti.CircularPictureBox();
            this.backBtn = new JImageButton.JImageButton();
            this.closeBtn = new JImageButton.JImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.circularPictureBox1);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 127);
            this.panel1.TabIndex = 43;
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveChangesBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.saveChangesBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.saveChangesBtn.BorderRadius = 20;
            this.saveChangesBtn.ButtonText = "Save Changes";
            this.saveChangesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChangesBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesBtn.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesBtn.ForeColors = System.Drawing.Color.White;
            this.saveChangesBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.saveChangesBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.saveChangesBtn.HoverFontColor = System.Drawing.Color.White;
            this.saveChangesBtn.LineThickness = 2;
            this.saveChangesBtn.Location = new System.Drawing.Point(140, 428);
            this.saveChangesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(149, 56);
            this.saveChangesBtn.TabIndex = 50;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // newTextBox
            // 
            this.newTextBox.BackColor = System.Drawing.Color.Transparent;
            this.newTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTextBox.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTextBox.ForeColors = System.Drawing.Color.Black;
            this.newTextBox.HintText = null;
            this.newTextBox.IsPassword = false;
            this.newTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.newTextBox.LineThickness = 2;
            this.newTextBox.Location = new System.Drawing.Point(29, 358);
            this.newTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newTextBox.MaxLength = 32767;
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.newTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.newTextBox.ReadOnly = false;
            this.newTextBox.Size = new System.Drawing.Size(391, 26);
            this.newTextBox.TabIndex = 45;
            this.newTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newTextBox.TextName = "";
            // 
            // newLbl
            // 
            this.newLbl.AutoSize = true;
            this.newLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.newLbl.Location = new System.Drawing.Point(43, 329);
            this.newLbl.Name = "newLbl";
            this.newLbl.Size = new System.Drawing.Size(95, 21);
            this.newLbl.TabIndex = 47;
            this.newLbl.Text = "New Data:";
            // 
            // OldTextBox
            // 
            this.OldTextBox.BackColor = System.Drawing.Color.Transparent;
            this.OldTextBox.Enabled = false;
            this.OldTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OldTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OldTextBox.ForeColors = System.Drawing.Color.Black;
            this.OldTextBox.HintText = null;
            this.OldTextBox.IsPassword = false;
            this.OldTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.OldTextBox.LineThickness = 2;
            this.OldTextBox.Location = new System.Drawing.Point(29, 275);
            this.OldTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OldTextBox.MaxLength = 32767;
            this.OldTextBox.Name = "OldTextBox";
            this.OldTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.OldTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.OldTextBox.ReadOnly = false;
            this.OldTextBox.Size = new System.Drawing.Size(391, 28);
            this.OldTextBox.TabIndex = 44;
            this.OldTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OldTextBox.TextName = "";
            // 
            // OldLbl
            // 
            this.OldLbl.AutoSize = true;
            this.OldLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.OldLbl.Location = new System.Drawing.Point(40, 244);
            this.OldLbl.Name = "OldLbl";
            this.OldLbl.Size = new System.Drawing.Size(86, 21);
            this.OldLbl.TabIndex = 49;
            this.OldLbl.Text = "Old data:";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.Image = global::Cacti.Properties.Resources.more_info_80px;
            this.circularPictureBox1.Location = new System.Drawing.Point(178, 21);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(81, 83);
            this.circularPictureBox1.TabIndex = 37;
            this.circularPictureBox1.TabStop = false;
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
            this.closeBtn.Location = new System.Drawing.Point(396, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 36;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(25, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kindly provide us with accurate info for delivery purpose";
            // 
            // ChangeAddressOrPhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.newTextBox);
            this.Controls.Add(this.newLbl);
            this.Controls.Add(this.OldTextBox);
            this.Controls.Add(this.OldLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeAddressOrPhoneNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeAddressOrPhoneNumber";
            this.Load += new System.EventHandler(this.ChangeAddressOrPhoneNumber_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CircularPictureBox circularPictureBox1;
        private JImageButton.JImageButton backBtn;
        private JImageButton.JImageButton closeBtn;
        private JThinButton.JThinButton saveChangesBtn;
        private JMaterialTextbox.JMaterialTextbox newTextBox;
        private System.Windows.Forms.Label newLbl;
        private JMaterialTextbox.JMaterialTextbox OldTextBox;
        private System.Windows.Forms.Label OldLbl;
        private System.Windows.Forms.Label label1;
    }
}