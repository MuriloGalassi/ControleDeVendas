using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeVendas.Models
{
    public class Venda
    {
        public Cliente Cliente { get; set; }
        public List<ItemVenda> ItensVendas { get; set; }

        public Venda(Cliente cliente, List<ItemVenda> itensVenda)
        {
            Cliente = cliente;
            ItensVendas = itensVenda;
        }

        public decimal TotalVenda()
        {
            return ItensVendas.Sum(item => item.Produto.Preco * item.Quantidade);
        }
    }
}