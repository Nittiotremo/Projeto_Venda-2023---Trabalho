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
    public partial class frm_Cep : Form
    {
        DataTable tabelaCep;
        SqlDataAdapter da;

        private Boolean novo = true;

        public frm_Cep()
        {
            InitializeComponent();
            carregarTabela();
        }
        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            textCep.Text = string.Empty;
        }

        public void carregarTabela()
        {
            C_Cep ca = new C_Cep();

            tabelaCep = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaCep;
        }

        private void AtivarTexts()
        {
            txtId.Enabled = false;
            textCep.Enabled = true;
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

                Cep cep = new Cep();
                cep.Numerocep = textCep.Text;

                C_Cep ca = new C_Cep();
                ca.insereDados(cep);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Cep cep = new Cep();
                cep.Numerocep = textCep.Text;
                cep.Codcep = Int32.Parse(txtId.Text);

                C_Acesso ca = new C_Acesso();
                ca.editarDados(cep);

                carregarTabela();
                novo = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Cep ca = new C_Cep();

            tabelaCep = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;

        }

        private void cepBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cepBindingSource.EndEdit();


        }

        private void frm_Cep_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loja_unifunec_2023.cep'. Você pode movê-la ou removê-la conforme necessário.


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
