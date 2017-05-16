using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Entity
{
    class Administrativo
    {
        public string Cargo { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }
    }
}
