internal class Program
{
    private static void Main(string[] args)
    {
        //ArrayManipulator.GenerateRandomArray(10, 0, 10);
        int[] array = new int[] { 1, 8, 2, 9, 4, 3, 7, 5 };
        ArrayManipulator.PrintArray(array);
        Console.WriteLine("Max element: ");
        Console.WriteLine(ArrayManipulator.FindMax(array));
        ;
        Console.WriteLine("Sorted array: ");
        ArrayManipulator.PrintArray(ArrayManipulator.SortArray(array));
        
    }

    class ArrayManipulator
    {
        public static int[] GenerateRandomArray(int length, int min, int max)
        {
            int[] array = new int[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = System.Random(min, max);
            }
            return array;
        }

        public static int FindMax(int[] array)
        {
            int max_el = array[0];

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_el)
                {
                    max_el = array[i];
                }

            }

            return max_el;
        }

        public static int[] SortArray(int[] array)
        {
            System.Array.Sort(array);
            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0;i < array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }

}