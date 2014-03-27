using System;

class Bonus_Score
{
    static void Main()
    {
        int score;
        Console.Write("Please enter score between 1 and 9 = ");
        score = Int32.Parse(Console.ReadLine());
        int summary;
        switch (score)
        {
            case 1: summary = score * 10; Console.WriteLine(summary); break;
            case 2: summary = score * 10; Console.WriteLine(summary); break;
            case 3: summary = score * 10; Console.WriteLine(summary); break;
            case 4: summary = score * 100; Console.WriteLine(summary); break;
            case 5: summary = score * 100; Console.WriteLine(summary); break;
            case 6: summary = score * 100; Console.WriteLine(summary); break;
            case 7: summary = score * 1000; Console.WriteLine(summary); break;
            case 8: summary = score * 1000; Console.WriteLine(summary); break;
            case 9: summary = score * 1000; Console.WriteLine(summary); break;

            default: Console.WriteLine("Invalid number");
                break;
        }
    }
}