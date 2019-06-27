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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Pedido ped = new CAMADAS.DAL.Pedido();
            dgvPedidos.Refresh();
            dgvPedidos.DataSource = ped.Select();
        }
    }
}
