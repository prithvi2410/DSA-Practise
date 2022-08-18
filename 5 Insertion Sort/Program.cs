using System;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array={5,2,9,1,6,0};
            PrintArray("Unsorted",array);
            InsertionSort(array);
            PrintArray("Sorted",array);
        }
        
        //                                    Insertion Sort
        //----------------------------------------------------------------------------------------
        //	Best Case     : O(n)
	    //  Worst Case    : O(n2)
        //----------------------------------------------------------------------------------------
        //  Rule 1        : one main loop with one internal 
        //  Rule 2        : j = i+1 and reduced till 0 & swaps j and j-1 
        //----------------------------------------------------------------------------------------
        //  Condition 1   : if j < j-1 is false break internal loop
        //----------------------------------------------------------------------------------------
        
        static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for(int j=i+1;j>0;j--)
                {
                    if(array[j]<array[j-1])
                    {
                        Swap(j,j-1,array);
                        PrintArray("Swap : "+i+" "+j,array);
                        Console.WriteLine();
                    }
                    else
                        break;
                }
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
    }
}