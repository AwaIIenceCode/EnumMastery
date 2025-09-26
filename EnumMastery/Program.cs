using System;
class MyClass
{
    enum DayOfWeek
    {
        Monday,
        Tuesday, 
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
        
    }
    static void Main()
    {
        Console.WriteLine("Welcome to the calendar tracker. Please, enter the day of week!");

        string userChoice = Console.ReadLine();

        if (Enum.TryParse(userChoice, true, out DayOfWeek day))
        {
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Friday) { Console.WriteLine("Work day, good luck!"); }
        
            else { Console.WriteLine("Chill day, bro!"); }    
        }

        else { Console.WriteLine("There is no such day of the week"); }
    }
}