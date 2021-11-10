using System;

namespace ER2
{
    class Program
    {
        static void Main(string[] args)
        {
            // PessoaFisica Novapf = new PessoaFisica();
            // PessoaFisica pf = new PessoaFisica();
            // Endereco end = new Endereco();
            
            // end.logradouro = "Rua x";
            // end.numero = 100;
            // end.complemento = "Apto 14";
            // end.enderecoComercial = false;

            // pf.endereco = end;
            // pf.cpf = "123.456.789-10";
            // pf.nome = "Pessoa Fisica";
            // pf.DataNascimento = new DateTime(2010, 06, 15);
            
            // Console.WriteLine($@"Rua: {pf.endereco.logradouro}, Numero: {pf.endereco.numero}");
            // //com o @ é possível esquematizar onde eu quero o texto

            // bool idadeValida = pf.ValidarDataNascimento(pf.DataNascimento);
               
            // if (pf.ValidarDataNascimento(pf.DataNascimento) == true)
            // {
            //     Console.WriteLine($"Cadastro Aprovado");
            // }else
            // {
            //     Console.WriteLine($"Cadastro reprovado, não é permitido o cadastro para menores de 18 anos");
            // }
            


            PessoaJuridica pj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();

            Endereco end = new Endereco();

            end.logradouro = "Rua x";
            end.numero = 100;
            end.complemento = "Apto 14";
            end.enderecoComercial = true;

            novaPj.endereco = end;
            novaPj.cnpj = "12345678910001";
            novaPj.RazaoSocial = "Pessoa Juridica";

            if (pj.ValidarCNPJ(novaPj.cnpj))
            {
                Console.WriteLine("CNPJ Válido");
            }else
            {
                 Console.WriteLine($"CNPJ Inválido");
            }
        }
    }
}
