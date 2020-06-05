using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculo infoPlayer = new Calculo();

            // 1º opção, sem argumentos
            System.Console.WriteLine( infoPlayer.Calcular() );

            // 2º opção, com 1 argumento int
            System.Console.WriteLine( infoPlayer.Calcular(100) );

            // 3º opção, com 2 argumentos int
            System.Console.WriteLine( infoPlayer.Calcular(100,40) );

            // 4º opção, com 2 argumentos string
            System.Console.WriteLine( infoPlayer.Calcular("Bruce", "Banner") );


        }
    }
}
