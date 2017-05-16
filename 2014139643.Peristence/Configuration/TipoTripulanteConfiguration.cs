using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence
{
    class TipoTripulanteConfiguration
    {
         //Table configurations
            ToTable("TipoLugares");
            HasKey(c => c.TipoLugarId);
            Property(c => c.NombreTipo).IsRequired().HasMaxLength(300);
    }
}
