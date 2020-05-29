using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CPF cpf = new CPF();
            cpf.nome = "Paulo";
            Console.WriteLine( cpf.Saudar() );

            cpf.cpf = "000.000.000-00";
            Console.WriteLine( cpf.ValidarCPF() );

        


        }
    }
}
