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
    public partial class ChangeEmailOrPassword : Form
    {
        JThinButton.JThinButton button;
        Dictionary<Plant, int> dictionary;
        Client client;
        CactiDataContext DB = new CactiDataContext();


        public ChangeEmailOrPassword(Client c, Dictionary<Plant,int> dict, JThinButton.JThinButton btn)
        {
            InitializeComponent();
            button = btn;
            client = c;
            dictionary = dict;
            OldTextBox.ForeColor = Color.Black;
            newTextBox.ForeColor = Color.Black;
            verifyNewTextBox.ForeColor = Color.Black;
        }


        public ChangeEmailOrPassword(Client c,  JThinButton.JThinButton btn)
        {
            InitializeComponent();
            button = btn;
            client = c;
        }


        private void ChangeEmailOrPassword_Load(object sender, EventArgs e)
        {
            ChangeData(button);
        }


        #region change data
        public void ChangeData(JThinButton.JThinButton button)
        {
            if(button.Name == "changeEmailBtn")
            {
                OldLbl.Text = "Current Email";
                OldTextBox.IsPassword = false;
                newLbl.Text = "New Email";
                newTextBox.IsPassword = false;
                verifyNewLbl.Text = "New Email, again";
                verifyNewTextBox.IsPassword = false;
                

            }
            else if (button.Name == "changePasswordBtn")
            {
                OldLbl.Text = "Current Password";
                OldTextBox.IsPassword = true;
                newLbl.Text = "New Pasword";
                newTextBox.IsPassword = true;
                verifyNewLbl.Text = "New Password, again";
                verifyNewTextBox.IsPassword = true;
            }
        }

        #endregion change data


        #region back btn
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (dictionary!= null) 
            {
                Account account = new Account(client,dictionary);
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


        #region save Changes

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            if (button.Name == "changeEmailBtn")
            {
                try
                {
                    if(OldTextBox.TextName != "" && newTextBox.TextName !="" && verifyNewTextBox.TextName != "")
                    {
                        if (OldTextBox.TextName == client.Email)
                        {
                            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9].[a-zA-Z\.]*[a-zA-Z]$");
                            if (rEmail.IsMatch(newTextBox.TextName))
                            {
                                if (newTextBox.TextName == verifyNewTextBox.TextName)
                                {
                                    DB = new CactiDataContext();
                                    var cli = DB.Clients.Where(i => i.Email == newTextBox.TextName);

                                    if (newTextBox.TextName != OldTextBox.TextName)
                                    {

                                        if (cli.Count().ToString() == "0") 
                                        {
                                            DB = new CactiDataContext();
                                            var c = DB.Clients.SingleOrDefault(cl => cl.ClientId == client.ClientId);
                                            c.Email = newTextBox.TextName;
                                            client = c;
                                            DB.SubmitChanges();
                                            MessageBox.Show("Your email address has been successfully changed.");
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
                                        else //email already used
                                        {
                                            throw new Exception("The email you entered is already in use.Enter a differnt one.");
                                        }

                                 
                                    
                                    }
                                    else // old email = new email
                                    {
                                        throw new Exception("Your new email can't be the same as the old one.");
                                    }
                                }
                                else //pws do not match
                                {
                                    throw new Exception("The email you entered does not match with your current Email.");
                                }
                                
                            }
                            else //invalid new email
                            {
                                throw new Exception("Invalid Email.");
                            }
                        }
                        else // incorrect current email
                        {
                            throw new Exception("");
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

            else //changePasswordButton
            {
                try
                {
                    if (OldTextBox.TextName != "" && newTextBox.TextName != "" && verifyNewTextBox.TextName!="")
                    {
                        if (OldTextBox.TextName == client.Password)
                        {
                            if (OldTextBox.TextName.Length > 7)
                            {
                                if (newTextBox.TextName == verifyNewTextBox.TextName)
                                {
                                    if(OldTextBox.TextName != newTextBox.TextName)
                                    {
                                        DB = new CactiDataContext();
                                        var c = DB.Clients.SingleOrDefault(cl => cl.ClientId == client.ClientId);
                                        c.Password = newTextBox.TextName;
                                        client = c;
                                        DB.SubmitChanges();
                                        MessageBox.Show("Your password has been successfully changed.");

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
                                    else //current pw = new pw
                                    {
                                        throw new Exception("Your new password can't be the same as the old one.");
                                    }

                                }
                                else //Passwords do not match
                                {
                                    throw new Exception("Please make sure your passwords match.");
                                }
                            }
                            else //password shorter than 8 char
                            {
                                throw new Exception("Password must be at least 8 characters.");
                            }
                        }
                        else // incorrect current email
                        {
                            throw new Exception("The password you entered does not match with your current password.");
                        }
                    }
                    else //missing info
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


    }
}
