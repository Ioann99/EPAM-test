using System;

namespace EPAM
{
    public class Utilites
    {
        static Utilites() {}

        public static int[] InitializeArray()
        {
            Console.WriteLine("Input array's length between 2 and 20");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            while (arrSize < 2 || arrSize > 20)
            {
                Console.WriteLine("Wrong number. Input between 2 and 20");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }
            int[] array = new int[arrSize];
            Console.WriteLine("\nUnsorted array:");
            Random rnd = new Random();
            for (int i = 0; i < arrSize; i++)
            {
                array[i] = rnd.Next(0, 21);
                Console.Write(array[i].ToString() + " ");
            }
            return array;
        }

        public static int[] SortArray(int[] arr)
        {
            for (int j = 0; j < arr.GetLength(0) - 1; j++)
            {
                for (int i = 0; i < arr.GetLength(0) - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        arr[i] = arr[i] ^ arr[i + 1];
                        arr[i + 1] = arr[i + 1] ^ arr[i];
                        arr[i] = arr[i] ^ arr[i + 1];
                    }
                }
            }

            return arr;
        }

        public static void PrintArray(int[] sortedArr)
        {
            Console.WriteLine("\nSorted array:");
            for (int i = 0; i < sortedArr.GetLength(0); i++)
            {
                Console.Write(sortedArr[i].ToString() + " ");
            }

            Console.WriteLine();
        }

        public static int RequestNumber()
        {
            Console.WriteLine("\nInput integer you want to found");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
    }
}
