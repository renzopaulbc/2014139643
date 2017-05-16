using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence.Repositorio
{
    class ClienteRepositorio
    {
        private readonly TransporteDbContext _Context;

        private ClienteRepository()
        {

        }

        public ClienteRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
}
