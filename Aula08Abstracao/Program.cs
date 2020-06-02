using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Cartao 1

            CartaoCredito visa = new CartaoCredito();
            visa.limite = 3000f;

            Console.WriteLine("Quanto acrescentar no limite?");
            float acres = float.Parse( Console.ReadLine() );
            
            visa.AumentarLimite(acres);
            Console.WriteLine("Novo limite: R$ "+visa.limite);

            System.Console.WriteLine("Digite a data do pagamento:");
            visa.data = DateTime.Parse( Console.ReadLine() );
            
            System.Console.WriteLine("Data: " + visa.data);


            // Cartao 2
            // CartaoCredito elo = new CartaoCredito();
            // elo.limite = 1500f;

            // Console.WriteLine("Quanto acrescentar no limite?");
            // float soma = float.Parse( Console.ReadLine() );
            
            // elo.AumentarLimite(soma);
            // Console.WriteLine("Novo limite: R$ "+elo.limite);

        }
    }
}
