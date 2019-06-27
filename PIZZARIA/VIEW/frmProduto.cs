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

            limparCampos();
        }

        private void limparCampos()
        {
            lblID.Text = "";
            lblCodigo.Visible = false;
            txtDescricao.Text = "";
            txtPreco.Text = "";
            cmbClass.Text = "";
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Produto prod = new CAMADAS.MODEL.Produto();
            prod.preco = Convert.ToSingle(txtPreco.Text);
            prod.descricao = txtDescricao.Text;
            prod.idClassificacao = Convert.ToInt32(cmbClass.SelectedValue.ToString());

            CAMADAS.DAL.Produto dalProd = new CAMADAS.DAL.Produto();
            dalProd.Insert(prod);

            dgvProdutos.Refresh();
            dgvProdutos.DataSource = dalProd.Select();

            limparCampos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Produto produto = new CAMADAS.MODEL.Produto();
            produto.id = Convert.ToInt32(lblID.Text);
            produto.descricao = txtDescricao.Text;
            produto.preco = Convert.ToSingle(txtPreco.Text);
            produto.idClassificacao = Convert.ToInt32(cmbClass.SelectedValue.ToString());

            CAMADAS.DAL.Produto dalProd = new CAMADAS.DAL.Produto();
            dalProd.Update(produto);

            dgvProdutos.Refresh();
            dgvProdutos.DataSource = dalProd.Select();

            limparCampos();
        }

        private void DgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            lblCodigo.Visible = true;
            lblID.Text = dgvProdutos.SelectedRows[0].Cells["id"].Value.ToString();
            txtDescricao.Text = dgvProdutos.SelectedRows[0].Cells["descricao"].Value.ToString();
            txtPreco.Text = dgvProdutos.SelectedRows[0].Cells["preco"].Value.ToString();
            cmbClass.SelectedValue = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["idClassificacao"].Value.ToString());
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblID.Text);
            CAMADAS.DAL.Produto dalProd = new CAMADAS.DAL.Produto();
            dalProd.Delete(id);

            dgvProdutos.Refresh();
            dgvProdutos.DataSource = dalProd.Select();

            limparCampos();
        }
    }
}
