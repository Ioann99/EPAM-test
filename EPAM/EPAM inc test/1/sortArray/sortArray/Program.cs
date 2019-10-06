using System;

namespace EPAM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Utilites.InitializeArray();
            int[] sortedArr = Utilites.SortArray(arr);

            Utilites.PrintArray(sortedArr);

            Console.ReadLine();
        }
    }
}
