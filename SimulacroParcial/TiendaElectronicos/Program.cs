using System.ComponentModel;
using TiendaElectronicos.Modulos;

namespace TiendaElectronicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Juan", 336459884, "1");
            cliente.MostrarCliente();
            Producto prod = new Producto("Alfajor", 1000, "12");
            prod.MostrarDetalles();
            Venta venta = new Venta(new DateTime(09, 12, 2024), prod, 2, cliente);
           
        }
    }
}