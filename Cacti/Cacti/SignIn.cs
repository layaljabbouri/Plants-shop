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
    public partial class SignIn : Form
    {
        // WelcomePage WP;
        Form f;
        CactiDataContext DB;


        public SignIn()
        {
            InitializeComponent();
            f = this;
        }

        #region Close button
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
        #endregion Close button


        #region PlaceHolder

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
            else
            {

                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.TextName == "PassWorD")
            {
                passwordTextBox.TextName = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.IsPassword = true;
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

        #endregion


        #region Back button
        private void backBtn_Click(object sender, EventArgs e)
        {
            WelcomePage WP = new WelcomePage();
            this.Hide();
            WP.ShowDialog();
        }
        #endregion Back button
        

        #region Sign In 
        private void signInBtn_Click(object sender, EventArgs e)
        {
            try
            {

                #region Client login
                if (clientRadioButton.Checked)
                {
                    DB = new CactiDataContext();
                    var client = DB.Clients.SingleOrDefault(i => i.Email == emailTextBox.TextName && i.Password == passwordTextBox.TextName);
                    
                    if (client == null)
                    {
                        emailTextBox.TextName = "";
                        passwordTextBox.TextName = "";
                        emailTextBox.Focus();
                        throw new Exception("Invalid Email/Password");
                    }
                    else
                    {
                        HomePage HP = new HomePage(client);
                        this.Hide();
                        HP.ShowDialog();
                    }
                }
                #endregion Client login


                #region Staff login
                else if (staffRadioButton.Checked)
                {
                    Staff s = new Staff();
                    s.WorkerLogin(emailTextBox.TextName, passwordTextBox.TextName,f);
                    emailTextBox.TextName = "";
                    passwordTextBox.TextName = "";
                    emailTextBox.Focus();
                }
                #endregion Staff login


                #region Admin login
                else if (adminRadioButton.Checked)
                {
                    Admin a = new Admin();
                    a.WorkerLogin(emailTextBox.TextName, passwordTextBox.TextName, f);
                    emailTextBox.TextName = "";
                    passwordTextBox.TextName = "";
                    emailTextBox.Focus();
                }
                #endregion Admin login


                // if none of the radiobtns is checked
                else throw new Exception("Select your role");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion Sign In


        }

        
    }
}
