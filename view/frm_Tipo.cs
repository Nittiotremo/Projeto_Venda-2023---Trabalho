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
    public partial class frm_Tipo : Form
    {
        DataTable tabelaTipo;
        SqlDataAdapter da;

        private Boolean novo = true;
        public frm_Tipo()
        {
            InitializeComponent();
            carregarTabela();
        }

        public void carregarTabela()
        {
            C_Tipo ca = new C_Tipo();

            tabelaTipo = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaTipo;
        }

        private void AtivarTexts()
        {
            txtId.Enabled = false;
            txtTipo.Enabled = true;
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtTipo.Text = string.Empty;
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

                Tipo tipo = new Tipo();
                tipo.Nometipo = txtTipo.Text;

                C_Tipo ca = new C_Tipo();
                ca.insereDados(tipo);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Tipo tipo = new Tipo();
                tipo.Nometipo = txtTipo.Text;
                tipo.Codtipo = Int32.Parse(txtId.Text);

                C_Tipo ca = new C_Tipo();
                ca.editarDados(tipo);

                carregarTabela();
                novo = true;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Tipo ca = new C_Tipo();

            tabelaTipo = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTipo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
