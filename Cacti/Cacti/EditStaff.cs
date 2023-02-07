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
    public partial class EditStaff : Form
    {
        CactiDataContext DB;
        Worker worker;



        public EditStaff(Worker w)
        {
            InitializeComponent();
            worker = w;
        }


        #region on load
        private void EditStaff_Load(object sender, EventArgs e)
        {
            ToolTip tp1 = new ToolTip();
            tp1.SetToolTip(addEmployeeBtn, "Add Employee");
            ToolTip tp2 = new ToolTip();
            tp2.SetToolTip(removeEmployeeBtn, "Remove Employee");
        }
        #endregion on load


        #region back 
        private void backBtn_Click(object sender, EventArgs e)
        {
            WorkerHomePage WHP = new WorkerHomePage(worker);
            this.Hide();
            WHP.ShowDialog();
        }
        #endregion back


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


        #region proceed add
        private void proceed_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DB = new CactiDataContext();
                if (name_addTextBox.Text != "" && email_addTextBox.Text != "" && password_addTextBox.Text != "")
                {
                    if (Regex.IsMatch(name_addTextBox.Text, @"^[a-zA-Z ]{4,50}$")) // verify the the name does not contain any nb   !name_addTextBox.TextName.Any(char.IsDigit)
                    {

                        System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9].[a-zA-Z\.]*[a-zA-Z]$");
                        if (rEmail.IsMatch(email_addTextBox.Text))
                        {
                            if (password_addTextBox.Text.Length > 7)
                            {

                                DB = new CactiDataContext();
                                var c = DB.Staffs.Where(i => i.Email == email_addTextBox.Text);

                                if (c.Count().ToString() == "0")
                                {
                                    Staff staff = new Staff();
                                    staff.Email = email_addTextBox.Text;
                                    staff.Name = name_addTextBox.Text;
                                    staff.Password = password_addTextBox.Text;
                                    MessageBox.Show("Staff added Successfully.");
                                    DB.Staffs.InsertOnSubmit(staff);
                                    DB.SubmitChanges();
                                    WorkerHomePage WHP = new WorkerHomePage(worker);
                                    this.Hide();
                                    WHP.ShowDialog();
                                }
                                // email already used
                                else { throw new Exception("The entered is already in use. Enter a differnt one."); }

                            }
                            else
                            {
                                throw new Exception("Password must be at least 8 characters.");
                            }
                        }
                        else
                        {
                            throw new Exception("Invalid Email.");
                        }

                    }
                    else
                    {
                        throw new Exception("Invalid name.");
                    }

                }
                else
                {
                        throw new Exception("Missing data");
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion proceed add


        #region proceed removce
        private void proceed_removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (name_removeTextBox.Text != "" && email_removeTextBox.Text != "")
                {

                    DB = new CactiDataContext();
                    var st = DB.Staffs.SingleOrDefault(s => s.Email == email_removeTextBox.Text);
                    if (st != null)
                    {
                        if (string.Equals(name_removeTextBox.Text, st.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            if (MessageBox.Show($"Are You sure you want to remove this staff?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                DB.Staffs.DeleteOnSubmit(st);
                                DB.SubmitChanges();
                                MessageBox.Show("Staff removed successfully.");
                            }
                        }
                        else
                        {
                            throw new Exception("The name does not match with the email.");
                        }
                    }
                    else
                    {
                        throw new Exception("No employee with this email address.");
                    }
                }
                else
                {
                    throw new Exception("Missing data.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        #endregion proceed remove


    }
}