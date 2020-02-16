using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesginPattern
{
    class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType) {
            CreditCard creditCard = null;
            if (cardType == "MoneyBack")
            {
                creditCard = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                creditCard = new Titanium();
            }
            else if (cardType == "Platinum") {
                creditCard = new Platinum();
            }
            return creditCard;
        }
    }
}
