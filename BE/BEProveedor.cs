using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProveedor : IEntidad
    {
        public int codigo { get; set ; }

        public int cuit { get; set ; }

        public string razonSocial { get; set ; }


        public override string ToString()
        {
            return codigo +" " + razonSocial;
        }


    }
}
