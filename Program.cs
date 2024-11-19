using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using ControleDeVendas.Models;

namespace ControleDeVendas.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            List<Cliente> clientes = new List<Cliente>();
            List<Venda> vendas = new List<Venda>();

             while (true)
            {
                 Console.WriteLine("\n==== Sistema de Controle de Vendas ====");
                 Console.WriteLine("1 - Cadastrar Produto");
                 Console.WriteLine("2 - Cadastrar Cliente");
                 Console.WriteLine("3 - Realizar Venda");
                 Console.WriteLine("4 - Relatório de Vendas");
                 Console.WriteLine("5 - Sair");
                 Console.Write("Escolha uma opção: ");
                
                 string opcao = Console.ReadLine();
                 switch (opcao)
                 {
                      case "1":
                          CadastrarProduto(produtos);
                          break;
                      case "2":
                          CadastrarCliente(clientes);
                          break;
                      case "3":
                          RealizarVenda(produtos, clientes, vendas);
                          break;
                      case "4":
                          ExibirRelatorioVendas(vendas);
                          break;
                      case "5":
                          return;
                      default:
                          Console.WriteLine("Opção inválida. Tente novamente.");
                          break;
                 }
             }
        }

        static void CadastrarProduto(List<Produto> produtos)
        {
            Console.WriteLine("\nNome do Produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço do Preoduto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade em Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            produtos.Add(new Produto(nome, preco, quantidade));
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        static void CadastrarCliente(List<Cliente> clientes)
        {
            Console.WriteLine("\nNome do Cliente: ");
            string nome = Console.ReadLine();

            string cpf;

            while (true)
            {
                Console.WriteLine("CPF do Cliente (somente números): ");
                cpf = Console.ReadLine();


                if(cpf.Length == 11 && cpf.All(char.IsDigit))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("CPF inválido. Deve conter exatamente 11 dígitos.");
                }
            }

            clientes.Add(new Cliente(nome, cpf));
            Console.WriteLine("Cliente cadastrado com sucesso!");
        }
    }
}