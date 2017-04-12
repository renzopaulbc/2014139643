using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    class Administrativo : Empleado
    {
        public String area { get; set; }
        public String horaInicio { get; set; }
        public String horaFin { get; set; }

        public Administrativo(int id, String nombre, String apellido, String correo, decimal sueldo, String area, String horaInicio, String horaFin)
            : base(id, nombre, apellido, correo, sueldo)
        {
            this.area = area;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }

    }
}


