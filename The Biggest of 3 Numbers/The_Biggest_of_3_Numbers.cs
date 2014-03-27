using System;


    class The_Biggest_of_3_Numbers
    {
        static void Main()
        {
            double first, second, third, max;
            Console.Write("Please enter a= ");
            first = double.Parse(Console.ReadLine());
            Console.Write("Please enter b= ");
            second = double.Parse(Console.ReadLine());
            Console.Write("Please enter c= ");
            third = double.Parse(Console.ReadLine());
            max = Math.Max(first, Math.Max(second, third));
            Console.WriteLine("Biggest " + (max));
        }
    }

