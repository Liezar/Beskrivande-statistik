using Newtonsoft.Json;
namespace Beskrivande_statistik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meanResault = Statistics.Mean(Inputs.ImportJSON());

            
            Console.WriteLine(Statistics.DescriptiveStatistics());
        }
    }
}