public class Program
{
    public static void Main(string[] args)
    {
        int target = 1;
        int result = 0;

        int[] array = { 2, 4, 6, 7, 8, 22, 25, 29, 30, 34, 35, 55, 56, 57, 69, 70, 71, 76,78,80,82,85,87,89,90 };
        PrintArray(array);
        Console.WriteLine($"Inbuilt BS method : {array.ToList().BinarySearch(target)} index");

        result = BinarySearch(array, target);
        Console.WriteLine($"{target} is at {result} index");

        result = Ceiling(array, target);
        Console.WriteLine($"Celeing for {target} is {result} ");
        
        result = Floor(array, target);
        Console.WriteLine($"Floor for {target} is {result} ");
        
        
    }
    static void PrintArray(int[] array)
    {
        foreach(int index in array)
            Console.Write(index+" ");

        Console.WriteLine();
    }
    static int BinarySearch(int[] array, int target)
    {
        int Start = 0;
        int End = array.Length - 1;

        bool Order = array[Start] < array[End];

        while (Start <= End)
        {
            int Middle = (Start + End) / 2;
            if (array[Middle] == target)
                return Middle;

            if (Order)
            {
                if (target < array[Middle])
                    End = Middle-1;
                else
                    Start = Middle+1;
            }
            else
            {
                if (target > array[Middle])
                    End = Middle-1;
                else
                    Start = Middle+1;
            }
        }
        return -1;
    }
    static int Ceiling(int[] array,int target)
    {
        int Start = 0;
        int End = array.Length - 1;

        bool Order = array[Start] < array[End];

        while (Start <= End)
        {
            int Middle = (Start + End) / 2;

            if (array[Middle] == target&& Middle!=array.Length-1) //if target is Gre or Equ to last element array[Middle + 1] throws exception
                return array[Middle+1];

            if (Middle==array.Length-1)
                return array[Middle];

            if (Order)
            {
                if (target < array[Middle])
                    End = Middle-1;
                else
                    Start = Middle+1;
            }
            else
            {
                if(target > array[Middle])
                    End = Middle-1;
                else
                    Start = Middle+1;
            }
        }
        return array[Start];
    }
    static int Floor(int[] array,int target)
    {
        int Start = 0;
        int End = array.Length - 1;

        bool Order = array[Start] < array[End];

        while (Start <= End)
        {
            int Middle = (Start + End) / 2;

            if (array[Middle] == target&& Middle!=array.Length-1) //if target is Gre or Equ to last element array[Middle + 1] throws exception
                return array[Middle-1];

            if (Middle==array.Length-1)
                return array[Middle];

            if (Order)
            {
                if (target < array[Middle])
                    End = Middle-1;
                else
                    Start = Middle+1;
            }
            else
            {
                if (target > array[Middle])
                    End = Middle-1;
                else
                    Start = Middle+1;
            }
        }
        return array[End];
    }
}