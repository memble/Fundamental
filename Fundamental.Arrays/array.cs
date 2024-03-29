﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fundamental.Arrays
{
    class array
    {
        void ExampleDeclareArray()
        {
            //single dimensional array
            int[] array1 = new int[5];

            // Declare and set array element values
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
        }

        static void Main(string[] args)
        {
            //single dimensional array
            int[] number = new int[] { 1, 3, 5, 7, 9 };

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}
