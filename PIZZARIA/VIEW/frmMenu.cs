using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZARIA.VIEW
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstado frmEst = new frmEstado();
            frmEst.MdiParent = this;
            frmEst.Show();
        }

        private void CidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade frmCid = new frmCidade();
            frmCid.MdiParent = this;
            frmCid.Show();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frmProd = new frmProduto();
            frmProd.MdiParent = this;
            frmProd.Show();
        }

        private void ClassificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassificacao frmClass = new frmClassificacao();
            frmClass.MdiParent = this;
            frmClass.Show();
        }

        private void PedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedido frmPed = new frmPedido();
            frmPed.MdiParent = this;
            frmPed.Show();
        }

        private void AtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendimento frmAten = new frmAtendimento();
            frmAten.MdiParent = this;
            frmAten.Show();
        }

        private void MesaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMesa frmMes = new frmMesa();
            frmMes.MdiParent = this;
            frmMes.Show();
        }
    }
}
