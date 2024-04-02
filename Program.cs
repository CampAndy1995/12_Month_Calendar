using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the year for the calendar: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("\n*** Calendar for Year {0} ***\n", year);

        for (int month = 1; month <= 12; month++)
        {
            Console.WriteLine("{0}\n", GetMonthCalendar(year, month));
        }

        Console.ReadLine();
    }

    static string GetMonthCalendar(int year, int month)
    {
        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        string monthName = firstDayOfMonth.ToString("MMMM");

        string calendar = monthName + " " + year + "\n";
        calendar += "-----------------------------\n";
        calendar += "Sun Mon Tue Wed Thu Fri Sat\n";

        int dayOfWeek = (int)firstDayOfMonth.DayOfWeek;
        int currentDay = 1;

        for (int i = 0; i < dayOfWeek; i++)
        {
            calendar += "    ";
        }

        while (currentDay <= daysInMonth)
        {
            for (int i = dayOfWeek; i < 7 && currentDay <= daysInMonth; i++)
            {
                calendar += currentDay.ToString().PadLeft(4);
                currentDay++;
            }
            calendar += "\n";

            dayOfWeek = 0;
        }

        return calendar;
    }
}
