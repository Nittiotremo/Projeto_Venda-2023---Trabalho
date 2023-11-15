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
    public partial class frm_Marca : Form
    {
        DataTable tabelaMarca;
        SqlDataAdapter da;

        private Boolean novo = true;
        public frm_Marca()
        {
            InitializeComponent();
            carregarTabela();
        }

        public void carregarTabela()
        {
            C_Marca ca = new C_Marca();

            tabelaMarca = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaMarca;
        }

        private void AtivarTexts()
        {
            txtId.Enabled = false;
            textMarca.Enabled = true;
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            textMarca.Text = string.Empty;
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

                Marca marca = new Marca();
                marca.Nomemarca = textMarca.Text;

                C_Marca ca = new C_Marca();
                ca.insereDados(marca);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Marca marca = new Marca();
                marca.Nomemarca = textMarca.Text;
                marca.Codmarca = Int32.Parse(txtId.Text);

                C_Marca ca = new C_Marca();
                ca.editarDados(marca);

                carregarTabela();
                novo = true;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Marca ca = new C_Marca();

            tabelaMarca = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textMarca.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
