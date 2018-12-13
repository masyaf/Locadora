namespace Locadora.Pesquisa
{
    partial class FRMPesquisa_Filme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPesquisa_Filme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBXPesquisa = new System.Windows.Forms.TextBox();
            this.BTNPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVFilme = new System.Windows.Forms.DataGridView();
            this.BTNConfirmar = new System.Windows.Forms.Button();
            this.BTNSair = new System.Windows.Forms.Button();
            this.MovieCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBXPesquisa);
            this.groupBox1.Controls.Add(this.BTNPesquisar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DGVFilme);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 316);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // TBXPesquisa
            // 
            this.TBXPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXPesquisa.Location = new System.Drawing.Point(7, 48);
            this.TBXPesquisa.Name = "TBXPesquisa";
            this.TBXPesquisa.Size = new System.Drawing.Size(514, 22);
            this.TBXPesquisa.TabIndex = 36;
            // 
            // BTNPesquisar
            // 
            this.BTNPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BTNPesquisar.Image")));
            this.BTNPesquisar.Location = new System.Drawing.Point(527, 35);
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
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nome do Filme";
            // 
            // DGVFilme
            // 
            this.DGVFilme.AllowUserToAddRows = false;
            this.DGVFilme.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGVFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFilme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieCode,
            this.Title,
            this.Stock,
            this.TypeMovie});
            this.DGVFilme.Location = new System.Drawing.Point(7, 77);
            this.DGVFilme.Name = "DGVFilme";
            this.DGVFilme.ReadOnly = true;
            this.DGVFilme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFilme.Size = new System.Drawing.Size(564, 231);
            this.DGVFilme.TabIndex = 33;
            this.DGVFilme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFilme_CellClick);
            // 
            // BTNConfirmar
            // 
            this.BTNConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("BTNConfirmar.Image")));
            this.BTNConfirmar.Location = new System.Drawing.Point(589, 6);
            this.BTNConfirmar.Name = "BTNConfirmar";
            this.BTNConfirmar.Size = new System.Drawing.Size(89, 67);
            this.BTNConfirmar.TabIndex = 46;
            this.BTNConfirmar.Text = "Confirmar";
            this.BTNConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNConfirmar.UseVisualStyleBackColor = true;
            this.BTNConfirmar.Click += new System.EventHandler(this.BTNConfirmar_Click);
            // 
            // BTNSair
            // 
            this.BTNSair.Image = ((System.Drawing.Image)(resources.GetObject("BTNSair.Image")));
            this.BTNSair.Location = new System.Drawing.Point(589, 75);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(89, 67);
            this.BTNSair.TabIndex = 47;
            this.BTNSair.Text = "Sair";
            this.BTNSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSair.UseVisualStyleBackColor = true;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // CodigoFilme
            // 
            this.MovieCode.DataPropertyName = "MovieCode";
            this.MovieCode.HeaderText = "Código";
            this.MovieCode.Name = "CodigoFilme";
            this.MovieCode.ReadOnly = true;
            this.MovieCode.Width = 50;
            // 
            // TituloFilme
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Título Filme";
            this.Title.Name = "TituloFilme";
            this.Title.ReadOnly = true;
            this.Title.Width = 280;
            // 
            // EstoqueFilme
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Estoque";
            this.Stock.Name = "EstoqueFilme";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 70;
            // 
            // NomeTipo
            // 
            this.TypeMovie.DataPropertyName = "TypeMovie";
            this.TypeMovie.HeaderText = "Tipo";
            this.TypeMovie.Name = "NomeTipo";
            this.TypeMovie.ReadOnly = true;
            // 
            // FRMPesquisa_Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNConfirmar);
            this.Controls.Add(this.BTNSair);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMPesquisa_Filme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Filme";
            this.Load += new System.EventHandler(this.FRMPesquisa_Filme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFilme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBXPesquisa;
        private System.Windows.Forms.Button BTNPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVFilme;
        private System.Windows.Forms.Button BTNConfirmar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeMovie;
    }
}