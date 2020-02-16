using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesginPattern
{
    class Platinum : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public int GetCardLimit()
        {
            return 350000;
        }

        public string GetCardType()
        {
            return "Platinum Plus";
        }
    }
}
