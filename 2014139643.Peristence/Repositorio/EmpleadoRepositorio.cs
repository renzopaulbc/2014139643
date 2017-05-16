using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence.Repositorio
{
    class EmpleadoRepositorio
    {
        private readonly TransporteDbContext _Context;

        private EmpleadoRepository()
        {

        }

        public EmpleadoRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
}
