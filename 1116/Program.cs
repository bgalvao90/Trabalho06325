int n = int.Parse(Console.ReadLine());

int[] vetor = new int [n];

for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split();
    double x = double.Parse(valores[0]);
    double y = double.Parse(valores[1]);
    if (y == 0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else
    {
        Console.WriteLine($"{(x / y):F1}");
    }

}   