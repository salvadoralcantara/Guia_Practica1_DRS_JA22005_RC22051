using System;

namespace GuiaPractica1.Ejercicio1
{
    public class CuentaBancaria{
        
        private decimal saldo; // Mantiene el estado interno oculto desde el exterior

        // Metodo que retorna el valor del saldo actual
        public decimal ObtenerSaldo(){
            return saldo;
        }

        // Incrementa el saldo si el monto recibido es mayor a cero
        public void Depositar(decimal monto){
            if (monto > 0){
                saldo += monto;
                Console.WriteLine($"Depósito exitoso. Nuevo saldo: {saldo}");
            }
            else{
                Console.WriteLine("Error: El monto a depositar debe ser mayor a cero.");
            }
        }

        // Disminuye el saldo previa validacion de fondos y montos positivos
        public void Retirar(decimal monto){
            if (monto <= 0){
                Console.WriteLine("Error: El monto a retirar debe ser mayor a cero.");
            }
            else if (monto > saldo){
                Console.WriteLine("Error: Fondos insuficientes para esta operación.");
            }
            else{
                saldo -= monto;
                Console.WriteLine($"Retiro exitoso. Nuevo saldo: {saldo}");
            }
        }
    }
}