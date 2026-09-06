using System;

namespace GuiaPractica1.Ejercicio4
{
    public class Animal //Clase base que usaremos
    {
        public virtual void HacerSonido() //Metodo virtual que sera sobreescrito por las clases derivadas
        {
            Console.WriteLine("El animal esta haciendo un sonido.");
        }
    }
}