﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_statistik
{
    internal class Inputs
    {
        public static void CheckInputs(int[] source)
        {
            if (source == null)
            {
                throw new System.ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new InvalidOperationException("Contains no elements");
            }
        }
        public static int[] ImportJSON()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/data.json");
            string jsonString = File.ReadAllText(filePath);
            int[] import = JsonConvert.DeserializeObject<int[]>(jsonString);
            CheckInputs(import);
            return import;
        }
    }
}