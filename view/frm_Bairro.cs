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
    public partial class frm_Bairro : Form
    {
        public frm_Bairro()
        {
            InitializeComponent();
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
