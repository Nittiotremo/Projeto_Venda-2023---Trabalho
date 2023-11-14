using Projeto_Venda_2023.controller;
using Projeto_Venda_2023.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private Boolean novo = true;
        public frm_Funcao()
        {
            InitializeComponent();
        }

        private void funcaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcaoBindingSource.EndEdit();
          

        }

        private void frm_Funcao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loja_unifunec_2023.funcao'. Você pode movê-la ou removê-la conforme necessário.
           

        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {

        }
        

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                //comandos adicionar novo elemento
                AtivarTexts();

                Acesso acesso = new Acesso();
                acesso.Nomeacesso = textFuncao.Text;

                C_Acesso ca = new C_Acesso();
                ca.insereDados(acesso);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Acesso acesso = new Acesso();
                acesso.Nomeacesso = textFuncao.Text;
                acesso.Codacesso = Int32.Parse(txtId.Text);

                C_Acesso ca = new C_Acesso();
                ca.editarDados(acesso);

                carregarTabela();
                novo = true;
            }
        }
        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            textFuncao.Text = string.Empty;
        }
        private void AtivarTexts()
        {
            txtId.Enabled = false;
            textFuncao.Enabled = true;
        }
        public void carregarTabela()
        {
            C_Funcao ca = new C_Funcao();

            tabelaFuncao = ca.buscarNome(txtBuscar.Text);

            dataGridView1.DataSource = tabelaFuncao;
        }
    }
}
