using System;

namespace Tarea2_Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("    ACTIVIDAD 2 - CONTROL DE FLUJO      ");
                Console.WriteLine("    Asignatura: Algoritmos Computacionales");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Calcular área del triángulo");
                Console.WriteLine("2. Calcular área del cuadrado");
                Console.WriteLine("3. Calcular área del círculo");
                Console.WriteLine("4. Verificar mayoría de edad");
                Console.WriteLine("5. Salir");
                Console.Write("\nPor favor, seleccione una opción: ");
                
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("--- CÁLCULO ÁREA DE UN TRIÁNGULO ---");
                        Console.Write("Ingrese la base: ");
                        double baseT = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura: ");
                        double alturaT = double.Parse(Console.ReadLine());
                        
                        double resTriangulo = CalcularAreaTriangulo(baseT, alturaT);
                        Console.WriteLine("\nEl área del triángulo es: " + resTriangulo);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("--- CÁLCULO ÁREA DE UN CUADRADO ---");
                        Console.Write("Ingrese el lado del cuadrado: ");
                        double lado = double.Parse(Console.ReadLine());
                        
                        double resCuadrado = CalcularAreaCuadrado(lado);
                        Console.WriteLine("\nEl área del cuadrado es: " + resCuadrado);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("--- CÁLCULO ÁREA DE UN CÍRCULO ---");
                        Console.Write("Ingrese el radio del círculo: ");
                        double radio = double.Parse(Console.ReadLine());
                        
                        double resCirculo = CalcularAreaCirculo(radio);
                        Console.WriteLine("\nEl área del círculo es: " + resCirculo);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("--- VERIFICACIÓN DE EDAD ---");
                        Console.Write("Ingrese su edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        
                        string mensajeEdad = VerificarEdad(edad);
                        Console.WriteLine("\n" + mensajeEdad);
                        break;

                    case 5:
                        Console.WriteLine("\nSaliendo del programa. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }

        // Función que calcula el área del triángulo
        static double CalcularAreaTriangulo(double b, double h)
        {
            double area = (b * h) / 2;
            return area;
        }

        // Función que calcula el área de un cuadrado
        static double CalcularAreaCuadrado(double l)
        {
            double area = l * l;
            return area;
        }

        // Función que calcula el área de un círculo[cite: 1]
        static double CalcularAreaCirculo(double r)
        {
            double area = Math.PI * (r * r);
            return area;
        }

        // Función que verifica si es mayor o menor de edad[cite: 1]
        static string VerificarEdad(int edad)
        {
            if (edad >= 18)
            {
                return "Usted es mayor de edad.";
            }
            else
            {
                return "Usted es menor de edad.";
            }
        }
    }
}
