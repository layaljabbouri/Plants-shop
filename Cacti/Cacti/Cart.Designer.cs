namespace Cacti
{
    partial class Cart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.buyBtn = new JThinButton.JThinButton();
            this.closeBtn = new JImageButton.JImageButton();
            this.addToCartBtn = new JImageButton.JImageButton();
            this.signOutBtn = new JImageButton.JImageButton();
            this.cartBtn = new JImageButton.JImageButton();
            this.accountBtn = new JImageButton.JImageButton();
            this.homeBtn = new JImageButton.JImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.cartDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(219)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.cartDataGridView.Location = new System.Drawing.Point(65, 124);
            this.cartDataGridView.MultiSelect = false;
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.ReadOnly = true;
            this.cartDataGridView.RowTemplate.ReadOnly = true;
            this.cartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartDataGridView.Size = new System.Drawing.Size(492, 231);
            this.cartDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shopping Cart";
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
            this.leftPanel.Size = new System.Drawing.Size(60, 540);
            this.leftPanel.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Total ";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.totalLbl.ForeColor = System.Drawing.Color.White;
            this.totalLbl.Location = new System.Drawing.Point(352, 385);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(32, 24);
            this.totalLbl.TabIndex = 39;
            this.totalLbl.Text = "tot";
            // 
            // buyBtn
            // 
            this.buyBtn.BackColor = System.Drawing.Color.Transparent;
            this.buyBtn.BackgroundColor = System.Drawing.Color.White;
            this.buyBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.buyBtn.BorderRadius = 20;
            this.buyBtn.ButtonText = "Buy";
            this.buyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.buyBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.buyBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.buyBtn.HoverFontColor = System.Drawing.Color.White;
            this.buyBtn.LineThickness = 2;
            this.buyBtn.Location = new System.Drawing.Point(233, 438);
            this.buyBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(149, 62);
            this.buyBtn.TabIndex = 43;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(530, 11);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 37;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addToCartBtn.BackColor = System.Drawing.Color.Transparent;
            this.addToCartBtn.CausesValidation = false;
            this.addToCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("addToCartBtn.ErrorImage")));
            this.addToCartBtn.Image = global::Cacti.Properties.Resources.add_shopping_cart_35px;
            this.addToCartBtn.ImageHover = null;
            this.addToCartBtn.InitialImage = null;
            this.addToCartBtn.Location = new System.Drawing.Point(373, 57);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(60, 30);
            this.addToCartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addToCartBtn.TabIndex = 35;
            this.addToCartBtn.Zoom = 4;
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
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
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
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(579, 540);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel leftPanel;
        private JImageButton.JImageButton signOutBtn;
        private JImageButton.JImageButton cartBtn;
        private JImageButton.JImageButton accountBtn;
        private JImageButton.JImageButton homeBtn;
        private JImageButton.JImageButton addToCartBtn;
        private JImageButton.JImageButton closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLbl;
        private JThinButton.JThinButton buyBtn;
    }
}