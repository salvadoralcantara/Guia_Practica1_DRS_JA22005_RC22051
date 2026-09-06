# Guia_Practica1_DRS_JA22005_RC22051

Guía práctica 1 - Desarrollo y Reutilización de Software (Ciclo II/2026). Aplicación de los
principios de programación orientada a objetos (POO) en C#: abstracción, encapsulación,
herencia y polimorfismo.

## Alumnos:

# Salvador Isaías Juárez Alcántara - JA22005
# Guillermo Alexander Rodríguez Cortez - RC22051

## Estructura del proyecto

```
├── Main.cs                 # Punto de entrada: ejecuta la demo de los 5 ejercicios
├── GuiaPractica1.csproj    # Definición del proyecto (.NET 8)
│
├── Ejercicio1/             # Abstracción de datos
│   └── CuentaBancaria.cs
├── Ejercicio2/             # Encapsulación y control de acceso
│   └── Empleado.cs
├── Ejercicio3/             # Herencia simple
│   ├── Vehiculo.cs
│   └── Coche.cs
├── Ejercicio4/             # Polimorfismo
│   ├── Animal.cs
│   ├── Perro.cs
│   └── Gato.cs
└── Ejercicio5/             # Herencia multinivel y sobrescritura
    ├── Animal.cs
    ├── Mamifero.cs
    └── Perro.cs
```

Cada carpeta `Ejercicio` contiene únicamente las clases necesarias para el desarrollo de cada uno. Todas se compilan
juntas por el proyecto principal y se demuestran desde `Main.cs`.

## Cómo ejecutar

Requisitos: [.NET SDK 8](https://dotnet.microsoft.com/download) o superior.

```bash
dotnet run --project GuiaPractica1.csproj
```

También puede ejecutarse desde Visual Studio Code con la extensión C# Dev Kit

## Ejercicios

1. **Abstracción** — `CuentaBancaria`: el saldo es privado y solo se accede por los métodos.
2. **Encapsulación** — `Empleado`: campos privados protegidos por propiedades validadas.
3. **Herencia simple** — `Coche` hereda de `Vehiculo` y añade su propio método.
4. **Polimorfismo** — `Perro` y `Gato` sobrescriben `HacerSonido()` vía referencia `Animal`.
5. **Herencia multinivel** — `Perro` → `Mamifero` → `Animal` con método sobrescrito.
