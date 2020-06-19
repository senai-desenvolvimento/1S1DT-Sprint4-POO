using System;

namespace Aula20_21_Exercicio
{
    public class Pedido
    {
        public string[] Itens { get; set; }
        public Cliente Cliente { get; set; }
        public Restaurante Restaurante { get; set; }
        public string FormaPGTO { get; set; }
        public bool PedidoPago { get; set; }
        public DateTime DataEntrega { get; set; }

        public string EntregarPedido(){
            
            DataEntrega = DateTime.Now;

            string retorno = "Pedido entregue! \n";
            retorno += Restaurante.MostrarDados();
            retorno += Cliente.MostrarDados();
            retorno += DataEntrega;

            return retorno;
        }
    }
}