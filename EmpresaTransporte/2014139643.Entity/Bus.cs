using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643.Entity
{
    public class Bus
    {
        public string NroPlaca { get; set; }
        public String Modelo { get; set; }
        public String Color { get; set; }
        public decimal Kilometraje { get; set; }



        public Encomienda encomienda { get; set; }
    }
}
