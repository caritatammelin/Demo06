using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Song
    {
        public string Single { get; set; }
        public string Duration { get; set; }

        public override string ToString()
        {
            return " -" + Single + ", " + Duration;
        }
    }
}
