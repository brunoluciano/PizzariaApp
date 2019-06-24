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
    public partial class frmClassificacao : Form
    {
        public frmClassificacao()
        {
            InitializeComponent();
        }

        private void FrmClassificacao_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Classificacao dalClass = new CAMADAS.DAL.Classificacao();
            dgvClassificacao.Refresh();
            dgvClassificacao.DataSource = dalClass.Select();
        }
    }
}
