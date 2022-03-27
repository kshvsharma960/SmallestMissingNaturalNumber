using System;

namespace SmallestMissingNaturalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new int[] { 1, 2};
            var arr2 = new int[] { 1, 2 };

            int data = Merge(arr1, arr2);
            Console.WriteLine(data);

        }

        private static int Merge(int[] arr1, int[] arr2)
        {
            int max = 0;
            var arr3 = new int[arr1.Length];
            for(int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] == arr2[i])
                {
                    arr3[i] = arr1[i];
                }
                else
                {
                    arr3[i] = Math.Max(arr1[i], arr2[i]);
                }
                max = Math.Max(max, arr3[i]);
            }
            var val = max+1;
            for(int i = 1; i <= max; i++) {
                if(Array.IndexOf(arr3,i)<0)
                {
                    val = i;
                }
            }
            return val;
        }
    }
}
