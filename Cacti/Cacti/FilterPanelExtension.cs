using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomControl_Product;

namespace Cacti
{
    public static class FilterPanelExtension
    {
        public static List<Plant> SortByName (this FilterPanel filterpanel, List<Plant> p)
        {
            PlantNameComparer pnc = new PlantNameComparer();
            p.Sort(pnc);
            return p;
        }
    }
}
