using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence.Repositorio
{
    public class TripulacionRepository : Repository<Tripulacion>, ITripulacionRepository
    {
        private readonly TransporteDbContext _Context;

        private TripulacionRepository()
        {

        }

        public TripulacionRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
