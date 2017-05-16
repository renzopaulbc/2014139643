using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Peristence.Repositorio
{
    class LugarViajeRepositorio
    {
        public class LugarViajeRepository : Repository<LugarViaje>, ILugarViajeRepository
        {
            private readonly TransporteDbContext _Context;

            private LugarViajeRepository()
            {

            }

            public LugarViajeRepository(TransporteDbContext context)
            {
                _Context = context;
            }
}
