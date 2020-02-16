using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesginPattern
{
    class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public int GetCardLimit()
        {
            return 250000;
        }

        public string GetCardType()
        {
            return "Titanium Edge";
        }
    }
}
