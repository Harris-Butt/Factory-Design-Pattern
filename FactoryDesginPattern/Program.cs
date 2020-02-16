using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesginPattern
{
    class Program
    {
        static void Main(string[] args) {
            CreditCard creditCard = CreditCardFactory.GetCreditCard("Platinum");
            if (creditCard != null)
            {
                Console.WriteLine("Card Type: " + creditCard.GetCardType());
                Console.WriteLine("Card Limit: " + creditCard.GetCardLimit());
                Console.WriteLine("Card Annual Charge: " + creditCard.GetAnnualCharge());
            }
            else {
                Console.WriteLine("Invalid Credit Card");
            }
            Console.ReadLine();
        }
    }
}
