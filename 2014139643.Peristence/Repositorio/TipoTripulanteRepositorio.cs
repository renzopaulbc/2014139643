﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence.Repositorio
{
    public class TipoTripulacionRepository : Repository<TipoTripulacion>, ITipoTripulacionRepository
    {
        private readonly TransporteDbContext _Context;

        private TipoTripulacionRepository()
        {

        }

        public TipoTripulacionRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
}
