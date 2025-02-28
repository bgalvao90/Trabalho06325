
int n = int.Parse(Console.ReadLine());
int[] valor = new int[n];
int totalCobaias = 0;
int totalCoelhos = 0;
int totalSapos = 0;
int totalRatos = 0;
for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().ToUpper().Split();

    int quantidade = int.Parse(valores[0]);
    char animal = char.Parse(valores[1]);
    
    if (animal == 'C')
    {
        totalCoelhos += quantidade;
    }
    else if (animal == 'R')
    {
        totalRatos += quantidade;
    }
    else if (animal == 'S')
    {
        totalSapos += quantidade;
    }
    totalCobaias += quantidade;
  

}
Console.WriteLine($"Total: {totalCobaias} cobaias");
Console.WriteLine($"Total de coelhos: {totalCoelhos}");
Console.WriteLine($"Total de ratos: {totalRatos}");
Console.WriteLine($"Total de sapos: {totalSapos}");
Console.WriteLine($"Percentual de coelhos: {(totalCoelhos * 100.0 / totalCobaias):F2} %");
Console.WriteLine($"Percentual de ratos: {(totalRatos * 100.0 / totalCobaias):F2} %");
Console.WriteLine($"Percentual de sapos: {(totalSapos * 100.0 / totalCobaias):F2} %");