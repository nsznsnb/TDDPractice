using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPractice
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this._amount = amount;
        }



        public override Money Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }


    }
}
