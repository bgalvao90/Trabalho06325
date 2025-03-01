
int totalAlcool = 0;  
int totalGasolina = 0;  
int totalDiesel = 0;  
for (int i = 0; i < 10000; i++)
{
    int combustivel = int.Parse(Console.ReadLine());
    if(combustivel < 1 && combustivel > 4)
    {
        combustivel = int.Parse(Console.ReadLine());

    }
    else {
        {
            if (combustivel == 1)
            {
                totalAlcool += 1;
            }
            else if (combustivel == 2)
            {
                totalGasolina += 1;
            }
            else if (combustivel == 3)
            {
                totalDiesel += 1;
            }
            else if (combustivel == 4)
            {
                break;
            }
        } }
   
}
Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine($"Alcool: {totalAlcool}");
Console.WriteLine($"Gasolina: {totalGasolina}");
Console.WriteLine($"Diesel: {totalDiesel}");