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

        private void limparCampos()
        {
            lblId.Text = "";
            lblStatus.Text = "";
            nudQtdLugares.Value = 0;
            txtNumero.Text = "";
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Mesa mesa = new CAMADAS.MODEL.Mesa();
            mesa.qtdLugares = Convert.ToInt32(nudQtdLugares.Value);
            mesa.numero = Convert.ToInt32(txtNumero.Text);
            mesa.status = false;

            CAMADAS.DAL.Mesa dalMesa = new CAMADAS.DAL.Mesa();
            dalMesa.Insert(mesa);

            dgvMesa.DataSource = "";
            dgvMesa.DataSource = dalMesa.Select();

            limparCampos();
        }

        private void DgvMesa_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvMesa.SelectedRows[0].Cells["id"].Value.ToString();
            lblStatus.Text = dgvMesa.SelectedRows[0].Cells["status"].Value.ToString();
            nudQtdLugares.Value = Convert.ToInt32(dgvMesa.SelectedRows[0].Cells["qtdLugares"].Value.ToString());
            txtNumero.Text = dgvMesa.SelectedRows[0].Cells["numero"].Value.ToString();
        }

        private void DgvMesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Mesa mesa = new CAMADAS.MODEL.Mesa();
            mesa.id = Convert.ToInt32(lblId.Text);
            mesa.qtdLugares = Convert.ToInt32(nudQtdLugares.Value);
            mesa.numero = Convert.ToInt32(txtNumero.Text);

            CAMADAS.DAL.Mesa dalMesa = new CAMADAS.DAL.Mesa();
            dalMesa.Update(mesa);

            dgvMesa.DataSource = "";
            dgvMesa.DataSource = dalMesa.Select();

            limparCampos();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if(lblId.Text != "")
            {
                DialogResult resp = MessageBox.Show("Deseja memso remover?", "Deletar", MessageBoxButtons.YesNo);
                if (resp.ToString().ToUpper() == "YES")
                {
                    int id = Convert.ToInt32(lblId.Text);
                    CAMADAS.DAL.Mesa dalMesa = new CAMADAS.DAL.Mesa();
                    dalMesa.Delete(id);

                    dgvMesa.DataSource = "";
                    dgvMesa.DataSource = dalMesa.Select();

                    limparCampos();
                }
            }
            else MessageBox.Show("Não há regirto de mesa para remover", "Remover");
        }

    }
}
