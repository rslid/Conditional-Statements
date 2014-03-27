using System;


    class The_Biggest_of_Five_Numbers
    {
        static void Main()
        {
             double a, b, c, d, e;
Console.Write("Please enter a= ");
a = double.Parse(Console.ReadLine());
Console.Write("Please enter b= ");
b = double.Parse(Console.ReadLine());
Console.Write("Please enter c= ");
c = double.Parse(Console.ReadLine());
Console.Write("Please enter d= ");
d = double.Parse(Console.ReadLine());
Console.Write("Please enter e= ");
e = double.Parse(Console.ReadLine());
 
if ( a > b && a > c && a > d && a > e )
{
Console.WriteLine("Biggest " + a);
}
else if (b > a && b > c && b > d && b > e)
{
Console.WriteLine("Biggest " + b);
}
else if (c > a && c > b && c > d && c > e)
{
Console.WriteLine("Biggest " + c);
}
else if (d > a && d > b && d > c && d > e)
{
Console.WriteLine("Biggest " + d);
}
else if (e > a && e > b && e > d && e > c)
{
Console.WriteLine("Biggest " + e);
}
else {
Console.WriteLine("Invalid input");
        }
    }

