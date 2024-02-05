using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MPPProductoPintura : IGestionesBase<BEProductoPintura>
    {

        Conexion conec = new Conexion();

        public bool Baja(BEProductoPintura producto)
        {
            string consulta = null;

            if (producto.codigo != 0)
            {
                consulta = $"delete from producto where producto.id_producto = {producto.codigo} ";
                return conec.Escribir(consulta);
            }
            else { return false; }
        }

        public bool Guardado(BEProductoPintura producto)
        {
            string consulta = null;

            if (producto.codigo != 0)
            {
                consulta = $"update producto set cantidad = {producto.cantidad}, id_proveedor = {producto.proveedor.codigo}, descripcion = '{producto.descripcion}', marca = '{producto.marca}', precio_unitario = {producto.precioUnidad}, id_medidaNombre = {producto.medicion.codigo}, medida = {producto.medida}, color = '{producto.color}' where id_producto = {producto.codigo}";
                return conec.Escribir(consulta);
            }
            else
            {
                consulta = $"insert into producto (descripcion, cantidad, marca, precio_unitario, medida, id_medidaNombre, id_proveedor, color) values ('{producto.descripcion}', {producto.cantidad},' {producto.marca}', {producto.precioUnidad}, {producto.medida}, {producto.medicion.codigo}, {producto.proveedor.codigo}, '{producto.color}') ";
                return conec.Escribir(consulta);
            }
        }

        public List<BEProductoPintura> listarTodo()
        {
            List<BEProductoPintura> listaProductos = new List<BEProductoPintura>();

            string consulta = "select prod.*, prov.*, med.nombre_medida from producto prod join proveedor prov on prod.id_proveedor = prov.id_proveedor join medida med on prod.id_medidaNombre = med.id_medidaNombre";

            DataSet resultado = conec.Lectura(consulta);


            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    string verificador = (registro["color"]).ToString();
                    if (verificador != "")
                    {
                        BEProductoPintura BEProductoCarga = new BEProductoPintura();

                        BEProductoCarga.codigo = Convert.ToInt32(registro["id_producto"]);
                        BEProductoCarga.descripcion = (registro["descripcion"]).ToString();
                        BEProductoCarga.marca = (registro["marca"]).ToString();
                        BEProductoCarga.precioUnidad = float.Parse(registro["precio_unitario"].ToString());
                        BEProductoCarga.medida = float.Parse(registro["medida"].ToString());
                        BEProductoCarga.cantidad = Convert.ToInt32(registro["cantidad"]);
                        BEProductoCarga.color = registro["color"].ToString();
                      

                        #region Carga Medida
                        BEMedidas oBEMedidaCarga = new BEMedidas();

                        oBEMedidaCarga.codigo = Convert.ToInt32(registro["id_medidaNombre"]);
                        oBEMedidaCarga.nombre = (registro["nombre_medida"]).ToString();

                        BEProductoCarga.medicion = oBEMedidaCarga;
                        #endregion

                        #region Carga Proveedor
                        BEProveedor BEProveedorCarga = new BEProveedor();

                        BEProveedorCarga.codigo = Convert.ToInt32(registro["id_proveedor"]);
                        BEProveedorCarga.razonSocial = (registro["razon_social"]).ToString();
                        BEProveedorCarga.cuit = Convert.ToInt32(registro["cuit"]);

                        BEProductoCarga.proveedor = BEProveedorCarga;
                        #endregion



                        listaProductos.Add(BEProductoCarga);
                    }
                }

            }

            return listaProductos;


        }
    }
 }

