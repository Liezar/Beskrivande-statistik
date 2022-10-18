﻿using Newtonsoft.Json;
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
            foreach (KeyValuePair<string, object> kvp in Statistics.DescriptiveStatistics())
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value}");
            }
        }
    }
}