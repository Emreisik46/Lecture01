using System;

namespace lec01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            try
            {
                string input = System.Console.ReadLine();
                int inputToInt = Int32.Parse(input);  
                 
                program.isLeapYear(inputToInt);
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("You may only type numbers as input!");
            }
            catch (System.Exception)
            {
                 System.Console.WriteLine("We have caught an exception. Please contact the developers!"); 
            }

        }
    

        public bool isLeapYear(int year)
        {
            
            if (year < 1582)
            {
                System.Console.WriteLine("The year must be greater than 1582");
                return false;   
            }

            if (year % 400 == 0 || year % 100 == 0)
            {
                System.Console.WriteLine("Yay!");
                return true;
            }
                System.Console.WriteLine("Nay!");
                return false; 
         }
    }
}
