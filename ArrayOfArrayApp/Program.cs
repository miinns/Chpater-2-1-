﻿using System;
class ArrayOfArrayApp
{
    public static void Main()
    {
        int[][] arrayOfArray = new int[3][]; 
        int i, j;
        for (i = 0; i < arrayOfArray.Length; i++) 
            arrayOfArray[i] = new int[i + 3];
        for (i = 0; i < arrayOfArray.Length; i++) 
            for (j = 0; j < arrayOfArray[i].Length; j++)
                arrayOfArray[i][j] = i * arrayOfArray[i].Length + j; // i * 3 + j, i* 4+j, i * 5+
        for (i = 0; i < arrayOfArray.Length; i++)
        {
            for (j = 0; j < arrayOfArray[i].Length; j++)
                Console.Write(" " + arrayOfArray[i][j]);
            Console.WriteLine();
        }
    }
}
