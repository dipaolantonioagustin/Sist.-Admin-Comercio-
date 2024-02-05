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
    public partial class FRCompras : Form
    {
        public FRCompras()
        {
            InitializeComponent();
        }

        private void FRCompras_Load(object sender, EventArgs e)
        {
            oBLLProductoElectro = new BLLProductoElectro();
            oBLLProductoPintura = new BLLProductoPintura();
            oBLLCategorias = new BLLCategorias();
            oBLLProveedor = new BLLProveedor();
            oBLLMedida = new BLLMedida();
            oBLLCliente = new BLLCliente();
            oBLLProducto = new BLLProducto();

            CargarProductosTodos();
            CargarComboCliente();

        }


        BLLProductoElectro oBLLProductoElectro;
        BLLProductoPintura oBLLProductoPintura;
        BLLCategorias oBLLCategorias;
        BLLProveedor oBLLProveedor;
        BLLMedida oBLLMedida;
        List<BEProducto> listaProductos = new List<BEProducto>();
        BLLCliente oBLLCliente;
        BLLProducto oBLLProducto;


        #region Métodos

        private List<BEProducto> listaProductosTotales()
        {
            List<BEProducto> listaProductosTotales = new List<BEProducto>();

            listaProductosTotales.AddRange(oBLLProductoElectro.listarTodo());
            listaProductosTotales.AddRange(oBLLProductoPintura.listarTodo());

            return listaProductosTotales;
        }

        private void validarCantidad(BEProducto producto)
        {
            if(producto.cantidad < Convert.ToInt32(txtCantidadPedido.Text))
            {
                throw new Exception("No es posible realizar la carga, el stock resulta insuficiente");
                 // MessageBox.Show("No es posible realizar la carga, el stock resulta insuficiente");
            }
        }

        private void mostrarProducto(BEProducto producto)
       {
            if(producto is BEProductoElectro)
            {
                BEProductoElectro oBEPE = (BEProductoElectro)producto;

                txtProducto.Text = oBEPE.ToString();
                txtValorUnitario.Text = oBEPE.precioUnidad.ToString();
                txtCantidadDisponible.Text = oBEPE.cantidad.ToString();


            }
            else
            {
                BEProductoPintura oBEPP = (BEProductoPintura)producto;

                txtProducto.Text = oBEPP.ToString();
                txtValorUnitario.Text = oBEPP.precioUnidad.ToString();
                txtCantidadDisponible.Text = oBEPP.cantidad.ToString();

            }

       }

        private bool impactarTablas(BECliente cliente,BEProducto productoStock, List<BEProducto> listaProductos)
        {
            bool resultado;

            foreach (BEProducto productoCompra in listaProductos)
            {
               resultado = oBLLProducto.GuardadoCompra(productoStock,productoCompra, cliente); 
            }

            resultado = oBLLCliente.ActualizarDescuentos(cliente);

            return resultado; 


        }

        #region Métodos Carrito

        private BEProducto preparadoCarrito(BEProducto producto)
        {
           if(producto is BEProductoElectro)
            {
                BEProductoElectro oBEProductoelectroCarrito = new BEProductoElectro((BEProductoElectro)producto);
                oBEProductoelectroCarrito.cantidad = Convert.ToInt32(txtCantidadPedido.Text);
                return oBEProductoelectroCarrito;

            }
            else
            {
                BEProductoPintura oBEProductoPinturaCarrito = new BEProductoPintura((BEProductoPintura)producto);
                oBEProductoPinturaCarrito.cantidad = Convert.ToInt32(txtCantidadPedido.Text);
                return oBEProductoPinturaCarrito;
            }
       }

        private float calcularCarrito(List<BEProducto> productos)
        {
            float total = (from x in productos select (x.cantidad * x.precioUnidad)).Sum();
            return total;
        }


        private void cargaListBoxCarrito(List<BEProducto> listaProductos)
        {
            lsbCarrito.DataSource = null;
            lsbCarrito.DataSource = listaProductos.ToArray();
        }
        private void CargaCarrito(BEProducto producto)
        {
           

            if (listaProductos.Exists(x => x.codigo == producto.codigo))
            {
                MessageBox.Show("Ya se encuentra en la lista el producto que desea ingresar");
            }
            else
            {
                if (producto is BEProductoElectro)
                {
                    
                    BEProductoElectro oBEPE = new BEProductoElectro((BEProductoElectro)producto);

                    listaProductos.Add(oBEPE);
                }
                else
                {
                    BEProductoPintura oBEPP = new BEProductoPintura((BEProductoPintura)producto);

                    listaProductos.Add(oBEPP);
                }

            }

        }
        private void CargarLabelsCarrito() 
        {
            lblDescuento.Text = (oBLLCliente.ComprarDescuento(listaProductos)).ToString();
            lblTotalConDescuento.Text = (calcularCarrito(listaProductos) - oBLLCliente.ComprarDescuento(listaProductos)).ToString();
            lblTotalCarrito.Text = (calcularCarrito(listaProductos)).ToString();

           
        }

        #endregion




        private void DescuentoAplicado(BECliente cliente, List<BEProducto> listaProductos)
        {
            float descuento = oBLLCliente.ComprarDescuento(listaProductos);
            cliente.descuentosAcumulados += descuento;
            MessageBox.Show($"El descuent oobtenido es de $ {descuento.ToString()}");

        }

        private void MostrarDescuentosAcumulados(BECliente cliente, List<BEProducto> listaProductos)
        {
            lblDescuentosAcumulados.Text = cliente.descuentosAcumulados.ToString();
           
        }
        private void CargaDataProductosCliente(BECliente cliente)
        {
            dataGridViewRegistroComprasCliente.DataSource = null;
            dataGridViewRegistroComprasCliente.DataSource = oBLLCliente.ListarPorductosCompras(cliente);
            
        }


        #endregion


        #region Cargas Generales Métodos



        private void CargarComboCliente()
        {
            cmbClientes.DataSource = null;
            cmbClientes.DataSource = oBLLCliente.listarTodo(); 
            cmbClientes.DisplayMember = "nombre";
            cmbClientes.ValueMember = "codigo";


        }


        private void CargarProductosTodos()
        {
            dataGridViewProductos.DataSource = null;
            dataGridViewProductos.DataSource = listaProductosTotales();

        }

        private void CargaProductosElectro()
        {
            dataGridViewProductos.DataSource = null;
            dataGridViewProductos.DataSource = oBLLProductoElectro.listarTodo().ToArray();
        }

        private void CargaProductosPintura()
        {

            dataGridViewProductos.DataSource = null;

            dataGridViewProductos.DataSource = oBLLProductoPintura.listarTodo().ToArray();

        }


        private void LimpiarCarritoAll()
        {
            lblDescuento.Text = String.Empty;
            lblTotalCarrito.Text = String.Empty;
            lblTotalConDescuento.Text= String.Empty;
            listaProductos.Clear();
            lsbCarrito.DataSource = null;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        #endregion



        #region botones
        private void btnPintura_Click(object sender, EventArgs e)
        {
            CargaProductosPintura();
        }

        private void btnElectro_Click(object sender, EventArgs e)
        {
            CargaProductosElectro();
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            CargarProductosTodos();
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarProducto((BEProducto)dataGridViewProductos.CurrentRow.DataBoundItem);
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                validarCantidad((BEProducto)dataGridViewProductos.CurrentRow.DataBoundItem);
                CargaCarrito(preparadoCarrito((BEProducto)dataGridViewProductos.CurrentRow.DataBoundItem));
                cargaListBoxCarrito(listaProductos);
               
                CargarLabelsCarrito();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmarCarrito_Click(object sender, EventArgs e)
        {
            DescuentoAplicado((BECliente)cmbClientes.SelectedItem, listaProductos);
            if (impactarTablas((BECliente)cmbClientes.SelectedItem, (BEProducto)dataGridViewProductos.CurrentRow.DataBoundItem, listaProductos) == false )
            {
                MessageBox.Show("Error"); 
            
            }
            else
            {
                
                CargarProductosTodos();
                CargaDataProductosCliente((BECliente)cmbClientes.SelectedItem);
                MostrarDescuentosAcumulados((BECliente)cmbClientes.SelectedItem, listaProductos);
                LimpiarCarritoAll();


            }

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaDataProductosCliente((BECliente)cmbClientes.SelectedItem);
            MostrarDescuentosAcumulados((BECliente)cmbClientes.SelectedItem, listaProductos);
        }

        #endregion
    }
}
