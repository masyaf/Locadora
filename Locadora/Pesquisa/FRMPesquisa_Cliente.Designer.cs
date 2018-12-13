namespace Locadora.Pesquisa
{
    partial class FRMPesquisa_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPesquisa_Cliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBXPesquisa = new System.Windows.Forms.TextBox();
            this.BTNPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVCliente = new System.Windows.Forms.DataGridView();
            this.BTNConfirmar = new System.Windows.Forms.Button();
            this.BTNSair = new System.Windows.Forms.Button();
            this.CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBXPesquisa);
            this.groupBox1.Controls.Add(this.BTNPesquisar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DGVCliente);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 290);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // TBXPesquisa
            // 
            this.TBXPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXPesquisa.Location = new System.Drawing.Point(7, 48);
            this.TBXPesquisa.Name = "TBXPesquisa";
            this.TBXPesquisa.Size = new System.Drawing.Size(377, 22);
            this.TBXPesquisa.TabIndex = 36;
            // 
            // BTNPesquisar
            // 
            this.BTNPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BTNPesquisar.Image")));
            this.BTNPesquisar.Location = new System.Drawing.Point(390, 34);
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
            // DGVCliente
            // 
            this.DGVCliente.AllowUserToAddRows = false;
            this.DGVCliente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerCode,
            this.CustomerName});
            this.DGVCliente.Location = new System.Drawing.Point(7, 77);
            this.DGVCliente.Name = "DGVCliente";
            this.DGVCliente.ReadOnly = true;
            this.DGVCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCliente.Size = new System.Drawing.Size(427, 207);
            this.DGVCliente.TabIndex = 33;
            this.DGVCliente.DoubleClick += new System.EventHandler(this.DGVCliente_DoubleClick);
            // 
            // BTNConfirmar
            // 
            this.BTNConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("BTNConfirmar.Image")));
            this.BTNConfirmar.Location = new System.Drawing.Point(454, 12);
            this.BTNConfirmar.Name = "BTNConfirmar";
            this.BTNConfirmar.Size = new System.Drawing.Size(89, 67);
            this.BTNConfirmar.TabIndex = 43;
            this.BTNConfirmar.Text = "Confirmar";
            this.BTNConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNConfirmar.UseVisualStyleBackColor = true;
            this.BTNConfirmar.Click += new System.EventHandler(this.BTNConfirmar_Click);
            // 
            // BTNSair
            // 
            this.BTNSair.Image = ((System.Drawing.Image)(resources.GetObject("BTNSair.Image")));
            this.BTNSair.Location = new System.Drawing.Point(454, 80);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(89, 67);
            this.BTNSair.TabIndex = 44;
            this.BTNSair.Text = "Sair";
            this.BTNSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSair.UseVisualStyleBackColor = true;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // CustomerCode
            // 
            this.CustomerCode.DataPropertyName = "CustomerCode";
            this.CustomerCode.HeaderText = "Código";
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.ReadOnly = true;
            this.CustomerCode.Width = 70;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "Name";
            this.CustomerName.HeaderText = "Nome Cliente";
            this.CustomerName.Name = "Name";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 300;
            // 
            // FRMPesquisa_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 299);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNConfirmar);
            this.Controls.Add(this.BTNSair);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Cliente";
            this.Load += new System.EventHandler(this.FRMPesquisa_Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBXPesquisa;
        private System.Windows.Forms.Button BTNPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVCliente;
        private System.Windows.Forms.Button BTNConfirmar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
    }
}