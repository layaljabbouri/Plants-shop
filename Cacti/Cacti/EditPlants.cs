using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Cacti
{
    public partial class EditPlants : Form
    {
        CactiDataContext DB;
        Worker worker;


        public EditPlants(Worker w)
        {
            InitializeComponent();
            name_addTextBox.Text = name_removeTextBox.Text = name_updateTextbox.Text
           = price_addTextBox.Text = price_updateTextBox.Text = "";

            worker = w;
        }


        #region ToolTips
        private void EditPlants_Load(object sender, EventArgs e)
        {
            ToolTip tp1 = new ToolTip();
            tp1.SetToolTip(addPlantBtn, "Add Plant");
            ToolTip tp2 = new ToolTip();
            tp2.SetToolTip(removePlantBtn, "Remove Plant");
            ToolTip tp3 = new ToolTip();
            tp3.SetToolTip(updatePriceBtn, "Update Price");
        }
        #endregion ToolTips


        #region Add plant
        private void save_addBtn_Click(object sender, EventArgs e)
        {
            worker.AddPlant(name_addTextBox.Text, price_addTextBox.Text);
            name_addTextBox.Text = "";
            price_addTextBox.Text = "";
        }
        #endregion Add plant


        #region Remove plant
        private void save_removeBtn_Click(object sender, EventArgs e)
        {
            worker.RemovePlant(name_removeTextBox.Text);
            name_removeTextBox.Text = "";
        }
        #endregion Remove plant
        

        #region Update price
        private void save_updateBtn_Click(object sender, EventArgs e)
        {
            worker.UpdatePlant(name_updateTextbox.Text, price_updateTextBox.Text);
            name_updateTextbox.Text = "";
            price_updateTextBox.Text = "";
        }
        #endregion Update price


        #region Close button
        private void closeBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
        #endregion Close button


        #region Back button
        private void backBtn_Click(object sender, EventArgs e)
        {
            WorkerHomePage WHP = new WorkerHomePage(worker);
            this.Hide();
            WHP.ShowDialog();
        }
        #endregion Back button

    }
}
