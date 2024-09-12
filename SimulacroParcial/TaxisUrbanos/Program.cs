namespace TaxisUrbanos.Modulos.Enums
{
    class Program
    {
        static void Main(string[] args) 
        {
            Pasajero pasajero = new Pasajero("Ana", "italia 120", true);
            Conductor conductor1 = new Conductor("Ana", 1, true);
            Conductor conductor2 = new Conductor("Ana", 2, false);
            SolicitudViaje viaje = pasajero.SolicitarViaje(pasajero);
            viaje.AsignarConductor(conductor2);
            viaje.TerminarViaje(conductor2);

        }

    }
}
