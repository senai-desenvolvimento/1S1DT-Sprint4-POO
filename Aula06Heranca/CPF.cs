namespace Aula06Heranca
{
    // chamamos a Herança da superclasse "Pessoa"
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;

        public bool ValidarCPF(){            
            
            if(cpf != null){
                return true;
            }

            return false;
        }

    }
}