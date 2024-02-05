using Abstraccion;
using BE;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;

namespace BLL
{
    public class BLLProductoPintura : IGestionesBase<BEProductoPintura>
    {
        MPPProductoPintura MPPProductoPintura = new MPPProductoPintura();

        public bool Baja(BEProductoPintura producto)
        {
           return MPPProductoPintura.Baja(producto);
        }

        public bool Guardado(BEProductoPintura producto)
        {
            return MPPProductoPintura.Guardado(producto);
        }

        public List<BEProductoPintura> listarTodo()
        {
           return MPPProductoPintura.listarTodo();
        }
    }
}
