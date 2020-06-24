using System;

namespace Aula24ObjetosArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto(1, "Hollow Knight", 34.98f);
            Produto p2 = new Produto(2, "Dead Cells", 23.98f);
            Produto p3 = new Produto(3, "Celeste", 43.98f);
            Produto p4 = new Produto(4, "The Last Of Us II", 443.98f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            cart.Deletar(p3);

            Produto prodAlterado = new Produto(1, "Cyberpunk 2077", 200f);
            cart.Alterar(2, prodAlterado);

            cart.Ler();
            cart.MostrarTotal();           

        }
    }
}
