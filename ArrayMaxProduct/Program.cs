﻿/*
 * Given an array of integers write a method that will return the highest possible products of any two integers in the array. 
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nInput an array of integer\n\n>>> ");
                    string[] input = Console.ReadLine().Split(',');
                    int[] intArr = new int[input.Length];
                    for (int i = 0; i < input.Length; i++)
                    {
                        intArr[i] = Convert.ToInt32(input[i]);
                    }
                    Console.WriteLine($"\nMaxProduct: {MaxProduct(intArr)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n{ex.Message}");
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static int MaxProduct(int[] arr)
        {
            // assign thre first two integers of the array to max1 and max2 variables
            int max1 = arr[0] > arr[1] ? arr[0] : arr[1];
            int max2 = arr[0] > arr[1] ? arr[1] : arr[0];

            // iterrate throught the array and update max1 and max2 as bigger nambers are encountered
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2)
                {
                    max2 = arr[i];
                }
            }
            return max1 * max2;
        }
    }
}
