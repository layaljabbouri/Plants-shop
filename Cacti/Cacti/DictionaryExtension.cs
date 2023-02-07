using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacti
{
    public static class DictionaryExtension
    {
        public static Dictionary<Plant,int> AddRange (this Dictionary<Plant,int> dictionary ,List<Plant> plants, List<int> quantity)
        {
            for(int i =0; i < plants.Count; i++)
            {
                dictionary.Add(plants[i], quantity[i]);
            }
            return dictionary;
        }
      
    }
}
