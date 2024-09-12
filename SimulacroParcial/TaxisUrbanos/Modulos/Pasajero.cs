using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxisUrbanos.Enums;

namespace TaxisUrbanos.Modulos
{
    public class Pasajero
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public bool EstatusMembresia { get; set; }
        public Pasajero(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }
        public Pasajero(string nombre, string direccion, bool estatus) 
        {
            Nombre = nombre;
            Direccion = direccion;
            EstatusMembresia = estatus;
        }
        public void CambiarEstatusMembresia()
        {
            Console.WriteLine("El cliente forma parte del programa de fidelidad? 1. si \n2. no\n");
            int opc = int.Parse(Console.ReadLine());
            if(opc == 1)
            {
                EstatusMembresia = true;
            }
            if(opc == 2)
            {
                EstatusMembresia = false;
            }
            else
            {
                Console.WriteLine("opcion invalida");
            }
        }
        public SolicitudViaje SolicitarViaje(Pasajero pasajero)
        {
            Console.WriteLine("Ingrese la distancia a recorrer en kilometros: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de vehiculo que necesita: \n 1. Auto \n2. Van");
            int tipo = int.Parse(Console.ReadLine());
            TipoVehiculo tipoV;
            switch(tipo) 
            {
                case 1:
                    tipoV = TipoVehiculo.AutoEstandar;
                    break;
                    case 2:
                    tipoV = TipoVehiculo.Van;

                    break;
                default:
                    throw new Exception("Opcion desconocida");
                    break;
            }
            SolicitudViaje viaje = new SolicitudViaje(tipoV, km, pasajero);
            return viaje;
        }
    }
}
