using System.IO;
using System;

class Program
{
    static void Main()
    {
        int firstNumber, secondNumber, result;
        Console.Write("Enter firstNumber :");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter secondNumber :");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        result = firstNumber + secondNumber;
         Console.WriteLine("Sum of two number is : "+result);
         Console.ReadLine();
    }
}