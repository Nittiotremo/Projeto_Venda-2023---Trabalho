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
    public partial class frm_Rua : Form
    {
        DataTable tabelaRua;
        SqlDataAdapter da;

        private Boolean novo = true;
        public frm_Rua()
        {
            InitializeComponent();
            carregarTabela();
        }

        public void carregarTabela()
        {
            C_Rua ca = new C_Rua();

            tabelaRua = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaRua;
        }

        private void AtivarTexts()
        {
            txtId.Enabled = false;
            txtRua.Enabled = true;
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtRua.Text = string.Empty;
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

                Rua rua = new Rua();
                rua.Nomerua = txtRua.Text;

                C_Rua ca = new C_Rua();
                ca.insereDados(rua);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Rua rua = new Rua();
                rua.Nomerua = txtRua.Text;
                rua.Codrua = Int32.Parse(txtId.Text);

                C_Rua ca = new C_Rua();
                ca.editarDados(rua);

                carregarTabela();
                novo = true;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Rua ca = new C_Rua();

            tabelaRua = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtRua.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
