using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cartao card = new Cartao();
            card.AprovarCompra();

            MasterCard master = new MasterCard();
            master.parcelas = 3;
            master.ComprarComDescontoMastercard(50f);

        }
    }
}
