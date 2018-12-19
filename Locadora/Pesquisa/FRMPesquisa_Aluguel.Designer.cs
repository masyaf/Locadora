namespace Locadora.Pesquisa
{
    partial class FRMPesquisa_Aluguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPesquisa_Aluguel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CKConcluido = new System.Windows.Forms.CheckBox();
            this.TBXPesquisa = new System.Windows.Forms.TextBox();
            this.BTNPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVAluguel = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNConfirmar = new System.Windows.Forms.Button();
            this.BTNSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAluguel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CKConcluido);
            this.groupBox1.Controls.Add(this.TBXPesquisa);
            this.groupBox1.Controls.Add(this.BTNPesquisar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DGVAluguel);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 309);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // CKConcluido
            // 
            this.CKConcluido.AutoSize = true;
            this.CKConcluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKConcluido.Location = new System.Drawing.Point(370, 19);
            this.CKConcluido.Name = "CKConcluido";
            this.CKConcluido.Size = new System.Drawing.Size(96, 20);
            this.CKConcluido.TabIndex = 37;
            this.CKConcluido.Text = "Concluído";
            this.CKConcluido.UseVisualStyleBackColor = true;
            // 
            // TBXPesquisa
            // 
            this.TBXPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXPesquisa.Location = new System.Drawing.Point(7, 48);
            this.TBXPesquisa.Name = "TBXPesquisa";
            this.TBXPesquisa.Size = new System.Drawing.Size(459, 22);
            this.TBXPesquisa.TabIndex = 36;
            // 
            // BTNPesquisar
            // 
            this.BTNPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BTNPesquisar.Image")));
            this.BTNPesquisar.Location = new System.Drawing.Point(480, 35);
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
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nome do Cliente";
            // 
            // DGVAluguel
            // 
            this.DGVAluguel.AllowUserToAddRows = false;
            this.DGVAluguel.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGVAluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAluguel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Column1,
            this.Idade});
            this.DGVAluguel.Location = new System.Drawing.Point(7, 77);
            this.DGVAluguel.Name = "DGVAluguel";
            this.DGVAluguel.ReadOnly = true;
            this.DGVAluguel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAluguel.Size = new System.Drawing.Size(517, 226);
            this.DGVAluguel.TabIndex = 33;
            this.DGVAluguel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAluguel_CellClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "LoanCode";
            this.Nome.HeaderText = "Código";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 70;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LoanDate";
            this.Column1.HeaderText = "Data";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "DateLoan";
            this.Idade.HeaderText = "Nome Cliente";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            this.Idade.Width = 300;
            // 
            // BTNConfirmar
            // 
            this.BTNConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("BTNConfirmar.Image")));
            this.BTNConfirmar.Location = new System.Drawing.Point(541, 12);
            this.BTNConfirmar.Name = "BTNConfirmar";
            this.BTNConfirmar.Size = new System.Drawing.Size(89, 67);
            this.BTNConfirmar.TabIndex = 49;
            this.BTNConfirmar.Text = "Confirmar";
            this.BTNConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNConfirmar.UseVisualStyleBackColor = true;
            this.BTNConfirmar.Click += new System.EventHandler(this.BTNConfirmar_Click);
            // 
            // BTNSair
            // 
            this.BTNSair.Image = ((System.Drawing.Image)(resources.GetObject("BTNSair.Image")));
            this.BTNSair.Location = new System.Drawing.Point(541, 80);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(89, 67);
            this.BTNSair.TabIndex = 50;
            this.BTNSair.Text = "Sair";
            this.BTNSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSair.UseVisualStyleBackColor = true;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // FRMPesquisa_Aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 318);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNConfirmar);
            this.Controls.Add(this.BTNSair);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMPesquisa_Aluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Aluguel";
            this.Load += new System.EventHandler(this.FRMPesquisa_Aluguel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAluguel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBXPesquisa;
        private System.Windows.Forms.Button BTNPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVAluguel;
        private System.Windows.Forms.Button BTNConfirmar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.CheckBox CKConcluido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
    }
}