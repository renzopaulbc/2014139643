using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    
      public abstract class Servicio
        {
            public  DateTime fechaPartida { get; set; }
            public  DateTime fechaLlegada { get; set; }

        }
    }
