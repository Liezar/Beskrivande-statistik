using Newtonsoft.Json;
using System.Linq;
namespace Beskrivande_statistik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Statistics.GetMedian());
            Console.WriteLine(Statistics.GetStandardDeviation());
            foreach (var item in Statistics.Mode())
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine(Statistics.GetMaximum());
            Console.WriteLine(Statistics.GetMinimum());
            Console.WriteLine(Statistics.GetRange());

        }
    }
}