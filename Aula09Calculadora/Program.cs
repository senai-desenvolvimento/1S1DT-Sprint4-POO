using System;

namespace Aula09Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculadoraCientifica calc = new CalculadoraCientifica();
            
            Console.WriteLine("Digite uma operção no formato de ex: 12 x 3");
            calc.ControlarMetodos( Console.ReadLine() );
            Console.WriteLine("Resultado: "+calc.resultado);

            Console.WriteLine("Digite números separados por ponto e vírgula para calcularmos a média");
            calc.CalcularMedia( Console.ReadLine() );
            Console.WriteLine("Média: "+calc.resultado);            


        }
    }
}
