using System;
namespace LSP.Payments
{

    class CreditCard :NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("A validar o limite ..." );
            Console.WriteLine("Limite ok");
        }

    }
}
