using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPractice
{
    public class Dollar
    {
        private int _amount;
        public Dollar(int amount)
        {
            this._amount = amount;
        }

        public int Amount { get; set; } = 10;

        public void Times(int multiplier)
        {
            _amount *= multiplier;
        }
    }
}
