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
    public partial class frm_Sexo : Form
    {
        DataTable tabelaSexo;
        SqlDataAdapter da;

        private Boolean novo = true;
        public frm_Sexo()
        {
            InitializeComponent();
            carregarTabela();
        }

        public void carregarTabela()
        {
            C_Sexo ca = new C_Sexo();

            tabelaSexo = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaSexo;
        }

        private void AtivarTexts()
        {
            txtId.Enabled = false;
            txtSexo.Enabled = true;
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtSexo.Text = string.Empty;
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

                Sexo sexo = new Sexo();
                sexo.Nomesexo = txtSexo.Text;

                C_Sexo ca = new C_Sexo();
                ca.insereDados(sexo);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Sexo sexo = new Sexo();
                sexo.Nomesexo = txtSexo.Text;
                sexo.Codsexo = Int32.Parse(txtId.Text);

                C_Sexo ca = new C_Sexo();
                ca.editarDados(sexo);

                carregarTabela();
                novo = true;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Sexo ca = new C_Sexo();

            tabelaSexo = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSexo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
