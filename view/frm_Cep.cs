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
    public partial class frm_Cep : Form
    {
        public frm_Cep()
        {
            InitializeComponent();
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
    }
}
