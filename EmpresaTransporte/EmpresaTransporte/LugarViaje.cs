using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    public class LugarViaje
    {
        TipoLugar tipoLugar;
        String nombreLugar;

        public LugarViaje(TipoLugar tipoLugar, String nombreLugar)
        {
            this.nombreLugar = nombreLugar;
            this.tipoLugar = tipoLugar;
        }
    }
}
