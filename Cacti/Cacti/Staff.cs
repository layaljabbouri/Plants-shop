using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacti
{
   partial class Staff : Worker
    {
        CactiDataContext DB;

        #region Worker Login
        public override void WorkerLogin(string email, string password, Form form)
        {

            
            try
            {
                DB = new CactiDataContext();
                var staff = DB.Staffs.SingleOrDefault(i => i.Email == email && i.Password == password);

                if (staff != null)
                {
                    WorkerHomePage HP = new WorkerHomePage(staff);
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

    }
}
