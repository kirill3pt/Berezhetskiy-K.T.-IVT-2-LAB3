using System;

namespace Zadanie6
{
    internal class Zadanie6
    {
        static int[] VvodMassiva() //функция на ввод массивов 3х3
        {
            int razmerMassiva;
            Console.WriteLine("Введите размер массива:");
            razmerMassiva = int.Parse(Console.ReadLine());//вводим ограничение для массива
            int[] massiv = new int[razmerMassiva];//массив будет состоять из стольки элементов, сколько мы ввели ранее
            
            for (int i = 0; i < razmerMassiva; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                massiv[i] = int.Parse(Console.ReadLine());//просто ввод массива с клавиатуры, пока не дойдем до значения 3х3
            }
            return massiv;
        }
        static void VivodMassiva(int[] massiv)//функция вывода массива на консоль
        {
            for (int i = 0; i < massiv.Length; i++)
            {
               Console.Write(massiv[i] + " | ");//просто выводим массив в консоль
            }
        }

        static int IterationSummaElementovMassiva(int[] massiv)
        {
            int sum = 0; //для коректного вычисления суммы
            for (int i = 0; i < massiv.Length; i++)
            {
                sum += massiv[i]; //сумма = 0 + первый элемент массива
                                  //сумма = 0 + второй элемент массива и т.д.
            }
            return sum;
        } //вычисляем сумму итерационно
        static int RecursionSummaElementovMassiva(int[] massiv, int i = 0)//вычисляем сумму рекурсивно
        {
            if (i >= massiv.Length) //если дошли до конца массива, то оставляем 0, ничего не складываем
            {
                return 0;
            }
            return massiv[i] + RecursionSummaElementovMassiva(massiv, i + 1);
            //возвращаем массив + возвращаем функцию,
            //увеличивая i на 1, и так пока не дойдем до massiv.Length
            //то есть i + 1 это переход к следующему эл. массива
        }
        static int IterationMinElementMassiva(int[] massiv)
        {
            int minElement = massiv[0]; //присваеваем значению минимальный элемент 1 элемент массива
            for (int i = 1; i < massiv.Length; i++) //проходимся по массиву
            {
                if (minElement > massiv[i])//если 1 элемент массива больше найденного элемента массива,
                                           //то записываем в минимальный элемент найденное значение, которое меньше
                                           //и так пока не найдем самый минимальный элемент
                {
                    minElement = massiv[i];
                }
            }
            return minElement;
        }//вычисляем минимальный элемент итерационно
        static int RecursionMinElementMassiva(int[] massiv, int i = 0)
        {  
            if (i == massiv.Length - 1) //когда дошли до конца, возвращаем значение последнего элемента
            {
                return massiv[i];
            }
            int minElement = RecursionMinElementMassiva(massiv, i + 1); //вызываем функцию, увеличивая i на 1 
                                                                        //то есть i + 1 это переход к следующему эл. массива
            if (massiv[i] < minElement) //если элемент на i этапе меньше 
            {
                return massiv[i]; //возвращаем значение этого элемента
            }
            else
            {
                return minElement;
            }
        }//вычисляем минимальный элемент рекурсивно
        static void Main()
        { 
            int[] massiv = VvodMassiva(); //вводим количество элементов массива и сам массив
            
            Console.WriteLine("Ваш массив:");
            VivodMassiva(massiv); //выводим массив
            Console.WriteLine();
            //------------------------------------------
            Console.Write("Итерационная сумма элементов массива: ");
            int sumOFmassivIteration = IterationSummaElementovMassiva(massiv);//выводим результат вычисления из функции
            Console.WriteLine(sumOFmassivIteration);
            //------------------------------------------
            Console.Write("Рекурсионная сумма элементов массива: ");
            int sumOFmassivRecursion = RecursionSummaElementovMassiva(massiv);
            Console.WriteLine(sumOFmassivRecursion);
            //------------------------------------------
            Console.Write("Минимальный элемент массива, найденный итерационно: ");
            int minElementIteration = IterationMinElementMassiva(massiv);
            Console.WriteLine(minElementIteration);
            //------------------------------------------
            Console.Write("Минимальный элемент массива, найденный рекурсионно: ");
            int minElementRecursion = RecursionMinElementMassiva(massiv);
            Console.WriteLine(minElementRecursion);
            
            Console.ReadLine();
        }
    }
}
