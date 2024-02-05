using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProducto : IEntidad
    {
        public int codigo { get; set; }

        public string descripcion { get; set; }

        public string marca { get; set; }

        public float precioUnidad { get; set; }

        public BEMedidas medicion { get; set; }
        public float medida { get; set; }

        public int cantidad { get; set; }

        public BEProveedor proveedor {get; set;}

        public BEProducto()
        {

        }

        public BEProducto(BEProducto producto)
        {

            this.codigo = producto.codigo;
            this.descripcion = producto.descripcion;
            this.marca = producto.marca;    
            this.medida = producto.medida;
            this.cantidad = producto.cantidad;
            this.precioUnidad = producto.precioUnidad;
            this.medicion = producto.medicion;
            this.proveedor = producto.proveedor;
            

        }


        public override string ToString()
        {
            return "Codigo "+ codigo + "Desc. " + descripcion + "Canitdad "+ cantidad.ToString() ;
        }



    }
}
