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
    public partial class frm_Operadora : Form
    {
        DataTable tabelaOperadora;
        SqlDataAdapter da;

        private Boolean novo = true;
        public frm_Operadora()
        {
            InitializeComponent();
            carregarTabela();
        }

        public void carregarTabela()
        {
            C_Operadora ca = new C_Operadora();

            tabelaOperadora = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaOperadora;
        }

        private void AtivarTexts()
        {
            textId.Enabled = false;
            textOperadora.Enabled = true;
        }

        private void LimparCampos()
        {
            textId.Text = string.Empty;
            textOperadora.Text = string.Empty;
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

                Operadora operadora = new Operadora();
                operadora.Nomeoperadora = textOperadora.Text;

                C_Operadora ca = new C_Operadora();
                ca.insereDados(operadora);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Operadora operadora = new Operadora();
                operadora.Nomeoperadora = textOperadora.Text;
                operadora.Codoperadora = Int32.Parse(textId.Text);

                C_Operadora ca = new C_Operadora();
                ca.editarDados(operadora);

                carregarTabela();
                novo = true;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Operadora ca = new C_Operadora();

            tabelaOperadora = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textOperadora.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
