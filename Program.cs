using System;
using System.Threading;

namespace ER2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@$"
=====================================
|  Bem vindo ao sistema de cadastro |
=====================================
");
           Console.Clear();

            BarraCarregamento("Inicializando");

            string opcao;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@$"
====================================
|   Escolha uma das opção abaixo   |
------------------------------------
|            1 - Pessoa Fisica     |
|            2 - Pessoa Juridica   |
|                                  |
|            0 - Sair              |
====================================
");
                Console.ResetColor();

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case ("1"):
                        PessoaFisica pf = new PessoaFisica();

                        PessoaFisica Novapf = new PessoaFisica();

                        Endereco endPf = new Endereco();

                        endPf.logradouro = "x";
                        endPf.numero = 100;
                        endPf.complemento = "Apto 14";
                        endPf.enderecoComercial = false;

                        Novapf.endereco = endPf;
                        Novapf.cpf = "123.456.789-10";
                        Novapf.nome = "Pessoa Fisica";
                        Novapf.rendimento = 6000;
                        Novapf.DataNascimento = new DateTime(2000, 06, 15);

                        Console.WriteLine($@"Rua: {Novapf.endereco.logradouro}, Numero: {Novapf.endereco.numero}");
                        //com o @ é possível esquematizar onde eu quero o texto

                        bool idadeValida = pf.ValidarDataNascimento(Novapf.DataNascimento);

                        if (idadeValida == true)
                        {
                            Console.WriteLine($"Cadastro Aprovado");
                        }
                        else
                        {
                            Console.WriteLine($"Cadastro reprovado, não é permitido o cadastro para menores de 18 anos");
                        }

                        Console.WriteLine(pf.PagarImposto(Novapf.rendimento));  

                        break;


                    case ("2"):

                        PessoaJuridica pj = new PessoaJuridica();

                        PessoaJuridica novaPj = new PessoaJuridica();

                        Endereco endPj = new Endereco();

                        endPj.logradouro = "Rua x";
                        endPj.numero = 100;
                        endPj.complemento = "Apto 14";
                        endPj.enderecoComercial = true;

                        novaPj.endereco = endPj;
                        novaPj.cnpj = "34567891000112";
                        novaPj.RazaoSocial = "Pessoa Juridica";
                        novaPj.rendimento = 10000;
                        
                        if (pj.ValidarCNPJ(novaPj.cnpj))
                        {
                            Console.WriteLine("CNPJ Válido");
                        }else
                        {
                             Console.WriteLine($"CNPJ Inválido");
                        }

                        Console.WriteLine(pj.PagarImposto(novaPj.rendimento).ToString("N2"));
                        

                        break;


                    case ("0"):
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.WriteLine($"Obrigado por utilizar nosso sistema");

                        BarraCarregamento("Finalizando");

                        break;


                    default:
                        Console.WriteLine("Opção Inválida, digite uma opção válida");
                        break;
                }
            } while (opcao != "0");
        }

        static void BarraCarregamento(string textoCarregamento)
        {

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(textoCarregamento);
            Thread.Sleep(500);



            for (var contador = 0; contador < 10; contador++)
            {

                System.Console.Write(".");
                Thread.Sleep(500);

            }
            Console.ResetColor();

        }

    }

}
