using System;

namespace factorial
{
    class ProgramCalcFactorial
    {
        static void Main(string[] args)
        {
            int number = RequestPositiveNumber();
            ulong factorial;

            if (number > 65)
            {
                Console.WriteLine($"Factorial of {number} can not be calculated.");
            }
            else
            {
                factorial = CalculateFactorial(number);
                //factorial = FindfactRecurrent(number); //this is second method
                Console.WriteLine($"Factorial of {number} is {factorial}.");
            }
            Console.ReadLine();
        }

        public static int RequestPositiveNumber()
        {
            Console.WriteLine("Enter positive integer.");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num < 0)
            {
                Console.WriteLine("Wrong number! \nEnter positive integer.");
                num = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }

        //first method
        public static ulong CalculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            ulong tmp = 1;
            for (int i = 2; i < number + 1; i++)
            {
                tmp *= (ulong)i;
            }
            return tmp;
        }

        //second method
        public static ulong FindfactRecurrent(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return (ulong)number * FindfactRecurrent(number - 1);
        }
    }
}
