using System;

namespace BubbleSort // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bubbleSortArray={9,4,6,3,1,8};
            PrintArray("Unsorted",bubbleSortArray);
            BubbleSort(bubbleSortArray);
            PrintArray("Sorted",bubbleSortArray);
        }

        // Prints the given array with a title
        static void PrintArray(string title,int[] array)
        {
            Console.WriteLine(title);

            foreach (int number in array)
                Console.Write(number+" ");

            Console.WriteLine();
        }

        //                                  Bubble Sort 
        //----------------------------------------------------------------------------------------
        // Rule 1 : Pushing Largest Numbers to Right
        //----------------------------------------------------------------------------------------
        // Best Case   : O(n)
	    // Worst Case  : O(n2)
        //----------------------------------------------------------------------------------------
        // Condition 1 : compare 1st and 0th element and go on for each pass
        // Condition 2 : swap if 1st < 0th ...(j < j-1) 
        // Condition 3 : breaking condition if there is no swap done in internal loop
        // Condition 4 : Loop - 1st till index < Lenght-1
        // Condition 5 : Loop - 2nd till index < Lenght-1st loop index
        //----------------------------------------------------------------------------------------
        static void BubbleSort(int[] array)
        {
            bool swapped=false;
            for (int i = 0; i < array.Length-1; i++)
            {
                swapped=false;
                for (int j = 1; j < array.Length-i; j++)
                {
                    if(array[j]<array[j-1]) //changing sign will change order of sorting
                    {
                        int temp=array[j];
                        array[j]=array[j-1];
                        array[j-1]=temp;
                        swapped=true;
                        PrintArray("swap : "+i+" : "+j,array);
                        Console.WriteLine();
                    }
                }
                //break condition if no swaps done in internal loop
                if(!swapped)
                    break;
            }
        }
    }
}