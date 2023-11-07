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
    public partial class frm_Acesso : Form
    {
        DataTable tabelaAcesso;
        SqlDataAdapter da;

        private Boolean novo = true;
        public frm_Acesso()
        {
            InitializeComponent();
            carregarTabela();
        }

        public void carregarTabela()
        {
            C_Acesso ca = new C_Acesso();

            tabelaAcesso = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaAcesso;
        }

        private void AtivarTexts()
        {
            txtId.Enabled = false;
            textAcesso.Enabled = true;
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            textAcesso.Text = string.Empty;
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

                Acesso acesso = new Acesso();
                acesso.Nomeacesso = textAcesso.Text;

                C_Acesso ca = new C_Acesso();
                ca.insereDados(acesso);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Acesso acesso = new Acesso();
                acesso.Nomeacesso = textAcesso.Text;
                acesso.Codacesso = Int32.Parse(txtId.Text);

                C_Acesso ca = new C_Acesso();
                ca.editarDados(acesso);

                carregarTabela();
                novo = true;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Acesso ca = new C_Acesso();

            tabelaAcesso = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textAcesso.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
