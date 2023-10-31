﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Venda_2023.model
{
    internal class Cliente
    {
        public int Codcliente {  get; set; }

        public String Nomecliente { get; set;}

        public Image Foto { get; set; }

        public DateTime Datanasc {  get; set; }

        public Sexo Sexo { get; set; }

        public Rua  Rua { get; set; }

        public Bairro Bairro { get; set; }

        public Cep Cep { get; set; }

        public Cidade Cidade { get; set; }

        public float Salario { get; set; }

        public Trabalho Trabalho { get; set; }

        public String Numerocasa {  get; set; }

        public Cliente() { }
    }
}
