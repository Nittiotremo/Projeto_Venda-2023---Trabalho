﻿namespace Projeto_Venda_2023
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bairroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ufToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.tabelasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoToolStripMenuItem,
            this.bairroToolStripMenuItem,
            this.cepToolStripMenuItem,
            this.cidadeToolStripMenuItem,
            this.funçãoToolStripMenuItem,
            this.lojaToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.operadoraToolStripMenuItem,
            this.ruaToolStripMenuItem,
            this.situaçãoToolStripMenuItem,
            this.tipoToolStripMenuItem,
            this.trabalhoToolStripMenuItem,
            this.ufToolStripMenuItem,
            this.sexoToolStripMenuItem});
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // acessoToolStripMenuItem
            // 
            this.acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            this.acessoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acessoToolStripMenuItem.Text = "Acesso";
            this.acessoToolStripMenuItem.Click += new System.EventHandler(this.AcessoToolStripMenuItem_Click);
            // 
            // bairroToolStripMenuItem
            // 
            this.bairroToolStripMenuItem.Name = "bairroToolStripMenuItem";
            this.bairroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bairroToolStripMenuItem.Text = "Bairro";
            this.bairroToolStripMenuItem.Click += new System.EventHandler(this.BairroToolStripMenuItem_Click);
            // 
            // cepToolStripMenuItem
            // 
            this.cepToolStripMenuItem.Name = "cepToolStripMenuItem";
            this.cepToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cepToolStripMenuItem.Text = "Cep";
            this.cepToolStripMenuItem.Click += new System.EventHandler(this.CepToolStripMenuItem_Click);
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cidadeToolStripMenuItem.Text = "Cidade";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.CidadeToolStripMenuItem_Click);
            // 
            // funçãoToolStripMenuItem
            // 
            this.funçãoToolStripMenuItem.Name = "funçãoToolStripMenuItem";
            this.funçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funçãoToolStripMenuItem.Text = "Função";
            this.funçãoToolStripMenuItem.Click += new System.EventHandler(this.FunçãoToolStripMenuItem_Click);
            // 
            // lojaToolStripMenuItem
            // 
            this.lojaToolStripMenuItem.Name = "lojaToolStripMenuItem";
            this.lojaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lojaToolStripMenuItem.Text = "Loja";
            this.lojaToolStripMenuItem.Click += new System.EventHandler(this.LojaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.MarcaToolStripMenuItem_Click);
            // 
            // operadoraToolStripMenuItem
            // 
            this.operadoraToolStripMenuItem.Name = "operadoraToolStripMenuItem";
            this.operadoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.operadoraToolStripMenuItem.Text = "Operadora";
            this.operadoraToolStripMenuItem.Click += new System.EventHandler(this.OperadoraToolStripMenuItem_Click);
            // 
            // ruaToolStripMenuItem
            // 
            this.ruaToolStripMenuItem.Name = "ruaToolStripMenuItem";
            this.ruaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ruaToolStripMenuItem.Text = "Rua";
            this.ruaToolStripMenuItem.Click += new System.EventHandler(this.RuaToolStripMenuItem_Click);
            // 
            // situaçãoToolStripMenuItem
            // 
            this.situaçãoToolStripMenuItem.Name = "situaçãoToolStripMenuItem";
            this.situaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.situaçãoToolStripMenuItem.Text = "Situação";
            this.situaçãoToolStripMenuItem.Click += new System.EventHandler(this.SituaçãoToolStripMenuItem_Click);
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            this.tipoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoToolStripMenuItem.Text = "Tipo";
            this.tipoToolStripMenuItem.Click += new System.EventHandler(this.TipoToolStripMenuItem_Click);
            // 
            // trabalhoToolStripMenuItem
            // 
            this.trabalhoToolStripMenuItem.Name = "trabalhoToolStripMenuItem";
            this.trabalhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trabalhoToolStripMenuItem.Text = "Trabalho";
            this.trabalhoToolStripMenuItem.Click += new System.EventHandler(this.TrabalhoToolStripMenuItem_Click);
            // 
            // ufToolStripMenuItem
            // 
            this.ufToolStripMenuItem.Name = "ufToolStripMenuItem";
            this.ufToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ufToolStripMenuItem.Text = "Uf";
            this.ufToolStripMenuItem.Click += new System.EventHandler(this.ufToolStripMenuItem_Click);
            // 
            // sexoToolStripMenuItem
            // 
            this.sexoToolStripMenuItem.Name = "sexoToolStripMenuItem";
            this.sexoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sexoToolStripMenuItem.Text = "Sexo";
            this.sexoToolStripMenuItem.Click += new System.EventHandler(this.sexoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(83)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(695, 440);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Loja Unifunec";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bairroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ufToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexoToolStripMenuItem;
    }
}

