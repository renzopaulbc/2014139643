using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte
{
    class Venta
    {
        Administrativo administrativo;
        Cliente cliente;
        Servicio servicio;
        TipoPago tipoPago;
        TipoComprobante tipoComprobante;

        public Venta(Administrativo administratativo, Cliente cliente, TipoComprobante tipoComprobante, Servicio servicio, TipoPago tipoPago)
        {
            this.administrativo = administratativo;
            this.cliente = cliente;
            this.servicio = servicio;
            this.tipoPago = tipoPago;
            this.tipoComprobante = tipoComprobante;
        }

        public int id { get; set; }
        public decimal costo { get; set; }
        public DateTime FechaVenta { get; set; }

    }

}


