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
        DataTable clientes;
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
            //System.NullReferenceException: 'Referência de objeto não definida
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


        }

        private void limpaCampos()
        {

        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {


        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {

        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {



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
    }
}
