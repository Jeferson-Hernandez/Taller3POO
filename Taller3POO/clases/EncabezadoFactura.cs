using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3POO.clases
{
    class EncabezadoFactura
    {
        public int numeroFactura { get; set; }
        public long cedulaCliente { get; set; }
        public DateTime fecha { get; set; }
        public long valorTotal { get; set; }

    }
}
