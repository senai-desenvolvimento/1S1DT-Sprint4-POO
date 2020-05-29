namespace Aula06Heranca
{
    // chamamos a Herança da superclasse "Pessoa"
    public class CNPJ : Pessoa
    {
        public string cnpj;

        public bool ValidarCNPJ(){

            if(cnpj != null){
                return true;
            }

            return false;
        }
    }
}