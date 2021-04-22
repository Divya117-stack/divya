using System;
					
public class Student
{
	 int Rollnumber {get; set;}
               string Name {get; set;}
               string Gender {get; set;}
	public static void Main()
	{
	 Student student = new Student();
            student.Rollnumber = 1;
             student.Name = "Divya";
              student.Gender = "Female";
Console.WriteLine(student.Rollnumber+"\t"+ student.Name+"\t"+ student.Gender);
    }
	}