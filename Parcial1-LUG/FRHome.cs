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
    public partial class FRHome : Form
    {
        public FRHome()
        {
            InitializeComponent();
        }
        

       

        private void FRHome_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aMBStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 AMBStock = new Form1();
            AMBStock.MdiParent = this;
            AMBStock.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRCompras Compras = new FRCompras();
            Compras.MdiParent = this;
            Compras.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FRProveedores Proveedores = new FRProveedores();
            Proveedores.MdiParent = this;
            Proveedores.Show();
        }

        private void informesGeneralesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FRInformes Informes = new FRInformes();
            Informes.MdiParent = this;
            Informes.Show();
        }
    }
}
