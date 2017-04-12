using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
   public  class Encomienda : Servicio
    {
      
        LugarViaje destino;
        Bus bus;
   public Encomienda (LugarViaje destino,Bus bus) 
        {
            this.destino = destino;
            this.bus = bus;
        }

    }

}

