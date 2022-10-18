using Newtonsoft.Json;
using System.Linq;
namespace Beskrivande_statistik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Statistics.GetMaximum());
            Console.WriteLine(Statistics.GetMinimum());
            Console.WriteLine(Statistics.GetRange());

        }
    }
}