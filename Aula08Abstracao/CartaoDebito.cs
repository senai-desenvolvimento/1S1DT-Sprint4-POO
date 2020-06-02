namespace Aula08Abstracao
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }
        public string Transferir(){
            return "Transferência efetuada";
        }
        public string Pagartitulo(){
            return "Título pago";
        }
    }
}