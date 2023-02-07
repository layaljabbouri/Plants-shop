using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacti
{
    partial class Order_Plant
    {
        CactiDataContext DB;
        public void InsertOrderDetails(int oID, Dictionary<Plant,int> cartDictionary)
        {
            DB = new CactiDataContext();
            for (int i =0; i < cartDictionary.Count; i++)
            {
                Order_Plant orderPlant = new Order_Plant();
                orderPlant.OrderId = oID;
                orderPlant.PlantId = cartDictionary.Keys.ToList()[i].PlantId;
                orderPlant.Quantity = cartDictionary.Values.ToList()[i];
                DB.Order_Plants.InsertOnSubmit(orderPlant);
                DB.SubmitChanges();

            }
           

        }
    }
}
