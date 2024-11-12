using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeVendas.Models
{
    public class Produto
    {
        
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuntidadeEmEstoque { get; set; }

        public Produto(string nome, decimal preco, int quntidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuntidadeEmEstoque = quntidadeEmEstoque;
        }

    }
}