using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence
{
    class ServicioConfiguracion
    {
        //Table configurations
            ToTable("Servicios");
            HasKey(c => c.ServicioId);
            Property(c => c.NombreServicio).IsRequired().HasMaxLength(100);

        //Relationships configurations
        Map<Encomienda>(m => m.Requires("Discriminator").HasValue("Encomienda"));
            Map<Transporte>(m => m.Requires("Discriminator").HasValue("Transporte"));

            HasRequired(c => c.Venta)
                .WithMany(c => c.Servicio)
                .HasForeignKey(c => c.VentaId);
    }
}
