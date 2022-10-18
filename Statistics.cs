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
        //Metod för beräkning av standardavikelse
        public static double GetStandardDeviation()
        {
           
           int[] nums = Inputs.ImportJSON();
           //hittar medelvärde
           double deviation = nums.Average();
           //formel för standardavikelse, avrundar resultat till en decimal
           double avarageDeviation = nums.Select(val => (val - deviation) * (val - deviation)).Sum();
           double standardDeviation = Math.Round(Math.Sqrt(avarageDeviation / nums.Length),1);
            
           
           return standardDeviation;
        }
        //Metod för beräkning av medianvärde
        public static int GetMedian()
        {
            
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
