namespace Projeto_Venda_2023.view
{
    partial class frm_Acesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Acesso));
            System.Windows.Forms.Label codacessoLabel;
            System.Windows.Forms.Label nomeacessoLabel;
           
            this.acessoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.acessoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.acessoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codacessoLabel1 = new System.Windows.Forms.Label();
            this.nomeacessoTextBox = new System.Windows.Forms.TextBox();
            codacessoLabel = new System.Windows.Forms.Label();
            nomeacessoLabel = new System.Windows.Forms.Label();
         
           
            // 
            // codacessoLabel
            // 
            codacessoLabel.AutoSize = true;
            codacessoLabel.Location = new System.Drawing.Point(9, 55);
            codacessoLabel.Name = "codacessoLabel";
            codacessoLabel.Size = new System.Drawing.Size(62, 13);
            codacessoLabel.TabIndex = 2;
            codacessoLabel.Text = "codacesso:";
            // 
            // codacessoLabel1
            // 
            this.codacessoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acessoBindingSource, "codacesso", true));
            this.codacessoLabel1.Location = new System.Drawing.Point(77, 55);
            this.codacessoLabel1.Name = "codacessoLabel1";
            this.codacessoLabel1.Size = new System.Drawing.Size(100, 23);
            this.codacessoLabel1.TabIndex = 3;
            this.codacessoLabel1.Text = "0";
            // 
            // nomeacessoLabel
            // 
            nomeacessoLabel.AutoSize = true;
            nomeacessoLabel.Location = new System.Drawing.Point(9, 90);
            nomeacessoLabel.Name = "nomeacessoLabel";
            nomeacessoLabel.Size = new System.Drawing.Size(70, 13);
            nomeacessoLabel.TabIndex = 4;
            nomeacessoLabel.Text = "nomeacesso:";
            // 
            // nomeacessoTextBox
            // 
            this.nomeacessoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acessoBindingSource, "nomeacesso", true));
            this.nomeacessoTextBox.Location = new System.Drawing.Point(85, 87);
            this.nomeacessoTextBox.Name = "nomeacessoTextBox";
            this.nomeacessoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeacessoTextBox.TabIndex = 5;
            // 
            // frm_Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 397);
            this.Controls.Add(nomeacessoLabel);
            this.Controls.Add(this.nomeacessoTextBox);
            this.Controls.Add(codacessoLabel);
            this.Controls.Add(this.codacessoLabel1);
            this.Controls.Add(this.acessoDataGridView);
            this.Controls.Add(this.acessoBindingNavigator);
            this.Name = "frm_Acesso";
            this.Text = "frm_Acesso";
            this.Load += new System.EventHandler(this.frm_Acesso_Load);
          
          

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblBuscaId;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPrimeiro;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRelatorio;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}