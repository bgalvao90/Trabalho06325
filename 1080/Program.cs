int n = 100;
    int [] valores = new int[n];
int maior = 0;
int posicao = 0;
for (int i = 0; i < n; i++)
{
    
    valores[i] = int.Parse(Console.ReadLine());
    if (valores[i] > maior)
    {
        maior = valores[i];
        posicao = i + 1;
    }

}
Console.WriteLine(maior);
Console.WriteLine(posicao);
