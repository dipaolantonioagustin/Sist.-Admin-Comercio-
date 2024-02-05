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
    public class MPPMedidas : IGestionesBase<BEMedidas>
    {
        Conexion conec = new Conexion();
        public bool Baja(BEMedidas medidas)
        {
            throw new NotImplementedException();
        }

        public bool Guardado(BEMedidas medidas)
        {
            throw new NotImplementedException();
        }

        public List<BEMedidas> listarTodo()
        {
            List<BEMedidas> listadoMedidas = new List<BEMedidas>();

            string consulta = "select * from medida";

            DataSet resultado = conec.Lectura(consulta);

            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    BEMedidas oBLLMedidasCargas = new BEMedidas();

                    oBLLMedidasCargas.codigo = Convert.ToInt32(registro["id_medidaNombre"]);
                    oBLLMedidasCargas.nombre = (registro["nombre_medida"]).ToString();

                    listadoMedidas.Add(oBLLMedidasCargas);
                }


            }

            return listadoMedidas;


        }
    }
}
