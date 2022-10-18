using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_statistik
{
    public static class Statistics
    {
        public static int[] Mode()
        {
            var jsonNumbers = Inputs.ImportJSON();
            List<int> KeyList = new List<int>();
            
            var counts = jsonNumbers.GroupBy(i => i).Select(grp => new { grp.Key, Count = grp.Count() });
            var itemsMax = counts.Where(x => x.Count == counts.Max(y => y.Count));

            foreach (var item in itemsMax)
            {
                KeyList.Add(item.Key);
            }
            return KeyList.ToArray();
        }
    }
}
