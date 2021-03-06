﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesginPattern
{
    class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public int GetCardLimit()
        {
            return 150000;
        }

        public string GetCardType()
        {
            return "Money Back";
        }
    }
}
