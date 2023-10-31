using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class CompraProduto
    {
        public int Codcompra {  get; set; }

        public DateTime Datacompra { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public Funcionario Funcionario { get; set; }

        public CompraProduto() { }
    }
}
