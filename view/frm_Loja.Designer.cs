namespace Projeto_Venda_2023.view
{
    partial class frm_Loja
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
            System.Windows.Forms.Label codlojaLabel;
            System.Windows.Forms.Label nomelojaLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label nomefantasiaLabel;
            System.Windows.Forms.Label razaosocialLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Loja));
            this.lojaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataGridView = new System.Windows.Forms.DataGridView();
            this.codlojaLabel1 = new System.Windows.Forms.Label();
            this.nomelojaTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.nomefantasiaTextBox = new System.Windows.Forms.TextBox();
            this.razaosocialTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscaId = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRelatorio = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            codlojaLabel = new System.Windows.Forms.Label();
            nomelojaLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            nomefantasiaLabel = new System.Windows.Forms.Label();
            razaosocialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lojaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codlojaLabel
            // 
            codlojaLabel.AutoSize = true;
            codlojaLabel.Location = new System.Drawing.Point(13, 88);
            codlojaLabel.Name = "codlojaLabel";
            codlojaLabel.Size = new System.Drawing.Size(44, 13);
            codlojaLabel.TabIndex = 2;
            codlojaLabel.Text = "codloja:";
            // 
            // nomelojaLabel
            // 
            nomelojaLabel.AutoSize = true;
            nomelojaLabel.Location = new System.Drawing.Point(13, 118);
            nomelojaLabel.Name = "nomelojaLabel";
            nomelojaLabel.Size = new System.Drawing.Size(52, 13);
            nomelojaLabel.TabIndex = 4;
            nomelojaLabel.Text = "nomeloja:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(13, 154);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(30, 13);
            cnpjLabel.TabIndex = 6;
            cnpjLabel.Text = "cnpj:";
            // 
            // nomefantasiaLabel
            // 
            nomefantasiaLabel.AutoSize = true;
            nomefantasiaLabel.Location = new System.Drawing.Point(13, 191);
            nomefantasiaLabel.Name = "nomefantasiaLabel";
            nomefantasiaLabel.Size = new System.Drawing.Size(73, 13);
            nomefantasiaLabel.TabIndex = 8;
            nomefantasiaLabel.Text = "nomefantasia:";
            // 
            // razaosocialLabel
            // 
            razaosocialLabel.AutoSize = true;
            razaosocialLabel.Location = new System.Drawing.Point(309, 64);
            razaosocialLabel.Name = "razaosocialLabel";
            razaosocialLabel.Size = new System.Drawing.Size(63, 13);
            razaosocialLabel.TabIndex = 10;
            razaosocialLabel.Text = "razaosocial:";
            // 
            // lojaDataGridView
            // 
            this.lojaDataGridView.AutoGenerateColumns = false;
            this.lojaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lojaDataGridView.DataSource = this.lojaBindingSource;
            this.lojaDataGridView.Location = new System.Drawing.Point(12, 265);
            this.lojaDataGridView.Name = "lojaDataGridView";
            this.lojaDataGridView.Size = new System.Drawing.Size(557, 220);
            this.lojaDataGridView.TabIndex = 1;
            // 
            // codlojaLabel1
            // 
            this.codlojaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojaBindingSource, "codloja", true));
            this.codlojaLabel1.Location = new System.Drawing.Point(68, 88);
            this.codlojaLabel1.Name = "codlojaLabel1";
            this.codlojaLabel1.Size = new System.Drawing.Size(100, 23);
            this.codlojaLabel1.TabIndex = 3;
            this.codlojaLabel1.Text = "0";
            // 
            // nomelojaTextBox
            // 
            this.nomelojaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojaBindingSource, "nomeloja", true));
            this.nomelojaTextBox.Location = new System.Drawing.Point(71, 115);
            this.nomelojaTextBox.Name = "nomelojaTextBox";
            this.nomelojaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomelojaTextBox.TabIndex = 5;
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojaBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(71, 151);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpjTextBox.TabIndex = 7;
            // 
            // nomefantasiaTextBox
            // 
            this.nomefantasiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojaBindingSource, "nomefantasia", true));
            this.nomefantasiaTextBox.Location = new System.Drawing.Point(92, 184);
            this.nomefantasiaTextBox.Name = "nomefantasiaTextBox";
            this.nomefantasiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomefantasiaTextBox.TabIndex = 9;
            // 
            // razaosocialTextBox
            // 
            this.razaosocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojaBindingSource, "razaosocial", true));
            this.razaosocialTextBox.Location = new System.Drawing.Point(378, 61);
            this.razaosocialTextBox.Name = "razaosocialTextBox";
            this.razaosocialTextBox.Size = new System.Drawing.Size(100, 20);
            this.razaosocialTextBox.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbSalvar,
            this.tsbCancelar,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.lblBuscaId,
            this.txtBuscar,
            this.btnBuscar,
            this.toolStripSeparator2,
            this.btnPrimeiro,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator3,
            this.btnRelatorio,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(589, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNovo.Text = "toolStripButton1";
            this.tsbNovo.ToolTipText = "Adicionar Novo Cliente";
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsbSalvar.Text = "toolStripButton1";
            this.tsbSalvar.ToolTipText = "Salvar Cliente";
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "toolStripButton1";
            this.tsbCancelar.ToolTipText = "Cancelar";
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbExcluir.Text = "toolStripButton1";
            this.tsbExcluir.ToolTipText = "Excluir Registro";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuscaId
            // 
            this.lblBuscaId.Name = "lblBuscaId";
            this.lblBuscaId.Size = new System.Drawing.Size(79, 22);
            this.lblBuscaId.Text = "Buscar por Id:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "toolStripButton1";
            this.btnBuscar.ToolTipText = "Buscar Cliente";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeiro.Image")));
            this.btnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.btnPrimeiro.Text = "toolStripButton1";
            this.btnPrimeiro.ToolTipText = "Primeiro Registro";
            // 
            // btnAnterior
            // 
            this.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(23, 22);
            this.btnAnterior.Text = "Registro Anterior";
            // 
            // btnProximo
            // 
            this.btnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(23, 22);
            this.btnProximo.Text = "toolStripButton1";
            this.btnProximo.ToolTipText = "Próximo Registro";
            // 
            // btnUltimo
            // 
            this.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(23, 22);
            this.btnUltimo.Text = "toolStripButton1";
            this.btnUltimo.ToolTipText = "Último Registro";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(23, 22);
            this.btnRelatorio.Text = "toolStripButton1";
            this.btnRelatorio.ToolTipText = "Gerar Relatório";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // frm_Loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 505);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(razaosocialLabel);
            this.Controls.Add(this.razaosocialTextBox);
            this.Controls.Add(nomefantasiaLabel);
            this.Controls.Add(this.nomefantasiaTextBox);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(nomelojaLabel);
            this.Controls.Add(this.nomelojaTextBox);
            this.Controls.Add(codlojaLabel);
            this.Controls.Add(this.codlojaLabel1);
            this.Controls.Add(this.lojaDataGridView);
            this.Name = "frm_Loja";
            this.Text = "frm_Loja";
            this.Load += new System.EventHandler(this.frm_Loja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lojaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.BindingSource lojaBindingSource;
        private System.Windows.Forms.DataGridView lojaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label codlojaLabel1;
        private System.Windows.Forms.TextBox nomelojaTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox nomefantasiaTextBox;
        private System.Windows.Forms.TextBox razaosocialTextBox;
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
    }
}