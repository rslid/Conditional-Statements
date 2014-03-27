using System;


class Exchange_If_Greater
{
    static void Main()
    {
        double numberUno;
        double numberDos;
        double temp1 = 0;

        Console.Write("Please enter first number= ");
        numberUno = Double.Parse(Console.ReadLine());
        Console.Write("Please enter second number= ");
        numberDos = Double.Parse(Console.ReadLine());
        if (numberUno > numberDos)
        {
            temp1 = numberDos;
            numberDos = numberUno;
            numberUno = temp1;
            Console.WriteLine("Numbers are {0} {1}", numberUno, numberDos);
        }
        else
        {

            Console.WriteLine("Numbers are {0} {1}", numberUno, numberDos);
        }

    }
}