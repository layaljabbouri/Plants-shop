using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacti
{
    partial class Admin: Worker
    {
        CactiDataContext DB;


        #region Worker Login
        public override void WorkerLogin(string email,string password, Form form)
        {

            try
            {
                DB = new CactiDataContext();
                var admin = DB.Admins.SingleOrDefault(i => i.Email == email && i.Password == password);

                if (admin != null)
                {
                    WorkerHomePage HP = new WorkerHomePage(admin);
                    form.Hide();
                    HP.ShowDialog();
                }
                else
                {
                    throw new Exception("Invalid Email/Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion Worker Login


        #region Add Staff
        public void AddStaff(string name, string email, string password)
        {

        }
        #endregion Add Staff


        #region Remove Staff
        public void RemoveStaff(string name, string rmsil, string password)
        {

        }
        #endregion Remove Staff

    }
}
