using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence.Repositorio
{
    class ServicioRepositorio
    {
        public class ServicioRepository : Repository<Servicio>, IServicioRepository
        {
            private readonly TransporteDbContext _Context;

            private ServicioRepository()
            {

            }

            public ServicioRepository(TransporteDbContext context)
            {
                _Context = context;
            }

        }
}
