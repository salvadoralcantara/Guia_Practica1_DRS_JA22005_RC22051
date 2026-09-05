using System;

namespace GuiaPractica1.Ejercicio3
{
    public class Coche : Vehiculo // Clase derivada que hereda de Vehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("El coche se conduce por la carretera.");
        }
    }
}