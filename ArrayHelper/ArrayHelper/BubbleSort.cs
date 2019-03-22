using System;

namespace ArrayHelper
{
    public static class BubbleSort
    {
        private static bool IsValid(int[] arr)
        {
            return arr.Length > 1;
        }

        public static void Sort(int[] arr, bool reverse)
        {
            if (!IsValid(arr)) return;

            for (var i = 0; i < arr.Length - 1; i++)
            for (var j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] <= arr[j]) continue;
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            if (reverse)
                Array.Reverse(arr);
        }
    }
}