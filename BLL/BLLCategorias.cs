using Abstraccion;
using BE;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCategorias : IGestionesBase<BECategorias>
    {
        MPPCategorias oMPPCategorias = new MPPCategorias();
        public bool Baja(BECategorias categoria)
        {
            throw new NotImplementedException();
        }

        public bool Guardado(BECategorias categoria)
        {
            throw new NotImplementedException();
        }

        public List<BECategorias> listarTodo()
        {
            
            return oMPPCategorias.listarTodo();


        }
    }
}
