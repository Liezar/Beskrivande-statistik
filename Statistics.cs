using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_statistik
{
    public static class Statistics
    {
        public static dynamic DescriptiveStatistics()
        {
            double meanResault = Statistics.Mean(Inputs.ImportJSON());

            dynamic allData = new Dictionary<string, object>()
            {
                
            };
            allData.Add("Mean", meanResault);

            foreach (KeyValuePair<string, object> kvp in allData)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            return allData;
        }
        public static double Mean(int[] inData)
        {
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
