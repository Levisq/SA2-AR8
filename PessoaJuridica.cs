namespace ER2
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }
        
        public string RazaoSocial { get; set; }
        
        public override double PagarImposto(float rendimento){
            
                    if (rendimento <= 5000)
            {
                return (rendimento/100) * 6;

            }else if (rendimento > 5000 && rendimento <= 10000)
            {
                return rendimento * .08;
        
            }else
            {
                return (rendimento/100) * 10;
            }

        }

        public bool ValidarCNPJ(string cnpj){
            if (cnpj.Length == 14 && cnpj.Substring(cnpj.Length - 6, 4) == "0001")
            {
            // o && serve para validar duas ao mesmo tempo
            // ou seja os 2 precisam estar de acordo para ser true
            // if (cnpj.Length == 14 &&)
            // o || serve para validar um ou outro
            // if (cnpj.Length == 14 || )
                return true;
            }
            return false;
        }
    }
}