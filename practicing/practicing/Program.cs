using System;

class Program
{
    static void Main()
    {

        int numero, i;

        Console.WriteLine("Insira o numero abaixo: ");

        numero = int.Parse(Console.ReadLine());

        for (i = 1; i <= numero; i++)
        {
            int primeiroN = i;
            int segundoN = i * i;
            int terceiroN = i * i * i;

            Console.WriteLine($"{primeiroN} {segundoN} {terceiroN}");
        }

    }
}