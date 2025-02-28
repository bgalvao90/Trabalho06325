 

for (int i = 1; i <= 9; i++)
{
    
    int j = 7;
    Console.WriteLine($"I={i} J={j}");
    Console.WriteLine($"I={i} J={j - 1}");
    Console.WriteLine($"I={i} J={j - 2}");
    i = i + 1;
}