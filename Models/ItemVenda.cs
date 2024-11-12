using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeVendas.Models
{
    public class ItemVenda
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public ItemVenda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}