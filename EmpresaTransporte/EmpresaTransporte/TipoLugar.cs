using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    public class TipoLugar
    {
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public decimal costoTipoLugar { get; set; }

        public TipoLugar(String nombre, String descripcion, decimal costoTipoLugar)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.costoTipoLugar = costoTipoLugar;
        }
    }
}


