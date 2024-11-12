using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}