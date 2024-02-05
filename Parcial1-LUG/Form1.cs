using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using System.Drawing.Printing;

namespace Parcial1_LUG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oBLLProductoElectro = new BLLProductoElectro();
            oBLLProductoPintura = new BLLProductoPintura();
            oBLLCategorias = new BLLCategorias();
            oBLLProveedor = new BLLProveedor();
            oBLLMedida = new BLLMedida();


            CargaComboCateogrias();
            CargaComboProveedor();
            CargaComboMedida();
            CargaComboTipos();
            Limpiar();

        }
        #region Instancias Objetos Genéricos
        BLLProductoElectro oBLLProductoElectro;
        BLLProductoPintura oBLLProductoPintura ;
        BLLCategorias oBLLCategorias;
        BLLProveedor oBLLProveedor;
        BLLMedida oBLLMedida;

       
        #endregion


        #region Cargas Generales
        private void CargaComboMedida()
        {
            cmbTipoMedida.DataSource = oBLLMedida.listarTodo();
            cmbTipoMedida.DisplayMember = "nombre";
            cmbTipoMedida.ValueMember = "codigo";
        }

        private void SeleccionItem(BEProducto producto) // revisar
        {
            
            if (producto is BEProductoElectro)
            {
                BEProductoElectro oBEPEC = (BEProductoElectro)producto;

                cmbTipoProducto.Text = tipoProducto.Electricidad.ToString();
                txtDescripcion.Text = oBEPEC.descripcion;
                cmbTipoMedida.Text = oBEPEC.medicion.ToString();
                txtMedida.Text = oBEPEC.medida.ToString();
                txtPrecioUnitario.Text = oBEPEC.precioUnidad.ToString();
                cmbProveedor.Text = oBEPEC.proveedor.razonSocial.ToString();
                txtCantidad.Text = oBEPEC.cantidad.ToString();
                txtCodigo.Text = oBEPEC.codigo.ToString();
                txtColor.Text = String.Empty;
                txtMarca.Text = oBEPEC.marca.ToString();
                cmbCategorias.Text = oBEPEC.categoria.nombre.ToString();
                txtColor.Text = String.Empty;
                cmbTipoProducto.Text = tipoProducto.Electricidad.ToString();

            }
            else
            {
                BEProductoPintura oBEPPC = (BEProductoPintura)producto;

                cmbTipoProducto.Text = tipoProducto.Electricidad.ToString();
                txtDescripcion.Text = oBEPPC.descripcion;
                cmbTipoMedida.Text = oBEPPC.medicion.ToString();
                txtMedida.Text = oBEPPC.medida.ToString();
                txtPrecioUnitario.Text = oBEPPC.precioUnidad.ToString();
                cmbProveedor.Text = oBEPPC.proveedor.razonSocial.ToString();
                txtCantidad.Text = oBEPPC.cantidad.ToString();
                txtCodigo.Text = oBEPPC.codigo.ToString();
                txtMarca.Text = oBEPPC.marca.ToString();
                txtColor.Text = oBEPPC.color.ToString();
                cmbCategorias.Text = null;
                cmbTipoProducto.Text = tipoProducto.Pintura.ToString();
            }


        }

        private void CargaComboProveedor()
        {
            cmbProveedor.DataSource = oBLLProveedor.listarTodo();
            cmbProveedor.DisplayMember = "razonSocial";
            cmbProveedor.ValueMember = "codigo";
        }

        private void CargaComboCateogrias()
        {
            cmbCategorias.DataSource = oBLLCategorias.listarTodo();
            cmbCategorias.DisplayMember = "nombre";
            cmbCategorias.ValueMember = "codigo";

        }
        private List<BEProducto> listaProductosTotales()
        {
            List<BEProducto> listaProductosTotales = new List<BEProducto>();
             
           
            listaProductosTotales.AddRange(oBLLProductoElectro.listarTodo());

            listaProductosTotales.AddRange(oBLLProductoPintura.listarTodo());
            
          
            return listaProductosTotales;

            
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

        private void CargaComboTipos()
        {
            cmbTipoProducto.DataSource = Enum.GetValues(typeof(tipoProducto));
        }

        

        #endregion

        #region Métodos Generales

        private void Carga()
        {
            if ((tipoProducto)cmbTipoProducto.SelectedIndex is tipoProducto.Electricidad)
            {

                oBLLProductoElectro.Guardado(CargaElectro());
                Limpiar();
                CargarProductosTodos();

            }
            else if((tipoProducto)cmbTipoProducto.SelectedIndex is tipoProducto.Pintura)
            {
                oBLLProductoPintura.Guardado(CargaPintura());
                Limpiar();
                CargarProductosTodos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el tipo de producto");
            }

        }

        private void Limpiar()
        {
            cmbTipoProducto.Text = null;
            txtDescripcion.Text = string.Empty;
            cmbTipoMedida.Text = string.Empty;
            cmbTipoMedida.Text = null;
            txtMedida.Text = null;
            txtPrecioUnitario.Text = String.Empty;
            cmbProveedor.Text = null;
            txtCantidad.Text = String.Empty;
            txtCodigo.Text = "0";
            txtColor.Text  = String.Empty;
            txtMarca.Text  =String.Empty;
            cmbCategorias.Text = null;


        }



        private BEProductoPintura CargaPintura()
        {
            BEProductoPintura oBEPintruaCarga = new BEProductoPintura();

            oBEPintruaCarga.descripcion = txtDescripcion.Text;
            
            BEMedidas oBEMedidas = new BEMedidas();

            oBEMedidas.codigo = ((BEMedidas)cmbTipoMedida.SelectedItem).codigo;
            oBEMedidas.nombre = ((BEMedidas)cmbTipoMedida.SelectedItem).nombre;
            
            oBEPintruaCarga.medicion = oBEMedidas;

            oBEPintruaCarga.medida = float.Parse(txtMedida.Text);
            oBEPintruaCarga.precioUnidad = float.Parse(txtPrecioUnitario.Text);
            
            BEProveedor oBEProveedor = new BEProveedor();

            oBEProveedor.codigo = ((BEProveedor)cmbProveedor.SelectedItem).codigo;
            oBEProveedor.cuit = ((BEProveedor)cmbProveedor.SelectedItem).cuit;
            oBEProveedor.razonSocial = ((BEProveedor)cmbProveedor.SelectedItem).razonSocial;

            oBEPintruaCarga.proveedor = oBEProveedor;

           
            oBEPintruaCarga.cantidad = Convert.ToInt32(txtCantidad.Text);
            oBEPintruaCarga.codigo = Convert.ToInt32(txtCodigo.Text);
            oBEPintruaCarga.color  = txtColor.Text;
            oBEPintruaCarga.marca = txtMarca.Text;

            return oBEPintruaCarga;


        }




        private BEProductoElectro CargaElectro()
        {
            BEProductoElectro oBEProductoCarga = new BEProductoElectro();

            oBEProductoCarga.descripcion = txtDescripcion.Text;

            BEMedidas oBEMedidas = new BEMedidas();

            oBEMedidas.codigo = ((BEMedidas)cmbTipoMedida.SelectedItem).codigo;
            oBEMedidas.nombre = ((BEMedidas)cmbTipoMedida.SelectedItem).nombre;

            oBEProductoCarga.medicion = oBEMedidas;

                  
            BEProveedor oBEProveedor = new BEProveedor();

            oBEProveedor.codigo = ((BEProveedor)cmbProveedor.SelectedItem).codigo;
            oBEProveedor.cuit = ((BEProveedor)cmbProveedor.SelectedItem).cuit;
            oBEProveedor.razonSocial = ((BEProveedor)cmbProveedor.SelectedItem).razonSocial;

            oBEProductoCarga.proveedor = oBEProveedor;

            oBEProductoCarga.medida = float.Parse(txtMedida.Text);
            oBEProductoCarga.cantidad = Convert.ToInt32(txtCantidad.Text);
            oBEProductoCarga.codigo = Convert.ToInt32(txtCodigo.Text);
           
            BECategorias oBECategoriaCarga = new BECategorias();

            oBECategoriaCarga.codigo = ((BECategorias)cmbCategorias.SelectedItem).codigo;
            oBECategoriaCarga.nombre = ((BECategorias)cmbCategorias.SelectedItem).nombre;

            oBEProductoCarga.categoria = oBECategoriaCarga;
            oBEProductoCarga.precioUnidad = float.Parse(txtPrecioUnitario.Text);
            
            oBEProductoCarga.marca = txtMarca.Text;

            return oBEProductoCarga;


        }

        private void baja()
        {
            if ((tipoProducto)cmbTipoProducto.SelectedIndex is tipoProducto.Electricidad)
            {

                oBLLProductoElectro.Baja(CargaElectro());
                Limpiar();
                CargarProductosTodos();

            }
            else if ((tipoProducto)cmbTipoProducto.SelectedIndex is tipoProducto.Pintura)
            {
                oBLLProductoPintura.Baja(CargaPintura());
                Limpiar();
                CargarProductosTodos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el tipo de producto");
            }

        }


        private List<BEProducto> BusquedaFaltantes(int margen)
        {
            List<BEProducto> listadofaltantes = new List<BEProducto>();

            List<BEProducto> listaTotal = listaProductosTotales();

            listadofaltantes =(from x in listaTotal where x.cantidad <= margen select x).ToList(); 

            return listadofaltantes;

        }

        #endregion



        #region Botones
        private void btnPintura_Click(object sender, EventArgs e)
        {
            CargaProductosPintura();
        }

        private void btnElectro_Click(object sender, EventArgs e)
        {
            CargaProductosElectro();

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CargarProductosTodos();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "0") { Carga(); } else { MessageBox.Show("El número de Producto ya se encuentra registrado"); }
        }

        private void cmbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((tipoProducto)cmbTipoProducto.SelectedIndex is tipoProducto.Electricidad)
            {
                cmbCategorias.Enabled = true;
                txtColor.Enabled = false;

            }
            else
            {
                cmbCategorias.Enabled = false;
                txtColor.Enabled = true;
            }
        }



        #endregion

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SeleccionItem((BEProducto)dataGridViewProductos.CurrentRow.DataBoundItem);




        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "0") { Carga(); } else { MessageBox.Show("El Producto no se encuentra registrado, realice el alta"); }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            baja();
        }

        private void btnFaltantes_Click(object sender, EventArgs e)
        {
            dgvFaltantes.DataSource = null;
            dgvFaltantes.DataSource = BusquedaFaltantes(Convert.ToInt32(txtFalantes.Text));


        }

        private void dgvFaltantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SeleccionItem((BEProducto)dgvFaltantes.CurrentRow.DataBoundItem);
        }
    }

    enum tipoProducto {Electricidad, Pintura};
  
}
