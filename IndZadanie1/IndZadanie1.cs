using System;

namespace IndZadanie1
{
    class IndZadanie1
    {
        static int[,] Massiv9na9()
        {
            int[,] massiv = new int[9, 9];
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < massiv.GetLength(1); j++) //тут заполняем матрицу от 1 до 81, т.к. матрица 9х9
                {
                    massiv[i, j] = i * 9 + j + 1;/* (i * 9) = задает начало строки(например, 1 * 9 = 9, 2 * 9 = 18, и т.д
                                                   * (+ j + 1) = задает последовательно значение для строки ->
                                                   * (например, 1 + 1 = 2, 2 + 1 = 3, 3 + 1 = 4, и т.д.)
                                                   */
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int temp = massiv[i, j];
                    massiv[j, i] = massiv[i, j];
                    massiv[i, j] = temp;
                }
            }
            return massiv;
        }
        static void VivodMassivov(int[,] massiv)//функция вывода массива на консоль
        {
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    Console.Write(massiv[i, j] + "\t");//просто выводим массив в консоль
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.WriteLine("Матрица симметричная главной диагонали: ");
            int[,] massiv = Massiv9na9();
            VivodMassivov(massiv);
            Console.ReadLine();
        }
    }
}
