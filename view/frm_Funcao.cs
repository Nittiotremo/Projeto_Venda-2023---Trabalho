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
    }
}
