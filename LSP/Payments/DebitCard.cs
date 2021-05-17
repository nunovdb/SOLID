using System;
namespace LSP.Payments
{
    class DebitCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("A verificar ao saldo da conta");
            Console.WriteLine("Saldo disponível");
        }

    }
}
