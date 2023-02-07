using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacti
{
    public partial class WorkerHomePage : Form
    {
        Worker worker;
        public WorkerHomePage(Worker w)
        {
            InitializeComponent();
            worker = w;
            if (worker is Staff)
            {
                staffBtn.Enabled = false;
                btnStaff.Enabled = false;
            }
            else if (worker is Admin)
            {
                staffBtn.Enabled = true;
                btnStaff.Enabled = true;
            }
        }

        #region logout     

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Sign Out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WelcomePage WP = new WelcomePage();
                this.Hide();
                WP.Show();
            }
        }
        #endregion Logout


        #region Close btn
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
        #endregion Close btn


        #region Plants
        private void plantsBtn_Click(object sender, EventArgs e)
        {
            EditPlants EP = new EditPlants(worker);
            this.Hide();
            EP.ShowDialog();
        }


        private void btnPlants_Click(object sender, EventArgs e)
        {
            EditPlants EP = new EditPlants(worker);
            this.Hide();
            EP.ShowDialog();
        }

        #endregion Plants


        #region Orders btn
        private void ordersBtn_Click(object sender, EventArgs e)
        {
            TotalOrders totalOrders = new TotalOrders(worker);
            this.Hide();
            totalOrders.ShowDialog();
        }


        private void btnOrders_Click(object sender, EventArgs e)
        {
            TotalOrders totalOrders = new TotalOrders(worker);
            this.Hide();
            totalOrders.ShowDialog();
        }

        #endregion Orders btn


        #region Staff btn
        private void staffBtn_Click(object sender, EventArgs e)
        {
            EditStaff ES = new EditStaff(worker);
            this.Hide();
            ES.ShowDialog();
        }
        #endregion Staff btn


        #region Profile

        private void profileBtn_Click(object sender, EventArgs e)
        {
            WorkerProfile WP = new WorkerProfile(worker);
            this.Hide();
            WP.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            WorkerProfile WP = new WorkerProfile(worker);
            this.Hide();
            WP.ShowDialog();
        }

        #endregion Profile


        #region Receipts
        private void receiptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //we need the list of items with pricessah
                using (StreamWriter writer = File.AppendText("receipts.txt"))
                {
                    CactiDataContext DB = new CactiDataContext();
                    var items = (from ordPlant in DB.Order_Plants
                                join order in DB.Orders
                                on ordPlant.OrderId equals order.OrderId
                                join plant in DB.Plants
                                on ordPlant.PlantId equals plant.PlantId
                                where order.OrderDate == DateTime.Now.Date
                                select new
                                {
                                    order.OrderDate,
                                    order.ClientId,
                                    order.OrderId,
                                    total = ordPlant.Quantity * plant.Price
                                }).ToList();

                    if (items.Count != 0)
                    {
                        foreach (var item in items)
                        {

                            writer.WriteLineAsync($"{item.OrderDate}\t{item.ClientId}\t{item.OrderId}\t{item.total}");
                        }
                        MessageBox.Show("Receipt generated.");
                        return;
                    }
                    MessageBox.Show("No Orders found for today :(");
                }
                   
            }
            catch
            {
                MessageBox.Show("The reciept could not be generated. Try again later.");
            }
           
        }


        private void btnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                //we need the list of items with pricessah
                using (StreamWriter writer = File.AppendText("receipts.txt"))
                {
                    CactiDataContext DB = new CactiDataContext();
                    var items = (from ordPlant in DB.Order_Plants
                                 join order in DB.Orders
                                 on ordPlant.OrderId equals order.OrderId
                                 join plant in DB.Plants
                                 on ordPlant.PlantId equals plant.PlantId
                                 where order.OrderDate == DateTime.Now.Date
                                 select new
                                 {
                                     order.OrderDate,
                                     order.ClientId,
                                     order.OrderId,
                                     total = ordPlant.Quantity * plant.Price
                                 }).ToList();

                    if (items.Count != 0)
                    {
                        foreach (var item in items)
                        {

                            writer.WriteLineAsync($"{item.OrderDate}\t{item.ClientId}\t{item.OrderId}\t{item.total}");
                        }
                        MessageBox.Show("Receipt generated.");
                        return;
                    }
                    MessageBox.Show("No Orders found for today :(");
                }

            }
            catch
            {
                MessageBox.Show("The reciept could not be generated. Try again later.");
            }
        }
        #endregion Receipts


    }
}
