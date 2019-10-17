using System;

namespace array_shift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number between 1-10");
            string inputNumArray = Console.ReadLine();
            int inputNumArrConv = Convert.ToInt32(inputNumArray);
            int[] startarr = new int[inputNumArrConv];
            int[] pop = Populate(startarr);
            Console.WriteLine($"Your array size is: {pop.Length} ");
            Console.WriteLine($"The numbers in your array are {String.Join(", ", pop) }");
            Console.WriteLine("Please enter a new number.");
            int shiftNumber = Convert.ToInt32(Console.ReadLine());
            int[] shiftedArr = ReturnArray(pop, shiftNumber);
            Console.WriteLine($"Your array size is: {shiftedArr.Length} ");
            Console.WriteLine($"The numbers in your array are {String.Join(", ", shiftedArr) }");

        }
        public static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter number {i + 1}/{arr.Length} ");
                string input = Console.ReadLine();
                arr[i] = Convert.ToInt32(input);
            }
            return arr;
        }

        public static int[] ReturnArray(int[] oldArr, int newNumber)
        {
            int oldLength = oldArr.Length;
            int newLength = oldLength + 1;
            int splitNum = newLength / 2;
            Console.WriteLine($"{splitNum}");
            int[] newArr = new int[newLength];
            for (int i = 0; i < oldArr.Length; i++)
            {
                newArr[splitNum] = newNumber;
                newArr[i] = oldArr[i];
            }
            Console.WriteLine($"{newArr}");
            return newArr;
        }
    }
}
