using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class Logins
    {
        public int Codlogin {  get; set; }

        public String Usuario { get; set; }

        public String Senha { get; set; }

        public Funcionario Funcionario { get; set; }

        public Logins () { }
    }
}
