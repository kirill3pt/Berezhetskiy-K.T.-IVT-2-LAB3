using System;

namespace Zadanie1
{
    class Zadanie1
    {
        static void Main()
        {
            int razmerMassiva, count = 0; //count для счетчика чтобы можно было сделать вывод по 10 элементов в строке
            Console.WriteLine("Введите число элементов для массива: ");
            razmerMassiva = int.Parse(Console.ReadLine());
            int[] massiv = new int[razmerMassiva];

            Random random = new Random();
            for (int i = 0; i < razmerMassiva; i++)
            {
                massiv[i] = random.Next(-30, 45); //заполнил массив целыми числами от -30 до 45, рандомно.
            }

            Console.WriteLine("Случайные элементы массива от -30 до 45: "); //вывел элементы массива от -30 до 45, рандомно. 
            foreach (int item in massiv)
            {
                count++;//узнаем количество элементов в массиве
                Console.Write($"{item} ");
                if (count % 10 == 0 && count > 0)//если счетчик дойдет до десятка чисел,
                                                 //то вывод чисел начнется с новой строки.
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            Console.WriteLine("Вывод массива в обратном направлении без отрицательных чисел: ");
            for (int i = massiv.Length - 1; i >= 0; i--) //massiv.Length - 1 - это последний элемент массива
            {
                if (massiv[i] >= 0)
                {
                    Console.Write($"{massiv[i]} ");
                }
            }
            /* еще пробовал вывести через Array.Reverse. результат был также верный
            
             Array.Reverse(massiv); //перевернул массив в обратную сторону с помощи функции .Reverse
             foreach (int item in massiv)
             {
                if (item >= 0)
                { 
                    Console.Write($"{item} ");
                }
             }
             */
            Console.ReadLine();
        }
    }
}
