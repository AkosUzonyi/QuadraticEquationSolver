using System;

namespace QuadraticEquationSolver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Quadratic Equation Solver";
            Console.WriteLine("Welcome to my very first C# console application.");

            double a = 0;
            double b = 0;
            double c = 0;

            bool keepCalculating = true;
            do
            {
                Input(ref a, ref b, ref c);
                InSquareRoot(ref a, ref b, ref c);

                Console.WriteLine("\nPress 'Y' for a new equation or any key to exit the program.");
                ConsoleKeyInfo answer = Console.ReadKey(true);
                keepCalculating = answer.KeyChar == 'y';                            

            } while (keepCalculating);           
        }

        static void Input(ref double a, ref double b, ref double c)
        {
            bool aError = true;
            do
            {
                try
                {
                    Console.Write("\nPlease enter the value of a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine(" a = {0}", a);
                    aError = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hey, this is not a number.");
                }
                catch (Exception)
                {
                    Console.WriteLine("An unknown error has occured. Plese try again.");
                }
            } while (aError);

            bool bError = true;
            do
            {
                try
                {
                    Console.Write("\nPlease enter the value of b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(" b = {0}", b);
                    bError = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hey, this is not a number.");
                }
                catch (Exception)
                {
                    Console.WriteLine("An unknown error has occured. Plese try again.");
                }
            } while (bError);

            bool cError = true;
            do
            {
                try
                {
                    Console.Write("\nEnter the value of c: ");
                    c = double.Parse(Console.ReadLine());
                    Console.WriteLine(" c = {0} ", c);
                    cError = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hey, this is not a number.");
                }
                catch (Exception)
                {
                    Console.WriteLine("An unknown error has occured. Plese try again.");
                }
            } while (cError);
        }

        static void InSquareRoot(ref double a, ref double b, ref double c)
        {
            double inSquareRoot, x1, x2;
            inSquareRoot = b * b - 4 * a * c;

            Console.WriteLine("\nDiscriminant = " + inSquareRoot);

            if (inSquareRoot == 0)
            {
                Console.Write("0 in the square root. X1 and X2 are equal. \n");

                x1 = (-b + Math.Sqrt(inSquareRoot)) / (2 * a);

                Console.Write("\n X1, X2 = {0}\n", x1);
            }
            else if (inSquareRoot > 0)
            {
                Console.Write("X1 and X2 are not equal. Solutions: \n");

                x1 = (-b + Math.Sqrt(inSquareRoot)) / (2 * a);
                x2 = (-b - Math.Sqrt(inSquareRoot)) / (2 * a);

                Console.Write("\n X1 = {0}\n", x1);
                Console.Write("\n X2 = {0}\n", x2);
            }
            else
            {
                Console.Write("Negative number in square root. No real solution.\n");
            }
        }
    }
}