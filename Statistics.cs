using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime;

namespace Beskrivande_statistik
{
    public static class Statistics
    {
        
        public static double GetStandardDeviation()
        {
           //https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-7.0
           int[] nums = Inputs.ImportJSON();
           //hittar medelvärde
           double deviation = nums.Average();
           //formel för standardavikelse, avrundar resultat till en decimal
           double avarageDeviation = nums.Select(val => (val - deviation) * (val - deviation)).Sum();
           double standardDeviation = Math.Round(Math.Sqrt(avarageDeviation / nums.Length),1);
            
           
           return standardDeviation;
        }

        public static int GetMedian()
        {
            //https://learn.microsoft.com/sv-se/dotnet/csharp/programming-guide/concepts/linq/how-to-add-custom-methods-for-linq-queries
            int[] nums = Inputs.ImportJSON();
            var sortednums = nums.OrderBy(number => number).ToList();
            int itemIndex = sortednums.Count / 2;

            if (sortednums.Count % 2 == 0)
            {
                // jämt antal
                return (sortednums[itemIndex] + sortednums[itemIndex - 1]) / 2;
                
            }
            else
            {
                // ojämnt antal
                return sortednums[itemIndex];
                
            }
                
        }
    }

}
