using System;
using System.Collections.Generic;

namespace Aula24ObjetosArgumentos
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _prod){
            carrinho.Add(_prod);
        }

        public void Deletar(Produto _p){
            carrinho.Remove(_p);
        }

        public void Ler(){
            foreach(Produto item in carrinho){
                Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
            }
        }

        public void Alterar(int _cod, Produto _produtoAlterado)
        {
            carrinho.Find(z => z.Codigo == _cod).Nome  = _produtoAlterado.Nome;
            carrinho.Find(z => z.Codigo == _cod).Preco = _produtoAlterado.Preco;
        }

        public void MostrarTotal(){
            foreach(Produto item in carrinho){
               ValorTotal += item.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Valor total da compra: R$ {ValorTotal}" );
            Console.ResetColor();
        }


    }
}