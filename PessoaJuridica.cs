using System.Collections.Generic;
using System.IO;

namespace ER2
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }
        
        public string RazaoSocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";
        public string Nome { get; set; }

        //private é para que ninguém altere os dados
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





        public string PrepararLinhasCsv(PessoaJuridica pj){

            return $"{pj.cnpj};{pj.nome};{pj.RazaoSocial}";

        }

        public void Inserir(PessoaJuridica pj){

            string[] linhas = {PrepararLinhasCsv(pj)};

            File.AppendAllLines(caminho, linhas);
        }

        public List<PessoaJuridica> Ler(){

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (var cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(";");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.cnpj = atributos[0];
                cadaPj.nome = atributos[1];
                cadaPj.RazaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }
    }
}