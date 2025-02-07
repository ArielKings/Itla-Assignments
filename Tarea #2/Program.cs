using System;

class Program
{
    static void Main()
    {
        //Desarrollar un programa que le solicite al usuario un numero y el programa indique si es par o impar.
        Console.WriteLine("Escribe un numero para determinar si es par o impar: ");
        int number = Console.Read();

        if (number % 2 == 0)
        {
            Console.WriteLine("El numero que usted ha ingresado es par.");
        }
        else
        {
            Console.WriteLine("El numero que usted ha ingresado es impar.");
        }
    }
}
