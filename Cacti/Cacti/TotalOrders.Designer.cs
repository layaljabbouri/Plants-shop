namespace Cacti
{
    partial class TotalOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new JImageButton.JImageButton();
            this.closeBtn = new JImageButton.JImageButton();
            this.pendingGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.completedGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.completeOrderTextBox = new System.Windows.Forms.TextBox();
            this.completeOrderBtn = new JThinButton.JThinButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendingGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 54);
            this.panel1.TabIndex = 2;
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
            this.backBtn.Location = new System.Drawing.Point(3, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 30);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 37;
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
            this.closeBtn.Location = new System.Drawing.Point(547, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 38;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pendingGV
            // 
            this.pendingGV.BackgroundColor = System.Drawing.Color.LightGray;
            this.pendingGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pendingGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.pendingGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.pendingGV.Location = new System.Drawing.Point(12, 344);
            this.pendingGV.Name = "pendingGV";
            this.pendingGV.Size = new System.Drawing.Size(570, 208);
            this.pendingGV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.label2.Location = new System.Drawing.Point(231, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pending Orders";
            // 
            // completedGV
            // 
            this.completedGV.BackgroundColor = System.Drawing.Color.LightGray;
            this.completedGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.completedGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completedGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.completedGV.Location = new System.Drawing.Point(14, 95);
            this.completedGV.Name = "completedGV";
            this.completedGV.Size = new System.Drawing.Size(570, 208);
            this.completedGV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.label3.Location = new System.Drawing.Point(222, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Completed Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(219, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Complete an order";
            // 
            // completeOrderTextBox
            // 
            this.completeOrderTextBox.Location = new System.Drawing.Point(223, 608);
            this.completeOrderTextBox.Name = "completeOrderTextBox";
            this.completeOrderTextBox.Size = new System.Drawing.Size(153, 20);
            this.completeOrderTextBox.TabIndex = 7;
            this.completeOrderTextBox.Enter += new System.EventHandler(this.completeOrderTextBox_Enter);
            this.completeOrderTextBox.Leave += new System.EventHandler(this.completeOrderTextBox_Leave);
            // 
            // completeOrderBtn
            // 
            this.completeOrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.completeOrderBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.completeOrderBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.completeOrderBtn.BorderRadius = 11;
            this.completeOrderBtn.ButtonText = "Complete";
            this.completeOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completeOrderBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeOrderBtn.Font_Size = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeOrderBtn.ForeColors = System.Drawing.Color.White;
            this.completeOrderBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(142)))), ((int)(((byte)(114)))));
            this.completeOrderBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.completeOrderBtn.HoverFontColor = System.Drawing.Color.White;
            this.completeOrderBtn.LineThickness = 2;
            this.completeOrderBtn.Location = new System.Drawing.Point(253, 635);
            this.completeOrderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.completeOrderBtn.Name = "completeOrderBtn";
            this.completeOrderBtn.Size = new System.Drawing.Size(84, 25);
            this.completeOrderBtn.TabIndex = 29;
            this.completeOrderBtn.Click += new System.EventHandler(this.completeOrderBtn_Click);
            // 
            // TotalOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 705);
            this.Controls.Add(this.completeOrderBtn);
            this.Controls.Add(this.completeOrderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.completedGV);
            this.Controls.Add(this.pendingGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TotalOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TotalOrders";
            this.Load += new System.EventHandler(this.TotalOrders_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pendingGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private JImageButton.JImageButton backBtn;
        private JImageButton.JImageButton closeBtn;
        private System.Windows.Forms.DataGridView pendingGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView completedGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox completeOrderTextBox;
        private JThinButton.JThinButton completeOrderBtn;
    }
}