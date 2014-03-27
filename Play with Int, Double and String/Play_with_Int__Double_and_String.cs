using System;



    class Play_with_Int__Double_and_String
    {
        static void Main()
        {
            int choice;
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            Console.Write("Your choice = ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.Write("Please enter a whole number = ");
                   int integer = int.Parse(Console.ReadLine());
                   double sum = integer + 1;
                   Console.WriteLine(sum);
                   break;
                case 2: Console.Write("Please enter a number = ");
                   double secondNum = double.Parse(Console.ReadLine());
                    sum = secondNum + 1;
                   Console.WriteLine(sum);
                   break;
                case 3: Console.Write("Please enter a string = ");
                   string str = Console.ReadLine();
                   string append = str + '*';
                   Console.WriteLine(append);
                   break;
                default: Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

