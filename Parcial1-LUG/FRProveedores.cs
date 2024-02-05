using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_LUG
{
    public partial class FRProveedores : Form
    {
        public FRProveedores()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRProveedores_Load(object sender, EventArgs e)
        {
            oBLLProveedor = new BLLProveedor();
            CargarProveedores();
            Limpiar();

        }

        BLLProveedor oBLLProveedor;


        private void CargarProveedores()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = oBLLProveedor.listarTodo();

        }


        private void Limpiar()
        {
            txtIdProveedor.Text = "0";
            txtRazonSocial.Text = "";
            txtCuit.Text = "";
        }

        private BEProveedor CargaProveedor()
        {
            BEProveedor oBEProveedor = new BEProveedor();

            oBEProveedor.cuit = Convert.ToInt32(txtCuit.Text);
            oBEProveedor.razonSocial = txtRazonSocial.Text;
            oBEProveedor.codigo = Convert.ToInt32(txtIdProveedor.Text);

            return oBEProveedor;

        }

        private void alta()
        {
            if (oBLLProveedor.Guardado(CargaProveedor()) == true)
            {
                MessageBox.Show("Se ha dado correctamente el alta");
                CargarProveedores();
            }
            else
            {
                MessageBox.Show("El CUIT se encuentra repetido, favor de verificarlo");
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            alta();
        }
    }
}
