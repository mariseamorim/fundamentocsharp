using System;

namespace EditorHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu.Show();
            var data = DateTime.Now;
            Console.WriteLine(data.DayOfWeek);
            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            Console.WriteLine(data.DayOfWeek);



        }
    }
}