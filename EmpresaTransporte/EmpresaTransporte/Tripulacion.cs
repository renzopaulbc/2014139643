using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    class Tripulacion : Empleado
    {
        TipoTripulacion tipoTripulacion;
        int nroViajesMax;
        Boolean estado;

        public Tripulacion(int id, String nombre, String apellido, String correo, decimal sueldo, TipoTripulacion tipoTripulacion, int nroViajesMax)
            : base(id, nombre, apellido, correo, sueldo)
        {
            this.tipoTripulacion = tipoTripulacion;
            this.nroViajesMax = nroViajesMax;
            this.estado = true;
        }
    }
}


