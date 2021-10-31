using System;
using static System.Math;

namespace MaxElementOfArrayClassLibrary
{
    public class MaxElementOfArray
    {
        public int Find(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            return RecurseSearch(0, array);
        }

        private int RecurseSearch(int tmp, int[] array)
        {
            return tmp < array.Length - 1 ? Max(array[tmp], RecurseSearch(++tmp, array)) : array[tmp];
        }
    }
}