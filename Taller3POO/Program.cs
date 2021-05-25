using System;
using System.Collections.Generic;
using Taller3POO.clases;
using Taller3POO.servicios;

namespace Taller3POO
{
    class Program
    {
        static void Main(string[] args)
        {

            ServicioCliente serviciosCliente = new ServicioCliente();
            ServicioProducto serviciosProducto = new ServicioProducto();
            ServicioFactura servicioFactura = new ServicioFactura();
            bool bucle = true;
            string nombreEmp = "";
            int opcion = 0;
            do
            {                
                Console.WriteLine($"*** Empresa:{nombreEmp} ***\n" +
                                  $"*********************************\n" +
                                  $"****     MENÚ DE MODULOS     ****\n" +
                                  $"*********************************\n" +
                                  $"*   1- Módulo de clientes       *\n" +
                                  $"*   2- modulo de productos      *\n" +
                                  $"*   3- modulo de venta          *\n" +
                                  $"*   4- modulo de reportes       *\n" +
                                  $"*   5- modulo de configuracion  *\n" +
                                  $"*   6- Terminar                 *\n" +
                                  $"*********************************\n" +                                  
                                  $"Ingrese opcion");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingrese una opcion valida");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                
                switch (opcion)
                {
                    case 1:                        
                        long documento = 0;
                        bool bucleServicios = true;
                        do
                        {
                            Console.WriteLine("********************************\n" +
                                              "*    SERVICIOS DEL CLIENTE     *\n" +
                                              "********************************\n" +
                                              "*    1-Registrar cliente       *\n" +
                                              "*    2-Buscar cliente          *\n" +
                                              "*    3-Modificar cliente       *\n" +
                                              "*    4-Eliminar cliente        *\n" +
                                              "*    5-Salir                   *\n" +
                                              "********************************");
                            Console.WriteLine("Ingrese opcion");
                            try
                            {
                                opcion = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Ingrese una opcion valida");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            try
                            {
                                if (opcion == 1)
                                {

                                    Cliente cliente = new Cliente();
                                    Console.WriteLine("Ingrese el nombre");
                                    cliente.nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese el documento");
                                    cliente.documento = long.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la direccion");
                                    cliente.direccion = (Console.ReadLine());
                                    Console.WriteLine("Ingrese el telefono");
                                    cliente.telefono = long.Parse(Console.ReadLine());
                                    if (serviciosCliente.ValidarCliente(cliente.documento))
                                        Console.WriteLine("El documento ya se encuentra registrado");
                                    else
                                    {
                                        serviciosCliente.RegistrarCliente(cliente);
                                        Console.WriteLine("Cliente registrado\n");
                                        Console.ReadKey();
                                    }
                                }
                                else if (opcion == 2)
                                {
                                    Console.WriteLine("Ingrese la cedula para buscar");
                                    documento = long.Parse(Console.ReadLine());
                                    if (serviciosCliente.ValidarCliente(documento))
                                    {
                                        serviciosCliente.BuscarCliente(documento);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay cliente con esa cedula");
                                        Console.ReadKey();
                                    }

                                }
                                else if (opcion == 3)
                                {
                                    Console.WriteLine("Ingrese la cedula para modificar");
                                    documento = long.Parse(Console.ReadLine());
                                    if (serviciosCliente.ValidarCliente(documento))
                                    {
                                        serviciosCliente.ModificarCliente(documento);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay cliente con esa cedula");
                                        Console.ReadKey();
                                    }

                                }
                                else if (opcion == 4)
                                {
                                    Console.WriteLine("Ingrese la cedula para eliminar");
                                    documento = long.Parse(Console.ReadLine());

                                    if (serviciosCliente.ValidarCliente(documento))
                                    {
                                        serviciosCliente.EliminarCliente(documento);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("El cliente no está registrado");
                                        Console.ReadKey();
                                    }
                                }
                                else if (opcion == 5)
                                    bucleServicios = false;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Debe ingresar el tipo de dato valido");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            Console.Clear();
                        } while (bucleServicios);                        
                        break;
                    case 2:
                        int codigo = 0;
                        bucleServicios = true;
                        do
                        {
                            Console.WriteLine("********************************\n" +
                                              "*    SERVICIOS DEL PRODUCTO     *\n" +
                                              "********************************\n" +
                                              "*    1-Registrar producto      *\n" +
                                              "*    2-Buscar producto         *\n" +
                                              "*    3-Modificar producto      *\n" +
                                              "*    4-Eliminar producto       *\n" +
                                              "*    5-Salir                   *\n" +
                                              "********************************");
                            Console.WriteLine("Ingrese opcion");
                            try
                            {
                                opcion = int.Parse(Console.ReadLine());
                                if (opcion == 1)
                                {
                                    Producto producto = new Producto();
                                    Console.WriteLine("Ingrese el nombre");
                                    producto.nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese el precio");
                                    producto.precio = long.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la cantidad");
                                    producto.cantidad = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el codigo");
                                    producto.codigo = int.Parse(Console.ReadLine());
                                    if (serviciosProducto.ValidarProducto(producto.codigo))
                                        Console.WriteLine("El codigo ya se encuentra registrado");
                                    else
                                    {
                                        serviciosProducto.RegistrarProducto(producto);
                                        Console.WriteLine("Producto registrado");
                                        Console.ReadKey();
                                    }
                                }
                                else if (opcion == 2)
                                {
                                    Console.WriteLine("Ingrese el codigo para buscar");
                                    codigo = int.Parse(Console.ReadLine());
                                    if (serviciosProducto.ValidarProducto(codigo))
                                    {
                                        serviciosProducto.BuscarProducto(codigo);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay producto con ese codigo");
                                        Console.ReadKey();
                                    }
                                }
                                else if (opcion == 3)
                                {
                                    Console.WriteLine("Ingrese el codigo para modificar");
                                    codigo = int.Parse(Console.ReadLine());
                                    if (serviciosProducto.ValidarProducto(codigo))
                                    {
                                        serviciosProducto.ModificarProducto(codigo);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay producto con ese codigo");
                                        Console.ReadKey();
                                    }
                                }
                                else if (opcion == 4)
                                {
                                    Console.WriteLine("Ingrese el codigo para eliminar");
                                    codigo = int.Parse(Console.ReadLine());

                                    if (serviciosProducto.ValidarProducto(codigo))
                                    {
                                        serviciosProducto.EliminarProducto(codigo);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("El producto no se encuentra registrado");
                                        Console.ReadKey();
                                    }
                                }
                                else if (opcion == 5)
                                    bucleServicios = false;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Debe ingresar el tipo de dato valido");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            Console.Clear();
                        } while (bucleServicios);
                        break;
                    case 3:
                        bucleServicios = true;
                        do
                        {
                            Console.WriteLine("********************************\n" +
                                          "*    SERVICIOS DE VENTA        *\n" +
                                          "********************************\n" +
                                          "*    1-Realizar venta          *\n" +
                                          "*    2-Buscar factura          *\n" +
                                          "*    3-Salir                   *\n" +
                                          "********************************\nIngrese la opción");                            
                            try
                            {
                                opcion = int.Parse(Console.ReadLine());
                                if (opcion == 1)
                                {
                                    Console.WriteLine("Ingrese el documento");
                                    documento = long.Parse(Console.ReadLine());
                                    Random rnd = new Random();
                                    bool bucleVenta = true;
                                    if (serviciosCliente.ValidarCliente(documento))
                                    {
                                        int numeroFactura = rnd.Next(1, 5000);
                                        long precio = 0;
                                        long valorTotal = 0;
                                        do
                                        {
                                            EncabezadoFactura encabezadoFactura = new EncabezadoFactura();
                                            DetalleFactura detalleFactura = new DetalleFactura();

                                            Console.WriteLine("Ingrese el codigo del producto");
                                            codigo = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese la cantidad");
                                            int cantidad = int.Parse(Console.ReadLine());

                                            if (serviciosProducto.CantidadExcedida(cantidad, codigo))
                                            {
                                                serviciosProducto.RestarCantidad(cantidad, codigo);
                                                serviciosProducto.DevolverPrecio(codigo);
                                                precio = serviciosProducto.DevolverPrecio(codigo) * cantidad;
                                                valorTotal += precio;

                                                if (servicioFactura.VerificarNoFactura(numeroFactura) != true)
                                                {
                                                    DateTime fecha = DateTime.Now;
                                                    encabezadoFactura.numeroFactura = numeroFactura;
                                                    encabezadoFactura.cedulaCliente = documento;
                                                    encabezadoFactura.fecha = fecha.Date;
                                                }
                                                detalleFactura.numeroFactura = numeroFactura;
                                                detalleFactura.cantidad = cantidad;
                                                detalleFactura.codigoProducto = codigo;
                                                servicioFactura.AgregarDetalleFactura(detalleFactura);
                                            }
                                            else
                                            {
                                                Console.WriteLine("No tenemos esa cantidad de productos");
                                                Console.ReadKey();
                                                continue;
                                            }
                                            Console.WriteLine("Quiere agregar otro producto?");
                                            string resp = Console.ReadLine();
                                            if (resp.Contains("no"))
                                            {
                                                encabezadoFactura.valorTotal = valorTotal;
                                                servicioFactura.AgregarEncabezadoFactura(encabezadoFactura);
                                                Console.WriteLine("Venta terminada");
                                                bucleVenta = false;
                                                Console.ReadKey();
                                            }
                                        } while (bucleVenta);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay cliente con ese documento");
                                        Console.ReadKey();
                                    }

                                }
                                else if (opcion == 2)
                                {
                                    Console.WriteLine("Ingrese el No Factura");
                                    int numFactura = int.Parse(Console.ReadLine());
                                    servicioFactura.ListarDetalleFactura(numFactura);
                                    Console.ReadKey();
                                }
                                else if (opcion == 3)
                                    bucleServicios = false;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Debe ingresar el tipo de dato valido");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }                                
                            
                            Console.Clear();
                        } while (bucleServicios);                        
                        break;
                    case 4:
                        bucleServicios = true;
                        do
                        {
                            Console.WriteLine("********************************\n" +
                                          "*    SERVICIOS DE REPORTES     *\n" +
                                          "********************************\n" +
                                          "*    1-Listar los clientes     *\n" +
                                          "*    2-Listar los productos    *\n" +
                                          "*    3-Listar las facturas     *\n" +
                                          "*    4-Salir                   *\n" +
                                          "********************************");
                            Console.WriteLine("Ingrese opcion");
                            try
                            {
                                opcion = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Ingrese una opción válida");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            
                            if (opcion == 1)
                            {
                                Console.WriteLine("**Listado de clientes**");
                                serviciosCliente.ListarClientes();                                
                                Console.ReadKey();
                            }
                                
                            else if (opcion == 2)
                            {
                                Console.WriteLine("**Listado de productos**");
                                serviciosProducto.ListarProductos();
                                Console.ReadKey();
                            }
                                
                            else if (opcion == 3)
                            {
                                Console.WriteLine("**Listado de facturas(Encabezado)**");
                                servicioFactura.ListarFactura();
                                Console.ReadKey();
                            }
                                
                            else if (opcion == 4)
                                bucleServicios = false;
                            
                        } while (bucleServicios);                        
                        break;
                    case 5:
                        bucleServicios = true;
                        do
                        {
                            Console.WriteLine("**************************************\n" +
                                          "*    SERVICIOS DE CONFIGURACIÓN      *\n" +
                                          "**************************************\n" +
                                          "*    1-Configurar nombre de empresa  *\n" +
                                          "*    2-Llenar información            *\n" +
                                          "*    3-Salir                         *\n" +
                                          "**************************************");
                            Console.WriteLine("Ingrese opcion");
                            try
                            {
                                opcion = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Ingrese una opción válida");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            if (opcion == 1)
                            {
                                Console.WriteLine("Ingrese el nombre");
                                nombreEmp = Console.ReadLine();
                                Console.WriteLine("Nombre configurado");
                                Console.ReadKey();
                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Quiere llenar la informacion?");
                                string resp = Console.ReadLine();
                                if (resp.Contains("si"))
                                {
                                    serviciosCliente.AgregarInformacionCliente();
                                    serviciosProducto.AgregarInformacionProducto();
                                    Console.WriteLine("Información registrada");
                                    Console.ReadKey();
                                }
                            }
                            else if (opcion == 3)
                                bucleServicios = false;
                            Console.Clear();
                        } while (bucleServicios);                                                
                        break;
                    case 6:
                        bucle = false; break;
                    default:                        
                        break;
                }
            } while (bucle);
            Console.WriteLine("PROGRAMA FINALIZADO");
        }
    }
}
