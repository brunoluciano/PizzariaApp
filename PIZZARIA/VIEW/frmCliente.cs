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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            //dgvClientes.DataSource = "";
            dgvClientes.Refresh();
            dgvClientes.DataSource = dalCli.Select();

            //Carregar Combo Box de Cidade
            CAMADAS.DAL.Cidade dalCid = new CAMADAS.DAL.Cidade();
            cmbCidade.DisplayMember = "nome";
            cmbCidade.ValueMember = "id";
            cmbCidade.DataSource = dalCid.SelectCres();

            limparCampos();
        }

        private void limparCampos()
        {
            lblCodigo.Visible = false;
            lblID.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtTelefone.Text = "";
            dtpDt_Nasc.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCEP.Text = "";
            cmbCidade.Text = "";
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cliente cliente = new CAMADAS.MODEL.Cliente();
            cliente.nome = txtNome.Text;
            cliente.cpf = txtCPF.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.dt_nasc = dtpDt_Nasc.Value;
            cliente.endereco = txtEndereco.Text;
            cliente.numero = Convert.ToInt32(txtNumero.Text);
            cliente.complemento = txtComplemento.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cep = Convert.ToInt32(txtCEP.Text);
            cliente.idCidade = Convert.ToInt32(cmbCidade.SelectedValue.ToString());

            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            dalCli.Inserir(cliente);

            //dgvClientes.DataSource = "";
            dgvClientes.Refresh();
            dgvClientes.DataSource = dalCli.Select();

            limparCampos();
        }

        private void DgvClientes_DoubleClick(object sender, EventArgs e)
        {
            lblCodigo.Visible = true;
            lblID.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
            txtCPF.Text = dgvClientes.SelectedRows[0].Cells["cpf"].Value.ToString();
            txtTelefone.Text = dgvClientes.SelectedRows[0].Cells["telefone"].Value.ToString();
            dtpDt_Nasc.Value = Convert.ToDateTime(dgvClientes.SelectedRows[0].Cells["dt_nasc"].Value.ToString());
            txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
            txtNumero.Text = dgvClientes.SelectedRows[0].Cells["numero"].Value.ToString();
            txtComplemento.Text = dgvClientes.SelectedRows[0].Cells["complemento"].Value.ToString();
            txtBairro.Text = dgvClientes.SelectedRows[0].Cells["bairro"].Value.ToString();
            txtCEP.Text = dgvClientes.SelectedRows[0].Cells["cep"].Value.ToString();
            cmbCidade.SelectedValue = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["idCidade"].Value.ToString());

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cliente cliente = new CAMADAS.MODEL.Cliente();
            cliente.id = Convert.ToInt32(lblID.Text);
            cliente.nome = txtNome.Text;
            cliente.cpf = txtCPF.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.dt_nasc = dtpDt_Nasc.Value;
            cliente.endereco = txtEndereco.Text;
            cliente.numero = Convert.ToInt32(txtNumero.Text);
            cliente.complemento = txtComplemento.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cep = Convert.ToInt32(txtCEP.Text);
            cliente.idCidade = Convert.ToInt32(cmbCidade.SelectedValue.ToString());

            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            dalCli.Update(cliente);

            //dgvClientes.DataSource = "";
            dgvClientes.Refresh();
            dgvClientes.DataSource = dalCli.Select();
            
            limparCampos();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblID.Text);
            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            dalCli.Delete(id);

            //dgvClientes.DataSource = "";
            dgvClientes.Refresh();
            dgvClientes.DataSource = dalCli.Select();

            limparCampos();
        }
    }
}
