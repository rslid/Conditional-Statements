﻿using System;

class Sort_3_Numbers_with_Nested_Ifs
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

        if (first == second && first == third)
            {
                Console.WriteLine("{0} {1} {2}", first, second, third);
            }
        if (first > second && first > third)
            if (second > third)
            {
                Console.WriteLine("{0} {1} {2}", first, second, third);
            }
            else if (second < third)
            {
                Console.WriteLine("{0} {1} {2}", first, third, second);
            }
            else if (second == third)
            {
                Console.WriteLine("{0} {1} {2}", first, third, second);
            }
        if (second > first && second > third)
            if (first > third)
            {
                Console.WriteLine("{0} {1} {2}", second, first, third);
            }
            else if (third > first)
            {
                Console.WriteLine("{0} {1} {2}", second, third, first);
            }
            else if (third == first)
            {
                Console.WriteLine("{0} {1} {2}", second, third, first);
            }
        if (third > first && third > second)
            if (first > second)
            {
                Console.WriteLine("{0} {1} {2}", third, first, second);
            }
            else if (second > first)
            {
                Console.WriteLine("{0} {1} {2}", third, second, first);
            }
            else if (second == first)
            {
                Console.WriteLine("{0} {1} {2}", third, second, first);
            }
    }

}
