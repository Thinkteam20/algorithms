using System;

namespace InsertionSortAlgo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] sorted_array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sorted_array_length = sorted_array.Length;

        }

        static void InsertionSort(int []A, int n)
        {
            for(int i = 1; i < n - 1; i++)
            {
                int v = A[i];
                int j = i - 1;
                while(j >= 0 && A[j] > v)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = v;
            }
        }
    }
}
