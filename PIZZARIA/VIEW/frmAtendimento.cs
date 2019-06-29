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

            lblIdAtend.Text = "0";
            AttTotal();
            limparCampos();
        }

        private void limparCampos()
        {
            cmbClientes.SelectedText = "";
            cmbProduto.SelectedText = "";
            nudQuantidade.Value = 1;
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

            Voltar(false);

            AttTotal();
        }

        private void DgvAtendimento_DoubleClick(object sender, EventArgs e)
        {
            lblIdAtend.Text = dgvAtendimento.SelectedRows[0].Cells["id"].Value.ToString();
            cmbClientes.SelectedValue = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["idCliente"].Value.ToString());

            CAMADAS.BLL.Pedido bllPed = new CAMADAS.BLL.Pedido();
            dgvPedidos.Refresh();
            dgvPedidos.DataSource = bllPed.SelectByFkID(Convert.ToInt32(lblIdAtend.Text));

            Voltar(false);

            AttTotal();
            limparCampos();
        }

        private void AttTotal()
        {
            CAMADAS.MODEL.Pedido ped = new CAMADAS.MODEL.Pedido();
            ped.idAtend = Convert.ToInt32(lblIdAtend.Text);

            CAMADAS.DAL.Atendimento dalAtend = new CAMADAS.DAL.Atendimento();
            float total = 0;
            total = Convert.ToSingle(dalAtend.Total(ped.idAtend, total).ToString());
            txtTotal.Text = total.ToString();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Pedido ped = new CAMADAS.MODEL.Pedido();
            ped.idAtend = Convert.ToInt32(lblIdAtend.Text);
            ped.idProduto = Convert.ToInt32(cmbProduto.SelectedValue.ToString());
            ped.quantidade = Convert.ToInt32(nudQuantidade.Value.ToString());
            ped.idClass = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            ped.observacao = txtObs.Text.ToString();

            CAMADAS.DAL.Pedido dalPed = new CAMADAS.DAL.Pedido();
            dalPed.Inserir(ped);
            dgvPedidos.Refresh();
            dgvPedidos.DataSource = dalPed.SelectByFkID(ped.idAtend);

            AttTotal();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Pedido ped = new CAMADAS.MODEL.Pedido();
            ped.idAtend = Convert.ToInt32(lblIdAtend.Text);
            ped.id = Convert.ToInt32(lblIdPed.Text);
            ped.observacao = txtObs.Text.ToString();
            ped.idProduto = Convert.ToInt32(cmbProduto.SelectedValue);
            ped.quantidade = Convert.ToInt32(nudQuantidade.Value);

            CAMADAS.DAL.Pedido dalPed = new CAMADAS.DAL.Pedido();
            dalPed.Update(ped);

            dgvPedidos.Refresh();
            dgvPedidos.DataSource = dalPed.SelectByFkID(ped.idAtend);

            AttTotal();
        }

        private void DgvPedidos_DoubleClick(object sender, EventArgs e)
        {
            grbPedido.Visible = true;
            lblIdPed.Text = dgvPedidos.SelectedRows[0].Cells["id"].Value.ToString();
            cmbClass.SelectedValue = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells["idClass"].Value.ToString());
            cmbProduto.SelectedValue = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells["idProduto"].Value.ToString());
            nudQuantidade.Value = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells["quantidade"].Value.ToString());
            txtObs.Text = dgvPedidos.SelectedRows[0].Cells["observacao"].Value.ToString();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblIdPed.Text);
            int fk = Convert.ToInt32(lblIdAtend.Text);

            CAMADAS.DAL.Pedido dalPed = new CAMADAS.DAL.Pedido();
            dalPed.Delete(id);

            dgvPedidos.Refresh();
            dgvPedidos.DataSource = dalPed.SelectByFkID(fk);

            AttTotal();
            limparCampos();
        }

        private void Voltar(bool status)
        {
            grbPedido.Visible = !status;
            cmbClientes.Enabled = status;
            btnInsAtend.Visible = status;
            btnFinalizar.Visible = !status;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Voltar(true);

            lblIdAtend.Text = "0";
            AttTotal();
        }
    }
}
