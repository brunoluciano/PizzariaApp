namespace PIZZARIA.VIEW
{
    partial class frmCidade
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
            this.dgvCidade = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCidade
            // 
            this.dgvCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.uf,
            this.idEstado});
            this.dgvCidade.Location = new System.Drawing.Point(98, 269);
            this.dgvCidade.Name = "dgvCidade";
            this.dgvCidade.Size = new System.Drawing.Size(548, 132);
            this.dgvCidade.TabIndex = 0;
            this.dgvCidade.DoubleClick += new System.EventHandler(this.DgvCidade_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "CIDADE";
            this.nome.Name = "nome";
            this.nome.Width = 200;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf";
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.Width = 50;
            // 
            // idEstado
            // 
            this.idEstado.DataPropertyName = "idEstado";
            this.idEstado.HeaderText = "idEstado";
            this.idEstado.Name = "idEstado";
            this.idEstado.Visible = false;
            this.idEstado.Width = 5;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(208, 41);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(338, 41);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 13);
            this.lblUf.TabIndex = 2;
            this.lblUf.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(211, 66);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 3;
            // 
            // cmbUf
            // 
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(341, 66);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(63, 21);
            this.cmbUf.TabIndex = 4;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(152, 219);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(253, 218);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(140, 64);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(49, 23);
            this.lblId.TabIndex = 7;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(149, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(18, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "ID";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(355, 218);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // frmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.cmbUf);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.dgvCidade);
            this.Name = "frmCidade";
            this.Text = "frmCidade";
            this.Load += new System.EventHandler(this.FrmCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnRemover;
    }
}