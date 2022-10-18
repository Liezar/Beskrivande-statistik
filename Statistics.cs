using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Beskrivande_statistik
{
    public static class Statistics
    {
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
    }

}
