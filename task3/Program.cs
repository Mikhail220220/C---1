﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        

        if (number % 2 == 0){ 
            Console.WriteLine("Number is even");
        }       
    
    else
    Console.WriteLine("Number is not even");
    }
}