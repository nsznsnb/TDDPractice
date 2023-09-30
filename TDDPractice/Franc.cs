﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPractice
{
    public class Franc: Money
    {
        public Franc(int amount, string currency): base(amount, currency) 
        {
        }



        public override Money Times(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }


    }
}
