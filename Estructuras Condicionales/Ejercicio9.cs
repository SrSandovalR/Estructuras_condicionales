internal class Ejercicio9
{
    private static void Main(string[] args)
    {
        Console.Write("Introduce un numero del 1 al 7: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("El día de la semana es Lunes.");
                break;

            case 2:
                Console.WriteLine("El día de la semana es Martes.");
                break;

            case 3:
                Console.WriteLine("El día de la semana es Miercoles.");
                break;

            case 4:
                Console.WriteLine("El día de la semana es Jueves.");
                break;

            case 5:
                Console.WriteLine("El día de la semana es Viernes.");
                break;

            case 6:
                Console.WriteLine("El día de la semana es Sabado.");
                break;

            case 7:
                Console.WriteLine("El día de la semana es Domingo.");
                break;

            default:
                Console.WriteLine("Número no reconocido.");
                break;
        }
    }
}