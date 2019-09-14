using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_A_Farm
{

    enum WeekDays
    {
        Monday = 12,
        Tuesday = 98,
        Wednesday = 19,
        Thursday = 0,
        Friday = 6,
        Saturday = -10,
        Sunday = Saturday,
    }
    public class Animals
    {
        public string name { get; set; }
        public int age { get; set; }
        public string job { get; set; }
        public string hobby { get; set; }
    }
}
