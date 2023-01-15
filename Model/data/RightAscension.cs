using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    public class RightAscension
    {
        public byte Hours { get; set; }
        public byte Minutes { get; set; }
        public double Seconds { get; set; }

        public RightAscension(byte hours, byte minutes, double seconds)
        {
            bool hoursOutOfRange = hours > 24 || hours < 0;
            bool minutesOutOfRange = minutes > 60 || minutes < 0;
            bool secondsOutOfRange = seconds > 60 || seconds < 0;
            if (hoursOutOfRange || minutesOutOfRange || secondsOutOfRange)
            {
                throw new ArgumentException("Wrong right ascension values.");
            }
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

    }
}
