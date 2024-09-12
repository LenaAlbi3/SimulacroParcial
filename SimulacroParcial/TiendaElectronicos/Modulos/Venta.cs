using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElectronicos.Modulos
{
    public class Venta
    {
        public DateTime Fecha { get; private set; }
        public Producto ProductoVendido { get; private set; }
        public int Cantidad { get; private set; }
        public Cliente Cliente { get; private set; }
        public Venta(DateTime fecha, Producto productoVendido, int cantidad, Cliente cliente)
        {
            Fecha = fecha;
            ProductoVendido = productoVendido;
            Cantidad = cantidad;
            Cliente = cliente;
        }
        public double CalcularTotal(Venta venta)
        {
            double total = 0;
            total = ProductoVendido.Precio;
            total *= venta.Cantidad;
            return total;
        }
        public string MostrarVenta(Venta venta)
        {
            return venta.ToString();
        }
    }
}
