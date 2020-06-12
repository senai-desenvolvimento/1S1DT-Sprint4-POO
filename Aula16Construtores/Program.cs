using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instância sem argumentos
            Produto sapato = new Produto();
            sapato.Nome = "Vizzano";

            // Instância com 1 argumento
            Produto chinelo = new Produto(45);
            System.Console.WriteLine(chinelo.Codigo);

            // Instância com todos os atributos como argumento
            Produto camisa = new Produto(34, "Supreme", "Azul", 234);
            System.Console.WriteLine(camisa.Codigo);
            System.Console.WriteLine(camisa.Nome);
            System.Console.WriteLine(camisa.Descricao);
            System.Console.WriteLine(camisa.Estoque);

        }
    }
}
