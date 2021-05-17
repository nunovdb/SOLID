using System;
namespace LSP.Payments
{
    public class NubankRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso");
            Console.WriteLine("Adicionados os pontos");
        }

        public void Validate()
        {
            Console.WriteLine("Limite ok, Rewards Ok");
        }
    }
}
