public class BitWise
{
    public static void Main(string[] args)
    {
        Console.WriteLine("input is : "+IsOddOrEven(34));
        Console.WriteLine("unique number is : "+GetUnique(new int[]{2,4,5,4,2}));
        Console.ReadKey();
    }

    private static string IsOddOrEven(int number)
    {
        if( (number&1) == 1)
            return "odd";

        return "even";
    }
    private static int GetUnique(int[] arr)
    {
        int unique = 0;
        foreach(int num in arr)
            {
                //using XOR for each number in array finally gives us unique number in the array
                unique^=num;
            }
                
        return unique;
    }
}