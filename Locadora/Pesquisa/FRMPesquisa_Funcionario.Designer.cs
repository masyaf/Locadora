namespace Locadora.Pesquisa
{
    partial class FRMPesquisa_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPesquisa_Funcionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBXPesquisa = new System.Windows.Forms.TextBox();
            this.BTNPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVFuncionario = new System.Windows.Forms.DataGridView();
            this.BTNConfirmar = new System.Windows.Forms.Button();
            this.BTNSair = new System.Windows.Forms.Button();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBXPesquisa);
            this.groupBox1.Controls.Add(this.BTNPesquisar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DGVFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 290);
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
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nome do Funcionário";
            // 
            // DGVFuncionario
            // 
            this.DGVFuncionario.AllowUserToAddRows = false;
            this.DGVFuncionario.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGVFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeCode,
            this.EmployeeName});
            this.DGVFuncionario.Location = new System.Drawing.Point(7, 77);
            this.DGVFuncionario.Name = "DGVFuncionario";
            this.DGVFuncionario.ReadOnly = true;
            this.DGVFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFuncionario.Size = new System.Drawing.Size(427, 207);
            this.DGVFuncionario.TabIndex = 33;
            this.DGVFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFuncionario_CellClick);
            this.DGVFuncionario.DoubleClick += new System.EventHandler(this.DGVFuncionario_DoubleClick);
            // 
            // BTNConfirmar
            // 
            this.BTNConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("BTNConfirmar.Image")));
            this.BTNConfirmar.Location = new System.Drawing.Point(450, 12);
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
            this.BTNSair.Location = new System.Drawing.Point(450, 80);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(89, 67);
            this.BTNSair.TabIndex = 47;
            this.BTNSair.Text = "Sair";
            this.BTNSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSair.UseVisualStyleBackColor = true;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "EmployeeCode";
            this.EmployeeCode.HeaderText = "Código";
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.ReadOnly = true;
            // 
            // Employee Name
            // 
            this.EmployeeName.DataPropertyName = "Name";
            this.EmployeeName.HeaderText = "Nome Funcionário";
            this.EmployeeName.Name = "Name";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 300;
            // 
            // FRMPesquisa_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNConfirmar);
            this.Controls.Add(this.BTNSair);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMPesquisa_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Funcionário";
            this.Load += new System.EventHandler(this.FRMPesquisa_Funcionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBXPesquisa;
        private System.Windows.Forms.Button BTNPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVFuncionario;
        private System.Windows.Forms.Button BTNConfirmar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCode;
    }
}