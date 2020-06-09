using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Passageiro paulo = new Passageiro();

            System.Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            paulo.Login(login, senha);

            if( paulo.TokenLogin != "" && paulo.TokenLogin != null ){
                
                System.Console.WriteLine("Login autorizado!");
                System.Console.WriteLine(paulo.TokenLogin);

            }else{
                System.Console.WriteLine("Não é possível utilizar o app");
            }



        }
    }
}
