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
            //carregaSexo();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frm_Cidade frm_cidade = new frm_Cidade();
            frm_cidade.ShowDialog();
        }

        /*public void carregaSexo()
        {
            C_Sexo cs = new C_Sexo();

            List<Sexo> aux = new List<Sexo>();

            aux = cs.carregaDados();

            comboBox1.DataSource = aux;
            comboBox1.DisplayMember = "nomesexo";
            comboBox1.ValueMember = "codsexo";
        }*/

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void AcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Acesso frm_Acesso = new frm_Acesso();
            frm_Acesso.ShowDialog();
        }

        private void BairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Bairro frm_Bairro = new frm_Bairro();
            frm_Bairro.ShowDialog();
        }

        private void CepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cep frm_Cep = new frm_Cep();
            frm_Cep.ShowDialog();
        }

        private void CidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cidade frm_Cidade = new frm_Cidade();
            frm_Cidade.ShowDialog();
        }

        private void FunçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Funcao frm_Funcao = new frm_Funcao();
            frm_Funcao.ShowDialog();
        }

        private void LojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Loja frm_Loja = new frm_Loja();
            frm_Loja.ShowDialog();
        }

        private void MarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Marca frm_Marca = new frm_Marca();
            frm_Marca.ShowDialog();
        }

        private void OperadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Operadora frm_Operadora = new frm_Operadora();
            frm_Operadora.ShowDialog();
        }

        private void RuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Rua frm_Rua = new frm_Rua();
            frm_Rua.ShowDialog();
        }

        private void SituaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Situacao frm_Situacao = new frm_Situacao();
            frm_Situacao.ShowDialog();
        }

        private void TipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Tipo frm_Tipo = new frm_Tipo();
            frm_Tipo.ShowDialog();
        }

        private void TrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Trabalho frm_Trabalho = new frm_Trabalho();
            frm_Trabalho.ShowDialog();
        }

        
    }
}
