using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProductoPintura : BEProducto
    {
        public string color { get; set; }

        public BEProductoPintura()
        {

        }

        public BEProductoPintura(BEProductoPintura productoPintura)
        {
            this.codigo = productoPintura.codigo;
            this.descripcion = productoPintura.descripcion;
            this.marca = productoPintura.marca;
            this.medida = productoPintura.medida;
            this.cantidad = productoPintura.cantidad;
            this.precioUnidad = productoPintura.precioUnidad;
            this.medicion = productoPintura.medicion;
            this.proveedor = productoPintura.proveedor;
            this.color = productoPintura.color;

        }



        public override string ToString()
        {
            return "Codigo " + codigo + "Desc. " + descripcion + "Canitdad " + cantidad.ToString();
        }

    }
}
