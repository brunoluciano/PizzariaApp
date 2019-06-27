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
    public partial class frmMesa : Form
    {
        public frmMesa()
        {
            InitializeComponent();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Mesa dalMesa = new CAMADAS.DAL.Mesa();
            dgvMesa.DataSource = "";
            dgvMesa.DataSource = dalMesa.Select();
        }
    }
}
