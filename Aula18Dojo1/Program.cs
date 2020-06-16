using System;

namespace Aula18Dojo1
{
    class Program
    {
             
        static void Main(string[] args)
        {

            Jogador messi = new Jogador();
            messi.Nome= "messi";
            messi.Altura = 1.80f;
            messi.Peso = 80f;
            messi.Nascimento = DateTime.Parse("24/06/1987");
            messi.Posicao = "Atacante";
            
            Console.WriteLine(messi.CalcularIdade());
            Console.WriteLine(messi.VerificarAposentadoria());
            
        }
    
        
    }
}



























































































































