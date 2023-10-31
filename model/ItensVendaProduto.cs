using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class ItensVendaProduto
    {
        public VendaProduto VendaProduto { get; set; }

        public Produto Produto { get; set; }

        public float Quantidade { get; set; }

        public float Valor {  get; set; }

        public ItensVendaProduto() { }
    }
}
