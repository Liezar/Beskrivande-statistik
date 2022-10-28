namespace Beskrivande_statistik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (KeyValuePair<string, object> kvp in Statistics.DescriptiveStatistics()) // Skriver ut resultatet från Dictionary.
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}