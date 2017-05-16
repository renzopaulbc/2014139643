using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Entity
{
    class TipoLugar
    {
        public int TipoLugarId { get; set; }
        public string NombreTipo { get; set; }

        public int LugarViajeId { get; set; }
        public LugarViaje LugarViaje { get; set; }
    }
}
