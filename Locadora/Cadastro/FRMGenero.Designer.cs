namespace Locadora.Cadastro
{
    partial class FRMGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMGenero));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBXGenero = new System.Windows.Forms.TextBox();
            this.TBXCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNExcluir = new System.Windows.Forms.Button();
            this.BTNGravar = new System.Windows.Forms.Button();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.BTNSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBXPesquisa = new System.Windows.Forms.TextBox();
            this.BTNPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVGenero = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBXGenero);
            this.groupBox2.Controls.Add(this.TBXCodigo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 134);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informe os Dados";
            // 
            // TBXGenero
            // 
            this.TBXGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXGenero.Location = new System.Drawing.Point(19, 94);
            this.TBXGenero.Name = "TBXGenero";
            this.TBXGenero.Size = new System.Drawing.Size(406, 22);
            this.TBXGenero.TabIndex = 35;
            // 
            // TBXCodigo
            // 
            this.TBXCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXCodigo.Location = new System.Drawing.Point(19, 41);
            this.TBXCodigo.Name = "TBXCodigo";
            this.TBXCodigo.ReadOnly = true;
            this.TBXCodigo.Size = new System.Drawing.Size(100, 22);
            this.TBXCodigo.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Género";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código";
            // 
            // BTNExcluir
            // 
            this.BTNExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BTNExcluir.Image")));
            this.BTNExcluir.Location = new System.Drawing.Point(468, 79);
            this.BTNExcluir.Name = "BTNExcluir";
            this.BTNExcluir.Size = new System.Drawing.Size(89, 67);
            this.BTNExcluir.TabIndex = 38;
            this.BTNExcluir.Text = "Excluir";
            this.BTNExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNExcluir.UseVisualStyleBackColor = true;
            this.BTNExcluir.Click += new System.EventHandler(this.BTNExcluir_Click);
            // 
            // BTNGravar
            // 
            this.BTNGravar.Image = ((System.Drawing.Image)(resources.GetObject("BTNGravar.Image")));
            this.BTNGravar.Location = new System.Drawing.Point(468, 12);
            this.BTNGravar.Name = "BTNGravar";
            this.BTNGravar.Size = new System.Drawing.Size(89, 67);
            this.BTNGravar.TabIndex = 35;
            this.BTNGravar.Text = "Gravar";
            this.BTNGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNGravar.UseVisualStyleBackColor = true;
            this.BTNGravar.Click += new System.EventHandler(this.BTNGravar_Click);
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BTNLimpar.Image")));
            this.BTNLimpar.Location = new System.Drawing.Point(468, 146);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(89, 67);
            this.BTNLimpar.TabIndex = 37;
            this.BTNLimpar.Text = "Limpar";
            this.BTNLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNLimpar.UseVisualStyleBackColor = true;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Click);
            // 
            // BTNSair
            // 
            this.BTNSair.Image = ((System.Drawing.Image)(resources.GetObject("BTNSair.Image")));
            this.BTNSair.Location = new System.Drawing.Point(468, 214);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(89, 67);
            this.BTNSair.TabIndex = 36;
            this.BTNSair.Text = "Sair";
            this.BTNSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSair.UseVisualStyleBackColor = true;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBXPesquisa);
            this.groupBox1.Controls.Add(this.BTNPesquisar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DGVGenero);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 264);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // TBXPesquisa
            // 
            this.TBXPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXPesquisa.Location = new System.Drawing.Point(6, 46);
            this.TBXPesquisa.Name = "TBXPesquisa";
            this.TBXPesquisa.Size = new System.Drawing.Size(386, 22);
            this.TBXPesquisa.TabIndex = 36;
            // 
            // BTNPesquisar
            // 
            this.BTNPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BTNPesquisar.Image")));
            this.BTNPesquisar.Location = new System.Drawing.Point(398, 35);
            this.BTNPesquisar.Name = "BTNPesquisar";
            this.BTNPesquisar.Size = new System.Drawing.Size(44, 36);
            this.BTNPesquisar.TabIndex = 28;
            this.BTNPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNPesquisar.UseVisualStyleBackColor = true;
            this.BTNPesquisar.Click += new System.EventHandler(this.BTNPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nome Género";
            // 
            // DGVGenero
            // 
            this.DGVGenero.AllowUserToAddRows = false;
            this.DGVGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGenero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Idade});
            this.DGVGenero.Location = new System.Drawing.Point(7, 77);
            this.DGVGenero.Name = "DGVGenero";
            this.DGVGenero.ReadOnly = true;
            this.DGVGenero.Size = new System.Drawing.Size(435, 176);
            this.DGVGenero.TabIndex = 33;
            this.DGVGenero.DoubleClick += new System.EventHandler(this.DGVGenero_DoubleClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "GenderCode";
            this.Nome.HeaderText = "Código";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "Name";
            this.Idade.HeaderText = "Nome Género";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            this.Idade.Width = 280;
            // 
            // FRMGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTNExcluir);
            this.Controls.Add(this.BTNGravar);
            this.Controls.Add(this.BTNLimpar);
            this.Controls.Add(this.BTNSair);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Género";
            this.Load += new System.EventHandler(this.FRMGenero_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGenero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBXGenero;
        private System.Windows.Forms.TextBox TBXCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNExcluir;
        private System.Windows.Forms.Button BTNGravar;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVGenero;
        private System.Windows.Forms.TextBox TBXPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
    }
}