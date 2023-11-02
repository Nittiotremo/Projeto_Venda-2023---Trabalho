using Projeto_Venda_2023;
using Projeto_Venda_2023.controller;
using Projeto_Venda_2023.model;
using Projeto_Venda_2023.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Venda_2023
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Cidade frm_cidade = new frm_Cidade();
            frm_cidade.ShowDialog();
        }

        

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void acessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Acesso frm_Acesso = new frm_Acesso();
            frm_Acesso.ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Bairro frm_Bairro = new frm_Bairro();
            frm_Bairro.ShowDialog();
        }

        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cep frm_Cep = new frm_Cep();
            frm_Cep.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cidade frm_Cidade = new frm_Cidade();
            frm_Cidade.ShowDialog();
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Funcao frm_Funcao = new frm_Funcao();
            frm_Funcao.ShowDialog();
        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Loja frm_Loja = new frm_Loja();
            frm_Loja.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Marca frm_Marca = new frm_Marca();
            frm_Marca.ShowDialog();
        }

        private void operadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Operadora frm_Operadora = new frm_Operadora();
            frm_Operadora.ShowDialog();
        }

        private void ruaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Rua frm_Rua = new frm_Rua();
            frm_Rua.ShowDialog();
        }

        private void situaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Situacao frm_Situacao = new frm_Situacao();
            frm_Situacao.ShowDialog();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Tipo frm_Tipo = new frm_Tipo();
            frm_Tipo.ShowDialog();
        }

        private void trabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Trabalho frm_Trabalho = new frm_Trabalho();
            frm_Trabalho.ShowDialog();
        }

        
    }
}
