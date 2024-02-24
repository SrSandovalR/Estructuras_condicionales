using System;

try
{

    Console.WriteLine("Escribe un numero: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escribe un numero: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escribe un numero: ");
    int numero3 = Convert.ToInt32(Console.ReadLine());

    int numMayor = numero1;


    if (numMayor <= numero2)
    {
        numMayor = numero2;
    }

    if (numMayor <= numero3)
    {
        numMayor = numero3;

    }


    Console.WriteLine("El número mayor es: " + numMayor);



}
catch (FormatException)
{
    Console.Clear();
    Console.WriteLine("Ha ocurrido un error solo debe ingresar numeros.");
    Console.Read();
    Console.ReadLine();
    throw;
}
