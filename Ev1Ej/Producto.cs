using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev1Ej
{
    internal class Producto
    {
        public int codigo { get; set; }
        public string articulo { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double impuestos { get; set; }
        public string tipo { get; set; }
        public Producto(int codigo, string articulo)
        {
            this.codigo = codigo;
            this.articulo = articulo;
        }

        public Producto(int codigo, string articulo, double precio, int cantidad, double impuestos, string tipo)
        {
            this.codigo = codigo;
            this.articulo = articulo;
            this.precio = precio;
            this.cantidad = cantidad;
            this.impuestos = impuestos;
            this.tipo = tipo;
        }

    }
}
