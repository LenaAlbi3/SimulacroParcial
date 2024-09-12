using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElectronicos.Modulos
{
    public class Producto
    {
        public string NombreProd { get; private set; }
        public double Precio { get; private set; }
        public string CodigoProd { get; private set; }
        public Producto(string nombreProd, double precio, string codigoProd)
        {
            NombreProd = nombreProd;
            Precio = precio;
            CodigoProd = codigoProd;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"--- PRODUCTO ---\n" +
                $"NOMBRE: {NombreProd}\n" +
                $"PRECIO: {Precio}\n" +
                $"CODIGO: {CodigoProd}\n");
        }
    }
}
