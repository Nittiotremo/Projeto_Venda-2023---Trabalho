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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Venda_2023.view
{
    public partial class frm_Cidade : Form
    {

        string connectionString = @"Server=.;Database=loja_unifunec_2023;
                                    Trusted_Connection=True;";
        bool novo;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable tabelaCidade;
        SqlDataReader tabCliente;
        DataRow[] linhaAtual;

        int posicao = 0;
        //Carrega as informações no DatagridView1 com os dados dos clientes
        public void carregarTabela()
        {

        }

        //Construtor da Classe frmCadastroCliente
        public frm_Cidade()
        {
            //InitializeComponent();
            carregarTabela();
            carregaUf();

        }



        public void carregaUf()
        {
            C_Uf cs = new C_Uf();
            List<Uf> aux = new List<Uf>();

            aux = cs.carregaDados();
            //System.NullReferenceExcidadetion: 'Referência de objeto não definida
            //para uma instância de um objeto.'
            //Retirar esta mensagem até o form carregar
            comboUf.DataSource = aux;
            comboUf.DisplayMember = "sigla";
            comboUf.ValueMember = "coduf";
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }
        
        private void tsbNovo_Click(object sender, EventArgs e)
        {
            AtivarTexts();
            LimparCampos();
        }

        private void limpaCampos()
        {

        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                //comandos adicionar novo elemento
                AtivarTexts();

                Cidade cidade = new Cidade();
                cidade.Nomecidade = textCidade.Text;

                C_Cidade ca = new C_Cidade();
                ca.insereDados(cidade);

                carregarTabela();

            }
            else
            {
                //comandos para editar dados
                Cidade cidade = new Cidade();
                cidade.Nomecidade = textCidade.Text;
                cidade.Codcidade = Int32.Parse(txtId.Text);

                C_Acesso ca = new C_Acesso();
                ca.editarDados(cidade);

                carregarTabela();
                novo = true;
            }

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {

        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Cidade ca = new C_Cidade();

            tabelaCidade = ca.buscarNome(txtBuscar.Text);
            carregarTabela();
            AtivarTexts();
            novo = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {


        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {


        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {


        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //FrmRelProfessor frmrelprof = new FrmRelProfessor();
            //frmrelprof.ShowDialog();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frm_Cidade_Load(object sender, EventArgs e)
        {

        }
        //Para copiar e colar 
        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            textCidade.Text = string.Empty;
        }

        private void AtivarTexts()
        {
            txtId.Enabled = false;
            textCidade.Enabled = true;
        }
    }
    
}
