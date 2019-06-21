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
    public partial class frmEstado : Form
    {
        public frmEstado()
        {
            InitializeComponent();
        }

        private void FrmEstado_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Estado dalEstado = new CAMADAS.DAL.Estado();
            dgvEstado.DataSource = "";
            dgvEstado.DataSource = dalEstado.Select();
        }
    }
}
