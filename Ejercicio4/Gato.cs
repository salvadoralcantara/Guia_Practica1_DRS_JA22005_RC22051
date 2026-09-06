using System;

namespace GuiaPractica1.Ejercicio4
{
    public class Gato : Animal //Segunda clase derivada de Animal
    {
        public override void HacerSonido() //Sobreescribimos el metodo de la clase base para que haga un sonido diferente
        {
            Console.WriteLine("El gato dice: ¡Miau miau!");
        }
    }
}