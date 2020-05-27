namespace CelularPOO
{
    public class Celular
    {
        // Atributos
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        // Métodos
        /// <summary>
        /// Liga o celular
        /// </summary>
        /// <returns>texto de celular ligado</returns>
        public string Ligar(){
            ligado = true;
            return "Celular ligando";
        }

        /// <summary>
        /// Desligar o celular
        /// </summary>
        /// <returns>texto de celular desligado</returns>
        public string Desligar(){
            ligado = false;
            return "Celular desligando";
        }

        /// <summary>
        /// Realiza ligação pelo celular
        /// </summary>
        /// <returns>texto de ligação efetuada</returns>
        public string FazerLigacao(){
            return "Realizando ligação";
        }

        /// <summary>
        /// Envia mensagem
        /// </summary>
        /// <returns>texto de mensagem enviada</returns>
        public string EnviarMensagem(){
            return "Enviando mensagem";
        }

    }
}