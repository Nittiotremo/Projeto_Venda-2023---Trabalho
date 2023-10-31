using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class Funcionario
    {
        public int Codfuncionario { get; set; }

        public String Nomefuncionario { get; set; }

        public String Numerocasa { get; set; }

        public Image Foto { get; set; }

        public Rua Rua { get; set; }

        public Bairro Bairro { get; set; }

        public Cep Cep { get; set; }

        public Cidade Cidade { get; set; }

        public Funcao Funcao { get; set; }

        public float Salario { get; set; }

        public Loja Loja { get; set; }

        public Sexo Sexo { get; set; }

        public DateTime Datanasc {  get; set; }

        public Funcionario () { }
    }
}
