using System;

namespace Zadanie3
{
    internal class Zadanie3
    {
        static void Main()
        {
            int razmerMassiva, k;
            Console.Write("Введите сколько чисел будет в массиве: "); //ограничения для кол-ва элементов массива
            razmerMassiva = int.Parse(Console.ReadLine());
            int[] massiv = new int[razmerMassiva];

            for (int i = 0; i < razmerMassiva; i++) //ввод чисел для массива
            {
                Console.Write($"Введите {i + 1} элемент массива: ");//i + 1 потому что там отображалось с 0 элемента, можно сказать больше для красоты сделал так
                massiv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Массив: ");
            foreach (int item in massiv)//вывел изначальный массив
            {
                Console.Write($"{item} | ");
            }
            
            Console.WriteLine();
            Console.Write("Введите теперь k для сдвига на k влево: ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Массив со сдвигом на k влево:");

            if (razmerMassiva >= k) //проверил, чтобы число сдвига было меньше самого размера массива, для оптимальности
            {
                int[] temp = new int[k]; /*
                                          * создал новый массив, в который вписал количество элементов, 
                                          * которые после сдвига уйдут, то есть если k = 2, 
                                          * то первые 2 элемента запишутся в этот массив
                                          */
                for (int i = 0; i < razmerMassiva; i++)
                {
                    if (i < k)
                    {
                        temp[i] = massiv[i]; //пока i < k, сохраняю элементы i в массив, а потом:
                    }
                    else
                    {
                        massiv[i - k] = massiv[i];//сдвигаю оставшиеся элементы влево, перезаписывая старый массив новыми данными
                    }//и повторяю эти действия пока i не достигнет значения razmerMassiva.
                }
                for (int i = 0; i < k; i++)
                {
                    massiv[razmerMassiva - k + i] = temp[i]; //прибавляю те элементы, которые ушли после сдвига в конец массива
                }
                foreach (int item in massiv)
                {
                    Console.Write($"{item} | ");//вывел измененный массив
                }
            }
            else
            {
                Console.WriteLine("k больше размера массива. Сдвиг невозможен."); //сообщение об ошибке, т.к. в начале условие razmerMassiva >= k.
            }
            Console.ReadLine();
        }
    }
}
