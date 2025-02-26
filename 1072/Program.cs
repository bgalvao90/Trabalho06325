int n = int.Parse(Console.ReadLine());
int b = 0;
int y = 0;
for  (int i = 0; i < n; i++)
{
    
    int x = int.Parse(Console.ReadLine());
    if ((x > Math.Pow(-10,7)) && (x < Math.Pow(10,7)))
    {
        if ((x >= 10) && (x <= 20))
        {
            
            b = b+ 1;
            
        }
        else
        {
            
            y = y+ 1;
            
        }
   } 

}
Console.WriteLine($"{b} IN");
Console.WriteLine($"{y} OUT");