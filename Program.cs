using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3A6
{
    class Program
    {
        // Lista que recebe os atributos de pessoa fisica e cliente
        List<PessoaFisica> clienteFiList = new List<PessoaFisica>(); 
        // Lista que recebe os atributos de pessoa juridica e cliente
        List<PessoaJuridica> clienteJuList = new List<PessoaJuridica>();

        static void Main(string[] args)
        {

            Program instancia = new Program();

            int op1, op2;
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 -Cadastrar:");
                Console.WriteLine("2 -Listar");
                op1 = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op1)
                {
                    case 1:
                        Console.WriteLine("1 -Cadastrar Pessoa Física:");
                        Console.WriteLine("2 -Cadastrar Pessoa Jurídica:");
                        op2 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (op2)
                        {
                            case 1:
                                instancia.CadastroPessoaFisica();
                                break;
                            case 2:
                                instancia.CadastroPessoaJuridica();
                                break;
                            default:

                                Console.WriteLine("Informe opção válida!");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("1 -Listar Pessoa Física:");
                        Console.WriteLine("2 -Listar Pessoa Jurídica:");
                        op2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (op2)
                        {
                            case 1:
                                instancia.ListaPessoaFisica();
                                break;
                            case 2:
                                instancia.ListaPessoaJuridica();
                                break;
                            default:

                                Console.WriteLine("Informe opção válida!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Informe opção válida!");
                        break;
                }
                Console.ReadKey();
            } while (op1 != 0);
        }

        // métodos para Cadastrar
        private void CadastroPessoaFisica()
        {
            PessoaFisica novoFisica = new PessoaFisica(); // instanciar objeto da classe PessoaFisica

            Console.WriteLine("Informe nome:");
            novoFisica.NomeCliente = Console.ReadLine();

            Console.WriteLine("Informe telefone:");
            novoFisica.TelefoneCliente = Console.ReadLine();

            Console.WriteLine("Informe CPF:");
            novoFisica.PessoaCpf = Console.ReadLine();
          
            clienteFiList.Add(novoFisica); // adiciona os atributos da classe na lista
        }

        private void CadastroPessoaJuridica()
        {
            PessoaJuridica novoJuridica = new PessoaJuridica(); //instanciar objeto da classe PessoaJuridica

            Console.WriteLine("Informe nome:");
            novoJuridica.NomeCliente = Console.ReadLine();

            Console.WriteLine("Informe telefone:");
            novoJuridica.TelefoneCliente = Console.ReadLine();

            Console.WriteLine("Informe CNPJ:");
            novoJuridica.PessoaCnpj = Console.ReadLine();

            Console.WriteLine("Informe nome da empresa");
            novoJuridica.PessoaEmpresa = Console.ReadLine();

            clienteJuList.Add(novoJuridica);// adiciona os atributos da classe na lista
        }

        // métodos para Listar
        private void ListaPessoaFisica()
        {
            foreach (PessoaFisica nova in clienteFiList)
            {
                Console.WriteLine("Nome: {0}", nova.NomeCliente);
                Console.WriteLine("Telefone: {0}", nova.TelefoneCliente);
                Console.WriteLine("CPF: {0}", nova.PessoaCpf);

            }


        }

        private void ListaPessoaJuridica()
        {
            foreach (PessoaJuridica nova in clienteJuList)
            {
                Console.WriteLine("Nome: {0}", nova.NomeCliente);
                Console.WriteLine("Telefone: {0}", nova.TelefoneCliente);
                Console.WriteLine("CNPJ: {0}", nova.PessoaCnpj);
                Console.WriteLine("Empresa: {0}", nova.PessoaEmpresa);


            }
        }


    }
}
