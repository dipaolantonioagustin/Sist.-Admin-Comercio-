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
    public class BLLProductoElectro : IGestionesBase<BEProductoElectro>
    {

        MPPProductoElectro MPPProductoElectro = new MPPProductoElectro();

        public bool Baja(BEProductoElectro producto)
        {
            return MPPProductoElectro.Baja(producto);
        }

        public bool Guardado(BEProductoElectro producto)
        {
            return MPPProductoElectro.Guardado(producto);
        }

        public List<BEProductoElectro> listarTodo()
        {
            return MPPProductoElectro.listarTodo();
        }
    }
}
