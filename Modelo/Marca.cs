using System;

namespace Modelo
{
    public class Marca
    {
        public Int32 Id { get; set; }
        public String Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}