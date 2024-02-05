using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using BE;

namespace BLL
{
    public class BLLProducto
    {

        MPPProducto oMPPProducto = new MPPProducto();
        public bool GuardadoCompra(BEProducto productoStock, BEProducto productoCompra, BECliente cliente)
        {
            productoStock.cantidad = productoStock.cantidad - productoCompra.cantidad;
                

            return oMPPProducto.GuardadoCompra(productoStock,productoCompra, cliente);
        }
        


    }
}
