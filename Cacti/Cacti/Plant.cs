using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacti
{
    partial class Plant 
    {
        //Plant(int PlantID, ) { }
    }

    public class PlantPriceComparer : IComparer<Plant>
    {
        public int Compare(Plant p1, Plant p2)
        {
            if (p1.Price > p2.Price)
                return 1;
            else if (p1.Price < p2.Price)
                return -1;
            else return 0;

        }
    }

    public class PlantNameComparer : IComparer<Plant>
    {
        public int Compare(Plant x, Plant y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    
}
