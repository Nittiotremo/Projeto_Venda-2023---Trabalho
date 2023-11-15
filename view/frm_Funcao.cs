using Projeto_Venda_2023.controller;
using Projeto_Venda_2023.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Venda_2023.view
{
    public partial class frm_Funcao : Form
    {
        DataTable tabelaFuncao;
        SqlDataAdapter da;

        private Boolean novo = true;
        public frm_Funcao()
        {
            InitializeComponent();
            carregarTabela();
        }

        public void carregarTabela()
        {
            C_Funcao ca = new C_Funcao();

            tabelaFuncao = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaFuncao;
        }

        private void AtivarTexts()
        {
            txtId.Enabled = false;
            textFuncao.Enabled = true;
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            textFuncao.Text = string.Empty;
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            LimparCampos();
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                //comandos adicionar novo elemento
                AtivarTexts();

                Funcao funcao = new Funcao();
                funcao.Nomefuncao = textFuncao.Text;

                C_Funcao ca = new C_Funcao();
                ca.insereDados(funcao);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Funcao funcao = new Funcao();
                funcao.Nomefuncao = textFuncao.Text;
                funcao.Codfuncao = Int32.Parse(txtId.Text);

                C_Funcao ca = new C_Funcao();
                ca.editarDados(funcao);

                carregarTabela();
                novo = true;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Funcao ca = new C_Funcao();

            tabelaFuncao = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textFuncao.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
