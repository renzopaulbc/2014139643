using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence.Repositorio
{
    class AdministrativoRepositorio
    {
        private readonly TransporteDbContext _Context;

        private AdministrativoRepository()
        {

        }

        public AdministrativoRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
