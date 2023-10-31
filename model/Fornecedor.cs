using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class Fornecedor
    {
        public int Codfornecedor {  get; set; }

        public String Nomefornecedor { get; set; }

        public String Numerocasa { get; set; }

        public Rua Rua { get; set; }

        public Bairro Bairro { get; set; }

        public Cep Cep { get; set; }

        public Cidade Cidade { get; set; }
        public Fornecedor() { }
    }
}
