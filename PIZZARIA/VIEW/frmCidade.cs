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
    public partial class frmCidade : Form
    {
        public frmCidade()
        {
            InitializeComponent();
        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Cidade lstCidade = new CAMADAS.DAL.Cidade();
            dgvCidade.DataSource = "";
            dgvCidade.DataSource = lstCidade.Select();

            //Carregando Combo Box
            CAMADAS.DAL.Estado lstEst = new CAMADAS.DAL.Estado();
            cmbUf.DisplayMember = "uf";
            cmbUf.ValueMember = "id";
            cmbUf.DataSource = lstEst.SelectCres();

            limparCampos();
        }

        private void limparCampos()
        {
            txtCidade.Text = "";
            cmbUf.Text = "";
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cidade cidade = new CAMADAS.MODEL.Cidade();
            cidade.nome = txtCidade.Text;
            cidade.idEstado = Convert.ToInt32(cmbUf.SelectedValue.ToString());

            CAMADAS.DAL.Cidade dalCid = new CAMADAS.DAL.Cidade();
            dalCid.Insert(cidade);

            dgvCidade.DataSource = "";
            dgvCidade.DataSource = dalCid.Select();

            limparCampos();
        }

        private void DgvCidade_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvCidade.SelectedRows[0].Cells["id"].Value.ToString();
            txtCidade.Text = dgvCidade.SelectedRows[0].Cells["nome"].Value.ToString();
            cmbUf.Text = dgvCidade.SelectedRows[0].Cells["uf"].Value.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cidade cidade = new CAMADAS.MODEL.Cidade();
            cidade.id = Convert.ToInt32(lblId.Text);
            cidade.nome = txtCidade.Text;
            cidade.idEstado = Convert.ToInt32(cmbUf.SelectedValue.ToString());

            CAMADAS.DAL.Cidade dalCid = new CAMADAS.DAL.Cidade();
            dalCid.Update(cidade);

            dgvCidade.DataSource = "";
            dgvCidade.DataSource = dalCid.Select();

            limparCampos();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if(lblId.Text != "")
            {
                int id = Convert.ToInt32(lblId.Text);
                CAMADAS.DAL.Cidade dalCid = new CAMADAS.DAL.Cidade();
                dalCid.Delete(id);

                dgvCidade.DataSource = "";
                dgvCidade.DataSource = dalCid.Select();

                limparCampos();
            }
            else MessageBox.Show("Não há registros a remover!");
        }
    }
}
