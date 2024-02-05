using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
namespace BE
{
    public class BECliente : IEntidad
    {
        public int codigo { get ; set ; }

        public string nombre { get; set ; }

        public string apellido { get; set ; }

        public int dni { get; set ; }

        public float descuentosAcumulados { get; set; }

        

    }
}
