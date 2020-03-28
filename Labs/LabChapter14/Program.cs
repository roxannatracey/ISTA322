using System;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[constructor] Garbage Collection Lab"); // first line to print 

            using (Calculator calculator = new Calculator()) // inside parenthesis it is being called 
            {
                // Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
                int dividend = calculator.Divide(120, 0);
                Console.WriteLine($"dividend is {dividend}");
            }

            //Calculator calculator = new Calculator();
            //  Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
            Console.WriteLine("Program finishing");
        }
    }
}
