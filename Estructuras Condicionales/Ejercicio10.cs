internal class Ejercicio10
{
    private static void Main(string[] args)
    {
        Console.Write("Introduce el tipo de servicio (lavado de auto, cambio de aceite, revision mecanica): ");
        string servicio = Console.ReadLine().ToLower();

        switch (servicio)
        {
            case "lavado de auto":
                Console.WriteLine("El importe a pagar por el lavado de auto es $30.");
                break;

            case "cambio de aceite":
                Console.WriteLine("El importe a pagar por el cambio de aceite es $75.");
                break;

            case "revision mecanica":
                Console.WriteLine("El importe a pagar por la revision mecanica es $200.");
                break;

            default:
                Console.WriteLine("Servicio no reconocido.");
                break;
        }
    }
}