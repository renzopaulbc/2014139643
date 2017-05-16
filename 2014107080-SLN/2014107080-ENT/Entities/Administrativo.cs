using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014107080_ENT
{
    public class Administrativo : Empleado
    {
        public string Cargo { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }
    }
}
