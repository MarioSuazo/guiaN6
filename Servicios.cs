using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaN6
{
    public abstract class Servicios
    {
        public abstract void realizarServicio();
        
        public abstract double calcularCosto();

        public abstract void tiempoTotal(double tipo);
    }
}
