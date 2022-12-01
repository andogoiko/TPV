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
        public Producto(int codigo, string articulo)
        {
            this.codigo = codigo;
            this.articulo = articulo;
        }

    }
}
