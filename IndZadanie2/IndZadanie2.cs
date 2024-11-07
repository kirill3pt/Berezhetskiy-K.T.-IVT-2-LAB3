using System;

namespace IndZadanie2
{
    class IndZadanie2
    {
        static int[] VvodMassiva() //функция на ввод массивов 3х3
        {
            //ввод размера массива
            int razmerMassiva;
            Console.Write("Введите количество элементов в массиве. Оно должно быть кратно 2-м: "); 
            razmerMassiva = int.Parse(Console.ReadLine());
            //--------------------
            if (razmerMassiva % 2 != 0)
            {
                Console.WriteLine("Неправильный ввод. Необходим размер массива, кратный 2-м!"); 
                //проверяем, сколько элементов в массиве, для корректных вычислений
                return null;
            }
            //--------------------
            //ввод элементов массива
            int[] massiv = new int[razmerMassiva];
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: "); //i + 1 чтобы отображалось не с 0, а с 1.
                massiv[i] = int.Parse(Console.ReadLine());
            }
            return massiv;
        }
        static void Main()
        {
            int[] massiv = VvodMassiva();
            if (massiv == null)
            {
                Console.WriteLine("Программа завершена."); //проверяем на то же, что и в функции ввода
                return;
            }
            int n = massiv.Length / 2;
            int leftSum = 0, rightSum = 0;

            for (int i = 0; i < n; i++) //цикл для рассчета суммы левой половины массива
            {
                leftSum += massiv[i];
            }
            //------------------------------------
            for (int i = n; i < massiv.Length; i++) //цикл для рассчета суммы левой половины массива
            {
                rightSum += massiv[i]; 
            }
            int result = leftSum - rightSum; //находим результат вычитания: левая половина - правая половина, по условию

            Console.WriteLine("Результат вычитания суммы эл-ов левой половины массива из " +
                $"суммы эл-ов правой половины массива: {result}");
            Console.ReadLine();
        }
    }
}
