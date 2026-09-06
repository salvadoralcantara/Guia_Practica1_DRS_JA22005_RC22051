using System;
using GuiaPractica1.Ejercicio4; // Importamos la clase Animal hecha en el Ejercicio 4

namespace GuiaPractica1.Ejercicio5
{
    // Mamifero hereda de la clase base Animal
    public class Mamifero : Animal
    {
        public void Alimentar() // Metodo propio de la clase Mamifero
        {
            Console.WriteLine("El mamífero amamanta a sus crías.");
        }
    }
}