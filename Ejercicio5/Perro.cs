using System;

namespace GuiaPractica1.Ejercicio5
{
    // Esta clase Perro hereda de Mamifero, completando la cadena multinivel
    public class Perro : Mamifero
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro (Mamífero) dice: ¡Guau guau!");
        }
    }
}