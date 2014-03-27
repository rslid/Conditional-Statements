using System;

class Multiplication_Sign
{
    static void Main()
    {
        double first, second, third;
        Console.Write("Please enter a= ");
        first = double.Parse(Console.ReadLine());
        Console.Write("Please enter b= ");
        second = double.Parse(Console.ReadLine());
        Console.Write("Please enter c= ");
        third = double.Parse(Console.ReadLine());
        if (first == 0 || second == 0 || third == 0)
        {
            Console.WriteLine("Result sign is \"0\" ");
        }
        if (first > 0 && second > 0 && third > 0)
        {
            Console.WriteLine("Result sign is \"+\" ");
        }
        else if (first > 0 && second > 0 && third < 0)
        {
            Console.WriteLine("Result sign is \"-\" ");
        }
        else if (first > 0 && second < 0 && third < 0)
        {
            Console.WriteLine("Result sign is \"+\" ");
        }
        else if (first > 0 && second < 0 && third > 0)
        {
            Console.WriteLine("Result sign is \"-\" ");
        }
        else if (first < 0 && second > 0 && third > 0)
        {
            Console.WriteLine("Result sign is \"-\" ");
        }
        else if (first < 0 && second > 0 && third < 0)
        {
            Console.WriteLine("Result sign is \"+\" ");
        }
        else if (first < 0 && second < 0 && third > 0)
        {
            Console.WriteLine("Result sign is \"+\" ");
        }
        else if (first < 0 && second < 0 && third < 0)
        {
            Console.WriteLine("Result sign is \"-\" ");
        }
    }
}

