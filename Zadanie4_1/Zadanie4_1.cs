using System;

namespace Zadanie4
{
    internal class Zadanie4_1
    {
        //это второй вариант решения этой задачи, т.е. добавил вычисление суммы для результатов операций сложения и вычитания
        static int[,] VvodMassivov() //функция на ввод массивов 3х3
        {
            int[,] massiv = new int[3, 3];
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    Console.Write($"Столбец: {i + 1}, введите {j + 1} элемент строки: ");//i + 1 и j + 1 для красоты, чтобы счёт начинался с 1, а не 0
                    massiv[i, j] = int.Parse(Console.ReadLine());//просто ввод массива с клавиатуры, пока не дойдем до значения 3х3
                }
                Console.WriteLine();
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
        static int[,] SlozhenieMassivov(int[,] massiv1, int[,] massiv2, out double sredneeSumma)//функция сложения массивов поэлементно
        {
            int sum = 0;
            int vseElements = massiv1.GetLength(0) * massiv2.GetLength(1);//узнаем количество элементов в массиве
            int[,] result = new int[3, 3];//создали массив с результатом 3х3, т.к. нам нужен массив 3х3 для хранения результата сложения
            for (int i = 0; i < massiv1.GetLength(0); i++)
            {
                for (int j = 0; j < massiv2.GetLength(1); j++)
                {
                    result[i, j] = massiv1[i, j] + massiv2[i, j];//складываем два введенных массива и записываем результат в массив result
                    sum += result[i, j];//это сумма элементов в уже посчитанном массиве
                }
            }
            sredneeSumma = (double)sum / vseElements;//находим среднее значение 
            return result;
        }
        static int[,] VichitanieMassivov(int[,] massiv1, int[,] massiv2, out double sredneeRaznost)//функция вычитания массивов поэлементно
        {
            int sum = 0;
            int vseElements = massiv1.GetLength(0) * massiv2.GetLength(1);//узнаем количество элементов в массиве
            int[,] result = new int[3, 3];//создали массив с результатом 3х3, т.к. нам нужен массив 3х3 для хранения результата вычитания
            for (int i = 0; i < massiv1.GetLength(0); i++)
            {
                for (int j = 0; j < massiv2.GetLength(1); j++)
                {
                    result[i, j] = massiv1[i, j] - massiv2[i, j];//вычитаем два введенных массива и записываем результат в массив result
                    sum += result[i, j];//это сумма элементов в уже посчитанном массиве
                }
            }
            sredneeRaznost = (double)sum / vseElements;//находим среднее значение 
            return result;
        }
        static void Main()
        {

            Console.WriteLine("Первый массив 3х3: ");
            int[,] massiv1 = VvodMassivov();//используем функцию ввода массива, в данном случае первого
            //для этого надо создать новый массив и записать в него результат функции VvodMassivov()
            Console.WriteLine("Ваш 1 массив 3х3: ");
            VivodMassivov(massiv1);//вывели первый массив с помощью функции VivodMassivov(тут записываем массив, который надо вывести)

            Console.WriteLine("Второй массив 3х3:");
            int[,] massiv2 = VvodMassivov();//снова функция для ввода массива, для второго массива
            Console.WriteLine("Ваш 2 массив 3х3: ");
            VivodMassivov(massiv2);//вывели второй массив с помощью функции VivodMassivov()


            Console.WriteLine("Результат сложения массивов:");
            int[,] Summa = SlozhenieMassivov(massiv1, massiv2, out double sredneeSumma);//используем функцию сложения массивов, результат её записываем в новый массив для суммы
            VivodMassivov(Summa);//выводим массив с результатом


            Console.WriteLine("Результат вычитания массивов:");
            int[,] Raznost = VichitanieMassivov(massiv1, massiv2, out double sredneeRaznost);//используем функцию вычитания массивов, результат её записываем в новый массив для разности
            VivodMassivov(Raznost);//выводим массив с результатом

            Console.WriteLine($"Среднее значение всех элементов cуммы: {sredneeSumma} ");//вывод среднего значения всех элементов массива суммы
            Console.WriteLine($"Среднее значение всех элементов разности: {sredneeRaznost} ");//вывод среднего значения всех элементов массива разности

            Console.ReadLine();
        }
    }
}
