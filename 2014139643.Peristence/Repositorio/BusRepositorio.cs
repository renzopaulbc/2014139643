using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence.Repositorio
{
    class BusConfiguration
    {
        private readonly TransporteDbContext _Context;

        private BusRepository()
        {

        }

        public BusRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
