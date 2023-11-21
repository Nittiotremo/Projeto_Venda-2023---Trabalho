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
    public partial class frm_Trabalho : Form
    {
        DataTable tabelaTrabalho;
        SqlDataAdapter da;

        private Boolean novo = true;
        public frm_Trabalho()
        {
            InitializeComponent();
            carregarTabela();
        }

        public void carregarTabela()
        {
            C_Trabalho ca = new C_Trabalho();

            tabelaTrabalho = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaTrabalho;
        }

        private void AtivarTexts()
        {
            txtId.Enabled = false;
            txtTrabalho.Enabled = true;
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtTrabalho.Text = string.Empty;
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

                Trabalho trabalho = new Trabalho();
                trabalho.Nometrabalho = txtTrabalho.Text;

                C_Trabalho ca = new C_Trabalho();
                ca.insereDados(trabalho);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Trabalho trabalho = new Trabalho();
                trabalho.Nometrabalho = txtTrabalho.Text;
                trabalho.Codtrabalho = Int32.Parse(txtId.Text);

                C_Trabalho ca = new C_Trabalho();
                ca.editarDados(trabalho);

                carregarTabela();
                novo = true;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Trabalho ca = new C_Trabalho();

            tabelaTrabalho = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTrabalho.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}