int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());


if (x > y)
{
    int diferenca = x;
    x = y;
    y = diferenca;
}

int soma = 0;


for (int i = x + 1; i < y; i++)
{
    if (i % 2 != 0)
    {
        soma += i;
    }
}

Console.WriteLine(soma);