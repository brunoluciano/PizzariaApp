namespace PIZZARIA.VIEW
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.cidadeToolStripMenuItem,
            this.estadoToolStripMenuItem,
            this.toolStripSeparator1,
            this.produtoToolStripMenuItem,
            this.classificaçãoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
            this.cadastrarToolStripMenuItem.Text = "&Cadastrar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::PIZZARIA.Properties.Resources.iconUser;
            this.clienteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.clienteToolStripMenuItem.Text = "&Cliente";
            this.clienteToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.cidadeToolStripMenuItem.Text = "C&idade";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.CidadeToolStripMenuItem_Click);
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.estadoToolStripMenuItem.Text = "&Estado";
            this.estadoToolStripMenuItem.Click += new System.EventHandler(this.EstadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.produtoToolStripMenuItem.Text = "&Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.ProdutoToolStripMenuItem_Click);
            // 
            // classificaçãoToolStripMenuItem
            // 
            this.classificaçãoToolStripMenuItem.Name = "classificaçãoToolStripMenuItem";
            this.classificaçãoToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.classificaçãoToolStripMenuItem.Text = "C&lassificação";
            this.classificaçãoToolStripMenuItem.Click += new System.EventHandler(this.ClassificaçãoToolStripMenuItem_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesaToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.movimentaçãoToolStripMenuItem.Text = "&Movimentação";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(57, 28);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // mesaToolStripMenuItem
            // 
            this.mesaToolStripMenuItem.Name = "mesaToolStripMenuItem";
            this.mesaToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.mesaToolStripMenuItem.Text = "&Mesa";
            this.mesaToolStripMenuItem.Click += new System.EventHandler(this.MesaToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::PIZZARIA.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 745);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicação de Gerenciamento de PIZZARIA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesaToolStripMenuItem;
    }
}