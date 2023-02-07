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
    public partial class Purchases : Form
    {
        
        Client client;
        Dictionary<Plant, int> dictionary;
        double total=0;



        public Purchases(Client c,Dictionary<Plant,int> dict)
        {
            InitializeComponent();
            client = c;
            dictionary = dict;
        }


        public Purchases(Client c)
        {
            InitializeComponent();
            client = c;
        }



        #region Load
        private void Purchases_Load(object sender, EventArgs e)
        {
            List<Order> aList = new List<Order>();

            using (CactiDataContext DB = new CactiDataContext())
            {
                aList = DB.Orders.OrderBy(o => o.OrderDate).ThenBy(o => o.Status).ThenBy(o => o.ClientId).ToList();
                var thisClientPurchases = aList.Where(o => o.ClientId == client.ClientId && o.Status == true);
                var purchases = from order in thisClientPurchases
                                join ordPlant in DB.Order_Plants
                                on order.OrderId equals ordPlant.OrderId
                                join plant in DB.Plants
                                on ordPlant.PlantId equals plant.PlantId
                                select new
                                {
                                    order.OrderDate,
                                    plant.Name,
                                    plant.Price,
                                    ordPlant.Quantity,
                                    order.Status
                                };
                
               
                if (purchases!= null)
                {

                    DataTable dt = new DataTable();

                    dt.Columns.AddRange(new DataColumn[] {
                                                    new DataColumn("Order Date"), new DataColumn("Plant"),
                                                    new DataColumn("Unit Price"), new DataColumn("Quantity"),
                                                    new DataColumn("Completed", typeof(bool))
                                                    });
                    //var purchList = purchases.ToList();

                    //purchasesGV.DataSource = purchList;

                    foreach (var item in purchases)
                    {
                        DataRow row = dt.NewRow();
                        row["Order Date"] = item.OrderDate;
                        row["Plant"] = item.Name;
                        row["Unit Price"] = item.Price;
                        row["Quantity"] = item.Quantity;
                        row["Completed"] = true;
                        total += (double)item.Price * item.Quantity;
                        dt.Rows.Add(row);
                    }
                    
                    //ADD TOTAL CELLS
                    DataRow dr;
                    
                    dr = dt.NewRow();
                    dr["Unit Price"] = "TOTAL";
                    dr["Quantity"] = total;
                    
                    dt.Rows.Add(dr);

                    purchasesGV.DataSource = dt;
                    purchasesGV.Rows[purchasesGV.Rows.Count - 1].Cells[2].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                    purchasesGV.Show();
                }
                else
                {
                    MessageBox.Show("No Orders found.");
                    purchasesGV.Hide();
                }

            }
        }

        #endregion Load


        #region back btn
        private void backBtn_Click(object sender, EventArgs e)
        {
            if(dictionary!= null)
            {
                HomePage HP = new HomePage(client, dictionary);
                this.Hide();
                HP.ShowDialog();
            }
            else
            {

                HomePage HP = new HomePage(client);
                this.Hide();
                HP.ShowDialog();
            }
        }
        #endregion back btn


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


    }
}
