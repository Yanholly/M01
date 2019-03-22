using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayHelper
{
   public static class SumCounter
    {
        private static bool IsValid(int[,] arr)
        {
            return arr.Length != 0;
        }

        public static int Count(int[,] arr)
        {
            if (!IsValid(arr)) return -1;
            var sum = (from int t in arr where t > 0 select t).Sum();
            return sum;
        }
    }
}
