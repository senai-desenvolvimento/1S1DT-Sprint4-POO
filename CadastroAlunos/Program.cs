using System;

namespace CadastroAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno milena = new Aluno();
            milena.nome = "Milena";
            milena.idade = 16;
            milena.bolsista = false;
            milena.valorMensalidade = 2000;
            milena.mediaFinal = 8.7f;

            Console.WriteLine( "Milena:" + milena.VerMediaFinal() );
            Console.WriteLine( "Milena:" + milena.VerMensalidade() );


            Aluno matheus = new Aluno();
            matheus.nome = "Matheus";
            matheus.idade = 15;

            Console.WriteLine("Aluno bolsista?");
            matheus.bolsista = matheus.TraduzConsole( Console.ReadLine() );

            matheus.percentual = 30;

            matheus.valorMensalidade = 2000;
            matheus.mediaFinal = 8.7f;

            Console.WriteLine( "Matheus:" + matheus.VerMediaFinal() );
            Console.WriteLine( "Matheus:" + matheus.VerMensalidade() );

        }
    }
}
