using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arraysmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //methods in 1D array

            int[] arr = new int[] { 23, 56, 12, 89, 22 };
            int[] arr2 = new int[3];
            int[] arr3 = new int[5];
            Console.WriteLine("original array");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            //built in class Array
            Array.Copy(arr, 0, arr2, 0, 2);
            Array.Copy(arr, arr3, 5);
            Array.Sort(arr);
            Array.Reverse(arr);
            Array.Clear(arr3, 3, 2);
            Console.WriteLine("sorted array");
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("reverse array");
            foreach (var item in arr)
            {
              Console.WriteLine(item);  
            }

        }
    }
}
