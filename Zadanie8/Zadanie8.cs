using System;

namespace Zadanie8
{
    class Zadanie8
    {
        static int[,] VvodMatric()
        {
            Console.Write("Введите размер матрицы: "); //вводим размер матрицы и её данные
            int razmer = int.Parse(Console.ReadLine());
            int[,] matrica = new int[razmer, razmer];

            for (int i = 0; i < razmer; i++)
            {
                for (int j = 0; j < razmer; j++)
                {
                    Console.Write($"Столбец: {i + 1}, введите {j + 1} элемент строки: ");
                    matrica[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return matrica;
        }
        static void VivodMatric(int[,] matrica) //выводим матрицу
        {
            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                    Console.Write(matrica[i, j] + "\t");
                Console.WriteLine();
            }
        }
        static int[,] NahozdenieMinora(int[,] matrica, int StrokaDelete, int StolbecDelete) //получаем 
        {
            int size = matrica.GetLength(0); //узнаем размер матрицы
            int[,] minor = new int[size - 1, size - 1]; //делаем матрицу с размером меньше на 1

            for (int i = 0, mi = 0; i < size; i++) 
            {
                if (i == StrokaDelete) continue; //пропуск строки, которую удаляем
                for (int j = 0, mj = 0; j < size; j++)
                {
                    if (j == StolbecDelete) continue; //пропуск столбца, который удаляем
                    minor[mi, mj] = matrica[i, j]; //сохраняем всё это в подматрицу
                    mj++; //переход на следующий столбец подматрицы
                }
                mi++;//переход на следующую строку подматрицы
            }
            return minor;
        }

        static int Opredelitel(int[,] matrica)
        {
            int size = matrica.GetLength(0); //получаем размер матрицы
            if (size == 1)  //это случай для единичной матрицы, 1х1. тогда возвращаем начальный элемент
            {
                return matrica[0, 0];
            }
            if (size == 2) //это случай для матрицы 2х2.
            {
                return matrica[0, 0] * matrica[1, 1] - matrica[0, 1] * matrica[1, 0];
            }

            int opredelitel = 0;
            for (int j = 0; j < size; j++) //это случаи для матриц больше 2х2
            {
                int sign = (j % 2 == 0) ? 1 : -1;
                //тут задаем знак для элемента, зависит от позиции Aij = (-1)^i+j * Mij, по формуле из условия
                //знак вычисляется как(-1)^(0 + j), что = (-1)^j
                opredelitel += sign * matrica[0, j] * Opredelitel(NahozdenieMinora(matrica, 0, j));
                //умножаем текущий элемент на определитель подматрицы, полученной удалением 0-й строки и j-го столбца
            }
            return opredelitel;
        }
        static void Main()
        {
            int[,] matrica = VvodMatric();
            Console.WriteLine("Ваша матрица:");
            VivodMatric(matrica);
            Console.WriteLine($"Определитель матрицы: {Opredelitel(matrica)}");
            Console.ReadLine();
        }
    }
}
