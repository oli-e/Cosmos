using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class Declination
    {
        public sbyte Degress { get; set; }
        public byte Minutes { get; set; }
        public byte Seconds { get; set; }

        public Declination(sbyte degress, byte minutes, byte seconds)
        {
            bool degressOutOfRange = degress > 90 || degress < -90;
            if (degressOutOfRange)
            {
                throw new ArgumentException("Wrong declination values.");
            }
            Degress = degress;
            Minutes = minutes;
            Seconds = seconds;
        }

    }
}
