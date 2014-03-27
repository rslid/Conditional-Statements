using System;

class Digit_as_Word
{
    static void Main()
    {
        int digit;
        bool isValid = true;
        do
        {
            Console.Write("Please enter a digit from 0 to 9 = ");
            String Result = Console.ReadLine();
            while (!Int32.TryParse(Result, out digit))
            {
                Console.WriteLine("Not a valid number, try again.");
                Console.Write("Please enter a digit from 0 to 9 = ");
                Result = Console.ReadLine();
            }
            isValid = true;
            switch (digit)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default: Console.WriteLine("not a digit!"); isValid = false;
                    break;
            }


        } while (!isValid);
    }
}

