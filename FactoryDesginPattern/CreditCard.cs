using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesginPattern
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCardLimit();
        int GetAnnualCharge();
    }
}
