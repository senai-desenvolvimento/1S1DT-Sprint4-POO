using System;

namespace Aula15TryCatch
{
    public class Permissao
    {
        public bool Permitir { get; set; }

        public void Autorizar(){

            Console.WriteLine("Deseja permitir acesso? Digite true ou false");            
            try{
                Permitir = Boolean.Parse( Console.ReadLine() );
            }catch(Exception){                
                Console.WriteLine("Erro na aplicação: dados inválidos");
            }


        }
    }
}