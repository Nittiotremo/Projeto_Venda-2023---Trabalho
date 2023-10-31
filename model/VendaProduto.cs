using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class VendaProduto
    {
        public int Codvenda { get; set; }

        public DateTime Datavenda { get; set; }
        
        public Cliente Cliente { get; set; }

        public Funcionario Funcionario { get; set; }

        public VendaProduto() { }
    }
}
