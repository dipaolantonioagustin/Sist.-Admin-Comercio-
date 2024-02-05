using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using DAL;

namespace Mapper
{
    public class MPPProducto
    {
        Conexion conec = new Conexion();

       

        public bool GuardadoCompra(BEProducto productoStock,BEProducto productoCompra, BECliente cliente)
        {
            string consulta1 = null;
            string consulta2 = null;
                        
            consulta1 = $"update producto set cantidad = {productoStock.cantidad} where id_producto = {productoStock.codigo}";
            consulta2 = $"insert into producto_cliente (id_cliente, id_producto, cantidad_producto_cliente) values({(cliente.codigo)} ,{(productoCompra.codigo)},{productoCompra.cantidad})";

            return conec.Transaccion(consulta1, consulta2);
            
        }





    }
}
