using System;

namespace ER2
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }

        public DateTime DataNascimento { get; set; }
        
        public override void PagarImposto(float salario){

        }
        
        public bool ValidarDataNascimento(DateTime dataNasc){
            
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 360;
            
            if (anos >= 18 ){

                return true;
                   
            } else {
                
                return false;
            }

        }
    }
}