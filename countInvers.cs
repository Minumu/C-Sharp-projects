using System;

namespace mergeSorting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 8, 3, 3, 7, 10 };
            int[] merge_arr = new int[arr.Length];
            uint left = 0;
            uint right = (uint)(arr.Length - 1);
            int[] res;
            int inv = 0;

            res = mergeSorting(arr, merge_arr, left, right, ref inv);
            Console.WriteLine($"{inv}");
        }
        private static int[] mergeSorting(int[] arr, int[] merge_arr, uint left, uint right, ref int inv)
        {
            int[] res;
            if (left == right)
            {
                merge_arr[left] = arr[left];
                return merge_arr;
            }
            uint middle = (left + right) / 2;
            int[] leftBuff = mergeSorting(arr, merge_arr, left, middle, ref inv);
            int[] rightBuff = mergeSorting(arr, merge_arr, middle + 1, right, ref inv);
            if (leftBuff == arr)
                res = merge_arr;
            else
                res = arr;
            uint leftIter = left;
            uint rightIter = middle + 1;
            for (uint i = left; i <= right; i++)
            {
                if (leftIter <= middle && rightIter <= right)
                {
                    if (leftBuff[leftIter] <= rightBuff[rightIter])
                    {
                        res[i] = leftBuff[leftIter];
                        leftIter++;
                    }
                    else
                    {
                        res[i] = rightBuff[rightIter];
                        for (uint k = leftIter; k <= middle; k++)
                            inv++;
                        rightIter++;
                    }
                }
                else if (leftIter <= middle)
                {
                    res[i] = leftBuff[leftIter];
                    leftIter++;
                }
                else
                {
                    res[i] = rightBuff[rightIter];
                    rightIter++;
                }
            }
            return res;
        }
    }
}
