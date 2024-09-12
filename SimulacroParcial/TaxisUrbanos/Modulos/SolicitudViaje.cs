using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxisUrbanos.Enums;

namespace TaxisUrbanos.Modulos
{
    public class SolicitudViaje
    {
        public TipoVehiculo Vehiculo { get; set; }
        public double Distancia { get; set; }
        public Conductor ConductorV { get; set; }
        public Pasajero PasajeroV { get; set; }
        public SolicitudViaje(TipoVehiculo vehiculo, double distancia, Pasajero pasajeroV)
        {
            Vehiculo = vehiculo;
            Distancia = distancia;
            PasajeroV = pasajeroV;

        }
        public void AsignarConductor(Conductor conductor)
        {
            if(conductor.IsOcupado == false)
            {
                ConductorV = conductor;
                conductor.CambiarEstado();
            }
            else
            {
                throw new Exception("El conductor que intento seleccionar ya esta ocupado");
            }
        }
        public void TerminarViaje(Conductor conductor)
        {
            conductor.CambiarEstado();
        }

    }
}
