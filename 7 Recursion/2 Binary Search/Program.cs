
using System;

namespace BinarySearchUsingRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 24, 32, 54, 65, 77, 78 };
            int Target = 32;
            int Result = BinarySearchUsingRecursion(Array, 0, Array.Length - 1, Target);
            Console.WriteLine("Element index : " + Result);
        }
        static int BinarySearchUsingRecursion(int[] array, int start, int end, int target)
        {
            if (start > end)
                return -1;
            int middle = (start + end) / 2;

            if (array[middle] == target)
                return middle;                
            if (array[middle] < target)
                return BinarySearchUsingRecursion(array, middle + 1, end, target);
            else
                return BinarySearchUsingRecursion(array, start, middle - 1, target);
        }
    }
}