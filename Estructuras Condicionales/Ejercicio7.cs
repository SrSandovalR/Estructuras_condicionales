using System;


internal class Ejercicio7
{
    private static void Main(string[] args)
    {
        try
        {


            Console.Write("Introduce una figura geometrica (triangulo, cuadrado o circulo): ");
            string figura = Console.ReadLine().ToLower();

            switch (figura)
            {
                case "triangulo":
                    Console.Write("Introduce la base del triangulo(ingrese solo numeros): ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Introduce la altura del triangulo: ");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                    double areaTriangulo = baseTriangulo * alturaTriangulo / 2;
                    Console.WriteLine($"El area del triangulo es {areaTriangulo}.");
                    break;

                case "cuadrado":
                    Console.Write("Introduce el lado del cuadrado(Ingrese solo numeros): ");
                    double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                    double areaCuadrado = Math.Pow(ladoCuadrado, 2);
                    Console.WriteLine($"El area del cuadrado es {areaCuadrado}.");
                    break;

                case "circulo":
                    Console.Write("Introduce el radio del circulo(Ingrese solo numeros): ");
                    double radioCirculo = Convert.ToDouble(Console.ReadLine());
                    double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
                    Console.WriteLine($"El area del circulo es {areaCirculo}.");
                    break;

                default:
                    Console.WriteLine("Figura geometrica no reconocida.");
                    break;
            }

        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Ha ocurrido un error solo debe ingresar numeros.");
            Console.Read();
            Console.ReadLine();
            throw;
        }
    }
}