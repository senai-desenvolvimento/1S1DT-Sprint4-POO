using System;

namespace Aula20_21_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente eduardo = new Cliente("Eduardo Almeida");
            eduardo.Endereco = "Av. Brasil, 123";
            Restaurante mcDonalds = new Restaurante("McDonalds", "Av Paulista, 123");

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = eduardo;
            pedido1.Restaurante = mcDonalds;

            Console.WriteLine( pedido1.EntregarPedido() );

        }
    }
}
