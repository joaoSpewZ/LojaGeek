﻿namespace LojaGeek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.pbxProduto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxVenda = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxFechar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1091, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoVendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // pedidoVendaToolStripMenuItem
            // 
            this.pedidoVendaToolStripMenuItem.Name = "pedidoVendaToolStripMenuItem";
            this.pedidoVendaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.pedidoVendaToolStripMenuItem.Text = "Pedido / Venda";
            this.pedidoVendaToolStripMenuItem.Click += new System.EventHandler(this.pedidoVendaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(51, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIENTES";
            // 
            // pbxCliente
            // 
            this.pbxCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbxCliente.Image")));
            this.pbxCliente.Location = new System.Drawing.Point(149, 241);
            this.pbxCliente.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(272, 230);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 2;
            this.pbxCliente.TabStop = false;
            this.pbxCliente.Click += new System.EventHandler(this.pbxCliente_Click);
            // 
            // pbxProduto
            // 
            this.pbxProduto.Image = ((System.Drawing.Image)(resources.GetObject("pbxProduto.Image")));
            this.pbxProduto.Location = new System.Drawing.Point(425, 241);
            this.pbxProduto.Margin = new System.Windows.Forms.Padding(2);
            this.pbxProduto.Name = "pbxProduto";
            this.pbxProduto.Size = new System.Drawing.Size(272, 230);
            this.pbxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProduto.TabIndex = 4;
            this.pbxProduto.TabStop = false;
            this.pbxProduto.Click += new System.EventHandler(this.pbxProduto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 489);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUTOS";
            // 
            // pbxVenda
            // 
            this.pbxVenda.Image = ((System.Drawing.Image)(resources.GetObject("pbxVenda.Image")));
            this.pbxVenda.Location = new System.Drawing.Point(701, 241);
            this.pbxVenda.Margin = new System.Windows.Forms.Padding(2);
            this.pbxVenda.Name = "pbxVenda";
            this.pbxVenda.Size = new System.Drawing.Size(272, 230);
            this.pbxVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVenda.TabIndex = 8;
            this.pbxVenda.TabStop = false;
            this.pbxVenda.Click += new System.EventHandler(this.pbxVenda_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(737, 489);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "VENDA / PEDIDO";
            // 
            // pbxFechar
            // 
            this.pbxFechar.Image = ((System.Drawing.Image)(resources.GetObject("pbxFechar.Image")));
            this.pbxFechar.Location = new System.Drawing.Point(977, 241);
            this.pbxFechar.Margin = new System.Windows.Forms.Padding(2);
            this.pbxFechar.Name = "pbxFechar";
            this.pbxFechar.Size = new System.Drawing.Size(272, 230);
            this.pbxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFechar.TabIndex = 10;
            this.pbxFechar.TabStop = false;
            this.pbxFechar.Click += new System.EventHandler(this.pbxFechar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1075, 489);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "SAIR";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 686);
            this.Controls.Add(this.pbxFechar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boteco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.PictureBox pbxProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxFechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem pedidoVendaToolStripMenuItem;
    }
}

