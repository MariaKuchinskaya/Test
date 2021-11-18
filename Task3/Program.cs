using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine(date.GetFormattedDateTime());
            Console.WriteLine(date.GetFormattedDateTimePlus5501());
        }
    }
}

public static class MyDateTimeExtension
{
    public static string GetFormattedDateTime(this DateTime date)
    {
        var formattedDate = date.ToString("dd MMM yyyy") + "+5501 от сотворения мира";
        return formattedDate;
    }

    public static string GetFormattedDateTimePlus5501(this DateTime date)
    {
        var yearFromCreation = date.Year + 5501;

        var formattedDate = $"{date.ToString("dd MMM")} {yearFromCreation} от сотворения мира";
        return formattedDate;
    }
}
