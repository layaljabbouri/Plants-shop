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
    public partial class ChangeAddressOrPhoneNumber : Form
    {
        Client client;
        Dictionary<Plant, int> dictionary;
        JThinButton.JThinButton button;
        CactiDataContext DB;


        public ChangeAddressOrPhoneNumber(Client c, Dictionary<Plant, int> dict, JThinButton.JThinButton btn)
        {
            InitializeComponent();
            client = c;
            dictionary = dict;
            button = btn;
            OldTextBox.ForeColor = Color.Black;
            newTextBox.ForeColor = Color.Black;
        }


        public ChangeAddressOrPhoneNumber(Client c, JThinButton.JThinButton btn)
        {
            InitializeComponent();
            client = c;
            button = btn;
        }

        #region change address or phone nb

        private void ChangeAddressOrPhoneNumber_Load(object sender, EventArgs e)
        {
            ChangeData(button);
        }

        #endregion change address or phone nb


        #region changedata

        public void ChangeData (JThinButton.JThinButton button)
        {
            if (button.Name == "changeAddressBtn")
            {
                OldLbl.Text = "Current Location:";
                if (client.Address == null)
                {
                    OldTextBox.TextName = "No Location";
                    OldTextBox.ForeColor = Color.Gray;
                }
                else
                {
                    OldLbl.Text = client.Address;
                    OldTextBox.ForeColor = Color.Gray;
                }

                newLbl.Text = "New Location:";
            }
            else if(button.Name == "changePhoneNumberBtn")
            {
                OldLbl.Text = "Current Phone Number:";
                if (client.PhoneNumber == null)
                {
                    OldTextBox.TextName = "No Phone Number";
                    OldTextBox.ForeColor = Color.Gray;
                }
                else
                {
                    OldLbl.Text = client.PhoneNumber.ToString() ;
                    OldTextBox.ForeColor = Color.Gray;
                }

                newLbl.Text = "New Phone Number:";
            }
        }

        #endregion change data


        #region save changes

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            if(button.Name== "changeAddressBtn")
            {
                try
                {
                    if (newTextBox.TextName != "")
                    {
                        if (newTextBox.TextName.Any(c => char.IsLetter(c)))
                        {
                            if (newTextBox.TextName.Length > 20)
                            {
                                if(newTextBox.TextName != OldTextBox.TextName)
                                {
                                    DB = new CactiDataContext();
                                    DB.SubmitChanges();
                                    var c = DB.Clients.SingleOrDefault(cl => cl.ClientId == client.ClientId);
                                    c.Address = newTextBox.TextName;
                                    client = c;
                                    DB.SubmitChanges();
                                    MessageBox.Show("Your Location has been successfully changed.");
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
                                else // new address = old address
                                {
                                    throw new Exception("Your new address can't be the same as the old one.");
                                }
                            }
                            else //location less than 21 characters
                            {
                                throw new Exception("Please provide us with more details about your location.");
                            }
                        }
                        else //location does not contain any character
                        {
                            throw new Exception("Enter a valid location.");
                        }
                        
                    }
                    else
                    {
                        throw new Exception("Kindly fill out all the information needed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else // Change phone number btn
            {
                try
                {
                    if (newTextBox.TextName != "")
                    {
                        if (!newTextBox.TextName.Any(c => char.IsDigit(c) == false))
                        {
                            if (newTextBox.TextName.Length == 8)
                            {
                                if(newTextBox.TextName != OldTextBox.TextName)
                                {
                                    DB = new CactiDataContext();
                                    var c = DB.Clients.SingleOrDefault(cl => cl.ClientId == client.ClientId);
                                    c.PhoneNumber = Convert.ToInt32(newTextBox.TextName);
                                    client = c;
                                    DB.SubmitChanges();
                                    MessageBox.Show("Your phone number has been successfully changed.");
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
                                else // new phone number = old phone nb
                                {
                                    throw new Exception("Your new phone number can't be the same as the old one.");
                                }
                                
                            }
                            else //phone numbe != 8 char
                            {
                                throw new Exception("Invalid Phone Number.");
                            }
                        }
                        else //location does not contain any character
                        {
                            throw new Exception("Invalid Phone Number.");
                        }

                    }
                    else
                    {
                        throw new Exception("Kindly fill out all the information needed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion save changes


        #region back btn

        private void backBtn_Click(object sender, EventArgs e)
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
