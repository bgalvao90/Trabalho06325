using System.Net.Http.Headers;
using System.Runtime.Intrinsics;

int n = int.Parse(Console.ReadLine());



for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split();
    double n1 = double.Parse(valores[0]);
    double n2 = double.Parse(valores[1]);
    double n3 = double.Parse(valores[2]);
    double media = (((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10);
    Console.WriteLine($"{media:F1}");

}
