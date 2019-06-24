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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Produto dalProd = new CAMADAS.DAL.Produto();
            dgvProdutos.Refresh();
            dgvProdutos.DataSource = dalProd.Select();

            //Carregar Combo Box Classificações
            CAMADAS.DAL.Classificacao dalClass = new CAMADAS.DAL.Classificacao();
            cmbClass.DisplayMember = "nome";
            cmbClass.ValueMember = "id";
            cmbClass.DataSource = dalClass.SelectCres();

            limparDados();
        }

        private void limparDados()
        {
            lblID.Text = "";
            lblCodigo.Visible = false;
            txtDescricao.Text = "";
            txtPreco.Text = "";
            cmbClass.Text = "";
        }
    }
}
