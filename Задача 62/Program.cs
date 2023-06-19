/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[4, 4];
        int num = 1;
        int i = 0, j = 0;
        int direction = 0; // 0 - right, 1 - down, 2 - left, 3 - up

        while (num <= 16)
        {
            array[i, j] = num;
            num++;

            // change direction if needed
            if (direction == 0 && (j == 3 || array[i, j + 1] != 0))
            {
                direction = 1;
            }
            else if (direction == 1 && (i == 3 || array[i + 1, j] != 0))
            {
                direction = 2;
            }
            else if (direction == 2 && (j == 0 || array[i, j - 1] != 0))
            {
                direction = 3;
            }
            else if (direction == 3 && (i == 0 || array[i - 1, j] != 0))
            {
                direction = 0;
            }

            // move in the current direction
            if (direction == 0)
            {
                j++;
            }
            else if (direction == 1)
            {
                i++;
            }
            else if (direction == 2)
            {
                j--;
            }
            else if (direction == 3)
            {
                i--;
            }
        }

        // print the array
        for (i = 0; i < 4; i++)
        {
            for (j = 0; j < 4; j++)
            {
                Console.Write("{0,2} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}

