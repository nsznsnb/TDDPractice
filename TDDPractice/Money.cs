using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPractice
{
    public abstract class Money
    {
        protected int _amount;
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

        public abstract Money Times(int multiplier);

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount && GetType().Equals(money.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }
    }
}
