using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class Telefone
    {
        public int Codtelefone {  get; set; }

        public String Numerotelefone { get; set; }

        public Operadora Operadora { get; set; }
        public Telefone() { }
    }
}
