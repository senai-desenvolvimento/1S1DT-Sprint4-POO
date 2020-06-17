using System;

namespace Aula19Dojo2
{ 
    public class IngressoVip : Ingresso
    {
        public float valorAdicional = 50.0f;

        public void AdicionarValor(){
            
            float newValor = IngressoPreco + valorAdicional;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("O valor VIP é : {0:c}",newValor);
            Console.ResetColor();
        }

    }
}