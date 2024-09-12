using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElectronicos.Modulos
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public double Telefono { get; private set; }
        public string Codigo { get; private set; }
        public Cliente(string nombre, double telefono, string codigo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Codigo = codigo;
        }
        public void MostrarCliente()
        {
            Console.WriteLine($"--- CLIENTE ---\n" +
                $"NOMBRE: {Nombre}\n" +
                $"TELEFONO: {Telefono}\n" +
                $"CODIGO: {Codigo}\n");
        }
    }
}
