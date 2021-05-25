using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller3POO.clases;

namespace Taller3POO.servicios
{
    class ServicioCliente
    {
        public List<Cliente> clientes = new List<Cliente>();
              
        public bool ValidarCliente(long documento)
        {
            foreach (var cliente in clientes)
            {
                if (documento == cliente.documento)
                    return true;
            }
            return false;
        }
        public void RegistrarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }
        public void BuscarCliente(long documento)
        {
            foreach (var cliente in clientes)
            {
                if (documento == cliente.documento)
                {
                    Console.WriteLine($"Nombre: {cliente.nombre} - Documento: {cliente.documento} - Direccion: {cliente.direccion} - Telefono: {cliente.telefono}");
                }
            }
        }
        public void ModificarCliente(long documento)
        {
            foreach (var cliente in clientes)
            {
                if (documento == cliente.documento)
                {
                    Console.WriteLine("Que quiere modificar?\n1-Nombre\n2-Direccion\n3-Telefono");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nombre ");
                            cliente.nombre = Console.ReadLine();
                            Console.WriteLine("Nombre modificado correctamente");
                            break;
                        case 2:
                            Console.WriteLine("Ingrese la dirección");
                            cliente.direccion = (Console.ReadLine());
                            Console.WriteLine("Dirección modificada correctamente");
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el teléfono");
                            cliente.telefono = long.Parse(Console.ReadLine());
                            Console.WriteLine("Teléfono modificado correctamente");
                            break;
                        default:
                            Console.WriteLine("Ingrese una opcion valida");
                            break;
                    }
                }
            }
        }
        public void EliminarCliente(long documento)
        {
            int index = 0;
            foreach (var cliente in clientes)
            {
                if (documento == cliente.documento)                
                    index = clientes.IndexOf(cliente);                
            }
            clientes.RemoveAt(index);
            Console.WriteLine("Cliente eliminado");
        }
        public void ListarClientes()
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Nombre: {cliente.nombre} - Documento: {cliente.documento} - Direccion: {cliente.direccion} - Telefono: {cliente.telefono}");
            }
        }         
        
        public void AgregarInformacionCliente()
        {
            Cliente cliente1 = new Cliente();
            cliente1.nombre = "Pedro"; cliente1.documento = 1039566512; cliente1.direccion = "Cra 25B # 55"; cliente1.telefono = 3461245;
            clientes.Add(cliente1);
            Cliente cliente2 = new Cliente();
            cliente2.nombre = "Luisa"; cliente2.documento = 1135568102; cliente2.direccion = "Cra 11A # 33"; cliente2.telefono = 2856494;
            clientes.Add(cliente2);
            Cliente cliente3 = new Cliente();
            cliente3.nombre = "Carlos"; cliente3.documento = 1024512011; cliente3.direccion = "Calle 24 # sur 33"; cliente3.telefono = 2456849;
            clientes.Add(cliente3);
            Cliente cliente4 = new Cliente();
            cliente4.nombre = "Pepe"; cliente4.documento = 1302545107; cliente4.direccion = "Calle 22 # 11 a1"; cliente4.telefono = 3451120;
            clientes.Add(cliente4);
            Cliente cliente5 = new Cliente();
            cliente5.nombre = "Carolina"; cliente5.documento = 1005846592; cliente5.direccion = "Cra 33AA # 55L"; cliente5.telefono = 3124512;
            clientes.Add(cliente5);
            Cliente cliente6 = new Cliente();
            cliente6.nombre = "Alejandra"; cliente6.documento = 1045723652; cliente6.direccion = "Cra 22C # 30L"; cliente6.telefono = 3236541;
            clientes.Add(cliente6);
            Cliente cliente7 = new Cliente();
            cliente7.nombre = "Gabriela"; cliente7.documento = 1032523741; cliente7.direccion = "Cra 55N# 52K"; cliente7.telefono = 3234189;
            clientes.Add(cliente7);
            Cliente cliente8 = new Cliente();
            cliente8.nombre = "Sara"; cliente8.documento = 1005235451; cliente8.direccion = "Cra 96l # 63H"; cliente8.telefono = 3748963;
            clientes.Add(cliente8);
            Cliente cliente9 = new Cliente();
            cliente9.nombre = "Daniel"; cliente9.documento = 1041236854; cliente9.direccion = "Cra 45A # 59B"; cliente9.telefono = 3632541;
            clientes.Add(cliente9);
            Cliente cliente10 = new Cliente();
            cliente10.nombre = "Carla"; cliente10.documento = 1041652896; cliente10.direccion = "Cra 45E # 23ML"; cliente10.telefono = 3854196;
            clientes.Add(cliente10);
        }
    }
}
