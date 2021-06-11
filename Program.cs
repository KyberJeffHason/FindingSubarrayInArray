using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingSubarrayInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 3, 4 };
            int[] sub_arr = new int[] { 3, 4 };
            Console.WriteLine(ContainsAtIndex(arr, sub_arr, 2));

            Console.WriteLine(FindSubarrayStartIndex(arr, sub_arr));
            Console.ReadLine();
        }

        public static int FindSubarrayStartIndex(int[] array, int[] subarray)
        {
            for (var i = 0; i < array.Length - subarray.Length + 1; i++)
            {
                if (ContainsAtIndex(array, subarray, i))
                {
                    return i;
                }
            }
            return -1;
        }
        public static Boolean ContainsAtIndex(int[] array, int[] subarray, int i)
        {

            string array_str = string.Join("", array);
            string substringed_array = array_str.Substring(i);
            string subarray_str = string.Join("", subarray);

            int index = 0;

            if (substringed_array.Contains(subarray_str))
            {
                int leng = array_str.Length - substringed_array.Length;
                index = substringed_array.IndexOf(subarray_str) + leng;
            }

            if (i == index)
            {
                return true;
            }

            return false;
        }
    }
}
