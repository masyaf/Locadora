namespace Locadora.Cadastro
{
    partial class FRMCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCidade));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBXCidade = new System.Windows.Forms.TextBox();
            this.TBXUf = new System.Windows.Forms.TextBox();
            this.TBXCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNExcluir = new System.Windows.Forms.Button();
            this.BTNGravar = new System.Windows.Forms.Button();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.BTNSair = new System.Windows.Forms.Button();
            this.BTNPesquisar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBXCidade);
            this.groupBox2.Controls.Add(this.TBXUf);
            this.groupBox2.Controls.Add(this.TBXCodigo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informe os Dados";
            // 
            // TBXCidade
            // 
            this.TBXCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXCidade.Location = new System.Drawing.Point(19, 102);
            this.TBXCidade.Name = "TBXCidade";
            this.TBXCidade.Size = new System.Drawing.Size(347, 22);
            this.TBXCidade.TabIndex = 35;
            // 
            // TBXUf
            // 
            this.TBXUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXUf.Location = new System.Drawing.Point(387, 102);
            this.TBXUf.Name = "TBXUf";
            this.TBXUf.Size = new System.Drawing.Size(40, 22);
            this.TBXUf.TabIndex = 34;
            // 
            // TBXCodigo
            // 
            this.TBXCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXCodigo.Location = new System.Drawing.Point(19, 43);
            this.TBXCodigo.Name = "TBXCodigo";
            this.TBXCodigo.ReadOnly = true;
            this.TBXCodigo.Size = new System.Drawing.Size(100, 22);
            this.TBXCodigo.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "UF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código";
            // 
            // BTNExcluir
            // 
            this.BTNExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BTNExcluir.Image")));
            this.BTNExcluir.Location = new System.Drawing.Point(187, 162);
            this.BTNExcluir.Name = "BTNExcluir";
            this.BTNExcluir.Size = new System.Drawing.Size(89, 67);
            this.BTNExcluir.TabIndex = 32;
            this.BTNExcluir.Text = "Excluir";
            this.BTNExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNExcluir.UseVisualStyleBackColor = true;
            this.BTNExcluir.Click += new System.EventHandler(this.BTNExcluir_Click);
            // 
            // BTNGravar
            // 
            this.BTNGravar.Image = ((System.Drawing.Image)(resources.GetObject("BTNGravar.Image")));
            this.BTNGravar.Location = new System.Drawing.Point(97, 162);
            this.BTNGravar.Name = "BTNGravar";
            this.BTNGravar.Size = new System.Drawing.Size(89, 67);
            this.BTNGravar.TabIndex = 29;
            this.BTNGravar.Text = "Gravar";
            this.BTNGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNGravar.UseVisualStyleBackColor = true;
            this.BTNGravar.Click += new System.EventHandler(this.BTNGravar_Click);
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BTNLimpar.Image")));
            this.BTNLimpar.Location = new System.Drawing.Point(7, 162);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(89, 67);
            this.BTNLimpar.TabIndex = 31;
            this.BTNLimpar.Text = "Limpar";
            this.BTNLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNLimpar.UseVisualStyleBackColor = true;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Click);
            // 
            // BTNSair
            // 
            this.BTNSair.Image = ((System.Drawing.Image)(resources.GetObject("BTNSair.Image")));
            this.BTNSair.Location = new System.Drawing.Point(367, 162);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(89, 67);
            this.BTNSair.TabIndex = 30;
            this.BTNSair.Text = "Sair";
            this.BTNSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSair.UseVisualStyleBackColor = true;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // BTNPesquisar
            // 
            this.BTNPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BTNPesquisar.Image")));
            this.BTNPesquisar.Location = new System.Drawing.Point(277, 162);
            this.BTNPesquisar.Name = "BTNPesquisar";
            this.BTNPesquisar.Size = new System.Drawing.Size(89, 67);
            this.BTNPesquisar.TabIndex = 33;
            this.BTNPesquisar.Text = "Pesquisar";
            this.BTNPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNPesquisar.UseVisualStyleBackColor = true;
            this.BTNPesquisar.Click += new System.EventHandler(this.BTNPesquisar_Click);
            // 
            // FRMCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 238);
            this.Controls.Add(this.BTNPesquisar);
            this.Controls.Add(this.BTNExcluir);
            this.Controls.Add(this.BTNGravar);
            this.Controls.Add(this.BTNLimpar);
            this.Controls.Add(this.BTNSair);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidade";
            this.Load += new System.EventHandler(this.FRMCidade_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBXCidade;
        private System.Windows.Forms.TextBox TBXUf;
        private System.Windows.Forms.TextBox TBXCodigo;
        private System.Windows.Forms.Button BTNExcluir;
        private System.Windows.Forms.Button BTNGravar;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.Button BTNPesquisar;
    }
}