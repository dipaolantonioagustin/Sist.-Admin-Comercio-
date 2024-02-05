using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using Abstraccion;
using System.Data;

namespace Mapper
{
    public class MPPProveedor : IGestionesBase<BEProveedor>
    {
        Conexion conec = new Conexion();
        public bool Baja(BEProveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public bool Guardado(BEProveedor proveedor)
        {
            string consulta = null;

            if (proveedor.codigo != 0)
            {
                consulta = $"update proveedor set cuit = {proveedor.cuit} , razon_social = '{proveedor.razonSocial}' where id_proveedor = {proveedor.codigo}";
                return conec.Escribir(consulta);
            }
            else
            {
                consulta = $"insert into proveedor (cuit, razon_social) values({proveedor.cuit},'{proveedor.razonSocial}')";
                return conec.Escribir(consulta);
            } 

        }

        public List<BEProveedor> listarTodo()
        {
            List<BEProveedor> listadoResultado = new List<BEProveedor>();
            string consulta = "select * from proveedor";
            DataSet resultado = conec.Lectura(consulta);

            if(resultado.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow registro in resultado.Tables[0].Rows)
                {
                    BEProveedor oBEProveedorCarga = new BEProveedor();

                    oBEProveedorCarga.cuit = Convert.ToInt32(registro["cuit"]);
                    oBEProveedorCarga.razonSocial = (registro["razon_social"].ToString());
                    oBEProveedorCarga.codigo = Convert.ToInt32(registro["id_proveedor"]);

                    listadoResultado.Add(oBEProveedorCarga);
                }

            } 
            
            return listadoResultado;
        }
    }
}
