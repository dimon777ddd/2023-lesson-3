using System;

class Program
{
    static void Main(string[] args)
    {
        double k1, b1, k2, b2;

        Console.Write("Enter value of k1: ");
        k1 = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b1: ");
        b1 = double.Parse(Console.ReadLine());

        Console.Write("Enter value of k2: ");
        k2 = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b2: ");
        b2 = double.Parse(Console.ReadLine());

        if (k1 == k2)
        {
            Console.WriteLine("The lines are parallel, they do not intersect.");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            Console.WriteLine("The point of intersection is: (" + x + ", " + y + ")");
        }

    }
}
