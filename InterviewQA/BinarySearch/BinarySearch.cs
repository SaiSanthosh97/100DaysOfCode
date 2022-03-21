using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 50, 60, 70, 80, 90 };
            int n = arr.Length;
            int x = 60;
            int result = binarySearch(arr, 0, n - 1, x);
            if (result == -1)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine("Element found at index " + result);
            }
            Console.ReadLine();
        }

        private static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = (r + l) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                if (arr[mid] > x)
                {
                    return binarySearch(arr, l, mid - 1, x);
                }
                return binarySearch(arr, mid + 1, r, x);
            }
            return -1;
        }
    }
}
