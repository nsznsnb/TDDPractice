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

        public int Amount { 
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }
    }
}
