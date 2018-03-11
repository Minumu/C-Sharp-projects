using System;

namespace mergeSorting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 20, -1, 5, 0, -5, 332, 19, 3, 9, 1 };
            int[] merge_arr = new int[arr.Length];
            uint left = 0;
            uint right = (uint)(arr.Length - 1);
            int[] res;

            res = mergeSorting(arr, merge_arr, left, right);
            int i = -1;
            while (++i < res.Length)
                Console.Write($"{res[i]} ");
        }
        private static int[] mergeSorting(int[] arr, int[] merge_arr, uint left, uint right)
        {
            int[] res;
            if (left == right)
            {
                merge_arr[left] = arr[left];
                return merge_arr;
            }
            uint middle = (left + right) / 2;
            int[] leftBuff = mergeSorting(arr, merge_arr, left, middle);
            int[] rightBuff = mergeSorting(arr, merge_arr, middle + 1, right);
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
                    if (leftBuff[leftIter] < rightBuff[rightIter])
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
