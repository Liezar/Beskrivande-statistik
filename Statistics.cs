using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime;
using System.Xml.Serialization;

namespace Beskrivande_statistik
{
    public static class Statistics
    {
        //En metod för att ta de mest förekommande talen i json-filen och returnera det till en int[]
        public static int[] Mode()
        {
            //Hämtar datan från json-filen och lagrar i variablen
            var jsonNumbers = Inputs.ImportJSON();

            //En list som lagrar typvärden
            List<int> KeyList = new List<int>();

            //Kollar alla tal och räknar hur många gånger talen förekommer
            var counts = jsonNumbers.GroupBy(i => i).Select(grp => new { grp.Key, Count = grp.Count() });

            //Lägger till alla tal som förkommer flest gånger i itemsMax
            var itemsMax = counts.Where(x => x.Count == counts.Max(y => y.Count));

            //Sorterar i vilken ordning som items läggs till i Keylist
            foreach (var item in itemsMax.OrderBy(x => x.Key))
            {
                KeyList.Add(item.Key);
            }

            //Konverterar listan till en array och returnerar detta
            return KeyList.ToArray();
        }

        }     
        //metod för beräkning av standardavikelse
        public static double GetStandardDeviation()
        {
           
           int[] nums = Inputs.ImportJSON();
           //formel för standardavikelse
           double deviation = nums.Average();
           double avarageDeviation = nums.Select(val => (val - deviation) * (val - deviation)).Sum();
           double standardDeviation = Math.Round(Math.Sqrt(avarageDeviation / nums.Length),1); 
           //returnar värdet på standardavikelsen
           return standardDeviation;
        }
        //metod för beräkning av medianvärde
        public static int GetMedian()
        {
           //importerar Jsonfilen och konverterar till array 
           int[] nums = Inputs.ImportJSON();
           //Konverterar array till en lista och använder ToList för att sortera i storleksordning
           var sortednums = nums.OrderBy(number => number).ToList();
           //hittar talet i mitten på talserien:
           int itemIndex = sortednums.Count / 2;
           //om jämnt värde i mitten på talserien:
           if (sortednums.Count % 2 == 0)
           {
               return (sortednums[itemIndex] + sortednums[itemIndex - 1]) / 2;
           }
           //om ojämnt värde i mitten på talsträngen
           else
           {
               return sortednums[itemIndex];  
           }    
        }
    
        public static int GetMaximum()
        {
            int[] inData = Inputs.ImportJSON();
            return inData.Max();
        }

        public static int GetMinimum()
        {
            int[] inData = Inputs.ImportJSON();
            return inData.Min();
        }

        public static int GetRange()
        {
            int range = GetMaximum() - GetMinimum();
            return range;
        }
        public static dynamic DescriptiveStatistics()
        {
            dynamic allData = new Dictionary<string, object>() { };

            StringBuilder modeResault = new StringBuilder();
            foreach (var item in Mode())
            {
                modeResault.Append($"{item}, ");
            }

            allData.Add("Maximum", GetMaximum());
            allData.Add("Minimum", GetMinimum());
            allData.Add("Medelvärde", GetMean());
            allData.Add("Median", GetMedian());
            allData.Add("Typvärde", modeResault);
            allData.Add("Variationsbredd", GetRange());
            allData.Add("Standardavvikelse", GetStandardDeviation());

            return allData;
        }

        public static double GetMean()
        {
            var inData = Inputs.ImportJSON();
            double sum = 0;
            foreach (int x in inData)
            {
                sum += x;
            }
            double rounded = Math.Round(sum / inData.Length,1);
            return rounded;
        }
    }
}
