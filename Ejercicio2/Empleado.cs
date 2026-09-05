using System;

namespace GuiaPractica1.Ejercicio2
{
    public class Empleado{
        // Atributos privados para proteger los datos
        private string nombre = string.Empty;
        private int edad;

        // Propiedad pública para acceder y modificar el nombre
        public string Nombre{
            get { return nombre; }

            set{
                if (string.IsNullOrWhiteSpace(value)){
                    Console.WriteLine("Error: el nombre no puede estar vacio.");
                }
                else{
                    nombre = value;
                }
            }
        }

        // Propiedad pública con validación de rango para la edad
        public int Edad{
            get { return edad; }

            set{
                if (value <= 0 || value >= 100){
                    Console.WriteLine("Error: la edad debe ser un valor positivo y menor que 100.");
                }
                else{
                    edad = value;
                }
            }
        }

        public Empleado(string nombre, int edad){
            Nombre = nombre;
            Edad = edad;
        }
    }
}