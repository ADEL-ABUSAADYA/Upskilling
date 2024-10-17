namespace ASS3;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original Array: " + string.Join(", ", numbers));

        ArrayUtils.ReverseArray(numbers);
        Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));

        int maxNumber = ArrayUtils.FindMax(numbers);
        Console.WriteLine("Max Number: " + maxNumber);

        string[] words = { "apple", "orange", "banana", "grape" };
        Console.WriteLine("\nOriginal Array: " + string.Join(", ", words));

        ArrayUtils.ReverseArray(words);
        Console.WriteLine("Reversed Array: " + string.Join(", ", words));

        string maxWord = ArrayUtils.FindMax(words);
        Console.WriteLine("Max Word: " + maxWord);
    }
}