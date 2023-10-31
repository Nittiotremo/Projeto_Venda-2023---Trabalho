using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class ParcelaCompra
    {
        public int Codparcelacompra {  get; set; }

        public DateTime Datavencimento { get; set; }

        public float Valor {  get; set; }

        public Situacao Situacao { get; set; }

        public CompraProduto CompraProduto { get; set; }

        public ParcelaCompra() { }
    }
}
