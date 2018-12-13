namespace Locadora
{
    partial class FRMMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNCadastro = new System.Windows.Forms.ToolStripSplitButton();
            this.BTNCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNCidade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNGenero = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNClassificacao = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNGravadora = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNAluguel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNCadastro,
            this.toolStripSeparator1,
            this.BTNAluguel,
            this.toolStripSeparator3,
            this.BTNSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(884, 64);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "TSMenu";
            // 
            // BTNCadastro
            // 
            this.BTNCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNCliente,
            this.BTNCidade,
            this.toolStripSeparator4,
            this.BTNFilme,
            this.BTNGenero,
            this.BTNTipo,
            this.BTNClassificacao,
            this.BTNGravadora,
            this.toolStripSeparator5,
            this.BTNFuncionario});
            this.BTNCadastro.Image = ((System.Drawing.Image)(resources.GetObject("BTNCadastro.Image")));
            this.BTNCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNCadastro.Name = "BTNCadastro";
            this.BTNCadastro.Size = new System.Drawing.Size(77, 61);
            this.BTNCadastro.Text = "Cadastro";
            this.BTNCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // BTNCliente
            // 
            this.BTNCliente.Image = ((System.Drawing.Image)(resources.GetObject("BTNCliente.Image")));
            this.BTNCliente.Name = "BTNCliente";
            this.BTNCliente.Size = new System.Drawing.Size(174, 46);
            this.BTNCliente.Text = "Cliente";
            this.BTNCliente.Click += new System.EventHandler(this.BTNCliente_Click);
            // 
            // BTNCidade
            // 
            this.BTNCidade.Image = ((System.Drawing.Image)(resources.GetObject("BTNCidade.Image")));
            this.BTNCidade.Name = "BTNCidade";
            this.BTNCidade.Size = new System.Drawing.Size(174, 46);
            this.BTNCidade.Text = "Cidade";
            this.BTNCidade.Click += new System.EventHandler(this.BTNCidade_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(171, 6);
            // 
            // BTNFilme
            // 
            this.BTNFilme.Image = ((System.Drawing.Image)(resources.GetObject("BTNFilme.Image")));
            this.BTNFilme.Name = "BTNFilme";
            this.BTNFilme.Size = new System.Drawing.Size(174, 46);
            this.BTNFilme.Text = "Filme";
            this.BTNFilme.Click += new System.EventHandler(this.BTNFilme_Click);
            // 
            // BTNGenero
            // 
            this.BTNGenero.Image = ((System.Drawing.Image)(resources.GetObject("BTNGenero.Image")));
            this.BTNGenero.Name = "BTNGenero";
            this.BTNGenero.Size = new System.Drawing.Size(174, 46);
            this.BTNGenero.Text = "Género";
            this.BTNGenero.Click += new System.EventHandler(this.BTNGenero_Click);
            // 
            // BTNTipo
            // 
            this.BTNTipo.Image = ((System.Drawing.Image)(resources.GetObject("BTNTipo.Image")));
            this.BTNTipo.Name = "BTNTipo";
            this.BTNTipo.Size = new System.Drawing.Size(174, 46);
            this.BTNTipo.Text = "Tipo";
            this.BTNTipo.Click += new System.EventHandler(this.BTNTipo_Click);
            // 
            // BTNClassificacao
            // 
            this.BTNClassificacao.Image = ((System.Drawing.Image)(resources.GetObject("BTNClassificacao.Image")));
            this.BTNClassificacao.Name = "BTNClassificacao";
            this.BTNClassificacao.Size = new System.Drawing.Size(174, 46);
            this.BTNClassificacao.Text = "Classificação";
            this.BTNClassificacao.Click += new System.EventHandler(this.BTNClassificacao_Click);
            // 
            // BTNGravadora
            // 
            this.BTNGravadora.Image = ((System.Drawing.Image)(resources.GetObject("BTNGravadora.Image")));
            this.BTNGravadora.Name = "BTNGravadora";
            this.BTNGravadora.Size = new System.Drawing.Size(174, 46);
            this.BTNGravadora.Text = "Gravadora";
            this.BTNGravadora.Click += new System.EventHandler(this.BTNGravadora_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(171, 6);
            // 
            // BTNFuncionario
            // 
            this.BTNFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("BTNFuncionario.Image")));
            this.BTNFuncionario.Name = "BTNFuncionario";
            this.BTNFuncionario.Size = new System.Drawing.Size(174, 46);
            this.BTNFuncionario.Text = "Funcionário";
            this.BTNFuncionario.Click += new System.EventHandler(this.BTNFuncionario_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // BTNAluguel
            // 
            this.BTNAluguel.Image = ((System.Drawing.Image)(resources.GetObject("BTNAluguel.Image")));
            this.BTNAluguel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNAluguel.Name = "BTNAluguel";
            this.BTNAluguel.Size = new System.Drawing.Size(55, 61);
            this.BTNAluguel.Text = "Aluguel";
            this.BTNAluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNAluguel.Click += new System.EventHandler(this.BTNAluguel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 64);
            // 
            // BTNSair
            // 
            this.BTNSair.Image = ((System.Drawing.Image)(resources.GetObject("BTNSair.Image")));
            this.BTNSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(44, 61);
            this.BTNSair.Text = "Sair";
            this.BTNSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // FRMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 468);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de Filmes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton BTNCadastro;
        private System.Windows.Forms.ToolStripMenuItem BTNCliente;
        private System.Windows.Forms.ToolStripMenuItem BTNCidade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem BTNFilme;
        private System.Windows.Forms.ToolStripMenuItem BTNGenero;
        private System.Windows.Forms.ToolStripMenuItem BTNTipo;
        private System.Windows.Forms.ToolStripMenuItem BTNClassificacao;
        private System.Windows.Forms.ToolStripMenuItem BTNGravadora;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem BTNFuncionario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTNAluguel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BTNSair;
    }
}

