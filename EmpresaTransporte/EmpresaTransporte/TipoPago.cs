using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
   public class TipoPago
    {
        public String nombre { get; set; }
        public String descripcion { get; set; }

        public TipoPago(String nombre, String descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}

