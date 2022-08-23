using System;

namespace CyclicSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array={5,3,2,4,1,6,8,9,7};
            PrintArray("Unsorted",array);
            CyclicSort(array);
            PrintArray("Sorted",array);
        }
        
        //                              Cyclic Sort
        //----------------------------------------------------------------------------------------
        //Best Case   : O(n)
	    //Worst Case  : O(n)
        //----------------------------------------------------------------------------------------
        // Rule 1       : One while loop and swap if the element is not equal to index
        // Rule 2       : Must follow 0 to n or any sequential numbers ( m to n )
        //----------------------------------------------------------------------------------------
        // Condition    : If( element != index ) => swap() else => index++
        //----------------------------------------------------------------------------------------
        // Optimized    : You can use a simple for loop with if(conditon) => swap() but this not a optimized way
        //----------------------------------------------------------------------------------------

        static void CyclicSort(int[] array)
        {
            int i=0;
            while(i<array.Length)
            {
                if(array[i]-1!=i)
                    Swap(i,array[i]-1,array);
                else
                    i++;
            }
        }
        
        //Simple method which prints the given array and a title
        static void PrintArray(string title,int[] array)
        {
            Console.WriteLine(title);

            foreach (int number in array)
                Console.Write(number+" ");

            Console.WriteLine();
        }

        //Simple method which swaps the element in the provided index 
        static void Swap(int first,int second,int[] array)
        {
            int temp=array[first];
            array[first]=array[second];
            array[second]=temp; 
        }
    }
}