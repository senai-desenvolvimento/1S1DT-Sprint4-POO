using System;

namespace Aula07Encapsulamento
{
    public class Cartao
    {
        
        public string numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }
        private string token = "aa89s7d8989asd9798as7d98a7ds98a7sd89a7sd987asd98a7sd89";
        protected string cvv { get; set; }

        public void AprovarCompra(){
            Console.WriteLine("Compra aprovada!");
        }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }
        

    }
}