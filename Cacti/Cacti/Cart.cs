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

    public partial class Cart : Form
    {
        Dictionary<Plant, int> Dictionary;
        Dictionary<Plant, int> cartDictionary;
        Client client;
        int orderId;



        public Cart(Client c)
        {
            InitializeComponent();
            client = c;
            buyBtn.Enabled = true;
        }
       


        public Cart(Client c,Dictionary<Plant, int> dictionary)
        { 
            InitializeComponent();
            Dictionary = dictionary;
            client = c;
            buyBtn.Enabled = true;
          
        }


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


        #region Cart Load

        private void Cart_Load(object sender, EventArgs e)
        {
            cartBtn.BackColor = Color.FromArgb(120, 197, 163);
           
            //foreach (Product p in products)
            //{
            //    Plant match = PlantsDictionary.Keys.SingleOrDefault(i => i.Name == p.Controls[nameIndex].Text.ToString());
            //    if (match != null)
            //    {
            //        PlantsDictionary[match] = (int)p.Controls.OfType<NumericUpDown>().First().Value;
            //    }
            //}

             cartDictionary = new Dictionary<Plant, int>();

        if(Dictionary != null)
            {
                foreach (var dict in Dictionary)
                {
                    if (dict.Value != 0)
                    {
                        cartDictionary.Add(dict.Key, dict.Value);
                    }
                }
                double T = 0;
                // List<KeyValuePair<Plant,int>> list = dictionary.ToList();
                if(cartDictionary != null)
                {
                    List<Item> cartItems = new List<Item>();
                    foreach (var l in cartDictionary)
                    {
                        Item i = new Item();
                        i.Name = l.Key.Name;
                        i.Price = (double)l.Key.Price;
                        i.Quantity = l.Value;
                        i.Total = i.Price * i.Quantity;
                        cartItems.Add(i);
                        T += i.Total;
                    }
                    cartDataGridView.DataSource = cartItems;
                    totalLbl.Text = T.ToString();
                }
                else
                {
                    MessageBox.Show("Your cart empty.");
                }
                
            }
            else
            {
                MessageBox.Show("Your cart is empty");
            }
           
        }
        #endregion Cart Load
         

        #region Menu
        private void accountBtn_Click(object sender, EventArgs e)
        {
            if (Dictionary != null)
            {
                Account account = new Account(client, Dictionary);
                this.Hide();
                account.ShowDialog();
            }
            else
            {
                Account account = new Account(client);
                this.Hide();
                account.ShowDialog();
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (Dictionary != null)
            {
                HomePage HP = new HomePage(client, Dictionary);
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

        private void signOutBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Sign Out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WelcomePage WP = new WelcomePage();
                this.Hide();
                WP.ShowDialog();
            }
        }

        #endregion Menu


        #region Buy btn
        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (Dictionary != null)
            {

                if (client.PhoneNumber != null && client.Address != null)
                {

                    if (MessageBox.Show("Are you sure you want to proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        #region Insert Order
                        Order order = new Order();
                        orderId =  order.InsertOrder(client.ClientId);
                        MessageBox.Show("Your order has been received. The delivery might take up to 3 days. Thank You");
                        #endregion Insert Order

                        #region Insert order plant
                        Order_Plant order_plant = new Order_Plant();
                        order_plant.InsertOrderDetails(orderId, cartDictionary);
                        #endregion Insert order plant

                        cartDictionary = null;
                        foreach (var key in Dictionary.Keys.ToList())
                        {
                            Dictionary[key] = 0;
                        }
                        buyBtn.Enabled = false;
                    }

                }
                else
                {
                    if (MessageBox.Show("Kindly enter your Phone number and Address in order to proceed.", "Missing info", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Account account = new Account(client, Dictionary);
                        this.Hide();
                        account.ShowDialog();
                    }
                }
            }
            else MessageBox.Show("Your cart is empty");
        }
        #endregion Buy btn

    }
}
