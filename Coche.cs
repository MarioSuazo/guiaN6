﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaN6
{
    public class Coche : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando Mantenimiento del coche: Cambio de aceite y revisión de frenos.");
        }

        public override double obtenerCostoMantenimiento()
        {
            return 150.0; //Costo del mantenimiento del coche.
        }

        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial.");
        }
    }
}
