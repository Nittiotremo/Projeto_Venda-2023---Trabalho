using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class ItensCompraProduto
    {
        public CompraProduto CompraProduto { get; set; }

        public Produto Produto { get; set; }

        public float Quantidade { get; set; }

        public float Valor {  get; set; }

        public ItensCompraProduto() { }
    }
}
