/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите размеры первой матрицы:");
        int rows1 = int.Parse(Console.ReadLine());
        int cols1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите элементы первой матрицы:");
        int[,] arr1 = new int[rows1, cols1];
        for (int i = 0; i < rows1; i++) {
            for (int j = 0; j < cols1; j++) {
                arr1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Введите размеры второй матрицы:");
        int rows2 = int.Parse(Console.ReadLine());
        int cols2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите элементы второй матрицы:");
        int[,] arr2 = new int[rows2, cols2];
        for (int i = 0; i < rows2; i++) {
            for (int j = 0; j < cols2; j++) {
                arr2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        if (cols1 != rows2) {
            Console.WriteLine("Умножение невозможно!");
            return;
        }

        int[,] result = new int[rows1, cols2];
        for (int i = 0; i < rows1; i++) {
            for (int j = 0; j < cols2; j++) {
                int sum = 0;
                for (int k = 0; k < cols1; k++) {
                    sum += arr1[i, k] * arr2[k, j];
                }
                result[i, j] = sum;
            }
        }

        Console.WriteLine("Результирующая матрица:");
        for (int i = 0; i < rows1; i++) {
            for (int j = 0; j < cols2; j++) {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}