using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter what u want to do  \n1.Add \n2.Sub \n3.Mul");
        int Choice = Convert.ToInt32(Console.ReadLine());
        
        Switch (Choice)
        {
            case 1:
            Console.WriteLine("Add");
              break;
            case 2:
            Console.WriteLine("Sub");
              break;
            case 3:
            Console.WriteLine("Mul");
              break;
            default:
            Console.WriteLine("Nothing");
            break;
        }
    }
}