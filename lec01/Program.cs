using System;

namespace lec01
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    

        public bool isLeapYear(int year)
        {
            if (year < 1582)
            {
                System.Console.WriteLi
             return false;   
            }
        if ((year/4) % 4 == 0)
        {
              return true;
         }
        return false; 
     }
    }
}
