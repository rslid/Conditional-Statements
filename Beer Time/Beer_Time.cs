using System;


class Beer_Time
{

    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter a time (ex. 1:00 pm) = ");
            var currentTime = Console.ReadLine();
            DateTime now = Convert.ToDateTime(currentTime);
            var startTime = new DateTime(now.Year, now.Month, now.Day, 13, 0, 0);
            var endTime = new DateTime(now.Year, now.Month, now.Day, 3, 0, 0);
            bool result = now.IsBetween(startTime, endTime);
            if (result == true)
                Console.WriteLine("beer time");
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input");
        }
    }


}


