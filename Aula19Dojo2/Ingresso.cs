using System;

namespace Aula19Dojo2
{
    public class Ingresso
    {
        public float IngressoPreco {get; set;}

        public void ImprimirValor(){
            Console.WriteLine("O valor do ingresso é R$ " + IngressoPreco);
        }

    }
}