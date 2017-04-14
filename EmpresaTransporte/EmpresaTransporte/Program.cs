using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    public class Program
    {
      
        static void Main(string[] args)
        {
            // TipoTripulacion
            TipoTripulacion azafata = new TipoTripulacion("azafata", "asistente de viaje encargada de la atencion del cliente dentro del bus.");
            TipoTripulacion chofer = new TipoTripulacion("chofer", "encargado de manejar el bus y llevar a los pasajeros sanos y salvos a su destino.");
            // TipoPago
            TipoPago efectivo = new TipoPago("efectivo", "Pagar con dinero al contado");
            TipoPago tarjeta = new TipoPago("tarjeta", "Pagar con tarjeta de credito o débito");
            // TipoComprobante
            TipoComprobante boleta = new TipoComprobante("boleta", "Comprobante que no se aplica IGV.");
            TipoComprobante factura = new TipoComprobante("factura", "Comprobante que se le aplica todos los impuestos que le corresponden.");
            // TipoLugar
            TipoLugar nacional = new TipoLugar("nacional", "Alcance dentro del pais", 20);
            TipoLugar internacional = new TipoLugar("internacional", "Alcande fuera del pais", 30);
            // TipoViaje
            TipoViaje normal = new TipoViaje("normal", "Servicio de Bus Normal");
            TipoViaje vip = new TipoViaje("vip", "Servicio de Bus VIP");
            // LugarViaje
            LugarViaje limaDestino = new LugarViaje(nacional, "Lima", 70);
            LugarViaje cixDestino = new LugarViaje(nacional, "Chiclayo", 75);
            LugarViaje ecuadorDestino1 = new LugarViaje(internacional, "Ecuador", 40);
            // Empleados (2 Administrativos y 4 Tripulacion)
            Administrativo admin1 = new Administrativo(1, "Renzo", "Bendezú", "renzobendezu@gmail.com", 850, "ventas", "08:00", "15:00");
            Administrativo admin2 = new Administrativo(2, "Pepe", "Quispe", "pepequispe@gmail.com", 1000, "ventas", "08:00", "16:00");
            Tripulacion tripul1 = new Tripulacion(1, "Leslie", "Espinoza", "lespinoza@gmail.com", 1200, azafata, 5);
            Tripulacion tripul2 = new Tripulacion(2, "Carla", "Palomino", "cpalomino@gmail.com", 1100, azafata, 4);
            Tripulacion tripul3 = new Tripulacion(3, "Alex", "Garcia", "alex_garcia@gmail.com", 1500, chofer, 6);
            Tripulacion tripul4 = new Tripulacion(4, "Luis", "Perales", "lperales@gmail.com", 1500, chofer, 6);
            // Buses (1 Bus)
            Bus bus1 = new Bus("XYZ201", "Mercedez Benz", "Rojo", 55000);
            bus1.AgregarTripulante(tripul1);
            bus1.AgregarTripulante(tripul3);
            // Clientes (5 Clientes)
            Cliente cliente1 = new Cliente(25638855, "Kevin", "Yamil", 19, 'm', "kyamil@gmail.com", 970555854);
            Cliente cliente2 = new Cliente(15487887, "Luis", "Naventa", 21, 'm', "lnaventa@gmail.com", 987454412);
            Cliente cliente3 = new Cliente(14747496, "Marcos", "Sosa", 18, 'm', "marcoss@gmail.com", 987654112);
            Cliente cliente4 = new Cliente(14587444, "Kyle", "Gutierrez", 15, 'f', "kyleg@gmail.com", 951115330);
            Cliente cliente5 = new Cliente(14855499, "Leyla", "Sanchez", 20, 'f', "leylas@gmail.com", 145788999);

            // Ventas (3 Pasajes y 2 Encomiendas)
            List<Venta> listaVentas = new List<Venta>();
            Venta pasaje1 = new Venta(1, admin1, cliente1, boleta, new Transporte(1, bus1, normal, cliente1, limaDestino, "22/03/17", "23/03/17"), efectivo, "20/03/17",normal);
            Venta pasaje2 = new Venta(2, admin1, cliente2, boleta, new Transporte(2, bus1, normal, cliente2, limaDestino, "22/03/17", "23/03/17"), efectivo, "21/03/17",vip);
            Venta pasaje3 = new Venta(3, admin1, cliente3, boleta, new Transporte(3, bus1, normal, cliente3, limaDestino, "22/03/17", "23/03/17"), efectivo, "21/03/17",normal);
            Venta encomienda1 = new Venta(4, admin2, cliente4, factura, new Encomienda(1, limaDestino, bus1, "Una bomda nuclear", "22/03/17", "23/03/17"), tarjeta, "20/03/17",vip);
            Venta encomienda2 = new Venta(5, admin2, cliente5, factura, new Encomienda(2, limaDestino, bus1, "Una caja de zapatos", "22/03/17", "23/03/17"), tarjeta, "21/03/17",normal);

            listaVentas.Add(pasaje1);
            listaVentas.Add(pasaje2);
            listaVentas.Add(pasaje3);
            listaVentas.Add(encomienda1);
            listaVentas.Add(encomienda2);

            foreach (Venta venta in listaVentas)
            {
                Console.WriteLine("Venta " + venta.id);
                venta.info();
               
                Console.WriteLine("==========================");
            }
        }
    }
}

