/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите размеры массива:");
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int[,] arr = new int[rows, cols];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int minSum = int.MaxValue;
        int minIndex = -1;
        for (int i = 0; i < rows; i++) {
            int sum = 0;
            for (int j = 0; j < cols; j++) {
                sum += arr[i, j];
            }
            if (sum < minSum) {
                minSum = sum;
                minIndex = i;
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex + 1}");
    }
}