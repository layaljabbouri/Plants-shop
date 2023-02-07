namespace Cacti
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.signOutBtn = new JImageButton.JImageButton();
            this.cartBtn = new JImageButton.JImageButton();
            this.accountBtn = new JImageButton.JImageButton();
            this.homeBtn = new JImageButton.JImageButton();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.nextBtn = new JImageButton.JImageButton();
            this.closeBtn = new JImageButton.JImageButton();
            this.filterBtn = new JImageButton.JImageButton();
            this.searchBtn = new JImageButton.JImageButton();
            this.search = new JMaterialTextbox.JMaterialTextbox();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
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
            this.leftPanel.Size = new System.Drawing.Size(60, 705);
            this.leftPanel.TabIndex = 33;
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
            this.signOutBtn.Location = new System.Drawing.Point(3, 523);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(57, 30);
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
            this.cartBtn.Location = new System.Drawing.Point(3, 390);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(57, 30);
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
            this.accountBtn.Location = new System.Drawing.Point(3, 124);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(57, 30);
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
            this.homeBtn.Location = new System.Drawing.Point(0, 257);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(60, 30);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homeBtn.TabIndex = 32;
            this.homeBtn.Zoom = 4;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.AutoScroll = true;
            this.centerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.centerPanel.Location = new System.Drawing.Point(61, 60);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(546, 666);
            this.centerPanel.TabIndex = 34;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.searchTextBox.ForeColor = System.Drawing.Color.Gray;
            this.searchTextBox.Location = new System.Drawing.Point(42, 17);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(256, 24);
            this.searchTextBox.TabIndex = 43;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.searchTextBox);
            this.topPanel.Controls.Add(this.nextBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Controls.Add(this.filterBtn);
            this.topPanel.Controls.Add(this.searchBtn);
            this.topPanel.Controls.Add(this.search);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(60, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(546, 60);
            this.topPanel.TabIndex = 33;
            // 
            // nextBtn
            // 
            this.nextBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextBtn.BackColor = System.Drawing.Color.White;
            this.nextBtn.CausesValidation = false;
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("nextBtn.ErrorImage")));
            this.nextBtn.Image = global::Cacti.Properties.Resources.next_page_35px;
            this.nextBtn.ImageHover = null;
            this.nextBtn.InitialImage = null;
            this.nextBtn.Location = new System.Drawing.Point(457, 13);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(36, 35);
            this.nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nextBtn.TabIndex = 42;
            this.nextBtn.Zoom = 4;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.CausesValidation = false;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.ErrorImage")));
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageHover = null;
            this.closeBtn.InitialImage = null;
            this.closeBtn.Location = new System.Drawing.Point(499, 13);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 35);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 41;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filterBtn.BackColor = System.Drawing.Color.White;
            this.filterBtn.CausesValidation = false;
            this.filterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("filterBtn.ErrorImage")));
            this.filterBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterBtn.Image")));
            this.filterBtn.ImageHover = null;
            this.filterBtn.InitialImage = null;
            this.filterBtn.Location = new System.Drawing.Point(308, 16);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(36, 35);
            this.filterBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.filterBtn.TabIndex = 41;
            this.filterBtn.Zoom = 4;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.CausesValidation = false;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("searchBtn.ErrorImage")));
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageHover = null;
            this.searchBtn.InitialImage = null;
            this.searchBtn.Location = new System.Drawing.Point(6, 16);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(33, 35);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.searchBtn.TabIndex = 34;
            this.searchBtn.Zoom = 4;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.Enabled = false;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColors = System.Drawing.Color.Gray;
            this.search.HintText = null;
            this.search.IsPassword = false;
            this.search.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.search.LineThickness = 2;
            this.search.Location = new System.Drawing.Point(42, 22);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.MaxLength = 32767;
            this.search.Name = "search";
            this.search.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.search.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.search.ReadOnly = false;
            this.search.Size = new System.Drawing.Size(256, 21);
            this.search.TabIndex = 40;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search.TextName = "";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 705);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private JImageButton.JImageButton signOutBtn;
        private JImageButton.JImageButton cartBtn;
        private JImageButton.JImageButton accountBtn;
        private JImageButton.JImageButton homeBtn;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel topPanel;
        private JImageButton.JImageButton searchBtn;
        private JMaterialTextbox.JMaterialTextbox search;
        private JImageButton.JImageButton closeBtn;
        private JImageButton.JImageButton nextBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private JImageButton.JImageButton filterBtn;
    }
}