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
    public partial class frmAtendimento : Form
    {
        public frmAtendimento()
        {
            InitializeComponent();
        }

        private void FrmAtendimento_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Cliente bllCli = new CAMADAS.BLL.Cliente();
            cmbClientes.DisplayMember = "nome";
            cmbClientes.ValueMember = "id";
            cmbClientes.DataSource = bllCli.Select();
        }
    }
}
