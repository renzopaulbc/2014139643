using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence
{
    class BusConfiguration
    {
         //Table configurations
            ToTable("Buses");
            HasKey(c => c.BusId);
            Property(c => c.Placa).IsRequired().HasMaxLength(15);

            //Relationships Configurations
            HasMany(c => c.Tripulacion)
                .WithRequired(c => c.Bus)
                .HasForeignKey(c => c.BusId);

            HasMany(c => c.Encomienda)
                .WithRequired(c => c.Bus)
                .HasForeignKey(c => c.BusId);

            HasRequired(c => c.Transporte)
                .WithMany(c => c.Bus)
                .HasForeignKey(c => c.TransporteId);
    }
}
