using System;
using LSP.Payments;

namespace LSP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //CreditCard card = new CreditCard();
            //DebitCard card = new DebitCard();
            NubankRewards card = new NubankRewards();

            card.Validate();
            card.CollectPayment();


            

            Console.ReadLine();
        }
    }
}
