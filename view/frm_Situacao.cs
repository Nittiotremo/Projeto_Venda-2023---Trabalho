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
    public partial class frm_Situacao : Form
    {
        public frm_Situacao()
        {
            InitializeComponent();
        }

        private void situacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          

        }

        private void frm_Situacao_Load(object sender, EventArgs e)
        {
           

        }
    }
}
