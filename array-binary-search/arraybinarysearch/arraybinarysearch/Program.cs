using System;

namespace arraybinarysearch
{
    public class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Please enter a number for the amount of numbers in the array:");

            int input = Convert.ToInt32(Console.ReadLine());
            int minNum = 0;
            int maxNum = 10;
            int[] newArr = new int[input];
            Random randomNumbers = new Random();
            for (int i = 0; i < input; i++)
            {
                newArr[i] = randomNumbers.Next(minNum, maxNum);
                Console.WriteLine($"{newArr[i]}");
            }
            Console.WriteLine("What number do you want to search for?");
            int searchKey = Convert.ToInt32(Console.ReadLine());
            Array.Sort(newArr);
            int findMiddle = 0;
            int low = 0;
            int high = (newArr.Length) - 1;
            int middle = (low + high) / 2;
            while (low <= high)
            {
                middle = (low + high) / 2;
                findMiddle = newArr[middle];
                if (findMiddle == searchKey)
                {
                    Console.WriteLine($"Found: {findMiddle} ");
                    return findMiddle;
                }
                else
                {
                    if (findMiddle > searchKey)
                    {
                        high = findMiddle - 1;
                    }
                    else
                    {
                        low = findMiddle + 1;
                    }
                }

            }
            Console.WriteLine("That number was not found");
            return -1;

        }
        public static int ReturnFound(int[] arr, int searchkey1)
        {
            int searchKey = searchkey1;
            int findMiddle = 0;
            int low = 0;
            int high = (arr.Length) - 1;
            int middle = (low + high) / 2;
            while (low <= high)
            {
                middle = (low + high) / 2;
                findMiddle = arr[middle];
                if (findMiddle == searchKey)
                {
                    return findMiddle;
                }
                else
                {
                    if (findMiddle > searchKey)
                    {
                        high = findMiddle - 1;
                    }
                    else
                    {
                        low = findMiddle + 1;
                    }
                    return findMiddle;
                }

            }
            return -1;
        }
    }
}
