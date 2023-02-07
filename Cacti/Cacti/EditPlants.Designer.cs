namespace Cacti
{
    partial class EditPlants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPlants));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new JImageButton.JImageButton();
            this.closeBtn = new JImageButton.JImageButton();
            this.save_updateBtn = new JThinButton.JThinButton();
            this.name_updateTextbox = new System.Windows.Forms.TextBox();
            this.price_updateTextBox = new System.Windows.Forms.TextBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.updatePriceBtn = new JImageButton.JImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.save_removeBtn = new JThinButton.JThinButton();
            this.name_removeTextBox = new System.Windows.Forms.TextBox();
            this.removePanel = new System.Windows.Forms.Panel();
            this.removePlantBtn = new JImageButton.JImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.save_addBtn = new JThinButton.JThinButton();
            this.name_addTextBox = new System.Windows.Forms.TextBox();
            this.price_addTextBox = new System.Windows.Forms.TextBox();
            this.addPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.addPlantBtn = new JImageButton.JImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.removePanel.SuspendLayout();
            this.addPanel.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(448, 58);
            this.panel1.TabIndex = 37;
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
            this.backBtn.Location = new System.Drawing.Point(6, 17);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 30);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 38;
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
            this.closeBtn.Location = new System.Drawing.Point(393, 17);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 37;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // save_updateBtn
            // 
            this.save_updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.save_updateBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.save_updateBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.save_updateBtn.BorderRadius = 15;
            this.save_updateBtn.ButtonText = "Save";
            this.save_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_updateBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_updateBtn.ForeColors = System.Drawing.Color.White;
            this.save_updateBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.save_updateBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.save_updateBtn.HoverFontColor = System.Drawing.Color.White;
            this.save_updateBtn.LineThickness = 2;
            this.save_updateBtn.Location = new System.Drawing.Point(315, 113);
            this.save_updateBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.save_updateBtn.Name = "save_updateBtn";
            this.save_updateBtn.Size = new System.Drawing.Size(82, 33);
            this.save_updateBtn.TabIndex = 44;
            this.save_updateBtn.Click += new System.EventHandler(this.save_updateBtn_Click);
            // 
            // name_updateTextbox
            // 
            this.name_updateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_updateTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.name_updateTextbox.Location = new System.Drawing.Point(200, 29);
            this.name_updateTextbox.Multiline = true;
            this.name_updateTextbox.Name = "name_updateTextbox";
            this.name_updateTextbox.Size = new System.Drawing.Size(197, 26);
            this.name_updateTextbox.TabIndex = 46;
            // 
            // price_updateTextBox
            // 
            this.price_updateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_updateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.price_updateTextBox.Location = new System.Drawing.Point(200, 70);
            this.price_updateTextBox.Multiline = true;
            this.price_updateTextBox.Name = "price_updateTextBox";
            this.price_updateTextBox.Size = new System.Drawing.Size(197, 26);
            this.price_updateTextBox.TabIndex = 46;
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.White;
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updatePanel.Controls.Add(this.label5);
            this.updatePanel.Controls.Add(this.updatePriceBtn);
            this.updatePanel.Controls.Add(this.label4);
            this.updatePanel.Controls.Add(this.price_updateTextBox);
            this.updatePanel.Controls.Add(this.name_updateTextbox);
            this.updatePanel.Controls.Add(this.save_updateBtn);
            this.updatePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updatePanel.Location = new System.Drawing.Point(0, 382);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(448, 162);
            this.updatePanel.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.label5.Location = new System.Drawing.Point(130, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Price";
            // 
            // updatePriceBtn
            // 
            this.updatePriceBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updatePriceBtn.BackColor = System.Drawing.Color.Transparent;
            this.updatePriceBtn.CausesValidation = false;
            this.updatePriceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatePriceBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("updatePriceBtn.ErrorImage")));
            this.updatePriceBtn.Image = global::Cacti.Properties.Resources.edit_70px;
            this.updatePriceBtn.ImageHover = null;
            this.updatePriceBtn.InitialImage = null;
            this.updatePriceBtn.Location = new System.Drawing.Point(11, 29);
            this.updatePriceBtn.Name = "updatePriceBtn";
            this.updatePriceBtn.Size = new System.Drawing.Size(85, 67);
            this.updatePriceBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.updatePriceBtn.TabIndex = 48;
            this.updatePriceBtn.Zoom = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(129, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Name";
            // 
            // save_removeBtn
            // 
            this.save_removeBtn.BackColor = System.Drawing.Color.Transparent;
            this.save_removeBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.save_removeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.save_removeBtn.BorderRadius = 15;
            this.save_removeBtn.ButtonText = "Save";
            this.save_removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_removeBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_removeBtn.ForeColors = System.Drawing.Color.White;
            this.save_removeBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.save_removeBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.save_removeBtn.HoverFontColor = System.Drawing.Color.White;
            this.save_removeBtn.LineThickness = 2;
            this.save_removeBtn.Location = new System.Drawing.Point(315, 99);
            this.save_removeBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.save_removeBtn.Name = "save_removeBtn";
            this.save_removeBtn.Size = new System.Drawing.Size(82, 33);
            this.save_removeBtn.TabIndex = 44;
            this.save_removeBtn.Click += new System.EventHandler(this.save_removeBtn_Click);
            // 
            // name_removeTextBox
            // 
            this.name_removeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_removeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.name_removeTextBox.Location = new System.Drawing.Point(200, 48);
            this.name_removeTextBox.Multiline = true;
            this.name_removeTextBox.Name = "name_removeTextBox";
            this.name_removeTextBox.Size = new System.Drawing.Size(197, 26);
            this.name_removeTextBox.TabIndex = 46;
            // 
            // removePanel
            // 
            this.removePanel.BackColor = System.Drawing.Color.White;
            this.removePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.removePanel.Controls.Add(this.removePlantBtn);
            this.removePanel.Controls.Add(this.name_removeTextBox);
            this.removePanel.Controls.Add(this.label2);
            this.removePanel.Controls.Add(this.save_removeBtn);
            this.removePanel.Location = new System.Drawing.Point(0, 220);
            this.removePanel.Name = "removePanel";
            this.removePanel.Size = new System.Drawing.Size(448, 162);
            this.removePanel.TabIndex = 35;
            // 
            // removePlantBtn
            // 
            this.removePlantBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removePlantBtn.BackColor = System.Drawing.Color.Transparent;
            this.removePlantBtn.CausesValidation = false;
            this.removePlantBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removePlantBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("removePlantBtn.ErrorImage")));
            this.removePlantBtn.Image = global::Cacti.Properties.Resources.remove_70px1;
            this.removePlantBtn.ImageHover = null;
            this.removePlantBtn.InitialImage = null;
            this.removePlantBtn.Location = new System.Drawing.Point(11, 27);
            this.removePlantBtn.Name = "removePlantBtn";
            this.removePlantBtn.Size = new System.Drawing.Size(85, 65);
            this.removePlantBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.removePlantBtn.TabIndex = 48;
            this.removePlantBtn.Zoom = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.label2.Location = new System.Drawing.Point(129, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Name";
            // 
            // save_addBtn
            // 
            this.save_addBtn.BackColor = System.Drawing.Color.Transparent;
            this.save_addBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.save_addBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.save_addBtn.BorderRadius = 15;
            this.save_addBtn.ButtonText = "Save";
            this.save_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_addBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_addBtn.ForeColors = System.Drawing.Color.White;
            this.save_addBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.save_addBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.save_addBtn.HoverFontColor = System.Drawing.Color.White;
            this.save_addBtn.LineThickness = 2;
            this.save_addBtn.Location = new System.Drawing.Point(315, 110);
            this.save_addBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.save_addBtn.Name = "save_addBtn";
            this.save_addBtn.Size = new System.Drawing.Size(82, 33);
            this.save_addBtn.TabIndex = 44;
            this.save_addBtn.Click += new System.EventHandler(this.save_addBtn_Click);
            // 
            // name_addTextBox
            // 
            this.name_addTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_addTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.name_addTextBox.Location = new System.Drawing.Point(200, 26);
            this.name_addTextBox.Multiline = true;
            this.name_addTextBox.Name = "name_addTextBox";
            this.name_addTextBox.Size = new System.Drawing.Size(197, 26);
            this.name_addTextBox.TabIndex = 46;
            // 
            // price_addTextBox
            // 
            this.price_addTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_addTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.price_addTextBox.Location = new System.Drawing.Point(200, 67);
            this.price_addTextBox.Multiline = true;
            this.price_addTextBox.Name = "price_addTextBox";
            this.price_addTextBox.Size = new System.Drawing.Size(197, 26);
            this.price_addTextBox.TabIndex = 46;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.White;
            this.addPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.addPlantBtn);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.save_addBtn);
            this.addPanel.Controls.Add(this.price_addTextBox);
            this.addPanel.Controls.Add(this.name_addTextBox);
            this.addPanel.Location = new System.Drawing.Point(0, 58);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(448, 162);
            this.addPanel.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.label3.Location = new System.Drawing.Point(129, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Price";
            // 
            // addPlantBtn
            // 
            this.addPlantBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPlantBtn.BackColor = System.Drawing.Color.Transparent;
            this.addPlantBtn.CausesValidation = false;
            this.addPlantBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPlantBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("addPlantBtn.ErrorImage")));
            this.addPlantBtn.Image = global::Cacti.Properties.Resources.add_70px;
            this.addPlantBtn.ImageHover = null;
            this.addPlantBtn.InitialImage = null;
            this.addPlantBtn.Location = new System.Drawing.Point(11, 26);
            this.addPlantBtn.Name = "addPlantBtn";
            this.addPlantBtn.Size = new System.Drawing.Size(85, 67);
            this.addPlantBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addPlantBtn.TabIndex = 47;
            this.addPlantBtn.Zoom = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(167)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Name";
            // 
            // EditPlants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.removePanel);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPlants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPlants";
            this.Load += new System.EventHandler(this.EditPlants_Load);
            this.panel1.ResumeLayout(false);
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.removePanel.ResumeLayout(false);
            this.removePanel.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private JImageButton.JImageButton closeBtn;
        private JImageButton.JImageButton backBtn;
        private JThinButton.JThinButton save_updateBtn;
        private System.Windows.Forms.TextBox name_updateTextbox;
        private System.Windows.Forms.TextBox price_updateTextBox;
        private System.Windows.Forms.Panel updatePanel;
        private JThinButton.JThinButton save_removeBtn;
        private System.Windows.Forms.TextBox name_removeTextBox;
        private System.Windows.Forms.Panel removePanel;
        private JThinButton.JThinButton save_addBtn;
        private System.Windows.Forms.TextBox name_addTextBox;
        private System.Windows.Forms.TextBox price_addTextBox;
        private System.Windows.Forms.Panel addPanel;
        private JImageButton.JImageButton addPlantBtn;
        private JImageButton.JImageButton updatePriceBtn;
        private JImageButton.JImageButton removePlantBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}