using System;

namespace Zadanie5
{
    //тут я использовал функции, написанные в предыдущей задаче для ввода и вывода матриц
    //опять же, надеюсь, что можно было это использовать. спасибо:)
    internal class Zadanie5
    {
        static int[,] VvodMatric() //функция на ввод матриц 5х5
        {
            int[,] matrica = new int[5, 5];
            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                {
                    Console.Write($"Столбец: {i + 1}, введите {j + 1} элемент строки: ");//i + 1 и j + 1 для красоты, чтобы счёт начинался с 1, а не 0
                    matrica[i, j] = int.Parse(Console.ReadLine());//просто ввод массива с клавиатуры, пока не дойдем до значения 3х3
                }
                Console.WriteLine();
            }
            return matrica;
        }
        static void VivodMatric(int[,] matrica)//функция вывода массива на консоль
        {
            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                {
                    Console.Write(matrica[i, j] + "\t");//просто выводим массив в консоль
                }
                Console.WriteLine();
            }
        }
        static int[,] UmnozhenieMatric(int[,] matrica1, int[,] matrica2)
        {
            int[,] result = new int[5, 5];
            for (int i = 0; i < matrica1.GetLength(0); i++)//проходимся по строкам
            {
                for (int j = 0; j < matrica2.GetLength(1); j++)//проходимся по столбцам
                {
                    result[i, j] = 0;//для накапливания элементов матриц
                    for (int k = 0; k < matrica1.GetLength(1); k++)
                    {
                        result[i, j] += matrica1[i, k] * matrica2[k, j]; //умножаем элементры строки i с первой матрицы на 
                        //элемент столбца j второй матрицы
                        //т.к. для того, чтобы перемножить массивы, надо (для примера) ->
                        //(matrica3(1,1) = matrica1(1,1) * matrica2(1,1) + matrica(1,2) * matrica2(2,1)) и т.д
                    }
                }
            }
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Первая матрица 5х5:");
            int[,] massiv1 = VvodMatric();
            Console.WriteLine("Ваша первая матрица 5х5:");
            VivodMatric(massiv1);
            Console.WriteLine("Вторая матрица 5х5:");
            int[,] massiv2 = VvodMatric();
            Console.WriteLine("Ваша вторая матрица 5х5:");
            VivodMatric(massiv2);
            Console.WriteLine("Результат умножения двух матриц 5х5:");
            int[,] Umnozhenie = UmnozhenieMatric(massiv1, massiv2);
            VivodMatric(Umnozhenie);

            Console.ReadLine();
        }
    }
}