 using System;
namespace Aula18Dojo1
{
    //  usa o atalho prop//posicao
    //
    //nacionalidade
    // Qual a diferençça de colocar ,
    //
    //data de nascimento usa o datetime using system
    //faltou nacionalidade D:
    //
    //
    public class Jogador
    {
        public string Nome {get; set;}
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public string Nacionalidade { get; set; }
        public float Altura  { get; set; }
        public float Peso { get; set; }
        public DateTime Nascimento { get; set; }
        
        public int CalcularIdade(){
            
            // 16/06/2020 14:25:39
            //  0  1  2
            // 2020 14:25:39
            //  0
            
            int AnoAtual      = Int32.Parse( DateTime.Now.ToString().Split("/")[2].Split(" ")[0] );            
            int AnoNascimento = Int32.Parse( Nascimento.ToString().Split("/")[2].Split(" ")[0] );

            Idade = AnoAtual - AnoNascimento;
            
            return Idade; 
        }

            //defensor = 40 anos
            //Meio Campo 38 anos
            //ataque = 35 anos
            
            public string VerificarAposentadoria(){

                CalcularIdade();
                string Retorno = "";
                if(Idade >= 35 && Posicao == "Atacante"){
                    Retorno = "O atacante pode se aposentar";
                }else if(Idade >= 38 && Posicao == "Meio Campo"){
                    Retorno = "O meio campista pode se aposentar";
                }else if(Idade >= 40 && Posicao == "Defensor"){
                    Retorno = "O Defensor pode se aposentar";
                }else{
                    Retorno = "O jogador não tem idade sulficiente para se aposentar";
                }
                return Retorno;
            }
        
        //  
        public void MostrarDados(){
            System.Console.WriteLine($"Nome: {Nome}, Posição: {Posicao}, Nascimento: {Nascimento}");
        }        

    }
}            

