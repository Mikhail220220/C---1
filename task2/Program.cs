Console.WriteLine("Enter first number: ");
int nub1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter second number: ");
int nub2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int nub3 = Convert.ToInt32(Console.ReadLine());
int Max = 0;
    if (nub1 < nub2) 
        Max = nub2;
    
    if (nub2 < nub3)
        Max = nub3;
    
    
    if (nub3 < nub1)    
        Max = nub1;

Console.WriteLine(Max);
