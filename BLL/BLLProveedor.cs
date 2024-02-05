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
    public class BLLProveedor : IGestionesBase<BEProveedor>
    {
        MPPProveedor oMPPProveedor = new MPPProveedor();
        public bool Baja(BEProveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public bool Guardado(BEProveedor proveedor)
        {   
            List<BEProveedor> proves = new List<BEProveedor>();

            proves.AddRange(this.oMPPProveedor.listarTodo());

            if (proves.Exists(x => x.cuit == proveedor.cuit))
            { 
                return false; 
            }
            else 
            {
                return oMPPProveedor.Guardado(proveedor);
            }
        }

        public List<BEProveedor> listarTodo()
        {
           return oMPPProveedor.listarTodo();
        }
    }
}
