# Guia_Practica1_DRS_JA22005_RC22051

Guía práctica 1 - Desarrollo y Reutilización de Software (Ciclo II/2026). Aplicación de los
principios de programación orientada a objetos (POO) en C#: abstracción, encapsulación,
herencia y polimorfismo.

## Alumnos:

- Salvador Isaías Juárez Alcántara - JA22005
- Guillermo Alexander Rodríguez Cortez - RC22051

## Estructura del proyecto

El proyecto está estructurado de manera modular dentro de la solución de **.NET 8**, separando cada principio de POO en sus respectivas carpetas y namespaces:

* **`Main.cs`**: Clase principal que coordina el flujo y ejecuta los casos de prueba solicitados para todos los ejercicios en la consola.
* **`Ejercicio1` (Abstracción)**: Contiene `CuentaBancaria.cs`, donde se oculta la gestión directa del saldo.
* **`Ejercicio2` (Encapsulación)**: Contiene `Empleado.cs`, implementando propiedades públicas con validaciones de rango.
* **`Ejercicio3` (Herencia Simple)**: Incluye la relación entre la clase base `Vehiculo.cs` y la clase `Coche.cs`.
* **`Ejercicio4` (Polimorfismo)**: Contiene `Animal.cs` con el método virtual `HacerSonido()`, y sus derivaciones en `Perro.cs` y `Gato.cs`.
* **`Ejercicio5` (Herencia Multinivel)**: Implementa la clase intermedia `Mamifero.cs` (que reutiliza la base `Animal` del ejercicio anterior) y la especialización `Perro.cs` que completa la cadena jerárquica.

Cada carpeta `Ejercicio` contiene únicamente las clases necesarias para el desarrollo de cada uno. Todas se compilan
juntas por el proyecto principal y se demuestran desde `Main.cs`.

## Cómo ejecutar

Requisitos: [.NET SDK 8](https://dotnet.microsoft.com/download) o superior.

```bash
dotnet run --project GuiaPractica1.csproj
```

También puede ejecutarse desde Visual Studio Code con la extensión C# Dev Kit

## Ejercicios

1. **Abstracción** - `CuentaBancaria`: el saldo es privado y solo se accede por los métodos.
2. **Encapsulación** - `Empleado`: campos privados protegidos por propiedades validadas.
3. **Herencia simple** - `Coche` hereda de `Vehiculo` y añade su propio método.
4. **Polimorfismo** - `Perro` y `Gato` sobrescriben `HacerSonido()` vía referencia `Animal`.
5. **Herencia multinivel** - `Perro` → `Mamifero` → `Animal` con método sobrescrito.
