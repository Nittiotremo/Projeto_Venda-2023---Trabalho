using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class ParcelaVenda
    {
        public int Codparcela {  get; set; }

        public DateTime Datavencimento { get; set; }

        public float Valor {  get; set; }

        public Situacao Situacao { get; set; }

        public VendaProduto VendaProduto { get; set; }

        public ParcelaVenda() { }
    }
}
