

using System;

namespace Assignment2
{

    public class MaxNumber
    {
        public static void Main(string[] args)
        {

            int[] arr = new int[] { 11, 23, 43, 84, 75, 6, 57 };
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("Max number is : " + max);

        }
    }
}