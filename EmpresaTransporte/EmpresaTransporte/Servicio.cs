using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{

    public abstract class Servicio
    {
        public String fechaPartida { get; set; }
        public String fechaLlegada { get; set; }
        public abstract decimal calcularServicio();

    }
}

