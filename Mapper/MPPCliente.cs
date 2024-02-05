using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using DAL;

namespace Mapper
{
    public class MPPCliente : IGestionesBase<BECliente>
    {
        Conexion conec = new Conexion();
        public bool Baja(BECliente objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardado(BECliente cliente)
        {
            string consulta = null;

            consulta = $"insert into cliente (nombre_cliente, apellido_cliente,dni_cliente) values ('{cliente.nombre}', {cliente.apellido}, '{cliente.dni}') ";
            return conec.Escribir(consulta);
           
        }

        public bool ActualizarDescuentos(BECliente cliente)
        {
            string consulta = $"update cliente set descuentos = {cliente.descuentosAcumulados} where cliente.id_cliente = {cliente.codigo}";

            return conec.Escribir(consulta);
        }





        public List<BEProductoElectro> ListarProductosElectroCliente()
        {
            string consulta = $"select p.descripcion, pc.id_producto, sum (cantidad_producto_cliente) as cantidad_producto_cliente from producto_cliente pc join producto p on pc.id_producto = p.id_producto where p.id_categoria is not null group by p.descripcion, pc.id_producto order by sum (pc.cantidad_producto_cliente) desc ";

            DataSet resultado = conec.Lectura(consulta);
            List<BEProductoElectro> listadoProductos = new List<BEProductoElectro>();

            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {

                   
                        BEProductoElectro BEProductoCarga = new BEProductoElectro();

                        BEProductoCarga.codigo = Convert.ToInt32(registro["id_producto"]);
                        BEProductoCarga.descripcion = (registro["descripcion"]).ToString();
                        //BEProductoCarga.marca = (registro["marca"]).ToString();
                        //BEProductoCarga.medida = float.Parse(registro["medida"].ToString());
                        BEProductoCarga.cantidad = Convert.ToInt32(registro["cantidad_producto_cliente"]);

                                 
                    


                        listadoProductos.Add(BEProductoCarga);

                 
                }

            }

            return listadoProductos;
        }








        public List<BEProductoPintura> ListarProductosPinturaCliente()
        {
            List<BEProductoPintura> listaProductos = new List<BEProductoPintura>();

            string consulta = "select p.marca, p.color, p.descripcion, pc.id_producto, sum (cantidad_producto_cliente) as cantidad_producto_cliente from producto_cliente pc join producto p on pc.id_producto = p.id_producto where p.color is not null group by p.marca, p.color, p.descripcion, pc.id_producto order by sum (pc.cantidad_producto_cliente) asc ";

            DataSet resultado = conec.Lectura(consulta);


            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                  
                        BEProductoPintura BEProductoCarga = new BEProductoPintura();

                        BEProductoCarga.codigo = Convert.ToInt32(registro["id_producto"]);
                        BEProductoCarga.descripcion = (registro["descripcion"]).ToString();
                        BEProductoCarga.marca = (registro["marca"]).ToString();
                        BEProductoCarga.cantidad = Convert.ToInt32(registro["cantidad_producto_cliente"]);
                        BEProductoCarga.color = registro["color"].ToString();


                        listaProductos.Add(BEProductoCarga);
                  
                }

            }

            return listaProductos;


        }
    

        public List<BECliente> listarTodo()
        {
            string consulta = "select * from cliente";
            DataSet resultado = conec.Lectura(consulta);
            List<BECliente> listaCliente = new List<BECliente>();
            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow registro in resultado.Tables[0].Rows)
                {
                    BECliente oBEClienteCarga = new BECliente();

                    oBEClienteCarga.codigo = Convert.ToInt32(registro["id_cliente"]);
                    oBEClienteCarga.dni = Convert.ToInt32(registro["dni_cliente"]);
                    oBEClienteCarga.nombre = (registro["nombre_cliente"]).ToString();
                    oBEClienteCarga.apellido = (registro["apellido_cliente"]).ToString();

                    if ((registro["descuentos"].ToString()) == "")
                    {
                        oBEClienteCarga.descuentosAcumulados = 0;
                    }
                    else
                    {
                        oBEClienteCarga.descuentosAcumulados = float.Parse((registro["descuentos"]).ToString());
                    }

                    listaCliente.Add(oBEClienteCarga);
                }
            }
            
            return listaCliente;

        }


        public List<BEProducto> ListarPorductosCompras(BECliente cliente)
        {
            string consulta = $"select pc.*, p.*, prov.* from producto_cliente pc join producto p on pc.id_producto = p.id_producto join proveedor prov on p.id_proveedor = prov.id_proveedor where pc.id_cliente =  {cliente.codigo} ";

            DataSet resultado = conec.Lectura(consulta);
            List<BEProducto> listadoProductos = new List<BEProducto>();

            if(resultado.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow registro in resultado.Tables[0].Rows)
                {
                    BEProducto BEProductoCarga = new BEProducto();

                    BEProductoCarga.codigo = Convert.ToInt32(registro["id_producto"]);
                    BEProductoCarga.descripcion = (registro["descripcion"]).ToString();
                    BEProductoCarga.marca = (registro["marca"]).ToString();
                    BEProductoCarga.precioUnidad = float.Parse(registro["precio_unitario"].ToString());
                    BEProductoCarga.medida = float.Parse(registro["medida"].ToString());
                    BEProductoCarga.cantidad = Convert.ToInt32(registro["cantidad_producto_cliente"]); 

                    #region CargaProveedor

                    BEProveedor BEProveedorCarga = new BEProveedor();

                    BEProveedorCarga.codigo = Convert.ToInt32(registro["id_proveedor"]);
                    BEProveedorCarga.razonSocial = (registro["razon_social"]).ToString();
                    BEProveedorCarga.cuit = Convert.ToInt32(registro["cuit"]);

                    BEProductoCarga.proveedor = BEProveedorCarga;
                    #endregion

                   
                    listadoProductos.Add(BEProductoCarga);

                }
            }

            return listadoProductos;

        }



    }
}
