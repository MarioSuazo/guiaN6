using System;

namespace guiaN6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            double moto, coche;

            Vehiculo miCoche = new Coche();
            miCoche.RealizarMantenimiento();
            coche = miCoche.obtenerCostoMantenimiento();
            Console.WriteLine("Costo del Mantenimiento del Coche: $" + coche + "\n");

            Vehiculo miMoto = new Moto();
            miMoto.RealizarMantenimiento();
            moto = miMoto.obtenerCostoMantenimiento();
            Console.WriteLine("Costo del Mantenimiento de la Moto: $" + moto + "\n");

            miCoche.Lavar();

            Coche miCocheReal = new Coche();
            miCocheReal.Lavar();

            //Servicios servicios = new Servicios();
            
            Servicios servicioAceite = new CambioAceite(); //Instancia cambio de aceite.
            servicioAceite.realizarServicio(); //Llamada de método realizar servicio.
            Console.WriteLine("Costo del Cambio de Aceite: $" + servicioAceite.calcularCosto());
            servicioAceite.tiempoTotal(coche); //Calcular Tiempo del cambio de aceite del coche.
            servicioAceite.tiempoTotal(moto); //Calcular Tiempo del cambio de aceite de la moto.

            Servicios servicioFrenos = new ReparacionFrenos(); //Instancia cambio de aceite.
            servicioFrenos.realizarServicio(); //Llamada de método realizar servicio.
            Console.WriteLine("Costo de la Reparación de Frenos: $" + servicioFrenos.calcularCosto());
            servicioFrenos.tiempoTotal(coche); //Calcular Tiempo de reparación de frenos del coche.
            servicioFrenos.tiempoTotal(moto); //Calcular Tiempo de reparación de frenos de la moto.


        }
    }
}