int n = int.Parse(Console.ReadLine());
int [] valor = new int[n];



for (int i = 0; i < n; i++)
{

    valor[i] = int.Parse(Console.ReadLine());
        if (valor[i] % 2 == 0 && valor[i] > 0)  
              Console.WriteLine("EVEN POSITIVE");
    else if (valor[i] % 2 == 0 && valor[i] < 0)
        Console.WriteLine("EVEN NEGATIVE");
    else if (valor[i] % 2 != 0 && valor[i] > 0)
        Console.WriteLine("ODD POSITIVE");
    else if (valor[i] % 2 != 0 && valor[i] < 0)
        Console.WriteLine("ODD NEGATIVE");
    
    else if (valor[i] == 0)
        Console.WriteLine("NULL");
    
}
