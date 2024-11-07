using System;

namespace Zadanie2
{
    internal class Zadanie2
    {
        static void Main()
        {
            int[,] massiv = new int[7, 7];

            Console.WriteLine("Исходный массив 7х7:"); //заполнил массив от 0 до 49, строки и столбцы = 7x7
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    massiv[i, j] = i * 7 + j + 1; /* (i * 7) = задает начало строки(например, 1 * 7 = 7, 2 * 7 = 14, и т.д
                                                   * (+ j + 1) = задает последовательно значение для строки ->
                                                   * (например, 1 + 1 = 2, 2 + 1 = 3, 3 + 1 = 4, и т.д.)
                                                   */
                    Console.Write(massiv[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Перевернутый массив 7х7 на 90 градусов:"); /*перевернул массив на 90 градусов через 6-j,i
                                                                           * 6 потому что это последний элементт массива(не 7, потому что 
                                                                           * нумерация с 0 в массивах)
                                                                           * 6-j,i - поставил первую строку на последний столбец, и т.д.
                                                                           */
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(massiv[6 - j, i] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
