using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProductoElectro : BEProducto
    {
       public BECategorias categoria { get; set; }

        public BEProductoElectro()
        {

        }
        public BEProductoElectro(BEProductoElectro productoElectro)
        {
            this.codigo = productoElectro.codigo;
            this.descripcion = productoElectro.descripcion;
            this.marca = productoElectro.marca;
            this.medida = productoElectro.medida;
            this.cantidad = productoElectro.cantidad;
            this.precioUnidad = productoElectro.precioUnidad;
            this.medicion = productoElectro.medicion;
            this.proveedor = productoElectro.proveedor;
            this.categoria = productoElectro.categoria;


        }

        public override string ToString()
        {
            return "Codigo " + codigo + "Desc. " + descripcion + "Canitdad " + cantidad.ToString();
        }

    }



}
