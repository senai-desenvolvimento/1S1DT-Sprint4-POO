namespace Aula09Calculadora
{
    public class Calculadora
    {
        public float num1 { get; set; }
        public float num2 { get; set; }
        public float resultado { get; set; }
        protected string operador { get; set; }

        public void Somar(){
            resultado = 0;
            resultado = num1 + num2;
        }

        public void Subtrair(){
            resultado = 0;
            resultado = num1 - num2;
        }

        public void Multiplicar(){
            resultado = 0;
            resultado = num1 * num2;
        }

        public void Dividir(){
            resultado = 0;
            resultado = num1 / num2;
        }

    }
}