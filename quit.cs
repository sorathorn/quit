using System;

namespace quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            mode = Console.ReadLine();
            double x, y, p, t;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            p = Math.Pow(x - 1, 2);
            t = Math.Sqrt(y) + 1;

            if (mode == "time" || mode == "price")
            {
                if (x >= 0)
                {
                    if (mode == "time")
                    {
                        Console.WriteLine("{0}, {1}", x, p);
                    }
                    else if (mode == "price")
                    {
                        Console.WriteLine("{0}, {1}", t , y);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
            else
            {
                Console.WriteLine("Invalid mode");
                if (x < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
        }
    }
}
