using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSIGHT
{
    class Coin
    {
        public int Value { get; } = 0;
        public string Initial { get; }
        public int Count { get; set; } = 0;

        public Coin(int value, string initial)
        {
            Value = value;
            Initial = initial;
        }

        public int CalculateCount(int cents)
        {
            if (cents / Value > 0)
            {
                Count = cents / Value;
                cents -= Count * Value;
            }

            return cents;
        }

        public string PrintCount()
        {
            if (Count > 0)
            {
                return Count + Initial;
            }
            else
            {
                return "";
            }
        }
    }
}
