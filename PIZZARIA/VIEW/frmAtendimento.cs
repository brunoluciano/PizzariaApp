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
            cmbClientes.DataSource = bllCli.SelectCres();

            CAMADAS.DAL.Classificacao dalClass = new CAMADAS.DAL.Classificacao();
            cmbClass.DisplayMember = "nome";
            cmbClass.ValueMember = "id";
            cmbClass.DataSource = dalClass.SelectCres();

            CAMADAS.DAL.Atendimento dalAtend = new CAMADAS.DAL.Atendimento();
            dgvAtendimento.Refresh();
            dgvAtendimento.DataSource = dalAtend.Select();

            limparCampos();
        }

        private void limparCampos()
        {
            cmbClientes.Text = "";
            cmbProduto.Text = "";
            nudQuantidade.Value = 0;
        }

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            cmbProduto.DisplayMember = "descricao";
            cmbProduto.ValueMember = "id";
            int fk = Convert.ToInt32(cmbClass.SelectedValue);
            cmbProduto.DataSource = bllProd.SelectByFkID(fk);

        }

        private void BtnInsAtend_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Atendimento atend = new CAMADAS.MODEL.Atendimento();
            atend.idCliente = Convert.ToInt32(cmbClientes.SelectedValue.ToString());

            CAMADAS.DAL.Atendimento dalAtend = new CAMADAS.DAL.Atendimento();
            dalAtend.Inserir(atend);

            dgvAtendimento.Refresh();
            dgvAtendimento.DataSource = dalAtend.Select();
        }
    }
}
