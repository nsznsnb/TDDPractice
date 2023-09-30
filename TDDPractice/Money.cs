using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPractice
{
    public class Money
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

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount && GetType().Equals(money.GetType());
        }
    }
}
