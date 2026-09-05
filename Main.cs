using System;
using GuiaPractica1.Ejercicio1;

namespace GuiaPractica1
{
    class Program{
        static void Main(string[] args){
            
            Console.WriteLine("=== GUÍA PRÁCTICA 1 ===");
            
            // --- EJERCICIO 1 ---
            Console.WriteLine("\n--- Ejercicio 1: Cuenta Bancaria ---");
            CuentaBancaria miCuenta = new CuentaBancaria();
            Console.WriteLine($"Saldo inicial: {miCuenta.ObtenerSaldo()}");

            miCuenta.Depositar(100);
            Console.WriteLine($"Saldo tras depositar: {miCuenta.ObtenerSaldo()}");

            miCuenta.Retirar(30);
            Console.WriteLine($"Saldo tras retirar: {miCuenta.ObtenerSaldo()}");

            miCuenta.Retirar(200); // Error: fondos insuficientes
            Console.WriteLine($"Saldo final: {miCuenta.ObtenerSaldo()}");

            //  Ejercicios 2, 3, 4 y 5...
        }
    }
}