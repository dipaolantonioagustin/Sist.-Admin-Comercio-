using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;
using Abstraccion;
using System.ComponentModel.Design;

namespace BLL
{
    public class BLLCliente : IGestionesBase<BECliente>
    {
        MPPCliente oMPPCliente = new MPPCliente();
        public bool Baja(BECliente objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardado(BECliente objeto)
        {
            throw new NotImplementedException();
        }

        public List<BECliente> listarTodo()
        {
            return oMPPCliente.listarTodo();
        }

        public List<BEProductoElectro> ListarProductosElectroCliente()
        {
            return oMPPCliente.ListarProductosElectroCliente();
        }

        public List<BEProductoPintura> ListarProductosPinturaCliente()
        {
            return oMPPCliente.ListarProductosPinturaCliente();
        }

        public BEProductoElectro ProductoElectricoMasSolicitado()
        {
            BEProductoElectro productoElectro = new BEProductoElectro();

            List<BEProductoElectro> listadoElectroCliente = new List<BEProductoElectro>();

            listadoElectroCliente = oMPPCliente.ListarProductosElectroCliente();

            productoElectro = (listadoElectroCliente).First();


            return productoElectro;

        }


        public BEProductoPintura ProductoPinturaMenosSolicitado()
        {
            BEProductoPintura productoElectro = new BEProductoPintura();

            List<BEProductoPintura> listadoPinturaCliente = new List<BEProductoPintura>();

            listadoPinturaCliente = oMPPCliente.ListarProductosPinturaCliente();

            productoElectro = (listadoPinturaCliente).First();


            return productoElectro;

        }


        public float ComprarDescuento(List<BEProducto> listaProductos)
        {
            float totalElectro = 0;
            float totalPintura = 0;
            float total = 0;

            foreach (BEProducto producto in listaProductos)
            {
                if(producto is BEProductoElectro)
                {
                    totalElectro += (producto.cantidad * producto.precioUnidad);
                    total += (producto.cantidad * producto.precioUnidad);
                }
                else if(producto is BEProductoPintura)
                {
                     totalPintura += (producto.cantidad * producto.precioUnidad);
                     total += (producto.cantidad * producto.precioUnidad);

                }

            }
            
            if(totalElectro > 1500) { totalElectro = (float)(totalElectro * 0.9); }
            if(totalPintura > 6500) { totalPintura = (float)(totalPintura * 0.8); }

            float totalGastoConDescuento = totalElectro + totalPintura;
            float totalDescuento = total-totalGastoConDescuento;
            

            return totalDescuento;

        }

        public bool ActualizarDescuentos(BECliente cliente)
        {
            return oMPPCliente.ActualizarDescuentos(cliente);
        }

        public List<BEProducto> ListarPorductosCompras(BECliente cliente)
        {
            return oMPPCliente.ListarPorductosCompras(cliente);
        }



    }
}
