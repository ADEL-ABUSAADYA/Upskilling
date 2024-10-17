namespace ASS3;

public static class ArrayUtils
{
    public static void ReverseArray<T>(T[] array)
    {
        int start = 0;
        int end = array.Length - 1;

        while (start < end)
        {
            T temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            start++;
            end--;
        }
    }

    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        T max = array[0]; 

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(max) > 0)
            {
                max = array[i]; 
            }
        }

        return max;
    }
}