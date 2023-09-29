using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPractice
{
    public class Franc
    {
        private int _amount;
        public Franc(int amount)
        {
            this._amount = amount;
        }

        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            Franc franc = (Franc)obj;
            return Amount == franc.Amount;
        }
    }
}
