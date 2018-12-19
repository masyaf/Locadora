namespace Locadora.Movimento
{
    partial class FRMAluguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAluguel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GBStatus = new System.Windows.Forms.GroupBox();
            this.LBStatus = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LBMulta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBValor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GBDados = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBXFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBXDataAluguel = new System.Windows.Forms.MaskedTextBox();
            this.TBXCliente = new System.Windows.Forms.TextBox();
            this.TBXCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TSAluguel = new System.Windows.Forms.ToolStrip();
            this.BTNNovo = new System.Windows.Forms.ToolStripButton();
            this.BTNGravar = new System.Windows.Forms.ToolStripButton();
            this.BTNPesquisar = new System.Windows.Forms.ToolStripButton();
            this.BTNExcluir = new System.Windows.Forms.ToolStripButton();
            this.BTNImprimir = new System.Windows.Forms.ToolStripButton();
            this.BTNSair = new System.Windows.Forms.ToolStripButton();
            this.GBFilme = new System.Windows.Forms.GroupBox();
            this.DGVFilme = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TBXFilme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BTNDevolucao = new System.Windows.Forms.Button();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.BTNDeletar = new System.Windows.Forms.Button();
            this.BTNAdicionar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LoanMovieCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountMuclt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.GBStatus.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GBDados.SuspendLayout();
            this.TSAluguel.SuspendLayout();
            this.GBFilme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFilme)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.GBStatus);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.GBDados);
            this.groupBox1.Controls.Add(this.TSAluguel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 642);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // GBStatus
            // 
            this.GBStatus.Controls.Add(this.LBStatus);
            this.GBStatus.Enabled = false;
            this.GBStatus.Location = new System.Drawing.Point(3, 470);
            this.GBStatus.Name = "GBStatus";
            this.GBStatus.Size = new System.Drawing.Size(370, 110);
            this.GBStatus.TabIndex = 70;
            this.GBStatus.TabStop = false;
            this.GBStatus.Text = "Status";
            // 
            // LBStatus
            // 
            this.LBStatus.AutoSize = true;
            this.LBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBStatus.ForeColor = System.Drawing.Color.Red;
            this.LBStatus.Location = new System.Drawing.Point(13, 48);
            this.LBStatus.Name = "LBStatus";
            this.LBStatus.Size = new System.Drawing.Size(182, 31);
            this.LBStatus.TabIndex = 51;
            this.LBStatus.Text = "EM ABERTO";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LBMulta);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.LBTotal);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.LBValor);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(3, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 192);
            this.groupBox4.TabIndex = 69;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valores";
            // 
            // LBMulta
            // 
            this.LBMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMulta.ForeColor = System.Drawing.Color.Red;
            this.LBMulta.Location = new System.Drawing.Point(220, 81);
            this.LBMulta.Name = "LBMulta";
            this.LBMulta.Size = new System.Drawing.Size(129, 31);
            this.LBMulta.TabIndex = 52;
            this.LBMulta.Text = "0,00";
            this.LBMulta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(13, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 31);
            this.label8.TabIndex = 51;
            this.label8.Text = "Multa R$";
            // 
            // LBTotal
            // 
            this.LBTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTotal.ForeColor = System.Drawing.Color.Black;
            this.LBTotal.Location = new System.Drawing.Point(214, 144);
            this.LBTotal.Name = "LBTotal";
            this.LBTotal.Size = new System.Drawing.Size(133, 31);
            this.LBTotal.TabIndex = 55;
            this.LBTotal.Text = "0,00";
            this.LBTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 31);
            this.label11.TabIndex = 54;
            this.label11.Text = "Total R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 31);
            this.label5.TabIndex = 53;
            this.label5.Text = "____________________";
            // 
            // LBValor
            // 
            this.LBValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LBValor.Location = new System.Drawing.Point(226, 36);
            this.LBValor.Name = "LBValor";
            this.LBValor.Size = new System.Drawing.Size(123, 31);
            this.LBValor.TabIndex = 50;
            this.LBValor.Text = "0,00";
            this.LBValor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(13, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 31);
            this.label6.TabIndex = 49;
            this.label6.Text = "Valor R$";
            // 
            // GBDados
            // 
            this.GBDados.Controls.Add(this.label4);
            this.GBDados.Controls.Add(this.TBXFuncionario);
            this.GBDados.Controls.Add(this.label3);
            this.GBDados.Controls.Add(this.TBXDataAluguel);
            this.GBDados.Controls.Add(this.TBXCliente);
            this.GBDados.Controls.Add(this.TBXCodigo);
            this.GBDados.Controls.Add(this.label2);
            this.GBDados.Controls.Add(this.label1);
            this.GBDados.Enabled = false;
            this.GBDados.Location = new System.Drawing.Point(3, 83);
            this.GBDados.Name = "GBDados";
            this.GBDados.Size = new System.Drawing.Size(370, 183);
            this.GBDados.TabIndex = 68;
            this.GBDados.TabStop = false;
            this.GBDados.Text = "Informe os Dados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Funcionário";
            // 
            // TBXFuncionario
            // 
            this.TBXFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXFuncionario.Location = new System.Drawing.Point(19, 145);
            this.TBXFuncionario.Name = "TBXFuncionario";
            this.TBXFuncionario.Size = new System.Drawing.Size(330, 22);
            this.TBXFuncionario.TabIndex = 42;
            this.TBXFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBXFuncionario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Data";
            // 
            // TBXDataAluguel
            // 
            this.TBXDataAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXDataAluguel.Location = new System.Drawing.Point(241, 50);
            this.TBXDataAluguel.Mask = "99/99/9999";
            this.TBXDataAluguel.Name = "TBXDataAluguel";
            this.TBXDataAluguel.Size = new System.Drawing.Size(109, 22);
            this.TBXDataAluguel.TabIndex = 37;
            this.TBXDataAluguel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBXCliente
            // 
            this.TBXCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXCliente.Location = new System.Drawing.Point(19, 97);
            this.TBXCliente.Name = "TBXCliente";
            this.TBXCliente.Size = new System.Drawing.Size(331, 22);
            this.TBXCliente.TabIndex = 35;
            this.TBXCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBXCliente_KeyPress);
            // 
            // TBXCodigo
            // 
            this.TBXCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXCodigo.Location = new System.Drawing.Point(19, 50);
            this.TBXCodigo.Name = "TBXCodigo";
            this.TBXCodigo.ReadOnly = true;
            this.TBXCodigo.Size = new System.Drawing.Size(66, 22);
            this.TBXCodigo.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código";
            // 
            // TSAluguel
            // 
            this.TSAluguel.AutoSize = false;
            this.TSAluguel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSAluguel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSAluguel.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.TSAluguel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNNovo,
            this.BTNGravar,
            this.BTNPesquisar,
            this.BTNExcluir,
            this.BTNImprimir,
            this.BTNSair});
            this.TSAluguel.Location = new System.Drawing.Point(3, 16);
            this.TSAluguel.Name = "TSAluguel";
            this.TSAluguel.Size = new System.Drawing.Size(373, 64);
            this.TSAluguel.Stretch = true;
            this.TSAluguel.TabIndex = 0;
            this.TSAluguel.Text = "toolStrip1";
            // 
            // BTNNovo
            // 
            this.BTNNovo.Image = ((System.Drawing.Image)(resources.GetObject("BTNNovo.Image")));
            this.BTNNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNNovo.Name = "BTNNovo";
            this.BTNNovo.Size = new System.Drawing.Size(44, 61);
            this.BTNNovo.Text = "Novo";
            this.BTNNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNNovo.Click += new System.EventHandler(this.BTNNovo_Click);
            // 
            // BTNGravar
            // 
            this.BTNGravar.Image = ((System.Drawing.Image)(resources.GetObject("BTNGravar.Image")));
            this.BTNGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNGravar.Name = "BTNGravar";
            this.BTNGravar.Size = new System.Drawing.Size(51, 61);
            this.BTNGravar.Text = "Gravar";
            this.BTNGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNGravar.Click += new System.EventHandler(this.BTNGravar_Click);
            // 
            // BTNPesquisar
            // 
            this.BTNPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BTNPesquisar.Image")));
            this.BTNPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNPesquisar.Name = "BTNPesquisar";
            this.BTNPesquisar.Size = new System.Drawing.Size(68, 61);
            this.BTNPesquisar.Text = "Pesquisar";
            this.BTNPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNPesquisar.Click += new System.EventHandler(this.BTNPesquisar_Click);
            // 
            // BTNExcluir
            // 
            this.BTNExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BTNExcluir.Image")));
            this.BTNExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNExcluir.Name = "BTNExcluir";
            this.BTNExcluir.Size = new System.Drawing.Size(49, 61);
            this.BTNExcluir.Text = "Excluir";
            this.BTNExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNExcluir.Click += new System.EventHandler(this.BTNExcluir_Click);
            // 
            // BTNImprimir
            // 
            this.BTNImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BTNImprimir.Image")));
            this.BTNImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNImprimir.Name = "BTNImprimir";
            this.BTNImprimir.Size = new System.Drawing.Size(61, 61);
            this.BTNImprimir.Text = "Imprimir";
            this.BTNImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNImprimir.Click += new System.EventHandler(this.BTNImprimir_Click);
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
            // GBFilme
            // 
            this.GBFilme.BackColor = System.Drawing.SystemColors.Control;
            this.GBFilme.Controls.Add(this.DGVFilme);
            this.GBFilme.Controls.Add(this.groupBox6);
            this.GBFilme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBFilme.Enabled = false;
            this.GBFilme.Location = new System.Drawing.Point(379, 0);
            this.GBFilme.Name = "GBFilme";
            this.GBFilme.Size = new System.Drawing.Size(985, 642);
            this.GBFilme.TabIndex = 1;
            this.GBFilme.TabStop = false;
            this.GBFilme.Text = "Filmes";
            // 
            // DGVFilme
            // 
            this.DGVFilme.AllowUserToAddRows = false;
            this.DGVFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFilme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Completed,
            this.LoanMovieCode,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Tipo,
            this.DateReturn,
            this.DateDelivery,
            this.AmountMuclt,
            this.Value,
            this.Column9});
            this.DGVFilme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVFilme.Location = new System.Drawing.Point(3, 105);
            this.DGVFilme.Name = "DGVFilme";
            this.DGVFilme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFilme.Size = new System.Drawing.Size(979, 534);
            this.DGVFilme.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(979, 89);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TBXFilme);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox8.Location = new System.Drawing.Point(3, 41);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(736, 45);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            // 
            // TBXFilme
            // 
            this.TBXFilme.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBXFilme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBXFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXFilme.Location = new System.Drawing.Point(3, 16);
            this.TBXFilme.Name = "TBXFilme";
            this.TBXFilme.Size = new System.Drawing.Size(730, 22);
            this.TBXFilme.TabIndex = 37;
            this.TBXFilme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBXFilme_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Filme";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BTNDevolucao);
            this.groupBox7.Controls.Add(this.BTNLimpar);
            this.groupBox7.Controls.Add(this.BTNDeletar);
            this.groupBox7.Controls.Add(this.BTNAdicionar);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox7.Location = new System.Drawing.Point(739, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(237, 70);
            this.groupBox7.TabIndex = 38;
            this.groupBox7.TabStop = false;
            // 
            // BTNDevolucao
            // 
            this.BTNDevolucao.Enabled = false;
            this.BTNDevolucao.Image = ((System.Drawing.Image)(resources.GetObject("BTNDevolucao.Image")));
            this.BTNDevolucao.Location = new System.Drawing.Point(182, 10);
            this.BTNDevolucao.Name = "BTNDevolucao";
            this.BTNDevolucao.Size = new System.Drawing.Size(52, 57);
            this.BTNDevolucao.TabIndex = 57;
            this.BTNDevolucao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNDevolucao.UseVisualStyleBackColor = true;
            this.BTNDevolucao.Click += new System.EventHandler(this.BTNDevolucao_Click);
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BTNLimpar.Image")));
            this.BTNLimpar.Location = new System.Drawing.Point(113, 10);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(52, 57);
            this.BTNLimpar.TabIndex = 56;
            this.BTNLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNLimpar.UseVisualStyleBackColor = true;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Click);
            // 
            // BTNDeletar
            // 
            this.BTNDeletar.Image = ((System.Drawing.Image)(resources.GetObject("BTNDeletar.Image")));
            this.BTNDeletar.Location = new System.Drawing.Point(60, 10);
            this.BTNDeletar.Name = "BTNDeletar";
            this.BTNDeletar.Size = new System.Drawing.Size(52, 57);
            this.BTNDeletar.TabIndex = 55;
            this.BTNDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNDeletar.UseVisualStyleBackColor = true;
            this.BTNDeletar.Click += new System.EventHandler(this.BTNDeletar_Click);
            // 
            // BTNAdicionar
            // 
            this.BTNAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("BTNAdicionar.Image")));
            this.BTNAdicionar.Location = new System.Drawing.Point(6, 10);
            this.BTNAdicionar.Name = "BTNAdicionar";
            this.BTNAdicionar.Size = new System.Drawing.Size(52, 57);
            this.BTNAdicionar.TabIndex = 54;
            this.BTNAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNAdicionar.UseVisualStyleBackColor = true;
            this.BTNAdicionar.Click += new System.EventHandler(this.BTNAdicionar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Completed
            // 
            this.Completed.DataPropertyName = "Completed";
            this.Completed.FalseValue = "false";
            this.Completed.HeaderText = "";
            this.Completed.Name = "Completed";
            this.Completed.TrueValue = "true";
            this.Completed.Width = 40;
            // 
            // LoanMovieCode
            // 
            this.LoanMovieCode.DataPropertyName = "LoanMovieCode";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LoanMovieCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.LoanMovieCode.HeaderText = "CodigoAluguelFilme";
            this.LoanMovieCode.Name = "LoanMovieCode";
            this.LoanMovieCode.Visible = false;
            this.LoanMovieCode.Width = 85;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LoanCode";
            this.Column2.HeaderText = "CodigoAluguel";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MovieCode";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Código Filme";
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Title";
            this.Column4.HeaderText = "Título";
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "MovieType";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 120;
            // 
            // DateReturn
            // 
            this.DateReturn.DataPropertyName = "DateReturn";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.DateReturn.DefaultCellStyle = dataGridViewCellStyle4;
            this.DateReturn.HeaderText = "Devolução";
            this.DateReturn.Name = "DateReturn";
            // 
            // DateDelivery
            // 
            this.DateDelivery.DataPropertyName = "DateDelivery";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.DateDelivery.DefaultCellStyle = dataGridViewCellStyle5;
            this.DateDelivery.HeaderText = "Entrega";
            this.DateDelivery.Name = "DateDelivery";
            // 
            // AmountMuclt
            // 
            this.AmountMuclt.DataPropertyName = "AmountMuclt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.AmountMuclt.DefaultCellStyle = dataGridViewCellStyle6;
            this.AmountMuclt.HeaderText = "Multa R$";
            this.AmountMuclt.Name = "AmountMuclt";
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.Value.DefaultCellStyle = dataGridViewCellStyle7;
            this.Value.HeaderText = "Valor R$";
            this.Value.Name = "Value";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TypeMovieCode";
            this.Column9.HeaderText = "CodigoTipo";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // FRMAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 642);
            this.Controls.Add(this.GBFilme);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRMAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluguel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMAluguel_Load);
            this.groupBox1.ResumeLayout(false);
            this.GBStatus.ResumeLayout(false);
            this.GBStatus.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GBDados.ResumeLayout(false);
            this.GBDados.PerformLayout();
            this.TSAluguel.ResumeLayout(false);
            this.TSAluguel.PerformLayout();
            this.GBFilme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFilme)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GBFilme;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip TSAluguel;
        private System.Windows.Forms.ToolStripButton BTNExcluir;
        private System.Windows.Forms.ToolStripButton BTNNovo;
        private System.Windows.Forms.ToolStripButton BTNGravar;
        private System.Windows.Forms.ToolStripButton BTNPesquisar;
        private System.Windows.Forms.ToolStripButton BTNImprimir;
        private System.Windows.Forms.ToolStripButton BTNSair;
        private System.Windows.Forms.GroupBox GBDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBXFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TBXDataAluguel;
        private System.Windows.Forms.TextBox TBXCliente;
        private System.Windows.Forms.TextBox TBXCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LBTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBMulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GBStatus;
        private System.Windows.Forms.Label LBStatus;
        private System.Windows.Forms.DataGridView DGVFilme;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox TBXFilme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Button BTNDeletar;
        private System.Windows.Forms.Button BTNAdicionar;
        private System.Windows.Forms.Button BTNDevolucao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanMovieCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountMuclt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}