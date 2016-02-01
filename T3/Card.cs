using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Card
    {
        public string Suit { get; set; }

        private readonly int maxNumber = 52;
        private readonly int minNumber = 1;
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value <= maxNumber && value >= minNumber) number = value;
                else
                {
                    Console.WriteLine("No such card!");
                }
            }
        }
    }
}
