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
    public partial class Account : Form
    {
        Client client;
        Dictionary<Plant, int> dictionary;
      


        public Account(Client c)
        {
            InitializeComponent();
            client = c;
        }


        public Account(Client c, Dictionary<Plant, int> d)
        {
            InitializeComponent();
            dictionary = d;
            client = c;
        }

        #region on load
        private void Account_Load(object sender, EventArgs e)
        {
            accountBtn.BackColor = Color.FromArgb(120, 197, 163);
            try
            {
                
                nameLbl.Text = client.Name;
                emailLbl.Text = client.Email;
                if (client.PhoneNumber != null)
                {
                    phoneNumberLbl.Text = client.PhoneNumber.ToString();
                }
                else phoneNumberLbl.Text = "";

                if (client.Address != null)
                {
                    AddressLbl.Text = client.Address;
                }
                else AddressLbl.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ ex.Message}");
            }
        }
        #endregion on load


        #region Change email
        private void changeEmailBtn_Click(object sender, EventArgs e)
        {
            if (dictionary != null)
            {
                ChangeEmailOrPassword changeEmailOrPassword = new ChangeEmailOrPassword(client, dictionary, changeEmailBtn);
                this.Hide();
                changeEmailOrPassword.Show();
            }
            else
            {
                ChangeEmailOrPassword changeEmailOrPassword = new ChangeEmailOrPassword(client, changeEmailBtn);
                this.Hide();
                changeEmailOrPassword.Show();
            }

        }

        #endregion change email


        #region home btn
        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (dictionary!= null)
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
        #endregion home btn


        #region change password

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (dictionary != null)
            {
                ChangeEmailOrPassword changeEmailOrPassword = new ChangeEmailOrPassword(client, dictionary, changePasswordBtn);
                this.Hide();
                changeEmailOrPassword.Show();
            }
            else
            {
                ChangeEmailOrPassword changeEmailOrPassword = new ChangeEmailOrPassword(client, changePasswordBtn);
                this.Hide();
                changeEmailOrPassword.Show();
            }
        }
        #endregion change passowrd


        #region cart
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
        #endregion cart


        #region sign out
        private void signOutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Sign Out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WelcomePage WP = new WelcomePage();
                this.Hide();
                WP.ShowDialog();
            }
        }
        #endregion sign out


        #region close btn
        private void closeBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
        #endregion cloe


        #region change address
        private void changeAddressBtn_Click(object sender, EventArgs e)
        {
            if (dictionary!= null)
            {
                ChangeAddressOrPhoneNumber changeAddressOrPhoneNumber = new ChangeAddressOrPhoneNumber(client, dictionary, changeAddressBtn);
                this.Hide();
                changeAddressOrPhoneNumber.ShowDialog();
            }
            else
            {
                ChangeAddressOrPhoneNumber changeAddressOrPhoneNumber = new ChangeAddressOrPhoneNumber(client, changeAddressBtn);
                this.Hide();
                changeAddressOrPhoneNumber.ShowDialog();
            }
        }
        #endregion change address


        #region change phone nb
        private void changePhoneNumberBtn_Click(object sender, EventArgs e)
        {
            if(dictionary!= null)
            {
                ChangeAddressOrPhoneNumber changeAddressOrPhoneNumber = new ChangeAddressOrPhoneNumber(client, dictionary, changePhoneNumberBtn);
                this.Hide();
                changeAddressOrPhoneNumber.ShowDialog();
            }
            else
            {
                ChangeAddressOrPhoneNumber changeAddressOrPhoneNumber = new ChangeAddressOrPhoneNumber(client, changePhoneNumberBtn);
                this.Hide();
                changeAddressOrPhoneNumber.ShowDialog();
            }
        }
        #endregion chnage phone nb

    }
}