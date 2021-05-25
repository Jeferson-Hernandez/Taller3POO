using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller3POO.clases;

namespace Taller3POO.servicios
{
    class ServicioProducto
    {
        public List<Producto> productos = new List<Producto>();
        public bool ValidarProducto(int codigo)
        {
            foreach (var producto in productos)
            {
                if (codigo == producto.codigo)
                    return true;
            }
            return false;
        }
        public void RegistrarProducto(Producto producto)
        {
            productos.Add(producto);
        }
        public void BuscarProducto(int codigo)
        {
            foreach (var producto in productos)
            {
                if (codigo == producto.codigo)
                {
                    Console.WriteLine($"Nombre: {producto.nombre} - Precio: {producto.precio} - Cantidad: {producto.cantidad} - Codigo: {producto.codigo}");
                }
            }
        }
        public void ModificarProducto(int codigo)
        {
            foreach (var producto in productos)
            {
                if (codigo == producto.codigo)
                {
                    Console.WriteLine("Que quiere modificar?\n1-Nombre\n2-Precio\n3-Cantidad");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nombre");
                            producto.nombre = Console.ReadLine();
                            Console.WriteLine("Nombre modificado correctamente");
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el precio");
                            producto.precio = long.Parse(Console.ReadLine());
                            Console.WriteLine("Precio modificado correctamente");
                            break;
                        case 3:
                            Console.WriteLine("Ingrese la cantidad");
                            producto.cantidad = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cantidad modificada correctamente");
                            break;
                        default:
                            Console.WriteLine("Ingrese una opcion valida");
                            break;
                    }
                }
            }
        }
        public void EliminarProducto(int codigo)
        {
            int index = 0;
            foreach (var producto in productos)
            {
                if (codigo == producto.codigo)
                    index = productos.IndexOf(producto);
            }
            productos.RemoveAt(index);
            Console.WriteLine("Producto eliminado");
        }
        public void ListarProductos()
        {
            foreach (var producto in productos)
            {
                Console.WriteLine($"Nombre: {producto.nombre} - Precio: {producto.precio} - Cantidad: {producto.cantidad} - Codigo: {producto.codigo}");
            }            
        }
        public long DevolverPrecio(int codProducto)
        {
            
            foreach (var producto in productos)
            {
                if (codProducto.Equals(producto.codigo))
                {
                    long precio = producto.precio;
                    return precio;
                }
            }
            return 100;
        }
        public bool CantidadExcedida(int cantidad, int codigo)
        {
            foreach (var producto in productos)
            {
                if (codigo.Equals(producto.codigo))
                {
                    if (cantidad <= producto.cantidad)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void RestarCantidad(int cantidad, int codigo)
        {
            foreach (var producto in productos)
            {
                if (codigo.Equals(producto.codigo))
                {                    
                    producto.cantidad -= cantidad;
                }
            }
        }
        
        public void AgregarInformacionProducto()
        {
            Producto producto1 = new Producto();
            producto1.nombre = "Audifonos"; producto1.cantidad = 20; producto1.precio = 180000; producto1.codigo = 100;
            productos.Add(producto1);
            Producto producto2 = new Producto();
            producto2.nombre = "Raton"; producto2.cantidad = 25; producto2.precio = 65000; producto2.codigo = 101;
            productos.Add(producto2);
            Producto producto3 = new Producto();
            producto3.nombre = "Teclado"; producto3.cantidad = 10; producto3.precio = 320000; producto3.codigo = 102;
            productos.Add(producto3);
            Producto producto4 = new Producto();
            producto4.nombre = "Altavoz"; producto4.cantidad = 5; producto4.precio = 99000; producto4.codigo = 103;
            productos.Add(producto4);
            Producto producto5 = new Producto();
            producto5.nombre = "Silla"; producto5.cantidad = 11; producto5.precio = 450000; producto5.codigo = 104;
            productos.Add(producto5);
            Producto producto6 = new Producto();
            producto6.nombre = "Televisor"; producto6.cantidad = 6; producto6.precio = 800000; producto6.codigo = 105;
            productos.Add(producto6);
            Producto producto7 = new Producto();
            producto7.nombre = "Cafetera"; producto7.cantidad = 8; producto7.precio = 200000; producto7.codigo = 106;
            productos.Add(producto7);
            Producto producto8 = new Producto();
            producto8.nombre = "Licuadora"; producto8.cantidad = 5; producto8.precio = 150000; producto8.codigo = 107;
            productos.Add(producto8);
            Producto producto9 = new Producto();
            producto9.nombre = "Lavadora"; producto9.cantidad = 10; producto9.precio = 500000; producto9.codigo = 108;
            productos.Add(producto9);
            Producto producto10 = new Producto();
            producto10.nombre = "Closet"; producto10.cantidad = 12; producto10.precio = 320000; producto10.codigo = 109;
            productos.Add(producto10);
        }
    }
}
