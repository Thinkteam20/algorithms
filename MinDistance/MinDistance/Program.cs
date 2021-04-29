using System;

namespace MinDistance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] num = { 1, 10, 4, 6 };
            int results = findDistance(num);
            Console.WriteLine("Minimum Distance is {0:d}", results);
        }
        static int findDistance (int[] A)
        {
            int dmin = 10000;
            for(int i = 0; i <= A.Length - 2; i++)
            {
                for (int j = i + 1; j <= A.Length - 1; j++)
                {
                    int temp = Math.Abs(A[i] - A[j]);
                    if (temp < dmin)
                    {
                        dmin = temp;
                    }
                }
            }
            return dmin;
        }
    }
}
