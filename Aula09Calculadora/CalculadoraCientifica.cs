namespace Aula09Calculadora
{
    public class CalculadoraCientifica : Calculadora
    {
        private string[] valores { get;set; }
        private float soma {get;set;}

        public void CalcularMedia(string txtConsole){

            resultado = 0;

            // Utilizamos o Split para separar os números
            // 12;3;5;7
            // valores[0] = 12
            // valores[1] = 3
            // valores[2] = 5
            // valores[3] = 7    
            valores = txtConsole.Split(";");

            for (int i = 0; i < valores.Length; i++)
            {
                soma += float.Parse(valores[i]);
            }

            resultado = soma / valores.Length;
        }

        public void ControlarMetodos(string entradaUsuario){

            // "12 x 4"
            // 12x4
            // dados[0] = 12
            // dados[1] = x
            // dados[2] = 4
            string[] dados = entradaUsuario.Split(" ");
            
            num1 = float.Parse(dados[0]);
            operador = dados[1];
            num2 = float.Parse(dados[2]); 

            switch (operador)
            {                
                case "+":
                Somar();
                break;

                case "-":
                Subtrair();
                break;

                case "x":
                Multiplicar();
                break;

                case "/":
                Dividir();
                break;

                default:
                Somar();
                break;
            }

        }

    }
}

//Gustavo Ferreira