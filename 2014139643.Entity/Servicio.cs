﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Entity
{
    class Servicio
    {
        public int ServicioId { get; set; }
        public string NombreServicio { get; set; }
        public decimal Tarifa { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }
    }
}
