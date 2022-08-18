using System;

namespace SelectionSort 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array={9,2,8,4,5,1,19};
            PrintArray("unsorted",array);
            SelectionSort(array);
            PrintArray("sorted",array);
        }

        //                                  Selection sort
        //----------------------------------------------------------------------------------------
        //	Best Case   : O(n2)
	    //  Worst Case  : O(n2)
        //----------------------------------------------------------------------------------------
        // Rule 1       : Select the max value and swap with last index (or) min value and swap with first index
        // Rule 2       : Run on loop 0 to < length
        //----------------------------------------------------------------------------------------
        // Condition 1  : Reduce last index by one for each iteration (or) increase first index by one
        //----------------------------------------------------------------------------------------

        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int last=array.Length-i-1;
                int max=GetMaxIndex(array,0,last);
                Swap(last,max,array);
            }
        }
        
        //Prints the array with a give title
        static void PrintArray(string title,int[] array)
        {
            Console.WriteLine(title);

            foreach (int number in array)
                Console.Write(number+" ");

            Console.WriteLine();
        }

        //It swaps the first paremeter with second paremeter's array position
        static void Swap(int first,int second,int[] array)
        {
            int temp=array[first];
            array[first]=array[second];
            array[second]=temp;
        }

        //Finding max element
        static int GetMaxIndex(int[] arr,int start,int last)
        {
            int max=start;
            for (int i = start; i <= last; i++)
            {
                if(arr[max]<arr[i]) //changing the sign with change the order
                    max=i;
            }
            return max;
        }
    }
}