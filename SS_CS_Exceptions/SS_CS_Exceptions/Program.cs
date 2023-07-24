using MathCalculations;

namespace SS_CS_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //QuadraticEquationTask();
            // DivTask();
            ReadNumbersTask();
        }

        public static void DivTask()
        {
            int a = 2;
            int b = 3;

            try
            {
                int result = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void ReadNumbersTask()
        {
            int start = 1;
            int end = 100;
            int prevNumber = start;

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    int number = ReadNumber(start, end);
                    if (number < prevNumber)
                    {
                        throw new Exception("The entered number cannot be less than previous");
                    }
                    prevNumber = number;
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Entered value is out of range");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int result = int.Parse(input);

            if (result < start || result > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return result;
        }

        public static void QuadraticEquationTask()
        {
            double a = 1;// 1, 0, 0, 7
            double b = 2;// 2, 2, 0, 9
            double c = 2;// 1, 3, 7, 3
                         //e // 1, 1, e, 2
            try
            {
                var solver = new QuadraticEquationSolver(a, b, c);
                var results = solver.Solve();
                if (results.Length == 1)
                {
                    Console.WriteLine($"The equation has 1 root: {results[0]}");
                }
                else
                {
                    Console.WriteLine($"The equation has 2 roots, x1={results[0]}, x2={results[1]}");
                }
            }
            catch (NoRootsException nre)
            {
                Console.WriteLine(nre.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}