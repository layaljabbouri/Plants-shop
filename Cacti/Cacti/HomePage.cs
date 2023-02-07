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
    public partial class HomePage : Form
    {
        Dictionary<Plant, int> dictionary;
        Client client;
        public HomePage(Client c)
        {
            InitializeComponent();
            client = c;
        }

        public HomePage(Client c, Dictionary<Plant, int> d)
        {
            InitializeComponent();
            dictionary = d;
            client = c;
        }


        #region Close
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
        #endregion Close


        #region Menu


        #region Account


        private void accountBtn_MouseEnter(object sender, EventArgs e)
        {
            accountBtn.BackColor = Color.FromArgb(120, 197, 163);
        }


        private void accountBtn_Hover(object sender, EventArgs e)
        {
            accountBtn.BackColor = Color.FromArgb(120, 197, 163);

        }



        private void acountBtn_Leave(object sender, EventArgs e)
        {
            accountBtn.BackColor = Color.Transparent;
        }



        private void accountBtn_Click(object sender, EventArgs e)
        {
            if (dictionary != null)
            {
                Account account = new Account(client, dictionary);
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
        #endregion Account


        #region Cart

        private void cartBtn_MouseEnter(object sender, EventArgs e)
        {
            cartBtn.BackColor = Color.FromArgb(120, 197, 163);
        }


        private void cartBtn_Hover(object sender, EventArgs e)
        {
            cartBtn.BackColor = Color.FromArgb(120, 197, 163);
        }



        private void cartBtn_Leave(object sender, EventArgs e)
        {
            cartBtn.BackColor = Color.Transparent;
        }



        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (dictionary != null)
            {
                Cart cart = new Cart(client, dictionary);
                this.Hide();
                cart.ShowDialog();
            }
            else
            {
                Cart cart = new Cart(client);
                this.Hide();
                cart.ShowDialog();
            }
        }
        #endregion Cart


        #region Sign out


        private void signOutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Sign Out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WelcomePage WP = new WelcomePage();
                this.Hide();
                WP.Show();
            }
        }


        private void signOutBtn_MouseEnter(object sender, EventArgs e)
        {
            signOutBtn.BackColor = Color.FromArgb(120, 197, 163);
        }
        private void signOutBtn_Hover(object sender, EventArgs e)
        {
            signOutBtn.BackColor = Color.FromArgb(120, 197, 163);
        }

        private void signOutBtn_Leave(object sender, EventArgs e)
        {
            signOutBtn.BackColor = Color.Transparent;
        }

        #endregion Sign out


        #endregion Menu



        #region on load

        private void HomePage_Load(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.FromArgb(120, 197, 163);
        }

        #endregion On load



        #region Offers

        private void btnOffers_Enter(object sender, EventArgs e)
        {
            btnOffers.BackColor = Color.White;
        }

        private void btnOffers_Hover(object sender, EventArgs e)
        {
            btnOffers.BackColor = Color.White;
        }
        #endregion Offers



        #region Shop

        private void shopBtn_Click(object sender, EventArgs e)
        {
            if(dictionary == null)
            {
                Shop shop = new Shop(client);
                this.Hide();
                shop.ShowDialog();
            }
            else
            {
                Shop shop = new Shop(client, dictionary);
                this.Hide();
                shop.ShowDialog();
                shop.display_dictionary(dictionary);
            }
            
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            if (dictionary == null)
            {
                Shop shop = new Shop(client);
                this.Hide();
                shop.ShowDialog();
            }
            else
            {
                Shop shop = new Shop(client, dictionary);
            }
        }

        #endregion Shop
        


        #region Track Order

        private void trackBtn_Click(object sender, EventArgs e)
        {

            if(dictionary != null)
            {
                TrackOrder to = new TrackOrder(client, dictionary);
                this.Hide();
                to.ShowDialog();
            }
            else
            {
                TrackOrder to = new TrackOrder(client);
                this.Hide();
                to.ShowDialog();
            }
        }



        private void btnTrack_Click(object sender, EventArgs e)
        {
            if (dictionary != null)
            {
                TrackOrder to = new TrackOrder(client, dictionary);
                this.Hide();
                to.ShowDialog();
            }
            else
            {
                TrackOrder to = new TrackOrder(client);
                this.Hide();
                to.ShowDialog();
            }
        }

        #endregion Track



        #region Purchases

        private void btnPurchases_Click(object sender, EventArgs e)
        {

            if (dictionary != null)
            {
                Purchases purchases = new Purchases(client, dictionary);
                this.Hide();
                purchases.ShowDialog();
            }
            else
            {
                Purchases purchases = new Purchases(client);
                this.Hide();
                purchases.ShowDialog();
            }
        }

        private void purchasesBtn_Click(object sender, EventArgs e)
        {
            if (dictionary != null)
            {
                Purchases purchases = new Purchases(client, dictionary);
                this.Hide();
                purchases.ShowDialog();
            }
            else
            {
                Purchases purchases = new Purchases(client);
                this.Hide();
                purchases.ShowDialog();
            }
        }

        #endregion Purchases


      
    }
}