using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Are you a full-time or part-time student?");

           string student = Convert.ToString(Console.ReadLine().ToLower());

           if (student == "full-time")
           {
               Console.WriteLine("What is your course of study?");
               string course = Convert.ToString(Console.ReadLine());
               Console.WriteLine(course + " is a good course.");
           }
           
           else if (student == "part-time")
           {
               Console.WriteLine("How many credits are you taking?");
               int credit = Convert.ToInt32(Console.ReadLine());
               
                if (credit > 6)
                {
                    Console.WriteLine("Too much units for a student.");
                }
                 else if (credit <= 6)
                {
                    Console.WriteLine("Proceed");
                }     
           }
    
        else
                {
                    System.Console.WriteLine("wrong input");
                }
    }
}
}