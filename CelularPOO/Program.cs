using System;

namespace CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Celular iphone = new Celular();
            iphone.modelo  = "X";
            iphone.tamanho = 10f;
            
            Console.WriteLine("Deseja ligar o celular ");
            iphone.ligado  = Boolean.Parse( Console.ReadLine() );

            if(iphone.ligado){
                
                while(iphone.ligado){

                    Console.WriteLine("O que deseja fazer? \n 1-Fazer Ligação \n 2-Enviar Mensagem \n 3-Desligar ");
                    int resposta  = Int32.Parse( Console.ReadLine() );

                    switch(resposta){

                        case 1:
                        Console.WriteLine( iphone.FazerLigacao() );
                        break;

                        case 2:
                        Console.WriteLine( iphone.EnviarMensagem() );
                        break;

                        case 3:
                        Console.WriteLine( iphone.Desligar() );
                        break;

                        default:
                        Console.WriteLine( iphone.Ligar() );
                        break;
                    }                
                }

            }else{
                Console.WriteLine("O celular está desligado!");
            }

        }
    }
}
