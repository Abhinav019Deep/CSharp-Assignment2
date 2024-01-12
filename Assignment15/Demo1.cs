using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Demo1
    {

        static void Main()
        {
            Console.WriteLine("Enter values : ");
            // int[ , ] x = new int [2, 3];
            int[,] arr = new int[3, 4];

            // taking row wise input
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.WriteLine($"arr[{row},{col}]");
                    arr[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    //arr[row][col]=Console.Readline();
                    Console.Write(arr[row, col] + " ");
                }
                Console.WriteLine();
            }




            // to check a number

            Console.WriteLine("Enter the number to check : ");
            int target = int.Parse(Console.ReadLine());

            // calling of function to check if a number is present or not
            if (isPresent(arr, target))
            {
                Console.WriteLine("number found");
            }
            else
                Console.WriteLine("Number not found");




            // row wise sum
            RowWiseSum(arr);

            //column wise sum
            ColWiseSum(arr);


            // largest Row sum
            largestRowSum(arr);


        }

        public static void largestRowSum(int[,] arr)
        {
            int max = 0;
            int rowIndex = 0;
            for (int row = 0; row < 3; row++)
            {
                int sum = 0;
                for (int col = 0; col < 4; col++)
                {
                    sum = sum + arr[row, col];
                }
                //Console.WriteLine($"Sum for {row + 1} row is {sum}");

                if(sum > max)
                {
                    max = sum;
                    rowIndex = row;
                }
            }

            Console.WriteLine("The Maximum sum of row index is : " + rowIndex);
        }


        // program to calculate column wise sum
        public static void ColWiseSum(int[,] arr)
        {
            for (int col = 0; col < 4; col++)
            {
                int sum = 0;
                for (int row = 0; row < 3; row++)
                {
                    sum = sum + arr[row, col];
                }
                Console.WriteLine($"Sum for {col + 1} col is {sum}");
            }
        }




        // function to calculate row wise sum
        public static void RowWiseSum(int[,] arr)
        {
            for(int row = 0;row < 3; row++)
            {
                int sum = 0;
                for(int col = 0;col < 4; col++)
                {
                    sum = sum+ arr[row, col];
                }
                Console.WriteLine($"Sum for {row + 1} row is {sum}");
            }
        }

        // function to check if a number is present or not...
        public static bool isPresent(int[,] arr, int target)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (arr[row, col] == target)
                    {
                        return true;
                    }
                }
            }

            return false;

        }

    }
}
