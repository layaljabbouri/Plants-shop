using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacti
{
    partial class Order
    {
        CactiDataContext DB;
        public int InsertOrder(int clientId)
        {
            //order id auto inc
            this.ClientId = clientId;
            this.OrderDate = DateTime.Now;
            this.Status = false;
            try
            {
                DB = new CactiDataContext();
                if(DB == null)
                {
                    throw new Exception("Unable to place your order. Try again later.");
                }
                else {
                    DB.Orders.InsertOnSubmit(this);
                    DB.SubmitChanges();
                    return this.OrderId;
                }
                   
                
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }





    }
}
