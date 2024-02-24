internal class Ejercicio8
{
    private static void Main(string[] args)
    {
        Console.Write("Introduce un numero del 1 al 5 en letra (uno, dos, tres, cuatro, cinco): ");
        string numeroEnLetra = Console.ReadLine().ToLower();

        switch (numeroEnLetra)
        {
            case "uno":
                Console.WriteLine("El numero es 1.");
                break;

            case "dos":
                Console.WriteLine("El numero es 2.");
                break;

            case "tres":
                Console.WriteLine("El numero es 3.");
                break;

            case "cuatro":
                Console.WriteLine("El numero es 4.");
                break;

            case "cinco":
                Console.WriteLine("El numero es 5.");
                break;

            default:
                Console.WriteLine("Numero no reconocido.");
                break;
        }
    }
}