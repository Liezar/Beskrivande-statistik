using Newtonsoft.Json;
using System.Linq;
namespace Beskrivande_statistik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (KeyValuePair<string, object> kvp in Statistics.DescriptiveStatistics())
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}