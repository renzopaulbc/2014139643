﻿using _2014107080_ENT;
using _2014107080_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014107080_PER.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
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
