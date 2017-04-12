using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    
       public class Transporte : Servicio
        {
   

        Bus bus;
            TipoViaje tipoViaje;
            Cliente cliente;
            LugarViaje destino;
        public Transporte (TipoViaje tipoViaje, Cliente cliente, LugarViaje destino)
        {
            this.tipoViaje = tipoViaje;
            this.cliente = cliente;
            this.destino = destino;
        }
    }
    }



