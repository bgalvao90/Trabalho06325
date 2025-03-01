int n = int.Parse(Console.ReadLine());
if (n <= 0 || n >= 46)
    return;

int num, num1;
num = 0;
num1 = 1;


for (int i = 0; i < n; i++)
{
   if (i == n - 1)
    {
        
        Console.WriteLine($"{num}");


    }
    else
    {
        Console.WriteLine($"{num} ");
        int temp = num + num1;
        num = num1;
        num1 = temp;
    }


}
