/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.WriteLine("Введите двумерный массив:");
int[,] arr = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    for (int j = 0; j < 5; j++)
    {
        arr[i, j] = int.Parse(input[j]);
    }
}



        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0,3} ", arr[i, j]);
            }
            Console.WriteLine();
        }

        // Упорядочиваем каждую строку по убыванию
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int k = j + 1; k < 5; k++)
                {
                    if (arr[i, k] > arr[i, j])
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }

        // Выводим упорядоченный массив
        Console.WriteLine("Упорядоченный массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0,3} ", arr[i, j]);
            }
            Console.WriteLine();
        }
 