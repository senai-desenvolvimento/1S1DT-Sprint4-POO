using System;

namespace Aula19Dojo2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            IngressoVip bilhete = new IngressoVip();
            bilhete.IngressoPreco = 23.90f;
            bilhete.ImprimirValor();
            bilhete.AdicionarValor();

            System.Console.WriteLine("A diferença de valores é: " + bilhete.valorAdicional);
            
        }
    }
}
