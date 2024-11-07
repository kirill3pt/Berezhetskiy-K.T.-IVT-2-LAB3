using System;

namespace Zadanie7
{
    class Zadanie7
    {
        // Рекурсивная функция для нахождения n-ого числа Фибоначчи
        static int RecursionNahozhdenieFibonacci(int n)
        {
            if (n <= 1) //<=1 т.к. 1 элемент = 0, 2 элемент 1 (в числах Фиббоначи)
                return n;
            return RecursionNahozhdenieFibonacci(n - 1) + RecursionNahozhdenieFibonacci(n - 2); 
            //каждое следующее число равно сумме двух предыдущих 
        }

        static void Main()
        {
            int n;
            Console.Write("Введите номер члена ряда Фибоначчи, необходимый для нахождения: ");
            n = int.Parse(Console.ReadLine());
            int fibonacci = RecursionNahozhdenieFibonacci(n);
            Console.WriteLine($"Число Фибоначчи под номером {n} = {fibonacci}");

            Console.ReadLine();
        }
    }
}
