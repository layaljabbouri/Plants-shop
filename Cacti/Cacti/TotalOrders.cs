using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacti
{
    public partial class TotalOrders : Form
    {
        CactiDataContext DB;
        Worker worker;
        public TotalOrders(Worker w)
        {
            InitializeComponent();
            worker = w;
        }



        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = pendingGV[column, row];
            DataGridViewCell cell2 = pendingGV[column, row - 1];
            if (cell1.Value == cell2.Value)
            {
                return true;
            }
            else return false;
        }

        #region load
        private void TotalOrders_Load(object sender, EventArgs e)
        {
            //pendingGV.AutoGenerateColumns = false;

            List<Order_Plant> totalpendingorders = new List<Order_Plant>();
            DataTable dt = new DataTable();
            DB = new CactiDataContext();

            List<Order> aList = new List<Order>();
            aList = DB.Orders.Where(o => o.Status == false).ToList();
            totalpendingorders = (from order in aList
                                  join client in DB.Clients
                                  on order.ClientId equals client.ClientId
                                  join ordPlant in DB.Order_Plants
                                  on order.OrderId equals ordPlant.OrderId
                                  join plant in DB.Plants
                                  on ordPlant.PlantId equals plant.PlantId
                                  select ordPlant).ToList();

            dt.Columns.AddRange(new DataColumn[]
            {
                  new DataColumn("Order ID"),
                  new DataColumn("Name"),
                  new DataColumn("Address"),
                  new DataColumn("Phone Number"),
                  new DataColumn("Order Date"),
                  new DataColumn("Plant Name"),
                  new DataColumn("Price"),
                //  new DataColumn("Status")
              });


            foreach (var ordp in totalpendingorders)
            {
                DataRow row = dt.NewRow();
                row["Order ID"] = ordp.OrderId;
                row["Order Date"] = ordp.Order.OrderDate;
                row["Name"] = ordp.Order.Client.Name;
                row["Address"] = ordp.Order.Client.Address;
                row["Phone Number"] = ordp.Order.Client.PhoneNumber;
                row["Plant Name"] = ordp.Plant.Name;
                row["Price"] = ordp.Plant.Price;
                //row["Status"] = ordp.Order.Status;
                dt.Rows.Add(row);
            }

        //int lastRowIndex = dt.Rows.Count;

        ////ADD TOTAL CELLS

        //dr = dt.NewRow();
        //    dt.Rows.Add(dr);

        //    dr = dt.NewRow();
        //    dr["Price"] = "TOTAL";
        //    dt.Rows.Add(dr);

        //    dr = dt.NewRow();
        //    dr["Price"] = total;
        //    dt.Rows.Add(dr);

        //after 
        //            resultGV.Rows[lastRowIndex + 1].Cells[3].Style.Font = new Font(DataGridView.DefaultFont,FontStyle.Bold);

            pendingGV.DataSource = dt;

            var order_plantList = totalpendingorders.ToList();


            List<Order> bList = new List<Order>();
            bList = DB.Orders.Where(o => o.Status == true).ToList();
            var totalcompletedOrders = from order in bList
                                       join client in DB.Clients
                                       on order.ClientId equals client.ClientId
                                       join ordPlant in DB.Order_Plants
                                       on order.OrderId equals ordPlant.OrderId
                                       join plant in DB.Plants
                                       on ordPlant.PlantId equals plant.PlantId
                                       select new
                                       {
                                           client.Name,
                                           client.Address,
                                           client.PhoneNumber,
                                           order.OrderDate,
                                           plant1 = plant.Name,
                                           plant.Price,
                                       };
            var tcOrders = totalcompletedOrders.ToList();
            completedGV.DataSource = tcOrders;
                 

        }

        #endregion load


        #region close btn
        private void closeBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
        #endregion close btn


        #region back btn
        private void backBtn_Click(object sender, EventArgs e)
        {
           
                WorkerHomePage WHP = new WorkerHomePage(worker);
                this.Hide();
                WHP.ShowDialog();
           
        }
        #endregion back btn


        #region complete btn
        private void completeOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (completeOrderTextBox.Text != "")
                {
                    if (!completeOrderTextBox.Text.Any(c => char.IsDigit(c) == false))
                    {
                        if (completeOrderTextBox.TextLength < 9)
                        {
                            List<Order> ord =  DB.Orders.Where(o => o.OrderId == Convert.ToInt32(completeOrderTextBox.Text)).ToList();
                        
                            if (ord.Count != 0)
                            {
                                if (MessageBox.Show("Are you sure you want to complete this order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    foreach (Order o in ord)
                                    {
                                        o.Status = true;
                                    }
                                    DB.SubmitChanges();
                                    completeOrderTextBox.Text = "";
                                    MessageBox.Show("Order has been marked as completed.");
                                    TotalOrders TO = new TotalOrders(worker);
                                    this.Hide();
                                    TO.Show();
                                }

                            }
                            else
                            {
                                completeOrderTextBox.Text = "";
                                throw new Exception("Order not found.");
                            }
                        }
                        else
                        {
                            completeOrderTextBox.Text = "";
                            throw new Exception("Invalid Order ID.");
                       
                        }
                       
                    }
                    else
                    {
                        completeOrderTextBox.Text = "";
                        throw new Exception("Invalid Order ID. Check pending orders to make sure you are entering the correct one.");
                    }
                }
                else
                {
                    completeOrderTextBox.Text = "";
                    throw new Exception("Enter the order ID.");
                }
            }
            catch (Exception ex)
            {
                completeOrderTextBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }
        #endregion complete btn


        #region Cell painting

        /*   private void pendingGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
           {

               e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
               if (e.RowIndex < 1 || e.ColumnIndex < 0)
                   return;
               if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
               {
                   e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                   //e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
               }
               else //L COMMENTED ANA ZEDTO
               {
                   e.AdvancedBorderStyle.Top = pendingGV.AdvancedCellBorderStyle.Top;
                   //e.AdvancedBorderStyle.Bottom = pendingGV.AdvancedCellBorderStyle.Bottom;
               }
           }

           private void pendingGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
           {
               if (e.RowIndex == 0)
                   return;
               if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
               {
                   e.Value = "";
                   e.FormattingApplied = true;
               }
           }
           */
        #endregion Cell Painting


        #region Placeholder
        private void completeOrderTextBox_Leave(object sender, EventArgs e)
        {

            if (completeOrderTextBox.Text == "")
            {

                completeOrderTextBox.Text = "Order ID";
                completeOrderTextBox.ForeColor = Color.Gray;
            }
            else
            {
                completeOrderTextBox.ForeColor = Color.FromArgb(31, 167, 127);
            }
        }

        private void completeOrderTextBox_Enter(object sender, EventArgs e)
        {
            if (completeOrderTextBox.Text == "someone@example.com")
            {
               completeOrderTextBox.Text = "";
                completeOrderTextBox.ForeColor = Color.FromArgb(31, 167, 127);

            }
        }
        #endregion Placeholder
    }
}
