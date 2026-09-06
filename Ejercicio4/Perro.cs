using System;

namespace GuiaPractica1.Ejercicio4
{
    public class Perro : Animal //Clase derivada de Animal
    {
        public override void HacerSonido() //Sobreescribimos el metodo de la clase base para que haga un sonido diferente
        {
            Console.WriteLine("El perro dice: ¡Guau guau!");
        }
    }
}