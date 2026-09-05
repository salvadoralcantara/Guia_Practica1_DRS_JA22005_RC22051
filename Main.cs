using System;
using GuiaPractica1.Ejercicio1;
using GuiaPractica1.Ejercicio2;

namespace GuiaPractica1
{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("=== GUÍA PRÁCTICA 1 ===\n");

            // --- EJERCICIO 1 ---
            Console.WriteLine("--- Ejercicio 1: Cuenta Bancaria ---");
            CuentaBancaria miCuenta = new CuentaBancaria();
            Console.WriteLine($"Saldo inicial: {miCuenta.ObtenerSaldo()}\n");

            miCuenta.Depositar(100);
            Console.WriteLine($"Saldo tras depositar: {miCuenta.ObtenerSaldo()}\n");

            miCuenta.Retirar(30);
            Console.WriteLine($"Saldo tras retirar: {miCuenta.ObtenerSaldo()}\n");

            miCuenta.Retirar(200); // Error: fondos insuficientes
            Console.WriteLine($"Saldo final: {miCuenta.ObtenerSaldo()}\n");

         // _________________________________________________________________________________

            // --- EJERCICIO 2 ---
            Console.WriteLine("--- Ejercicio 2: Encapsulacion (Empleado) ---\n");
            Empleado empleado = new Empleado("Ana Martinez", 28);
            Console.WriteLine($"Datos iniciales: {empleado.Nombre}, {empleado.Edad} anios\n");

            empleado.Nombre = "Carlos";
            Console.WriteLine($"Nombre actualizado a: {empleado.Nombre}\n");

            empleado.Nombre = "";   // Error: nombre vacio
            Console.WriteLine($"El nombre se mantiene en: {empleado.Nombre}\n");

            empleado.Edad = 45;
            Console.WriteLine($"Edad actualizada a: {empleado.Edad}\n");

            empleado.Edad = 0;      // Error: edad invalida
            empleado.Edad = 100;    // Error: edad invalida
            Console.WriteLine($"La edad se mantiene en: {empleado.Edad}\n");

            Console.WriteLine($"Datos finales: {empleado.Nombre}, {empleado.Edad} anios");

            //  Ejercicios 3, 4 y 5...
        }
    }
}