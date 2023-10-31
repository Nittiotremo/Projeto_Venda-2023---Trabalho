
using Projeto_Venda_2023.conexao;
using Projeto_Venda_2023.controller;
using Projeto_Venda_2023.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.LinkLabel;

namespace Aula_11_08
{
    public partial class frmCadastroCidades : Form
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
        public frmCadastroCidades()
        {
            InitializeComponent();
            carregarTabela();
            carregaUf();
            
        }
       
       

        public void carregaUf()
        {
            C_Uf cs = new C_Uf();

            List<Uf> aux = new List<Uf>();

            aux = cs.carregaDados();

            comboBox1.DataSource = aux;
            comboBox1.DisplayMember = "sigla";
            comboBox1.ValueMember = "coduf";
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
    }
}
