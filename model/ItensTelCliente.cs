using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class ItensTelCliente
    {
        public Telefone Telefone {  get; set; }

        public Cliente Cliente { get; set; }

        public ItensTelCliente() { }
    }
}
