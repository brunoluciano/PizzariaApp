namespace PIZZARIA.VIEW
{
    partial class frmClassificacao
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
            this.dgvClassificacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassificacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassificacao
            // 
            this.dgvClassificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassificacao.Location = new System.Drawing.Point(140, 223);
            this.dgvClassificacao.Name = "dgvClassificacao";
            this.dgvClassificacao.Size = new System.Drawing.Size(322, 150);
            this.dgvClassificacao.TabIndex = 0;
            // 
            // frmClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClassificacao);
            this.Name = "frmClassificacao";
            this.Text = "frmClassificacao";
            this.Load += new System.EventHandler(this.FrmClassificacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassificacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassificacao;
    }
}