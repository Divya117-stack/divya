using System.IO;
using System;

class Program
{
    static void Main()
    {
       int age;
       Console.Write("Enter the age:");
       age = Convert.ToInt32(Console.Readline());
       Console.WriteLine();
       if (age>=18)
       {
       Console.WriteLine("able to vote");
       }
       else
       {
       Console.WriteLine("unable to vote");
       }
    }
       
    
}