using System;


namespace EPAM
{
    public class ProgramSeek
    {
        static void Main(string[] args)
        {
            int[] arr = Utilites.InitializeArray();
            int[] sortedArr = Utilites.SortArray(arr);
            Utilites.PrintArray(sortedArr);

            int number = Utilites.RequestNumber();

            bool isFound = SeekArray(number, arr);

            SeekResultOut(isFound, number);
            Console.ReadLine();
        }

        public static bool SeekArray(int num, int[] arr)
        {
            foreach (int element in arr)
            {
                if (element == num)
                {
                    return true;
                }
            }
            return false;
        }

        static void SeekResultOut(bool isFound, int num)
        {
            if (isFound)
                Console.WriteLine($"\nYour number { num } is found!");
            else
                Console.WriteLine($"\nYour number { num } isn't found.");
        }
    }
}
