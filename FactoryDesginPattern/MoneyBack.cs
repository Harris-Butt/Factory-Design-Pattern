using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesginPattern
{
    class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            throw new NotImplementedException();
        }

        public int GetCardLimit()
        {
            throw new NotImplementedException();
        }

        public string GetCardType()
        {
            throw new NotImplementedException();
        }
    }
}
