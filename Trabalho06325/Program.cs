using System;

class URI
{

    static void Main(string[] args)
    {

        int ValorEntrada = int.Parse(Console.ReadLine());

        int impar = 1;
        
        for (int i = 0; i < ValorEntrada;i++)
        {

            if (i % 2 != 0 && i < 1000)
            {
                Console.WriteLine(i);
                
            }
            

        }
       
    }

}