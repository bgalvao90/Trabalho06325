int n = int.Parse(Console.ReadLine());
int b = 0;
int y = 0;
for  (int i = 0; i < n; i++)
{
    
    int x = int.Parse(Console.ReadLine());
    
        if (x >= 10 && x <= 20)
        {
            
            b++;
            
        }
        else
        {
            
            y++;
            
        }
   

}
Console.WriteLine($"{b} in");
Console.WriteLine($"{y} out");