namespace Aula08Abstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }
        
        public void AumentarLimite( float acrescimo ){

            token = "qweqweqweqweqwe";

            limite = limite + acrescimo;
        }

    }
}