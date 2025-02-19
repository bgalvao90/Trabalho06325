using System;

class URI
{

    static void Main(string[] args)
    {

        int ValorEntrada = int.Parse(Console.ReadLine());

        int impar = 1;

        do
        {
            Console.WriteLine(impar);
            impar = impar + 2;

        }
        while (impar <= ValorEntrada);
        Console.Read();

    }

}