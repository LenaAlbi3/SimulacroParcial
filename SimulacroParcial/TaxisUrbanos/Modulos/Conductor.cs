using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxisUrbanos.Modulos
{
    public class Conductor
    {
        public string Nombre { get; set; }
        public int Licencia { get; set; }
        public bool IsOcupado { get; set; }
        public Conductor(string nombre, int licencia)
        {
            Nombre = nombre;
            Licencia = licencia;
        }
        public Conductor(string nombre, int licencia, bool isOcupado)
        {
            Nombre = nombre;
            Licencia = licencia;
            IsOcupado = isOcupado;
        }
        public void CambiarEstado()
        {
            IsOcupado = !IsOcupado;
        }
    }
}
