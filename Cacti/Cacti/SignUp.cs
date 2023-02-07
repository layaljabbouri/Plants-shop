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
    public partial class SignUp : Form
    {
        CactiDataContext DB;

        public SignUp()
        {
            InitializeComponent();
            
        }

#region PlaceHolder
        private void fullNameTextBox_Enter(object sender, EventArgs e)
        {
            if (fullNameTextBox.TextName == "Full Name")
            {
                fullNameTextBox.TextName = "";
                fullNameTextBox.ForeColor = Color.Black;
            }
        }

        private void fullNameTextBox_Leave(object sender, EventArgs e)
        {
            if (fullNameTextBox.TextName == "")
            {
                fullNameTextBox.TextName = "Full Name";
                fullNameTextBox.ForeColor = Color.Gray;

            }
            else fullNameTextBox.ForeColor = Color.Black;
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.TextName == "someone@example.com")
            {
                emailTextBox.TextName = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.TextName == "")
            {
                emailTextBox.TextName = "someone@example.com";
                emailTextBox.ForeColor = Color.Gray;
            }
            else emailTextBox.ForeColor = Color.Black;
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.TextName == "PassWorD")
            {
                passwordTextBox.TextName = "";
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.TextName == "")
            {
                passwordTextBox.TextName = "PassWorD";
                passwordTextBox.ForeColor = Color.Gray;
                passwordTextBox.IsPassword = true;

            }
            else
            {
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.IsPassword = true;
            }

        }

        private void reEnterPassword_Enter(object sender, EventArgs e)
        {
            if (reEnterPasswordTextBox.TextName == "PassWorD")
            {
                reEnterPasswordTextBox.TextName = "";
            }
        }

        private void reEnterPassword_Leave(object sender, EventArgs e)
        {
            if (reEnterPasswordTextBox.TextName == "")
            {
                reEnterPasswordTextBox.TextName = "PassWorD";
                reEnterPasswordTextBox.ForeColor = Color.Gray;
                reEnterPasswordTextBox.IsPassword = true;
            }
            else {
                reEnterPasswordTextBox.ForeColor = Color.Black;
                reEnterPasswordTextBox.IsPassword = true;
            }
        }
        #endregion


        #region back btn
        private void backBtn_Click(object sender, EventArgs e)
        {
            WelcomePage WP = new WelcomePage();
            this.Hide();
            WP.ShowDialog();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {

            WelcomePage WP = new WelcomePage();
            this.Hide();
            WP.ShowDialog();
        }
        #endregion back btn


        #region close btn
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
        #endregion close btn





        private void SignUp_Load(object sender, EventArgs e)
        {
            fullNameTextBox.Focus();
        }


        #region Sign up
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (fullNameTextBox.TextName != "Full Name" && emailTextBox.TextName != "someone@example.com" && passwordTextBox.TextName != "PassWorD" && reEnterPasswordTextBox.TextName != "PassWorD")
                {
                    if (Regex.IsMatch(fullNameTextBox.TextName, @"^[a-zA-Z ]{4,50}$")) // verify the the name does not contain any nb   !fullNameTextBox.TextName.Any(char.IsDigit)
                    {
                        if (agreeCheckBox.Checked == true)
                        {
                            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9].[a-zA-Z\.]*[a-zA-Z]$");
                            if (rEmail.IsMatch(emailTextBox.TextName))
                            {
                                if(passwordTextBox.TextName.Length > 7)
                                {
                                    if (passwordTextBox.TextName == reEnterPasswordTextBox.TextName)
                                    {
                                        DB = new CactiDataContext();
                                        var c = DB.Clients.Where(i => i.Email == emailTextBox.TextName);

                                        if (c.Count().ToString() == "0")
                                        {
                                            var client = new Client();
                                            client.Email = emailTextBox.TextName;
                                            client.Name = fullNameTextBox.TextName;
                                            client.Password = passwordTextBox.TextName;
                                            MessageBox.Show("Sign Up Succeeded.");
                                            DB.Clients.InsertOnSubmit(client);
                                            DB.SubmitChanges();
                                            HomePage HP = new HomePage(client);
                                            this.Hide();
                                            HP.ShowDialog();
                                        }
                                        // email already used
                                        else { throw new Exception("The email you entered is already in use. Enter a differnt one."); }

                                    }
                                    // unmatching passwords
                                    else
                                    {
                                        passwordTextBox.Focus();
                                        throw new Exception("Please make sure your passwords match.");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Password must be at least 8 characters.");
                                }
                                
                            }
                            // email does not look like an email
                            else
                            {
                                emailTextBox.Focus();
                                throw new Exception("Please enter a valid email.");
                            }
                        }

                        //unchecked checkbox
                        else
                        {
                            throw new Exception("Kindly indicate that you agree to the terms and conditions.");
                        }
                       

                    }
                    else  //name contains other than letters
                    {
                        throw new Exception("The name must contain ONLY letters.");
                    }
                
                
                }
                else //missing info
                {
                   throw new Exception ("Kindly fill out all the information needed."); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        
    }
}
