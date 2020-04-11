using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Articulo
    {
        public Int64 Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }
        public String Imagen { get; set; }
        public float Precio { get; set; }
    }
}
