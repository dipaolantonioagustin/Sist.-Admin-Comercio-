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
    public partial class FRInformes : Form
    {
        public FRInformes()
        {
            InitializeComponent();
        }

        private void FRInformes_Load(object sender, EventArgs e)
        {
            oBLLCliente = new BLLCliente();
            oBLLProductoElectro = new BLLProductoElectro();
            oBLLProductoPintura = new BLLProductoPintura();

            MaxElectroVendido();
            MinPinturaVendido();
            CargaClienteSegunDescuentos();

        }


        BLLCliente oBLLCliente;
        BLLProductoElectro oBLLProductoElectro;
        BLLProductoPintura oBLLProductoPintura;

        private void CargaClienteSegunDescuentos()
        {
            List<BECliente> listaClientes = oBLLCliente.listarTodo();

            listaClientes = listaClientes.OrderByDescending(x => x.descuentosAcumulados).ToList();


            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaClientes;


        }

        private void MaxElectroVendido()
        {
            lblMaxElectro.Text = "Descripción" + "-" +(oBLLCliente.ProductoElectricoMasSolicitado()).descripcion + "-" +"Código" + "-" + (oBLLCliente.ProductoElectricoMasSolicitado()).codigo;
        }


        private void MinPinturaVendido()    
        {
            lblPinturaMenos.Text = "Descripción" + "-" +(oBLLCliente.ProductoPinturaMenosSolicitado()).descripcion +"-" + "Código" + "-" + +(oBLLCliente.ProductoPinturaMenosSolicitado()).codigo + "-" + "Marca" + "-"+(oBLLCliente.ProductoPinturaMenosSolicitado()).marca;
        }

        private void CargaDataGridProductosCliente(BECliente cliente)
        {
            dgvProductosCliente.DataSource = null;
            dgvProductosCliente.DataSource = oBLLCliente.ListarPorductosCompras(cliente);


        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaDataGridProductosCliente((BECliente)dgvClientes.CurrentRow.DataBoundItem);
        }


        private List<BEProducto> listaProductosTotales()
        {
            List<BEProducto> listaProductosTotales = new List<BEProducto>();


            listaProductosTotales.AddRange(oBLLProductoElectro.listarTodo());

            listaProductosTotales.AddRange(oBLLProductoPintura.listarTodo());


            return listaProductosTotales;


        }

        private List<BEProductoElectro> listaProductosElectro()
        {
            List<BEProductoElectro> listaProductos = new List<BEProductoElectro>();


            listaProductos.AddRange(oBLLProductoElectro.listarTodo());



            return listaProductos;


        }



        private List<BEProductoPintura> listaProductosPintura()
        {
            List<BEProductoPintura> listaProductos = new List<BEProductoPintura>();

            listaProductos.AddRange(oBLLProductoPintura.listarTodo());


            return listaProductos;


        }

        private void CargaDgvElectro()
        {
            dgvStockTotal.DataSource = null;
            dgvStockTotal.DataSource = listaProductosElectro();
        }

        private void CargaDgvPintura()
        {
            dgvStockTotal.DataSource = null;
            dgvStockTotal.DataSource = listaProductosPintura();
        }

        private void CargaDgvTotal()
        {
            dgvStockTotal.DataSource = null;
            dgvStockTotal.DataSource = listaProductosTotales();
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            CargaDgvTotal();
        }

        private void btnElectro_Click(object sender, EventArgs e)
        {
            CargaDgvElectro();
        }

        private void btnPintura_Click(object sender, EventArgs e)
        {
            CargaDgvPintura();
        }
    }

}
