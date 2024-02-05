using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using DAL;

namespace Mapper
{
    public class MPPCategorias : IGestionesBase<BECategorias>
    {
        Conexion conec = new Conexion();
        public bool Baja(BECategorias categorias)
        {
            throw new NotImplementedException();
        }

        public bool Guardado(BECategorias categorias)
        {
            throw new NotImplementedException();
        }

        public List<BECategorias> listarTodo()
        {
            List<BECategorias> listadoCategorias = new List<BECategorias>();
            string consulta = "select * from categoria";
            DataSet resultado = conec.Lectura(consulta);

            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach  (DataRow registro in resultado.Tables[0].Rows)
                {
                    BECategorias oBECategoriasCarga = new BECategorias();

                    oBECategoriasCarga.codigo = Convert.ToInt32(registro["id_categoria"]);
                    oBECategoriasCarga.nombre = (registro["nombre"]).ToString();

                    listadoCategorias.Add(oBECategoriasCarga);
                }

            }

            return listadoCategorias;
        }
    }
}
