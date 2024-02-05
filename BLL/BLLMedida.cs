using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using BE;
using Abstraccion;

namespace BLL
{
    public class BLLMedida : IGestionesBase<BEMedidas>
    {
        MPPMedidas oMPPMedida = new MPPMedidas();
        public bool Baja(BEMedidas medida)
        {
            throw new NotImplementedException();
        }

        public bool Guardado(BEMedidas medida)
        {
            throw new NotImplementedException();
        }

        public List<BEMedidas> listarTodo()
        {
            return oMPPMedida.listarTodo();
        }
    }
}
