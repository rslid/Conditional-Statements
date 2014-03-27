using System;

    class Check_for_a_Play_Card
    {
        static void Main()
        {
            Console.Write("Please enter playcard = ");
            string ch = Console.ReadLine();
            if (ch == "2" || ch == "3" || ch == "4" || ch == "5" || ch == "6" || ch == "7" || ch == "8" || ch == "9" || ch == "10" || ch == "j" || ch == "q" || ch == "k" || ch == "a" || ch == "J" || ch == "Q" || ch == "K" || ch == "A")
            {
                Console.WriteLine("Valid card sign? \r\nYes");
            }
            else
            {
                Console.WriteLine("Valid card sign? \r\nNo");
            }
        }
    }

