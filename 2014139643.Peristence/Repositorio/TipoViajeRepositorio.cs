using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence.Repositorio
{
    public class TipoViajeRepository : Repository<TipoViaje>, ITipoViajeRepository
    {
        private readonly TransporteDbContext _Context;

        private TipoViajeRepository()
        {

        }

        public TipoViajeRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
