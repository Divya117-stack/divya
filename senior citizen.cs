using System.IO;
using System;

class Program
{
    static void Main()
    {
       int age;
       Console.Write("Enter the age:");
       age = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine();
       if (age>=60)
       {
       Console.WriteLine("Senior citizen");
       }
       else if (age>=18)
       {
       Console.WriteLine("eligible for vote");
       }
     else
        {
            Console.WriteLine("uneligible for vote");
       }
       }
}