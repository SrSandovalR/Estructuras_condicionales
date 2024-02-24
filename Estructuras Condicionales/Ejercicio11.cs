internal class Ejercicio11
{
    private static void Main(string[] args)
    {
        Console.Write("Introduce el idioma de tu preferencia (espanol, ingles, frances): ");
        string idioma = Console.ReadLine().ToLower();

        switch (idioma)
        {
            case "espanol":
                Console.WriteLine("¡Bienvenido!");
                break;

            case "ingles":
                Console.WriteLine("Welcome!");
                break;

            case "frances":
                Console.WriteLine("Bienvenue!");
                break;

            default:
                Console.WriteLine("Idioma no reconocido.");
                break;
        }
    }
}