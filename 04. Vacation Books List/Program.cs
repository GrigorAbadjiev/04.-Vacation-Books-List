using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            int pageCount = int.Parse(Console.ReadLine());
            int pageReadForOneHouer = int.Parse(Console.ReadLine());
            int dayToReadTheBook = int.Parse(Console.ReadLine());
            // calculate
            int houresToRedTheBook = pageCount / pageReadForOneHouer;
            int daysRequiredToReadtheBook = houresToRedTheBook / dayToReadTheBook; 
            // output
          
            Console.WriteLine(daysRequiredToReadtheBook);

           
        }
    }
}
