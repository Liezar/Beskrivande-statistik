using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_statistik
{
    public static class Statistics
    {
        public static void Mode()
        {
            var sortedList = new List<int>();
            var jsonNumbers = Inputs.ImportJSON();

            foreach (var item in jsonNumbers.OrderBy(x => x))
            {
                sortedList.Add(item);   
            }
            
            var counts = sortedList.GroupBy(i => i).Select(grp => new { Key = grp.Key, Count = grp.Count() });

            foreach (var item in counts.OrderBy(x => x.Count))
            {
                Console.WriteLine(item);
            }
        }
    }
}
