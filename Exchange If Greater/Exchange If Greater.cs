using System;


class Exchange_If_Greater
{
    static void Main()
    {
        double numberOne;
        double numberTwo;
        double temp1 = 0;

        Console.Write("Please enter first number= ");
        numberOne = Double.Parse(Console.ReadLine());
        Console.Write("Please enter second number= ");
        numberTwo = Double.Parse(Console.ReadLine());
        if (numberOne > numberTwo)
        {
            temp1 = numberTwo;
            numberTwo = numberOne;
            numberOne = temp1;
            Console.WriteLine("Result {0} {1}", numberOne, numberTwo);
        }

            Console.WriteLine("Result {0} {1}", numberOne, numberTwo);
        

    }
}