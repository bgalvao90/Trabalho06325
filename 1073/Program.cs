int n = int.Parse(Console.ReadLine());

for  (int i = 1; i <= n; i++)
{
    
    if ( i % 2 == 0)
    {
        
        int n2 = i * i;
        Console.WriteLine($"{i}^2 = {n2}");
       
    }
}