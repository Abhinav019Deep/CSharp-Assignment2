using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class sumAverage
    {
        public static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum of num are : " + sum);

            int avg = sum / arr.Length;
            Console.WriteLine("The average of num are : " + avg);

        }
    }
}
