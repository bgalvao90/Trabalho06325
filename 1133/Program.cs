int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int inicio = Math.Min(x, y);
int fim = Math.Max(x, y);

for (int i = inicio; i < fim; i++)
{
    if (i % 5 == 2 || i % 5 == 3)
    {
        Console.WriteLine(i);
    }
}