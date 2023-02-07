using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacti
{
    public partial class TrackOrder : Form
    {
        Client client;
        CactiDataContext DB;
        Dictionary<Plant, int> dictionary;


        public TrackOrder(Client c, Dictionary<Plant,int> d)
        {
            InitializeComponent();
            client = c;
            dictionary = d;
        }



        public TrackOrder(Client c)
        {
            InitializeComponent();
            client = c;
        }


        #region on load
        private void TrackOrder_Load(object sender, EventArgs e)
        {
            List<Order> aList = new List<Order>();
            using (CactiDataContext DB = new CactiDataContext())
            {
                aList = DB.Orders.OrderBy(d => d.OrderDate).ThenBy(d => d.Status).ThenBy(d => d.ClientId).ToList();
                var thisClientOrder = aList.Where(o => o.ClientId == client.ClientId && o.Status == false); //List Of This Client's Uncompleted Orders

                //Order_Plants w Orders  (Order ID)   ------ Order_Plants w Plants  (Plant ID)
                var list = from order in thisClientOrder
                           join ordPlant in DB.Order_Plants
                           on order.OrderId equals ordPlant.OrderId
                           join plant in DB.Plants
                           on ordPlant.PlantId equals plant.PlantId
                           select new
                           {
                               name = plant.Name,
                               price = plant.Price,
                               orderDate = order.OrderDate,
                               quantity = ordPlant.Quantity
                           };
                if (list != null)
                {
                    var nshalaTezbate = list.ToList();
                    pendingOrdersGV.DataSource = nshalaTezbate;
                    pendingOrdersGV.Show();
                }

                else
                {
                    MessageBox.Show("No purchases found.");
                    pendingOrdersGV.Hide();
                }

               

            }
            //var thisClientOrder = aList.Where(o => o.ClientId == client.ClientId && o.Status == false); //List Of This Client's Uncompleted Orders
            //OrderID Date ClientId Status
            //var test = thisClientOrder.Join(DB.Order_Plants, 
            //                    cO => cO.OrderId,
            //                    oP => oP.OrderId, 
            //                    (order, orderPlant)=> new
            //                    {
            //                        orderId = order.OrderId,
            //                        orderPlant

            //                    }).ToList();
            //var orders = DB.Orders.ToList();
            //var orderPlants = DB.Order_Plants.ToList();
            

            //var tickets = db.Tickets.Where(t => t.flightNO == flightNO);

            //var pass = db.Passengers.Join(tickets,
            //            p => p.passengerID,
            //            t => t.passengerID,
            //            (passenger, ticket) => new
            //            {
            //                passenger,
            //                ticketNO = ticket.ticketNO
            //            }).ToList(); ;

            //List<Passenger> passen = new List<Passenger>();

        }
        #endregion on load


        #region close btn
        private void closeBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
        #endregion close bnt


        #region back btn
        private void backBtn_Click(object sender, EventArgs e)
        {

            if (dictionary != null)
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


    }
}
