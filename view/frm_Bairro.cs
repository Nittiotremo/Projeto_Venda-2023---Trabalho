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
    public partial class frm_Bairro : Form
    {
        DataTable tabelaBairro;
        SqlDataAdapter da;

        private Boolean novo = true;

        public frm_Bairro()
        {
            InitializeComponent();
            carregarTabela();
        }
        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            textBairro.Text = string.Empty;
        }

        public void carregarTabela()
        {
            C_Bairro ca = new C_Bairro();

            tabelaBairro = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaBairro;
        }

        private void AtivarTexts()
        {
            txtId.Enabled = false;
            textBairro.Enabled = true;
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

                Bairro bairro = new Bairro();
                bairro.Nomebairro = textBairro.Text;

                C_Bairro ca = new C_Bairro();
                ca.insereDados(bairro);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Bairro bairro = new Bairro();
                bairro.Nomebairro = textBairro.Text;
                bairro.Codbairro = Int32.Parse(txtId.Text);

                C_Acesso ca = new C_Acesso();
                ca.editarDados(bairro);

                carregarTabela();
                novo = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Bairro ca = new C_Bairro();

            tabelaBairro = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;

        }

        private void bairroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bairroBindingSource.EndEdit();
       

        }

        private void frm_Bairro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loja_unifunec_2023.bairro'. Você pode movê-la ou removê-la conforme necessário.
          

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
