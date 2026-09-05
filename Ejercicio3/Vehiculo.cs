using System;

namespace GuiaPractica1.Ejercicio3
{
    public class Vehiculo // Clase base
    {
        public void Arrancar()
        {
            Console.WriteLine("El vehiculo arranca.");
        }

        public void Detener()
        {
            Console.WriteLine("El vehiculo se detiene.");
        }
    }
}