namespace PIZZARIA.VIEW
{
    partial class frmAtendimento
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbPedido = new System.Windows.Forms.GroupBox();
            this.lblIdPed = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblIdAtend = new System.Windows.Forms.Label();
            this.lblCodAtend = new System.Windows.Forms.Label();
            this.btnInsAtend = new System.Windows.Forms.Button();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvAtendimento = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAtend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnFinalizar);
            this.splitContainer1.Panel1.Controls.Add(this.grbPedido);
            this.splitContainer1.Panel1.Controls.Add(this.lblIdAtend);
            this.splitContainer1.Panel1.Controls.Add(this.lblCodAtend);
            this.splitContainer1.Panel1.Controls.Add(this.btnInsAtend);
            this.splitContainer1.Panel1.Controls.Add(this.txtPago);
            this.splitContainer1.Panel1.Controls.Add(this.txtTroco);
            this.splitContainer1.Panel1.Controls.Add(this.txtTotal);
            this.splitContainer1.Panel1.Controls.Add(this.lblPago);
            this.splitContainer1.Panel1.Controls.Add(this.lblTroco);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel1.Controls.Add(this.lblPedidos);
            this.splitContainer1.Panel1.Controls.Add(this.dgvPedidos);
            this.splitContainer1.Panel1.Controls.Add(this.cmbClientes);
            this.splitContainer1.Panel1.Controls.Add(this.lblCliente);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer1.Panel2.Controls.Add(this.dgvAtendimento);
            this.splitContainer1.Size = new System.Drawing.Size(973, 425);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbPedido
            // 
            this.grbPedido.Controls.Add(this.btnVoltar);
            this.grbPedido.Controls.Add(this.lblIdPed);
            this.grbPedido.Controls.Add(this.txtObs);
            this.grbPedido.Controls.Add(this.lblObservacao);
            this.grbPedido.Controls.Add(this.lblProduto);
            this.grbPedido.Controls.Add(this.cmbClass);
            this.grbPedido.Controls.Add(this.cmbProduto);
            this.grbPedido.Controls.Add(this.lblClassificacao);
            this.grbPedido.Controls.Add(this.nudQuantidade);
            this.grbPedido.Controls.Add(this.lblQuantidade);
            this.grbPedido.Controls.Add(this.btnRemover);
            this.grbPedido.Controls.Add(this.btnInserir);
            this.grbPedido.Controls.Add(this.btnEditar);
            this.grbPedido.Location = new System.Drawing.Point(8, 79);
            this.grbPedido.Name = "grbPedido";
            this.grbPedido.Size = new System.Drawing.Size(463, 157);
            this.grbPedido.TabIndex = 0;
            this.grbPedido.TabStop = false;
            this.grbPedido.Visible = false;
            // 
            // lblIdPed
            // 
            this.lblIdPed.Location = new System.Drawing.Point(290, 89);
            this.lblIdPed.Name = "lblIdPed";
            this.lblIdPed.Size = new System.Drawing.Size(100, 23);
            this.lblIdPed.TabIndex = 15;
            this.lblIdPed.Visible = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(16, 86);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(234, 20);
            this.txtObs.TabIndex = 14;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(17, 70);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 13;
            this.lblObservacao.Text = "Observação";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(151, 11);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "Produto";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(16, 36);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 12;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.CmbClass_SelectedIndexChanged);
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmbProduto.Location = new System.Drawing.Point(154, 36);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(171, 21);
            this.cmbProduto.TabIndex = 3;
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Location = new System.Drawing.Point(16, 11);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(69, 13);
            this.lblClassificacao.TabIndex = 11;
            this.lblClassificacao.Text = "Classificação";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(355, 37);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(88, 20);
            this.nudQuantidade.TabIndex = 4;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(356, 11);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(197, 118);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(16, 118);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(76, 23);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(107, 118);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // lblIdAtend
            // 
            this.lblIdAtend.Location = new System.Drawing.Point(23, 50);
            this.lblIdAtend.Name = "lblIdAtend";
            this.lblIdAtend.Size = new System.Drawing.Size(57, 23);
            this.lblIdAtend.TabIndex = 19;
            // 
            // lblCodAtend
            // 
            this.lblCodAtend.AutoSize = true;
            this.lblCodAtend.Location = new System.Drawing.Point(26, 26);
            this.lblCodAtend.Name = "lblCodAtend";
            this.lblCodAtend.Size = new System.Drawing.Size(18, 13);
            this.lblCodAtend.TabIndex = 18;
            this.lblCodAtend.Text = "ID";
            // 
            // btnInsAtend
            // 
            this.btnInsAtend.Location = new System.Drawing.Point(333, 50);
            this.btnInsAtend.Name = "btnInsAtend";
            this.btnInsAtend.Size = new System.Drawing.Size(115, 23);
            this.btnInsAtend.TabIndex = 17;
            this.btnInsAtend.Text = "&Novo Atendimento";
            this.btnInsAtend.UseVisualStyleBackColor = true;
            this.btnInsAtend.Click += new System.EventHandler(this.BtnInsAtend_Click);
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(673, 226);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 20);
            this.txtPago.TabIndex = 16;
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(836, 226);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(100, 20);
            this.txtTroco.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(510, 226);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(678, 209);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(32, 13);
            this.lblPago.TabIndex = 13;
            this.lblPago.Text = "Pago";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Location = new System.Drawing.Point(835, 209);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(35, 13);
            this.lblTroco.TabIndex = 12;
            this.lblTroco.Text = "Troco";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(512, 209);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(179, 12);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(102, 13);
            this.lblPedidos.TabIndex = 10;
            this.lblPedidos.Text = "Registro de Pedidos";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.produto,
            this.classificacao,
            this.preco,
            this.quantidade,
            this.observacao,
            this.idAtend,
            this.idProduto,
            this.idClass});
            this.dgvPedidos.Location = new System.Drawing.Point(477, 12);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(484, 194);
            this.dgvPedidos.TabIndex = 6;
            this.dgvPedidos.DoubleClick += new System.EventHandler(this.DgvPedidos_DoubleClick);
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(92, 52);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(229, 21);
            this.cmbClientes.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(98, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // dgvAtendimento
            // 
            this.dgvAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimento.Location = new System.Drawing.Point(81, 32);
            this.dgvAtendimento.Name = "dgvAtendimento";
            this.dgvAtendimento.Size = new System.Drawing.Size(814, 126);
            this.dgvAtendimento.TabIndex = 0;
            this.dgvAtendimento.DoubleClick += new System.EventHandler(this.DgvAtendimento_DoubleClick);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(333, 49);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(138, 23);
            this.btnFinalizar.TabIndex = 20;
            this.btnFinalizar.Text = "&Finalizar Atendimento";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // produto
            // 
            this.produto.DataPropertyName = "produto";
            this.produto.HeaderText = "PRODUTO";
            this.produto.Name = "produto";
            this.produto.Width = 200;
            // 
            // classificacao
            // 
            this.classificacao.DataPropertyName = "classificacao";
            this.classificacao.HeaderText = "CLASSIFICAÇÃO";
            this.classificacao.Name = "classificacao";
            this.classificacao.Width = 150;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            this.preco.HeaderText = "PREÇO";
            this.preco.Name = "preco";
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "QUANTIDADE";
            this.quantidade.Name = "quantidade";
            // 
            // observacao
            // 
            this.observacao.DataPropertyName = "observacao";
            this.observacao.HeaderText = "OBSERVAÇÃO";
            this.observacao.Name = "observacao";
            this.observacao.Width = 120;
            // 
            // idAtend
            // 
            this.idAtend.DataPropertyName = "idAtend";
            this.idAtend.HeaderText = "idAtend";
            this.idAtend.Name = "idAtend";
            this.idAtend.Visible = false;
            // 
            // idProduto
            // 
            this.idProduto.DataPropertyName = "idProduto";
            this.idProduto.HeaderText = "idProduto";
            this.idProduto.Name = "idProduto";
            this.idProduto.Visible = false;
            // 
            // idClass
            // 
            this.idClass.DataPropertyName = "idClass";
            this.idClass.HeaderText = "idClass";
            this.idClass.Name = "idClass";
            this.idClass.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(368, 118);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 425);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAtendimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAtendimento_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbPedido.ResumeLayout(false);
            this.grbPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.GroupBox grbPedido;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnInsAtend;
        private System.Windows.Forms.Label lblIdAtend;
        private System.Windows.Forms.Label lblCodAtend;
        private System.Windows.Forms.DataGridView dgvAtendimento;
        private System.Windows.Forms.Label lblIdPed;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAtend;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClass;
        private System.Windows.Forms.Button btnVoltar;
    }
}