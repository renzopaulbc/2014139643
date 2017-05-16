using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence.Repositorio
{
    public class TransporteRepository : Repository<Transporte>, ITransporteRepository
    {
        private readonly TransporteDbContext _Context;

        private TransporteRepository()
        {

        }

        public TransporteRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
