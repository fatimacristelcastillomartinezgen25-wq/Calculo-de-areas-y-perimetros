using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=== 009 - CALCULO DE AREAS Y PERIMETROS ===");
        Console.ResetColor();
        Console.WriteLine();

        // Cuadrado - Verde
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Ingresa el lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine());
        double areaCuadrado = lado * lado;
        double perimetroCuadrado = lado * 4;
        Console.WriteLine($"Area del cuadrado: {areaCuadrado}");
        Console.WriteLine($"Perimetro del cuadrado: {perimetroCuadrado}");
        Console.ResetColor();
        Console.WriteLine();

        // Rectangulo - Azul
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Ingresa base del rectangulo: ");
        double baseR = double.Parse(Console.ReadLine());
        Console.Write("Ingresa altura del rectangulo: ");
        double alturaR = double.Parse(Console.ReadLine());
        double areaRect = baseR * alturaR;
        double perimRect = 2 * (baseR + alturaR);
        Console.WriteLine($"Area del rectangulo: {areaRect}");
        Console.WriteLine($"Perimetro del rectangulo: {perimRect}");
        Console.ResetColor();
        Console.WriteLine();

        // Triangulo - Rojo
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ingresa base del triangulo: ");
        double baseT = double.Parse(Console.ReadLine());
        Console.Write("Ingresa altura del triangulo: ");
        double alturaT = double.Parse(Console.ReadLine());
        Console.Write("Ingresa los otros 2 lados del triangulo para el perimetro: ");
        double lado2 = double.Parse(Console.ReadLine());
        double lado3 = double.Parse(Console.ReadLine());
        double areaTri = (baseT * alturaT) / 2;
        double perimTri = baseT + lado2 + lado3;
        Console.WriteLine($"Area del triangulo: {areaTri}");
        Console.WriteLine($"Perimetro del triangulo: {perimTri}");
        Console.ResetColor();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Programa finalizado con exito!");
        Console.ResetColor();
    }
}