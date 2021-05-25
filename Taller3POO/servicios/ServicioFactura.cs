using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller3POO.clases;

namespace Taller3POO.servicios
{
    class ServicioFactura
    {
        List<EncabezadoFactura> encabezadoFacturas = new List<EncabezadoFactura>();
        List<DetalleFactura> detalleFacturas = new List<DetalleFactura>();        
        
        public void AgregarEncabezadoFactura(EncabezadoFactura encabezadoFactura)
        {
            encabezadoFacturas.Add(encabezadoFactura);
        }
        public void AgregarDetalleFactura(DetalleFactura detalleFactura)
        {
            detalleFacturas.Add(detalleFactura);
        }
        
        public void ListarFactura()
        {    
            foreach (var encabezadoFactura in encabezadoFacturas)
            {                
                Console.WriteLine($"Numero factura {encabezadoFactura.numeroFactura} - Cliente Documento {encabezadoFactura.cedulaCliente} - Fecha {encabezadoFactura.fecha} - ValorTotal {encabezadoFactura.valorTotal}");
            }
        }
        public void ListarDetalleFactura(int noFactura)
        {
            foreach (var detalle in detalleFacturas)
            {
                if (noFactura == detalle.numeroFactura)                
                    Console.WriteLine($"No Factura: {detalle.numeroFactura} - Codigo Producto: {detalle.codigoProducto} - Cantidad: {detalle.cantidad}");               
                
            }
        }
        public bool VerificarNoFactura(int numFactura)
        {
            bool noFactura = false;

            foreach (var factura in encabezadoFacturas)
            {
                if (numFactura == factura.numeroFactura)
                    noFactura = true;
            }
            return noFactura;
        }        
    }
}
