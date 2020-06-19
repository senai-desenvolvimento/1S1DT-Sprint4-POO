namespace Aula20_21_Exercicio
{
    public class Restaurante
    {
        public string NomeRestaurante { get; set; }
        public string Endereco { get; set; }

        public Restaurante(string _nome, string _endereco){
            this.NomeRestaurante = _nome;
            this.Endereco = _endereco;
        }

        public string MostrarDados(){
            return $"Restaurante: {NomeRestaurante} \nEndereco: {Endereco}\n";
        }
    }
}