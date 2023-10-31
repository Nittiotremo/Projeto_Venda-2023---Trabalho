using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class Produto
    {
        public int Codproduto {  get; set; }

        public String Nomeproduto { get; set; }

        public float Quantidade { get; set; }

        public float Valor {  get; set; }

        public Marca Marca { get; set; }

        public Tipo Tipo { get; set; }
        public Produto() { }
    }
}
