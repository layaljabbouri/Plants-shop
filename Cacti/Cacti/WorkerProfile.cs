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
    public partial class WorkerProfile : Form
    {
        Worker worker;
        CactiDataContext DB = new CactiDataContext();


        public WorkerProfile(Worker w)
        {
            InitializeComponent();
            worker = w;
        }


        #region placeholder

        private void newEmailTextBox_Leave(object sender, EventArgs e)
        {

            if (newEmailTextBox.TextName == "")
            {
                newEmailTextBox.TextName = "someone@example.com";
                newEmailTextBox.ForeColor = Color.Gray;
            }
            else newEmailTextBox.ForeColor = Color.Black;
        }

        
        private void newEmailTextBox_Enter(object sender, EventArgs e)
        {
            if (newEmailTextBox.TextName == "someone@example.com")
            {
                newEmailTextBox.TextName = "";
                newEmailTextBox.ForeColor = Color.Black;
            }
        }
        #endregion placeholder


        #region Save email
        private void saveEmailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (worker is Staff)
                {
                    Staff s = worker as Staff;
                    if (newEmailTextBox.TextName != s.Email)
                    {
                        System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9].[a-zA-Z\.]*[a-zA-Z]$");
                        if (rEmail.IsMatch(newEmailTextBox.TextName))
                        {
                            DB = new CactiDataContext();

                            var sta = DB.Staffs.SingleOrDefault(i => i.Email == newEmailTextBox.TextName);
                            if (sta == null)
                            {
                                Staff myStaff = DB.Staffs.Single(staff => staff.Email == s.Email);
                                if (MessageBox.Show("Save Changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    
                                    myStaff.Email = newEmailTextBox.TextName;
                                    s = myStaff;
                                    worker = myStaff;
                                    DB.SubmitChanges();
                                    MessageBox.Show("Email updated successfully");
                                    WorkerHomePage WHP = new WorkerHomePage(worker);
                                    this.Hide();
                                    WHP.ShowDialog();
                                }
                            }
                            else
                            {
                                throw new Exception("The Email you entered is already in use.");
                            }
                        }
                        else
                        {
                            throw new Exception("Invalid Email.");
                        }
                    }
                    else
                    {
                        throw new Exception("The email you entered is the same as the current email.");
                    }
                }


                else if (worker is Admin)
                {
                    Admin a = worker as Admin;
                    if (newEmailTextBox.TextName != a.Email)
                    {
                        System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9].[a-zA-Z\.]*[a-zA-Z]$");
                         if (rEmail.IsMatch(newEmailTextBox.TextName))
                        {
                            DB = new CactiDataContext();

                            var ad = DB.Admins.SingleOrDefault(i => i.Email == newEmailTextBox.TextName);
                            if (ad == null)
                            {
                                if (MessageBox.Show("Save Changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Admin myAdmin = DB.Admins.Single(i => i.Email == a.Email);
                                    myAdmin.Email = newEmailTextBox.TextName;
                                    a = myAdmin;
                                    worker = a;
                                    DB.SubmitChanges();
                                    MessageBox.Show("Email updated successfully");
                                    WorkerHomePage WHP = new WorkerHomePage(worker);
                                    this.Hide();
                                    WHP.ShowDialog();
                                }
                            }
                            else
                            {
                                throw new Exception("The Email you entered is already in use.");
                            }
                        }
                        else
                        {
                            throw new Exception("Invalid Email.");
                        }
                    }
                    else
                    {
                        throw new Exception("The email you entered is the same as the current email.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Save email


        #region back btn
        private void backBtn_Click(object sender, EventArgs e)
        {

            WorkerHomePage WHP = new WorkerHomePage(worker);
            this.Hide();
            WHP.ShowDialog();
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


        #region on load
        private void WorkerProfile_Load(object sender, EventArgs e)
        {
            if(worker is Staff)
            {
                Staff s = worker as Staff;
                nameLbl.Text = s.Name;
                emailLbl.Text = s.Email;
            }
            else
            {
                Admin a = worker as Admin;
                nameLbl.Text = a.Name;
                emailLbl.Text = a.Email;
            }

        }
        #endregion on load


    }
}
