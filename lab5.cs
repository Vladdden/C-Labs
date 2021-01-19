using System;
/*
1 Написать программу, выводящею на экран одномерный и двумерный
массив чисел соответственно (одномерный — в виде строки, двумерный — в
виде таблицы).
2 Написать программу, находящую минимальный и максимальный элемент
массива, вычисляющую среднее арифметическое элементов массива и сумму
элементов. Массив одномерный, размерности N, заполнить его случайными
целыми числами от a до b. N, a и b вводятся пользователем. Вывести массив
и результаты.
3 Написать программу для перемножения квадратных матриц А и В
размерности NxN, которая должна вывести на экран результат — третью
матрицу размерности NxN.
4 Создать 1 из выбранных пользователем типов массивов (одномерный или
двумерный). В зависимости от выбора пользователя заполнить его вручную
или случайными целыми числами. Размерность массива задает пользователь.
Полученный массив вывести на экран
5.1 Напишите программу, формирующую квадратную матрицу, элементы
которой являются натуральными числами, расположенными в порядке
возрастания от 1 до n2 согласно приведенной схеме:
5.2 Квадратная матрица порядка 2n состоит из 4 блоков. Напишите
программу, которая формирует новую матрицу, переставляя блоки исходной
матрицы согласно приведенной схеме:
 */
namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise = ""; 
            while (choise != "0")
            {
                Console.Clear();
                Console.WriteLine("Выберите номер программы, которую надо запустить (или выход):");
                Console.WriteLine("1. Написать программу, выводящею на экран одномерный и двумерный массив чисел соответственно (одномерный — в виде строки, двумерный — в виде таблицы).");
                Console.WriteLine("2. Написать программу, находящую минимальный и максимальный элемент массива, вычисляющую среднее арифметическое элементов массива и сумму " +
                                  "элементов. Массив одномерный, размерности N, заполнить его случайными целыми числами от a до b. N, a и b вводятся пользователем. Вывести массив и результаты.");
                Console.WriteLine("3. Написать программу для перемножения квадратных матриц А и В размерности NxN, которая должна вывести на экран результат — третью матрицу размерности NxN.");
                Console.WriteLine("4. Создать 1 из выбранных пользователем типов массивов (одномерный или двумерный). В зависимости от выбора пользователя заполнить его вручную " +
                                  "или случайными целыми числами. Размерность массива задает пользователь. Полученный массив вывести на экран.");
                Console.WriteLine("5.1 Напишите программу, формирующую квадратную матрицу, элементы которой являются натуральными числами, расположенными в порядке " +
                                  "возрастания от 1 до n2 согласно приведенной схеме:");
                Console.WriteLine("5.2 Квадратная матрица порядка 2n состоит из 4 блоков. Напишите программу, которая формирует новую матрицу, переставляя блоки исходной матрицы" +
                                  " согласно приведенной схеме:");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        PrintArray();
                        break;
                    case "2":
                        MinMaxAverage();
                        break;
                    case "3":
                        MultXnX();
                        break;
                    case "4":
                        InOutArray();
                        break;
                    case "5.1":
                        Spiral();
                        break;
                    case "5.2":
                        FourBlocks();
                        break;
                    case "0":
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter, чтобы продолжить");
                Console.ReadKey();
            }
        }
        //Написать программу, выводящею на экран одномерный и двумерный
        //массив чисел соответственно (одномерный — в виде строки, двумерный — в виде таблицы).
        static void PrintArray()
        {
            Console.WriteLine("Введите длину одномерного массива А (количество элементов)");
            int lengthA = Convert.ToInt32(Console.ReadLine());
            int[] A = new int [lengthA];
            for (int i = 0; i < lengthA; i++)
            {
                Console.Write($"Введите A[{i}] элемент массива: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            
            Console.WriteLine("Введите длину строки двумерного массива B (количество элементов)");
            int lengthB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк двумерного массива B");
            int widthB = Convert.ToInt32(Console.ReadLine());
            int[,] B = new int [widthB, lengthB];
            for (int i = 0; i < widthB; i++)
            {
                for (int j = 0; j < lengthB; j++)
                {
                    Console.Write($"Введите B[{i}][{j}] элемент массива: ");
                    B[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.Clear();
            Console.WriteLine($"Массив А: ");
            for (int i = 0; i < A.Length; i++) Console.Write("{0} ", A[i]);
            Console.WriteLine();
            
            Console.WriteLine($"Массив B: ");
            for (int i = 0; i < widthB; i++)
            {
                for (int j = 0; j < lengthB; j++)
                {
                    Console.Write("{0} ", B[i,j]);
                }
                Console.WriteLine();
            }
        }
        //Написать программу, находящую минимальный и максимальный элемент массива, вычисляющую среднее арифметическое элементов массива и сумму
        //элементов. Массив одномерный, размерности N, заполнить его случайными целыми числами от a до b. N, a и b вводятся пользователем.
        //Вывести массив и результаты.
        static void MinMaxAverage()
        {
            int min, max, sum = 0;
            float average;
            Random rnd = new Random(); //Создание объекта для генерации чисел
            Console.WriteLine("Введите длину массива (количество элементов)");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите диапазон значений:");
            Console.Write("От: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("До: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] A = new int [N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(a, b+1); //Получить случайное число (в диапазоне от a до b)
                Console.WriteLine($"A[{i}] = {A[i]}");
            }
            min = A[0]; max = A[0];
            for (int i = 0; i < N; i++)
            {
                if (A[i] < min) min = A[i];
                if (A[i] > max) max = A[i];
                sum += A[i];
            }
            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine($"Максимальное значение: {max}");
            Console.WriteLine("Cреднее арифметическое элементов массива: {0:f2}", sum/N);
            Console.WriteLine($"Сумма элементов массива: {sum}");
        }
        //Написать программу для перемножения квадратных матриц А и В размерности NxN, которая должна вывести на экран результат — третью
        //матрицу размерности NxN.
        static void MultXnX()
        {
            Random rnd = new Random(); //Создание объекта для генерации чисел
            Console.WriteLine("Введите размерность квадратной матрицы (количество элементов в строке)");
            int length = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int [length,length];
            int[,] B = new int [length,length];
            int[,] C = new int [length,length];
            Console.WriteLine("Ввод матрицы:");
            Console.WriteLine("1. Самостоятельно");
            Console.WriteLine("2. Автоматически (случайные числа)");
            Console.Write("Ввведите номер необходимого метода ввода: ");
            string choise = Console.ReadLine();
            Console.WriteLine();
            if (Convert.ToInt32(choise) == 1)
            {
                Console.WriteLine("Ввод матрицы А:");
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write($"Введите A[{i}][{j}] элемент матрицы: ");
                        A[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                
                Console.WriteLine("Ввод матрицы B:");
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write($"Введите B[{i}][{j}] элемент матрицы: ");
                        B[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            else if (Convert.ToInt32(choise) == 2)
            {
                Console.WriteLine("Введите диапазон значений для матрицы А:");
                Console.Write("От: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("До: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Матрица:");
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        A[i,j] = rnd.Next(a, b+1); //Получить случайное число (в диапазоне от a до b)
                        Console.Write($"{A[i,j]} ");
                    }
                    Console.WriteLine();
                }
                
                Console.WriteLine("Введите диапазон значений для матрицы B:");
                Console.Write("От: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("До: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Матрица:");
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        B[i,j] = rnd.Next(a, b+1); //Получить случайное число (в диапазоне от a до b)
                        Console.Write($"{B[i,j]} ");
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Введено неверное значение.");
            Console.WriteLine();
            Console.WriteLine("Результат:");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    C[i, j] = A[i, j] * B[i, j];
                    Console.Write($"{C[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        //Создать 1 из выбранных пользователем типов массивов (одномерный или двумерный). В зависимости от выбора пользователя заполнить его вручную
        //или случайными целыми числами. Размерность массива задает пользователь.Полученный массив вывести на экран
        static void InOutArray()
        {
            int length = 0, width = 0;
            Console.WriteLine("Вид массива:");
            Console.WriteLine("1. Одномерный");
            Console.WriteLine("2. Двумерный");
            Console.Write("Ввведите номер необходимого массива: ");
            string type = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("Метод ввода:");
            Console.WriteLine("1. Самостоятельно");
            Console.WriteLine("2. Автоматически (случайные числа)");
            Console.Write("Ввведите номер необходимого метода ввода: ");
            string inputType = Console.ReadLine();
            Console.WriteLine();
            if (Convert.ToInt32(type) == 1) //одномерный
            {
                Console.WriteLine("Введите длину одномерного массива А (количество элементов)");
                length = Convert.ToInt32(Console.ReadLine());
                int[] A = new int [length];
                
                if (Convert.ToInt32(inputType) == 1) //самостоятельно
                {
                    Console.WriteLine("Ввод массива:");
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write($"Введите A[{i}] элемент массива: ");
                        A[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (Convert.ToInt32(inputType) == 2) //автоматически
                {
                    Random rnd = new Random(); //Создание объекта для генерации чисел
                    Console.WriteLine("Введите диапазон значений для массива:");
                    Console.Write("От: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("До: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Массив:");
                    for (int i = 0; i < length; i++)
                    {
                        A[i] = rnd.Next(a, b+1); //Получить случайное число (в диапазоне от a до b)
                        Console.WriteLine($"A[{i}] = {A[i]}");
                        
                    }
                    Console.WriteLine();
                }
                else Console.WriteLine("Данный вариант не обнаружен.");
                
                Console.WriteLine("Результат:");
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"{A[i]} ");
                }
            }
            else if (Convert.ToInt32(type) == 2) //двумерный
            {
                Console.WriteLine("Введите длину строки двумерного массива (количество элементов)");
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество строк двумерного массива");
                width = Convert.ToInt32(Console.ReadLine());
                int[,] A = new int [width,length];
                
                if (Convert.ToInt32(inputType) == 1) //самостоятельно
                {
                    Console.WriteLine("Ввод массива:");
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            Console.Write($"Введите A[{i}][{j}] элемент массива: ");
                            A[i,j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                else if (Convert.ToInt32(inputType) == 2) //автоматически
                {
                    Random rnd = new Random(); //Создание объекта для генерации чисел
                    Console.WriteLine("Введите диапазон значений для массива:");
                    Console.Write("От: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("До: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Массив:");
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            A[i,j] = rnd.Next(a, b+1); //Получить случайное число (в диапазоне от a до b)
                            Console.WriteLine($"A[{i}][{j}] = {A[i,j]}");
                        }
                        Console.WriteLine();
                    }
                }
                else Console.WriteLine("Данный вариант не обнаружен.");
                
                Console.WriteLine("Результат:");
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < length; j++) Console.Write($"{A[i,j]} ");
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Данный вариант не обнаружен.");
        }
        //Напишите программу, формирующую квадратную матрицу, элементы которой являются натуральными числами, расположенными в порядке
        //возрастания от 1 до n2 согласно приведенной схеме:
        static void Spiral()
        {
            Console.Write("Введите разрядность квадротной матрицы: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int N = length * length;
            int[] A = new int [N];
            
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите {i+1} элемент: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // сортировка
            int temp;
            for (int i = 0; i < A.Length-1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
            int[,] B = new int[length, length];
            int n = 0;
            N = 0;
            length--;
            while (N < Math.Pow(length+1, 2))
            {
                for (int i = n; i <= length - n; i++)//вправо
                {
                    if (N >= Math.Pow(length + 1, 2)) break;
                    B[n, i] = A[N];
                    N++;
                }
                //n++;
                for (int i = 1+n ; i <= length - n; i++)//вниз
                {
                    if (N >= Math.Pow(length + 1, 2)) break;
                    B[i, length-n] = A[N];
                    N++;
                }
                
                for (int i = length-1-n; i >= 0 + n; i--)//влево
                {
                    if (N >= Math.Pow(length + 1, 2)) break;
                    B[length-n, i] = A[N];
                    N++;
                }

                for (int i = length-1-n; i > 0 + n; i--)//вверх
                {
                    if (N >= Math.Pow(length + 1, 2)) break;
                    B[i, n] = A[N];
                    N++;
                }

                n++;
            }
            
            Console.WriteLine("Результат:");
            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j <= length; j++) Console.Write($"{B[i,j]} ");
                Console.WriteLine();
            }
        }
        //Квадратная матрица порядка 2n состоит из 4 блоков. Напишите программу, которая формирует новую матрицу,
        //переставляя блоки исходной матрицы согласно приведенной схеме:
        static void FourBlocks()
        {
            Console.WriteLine("Введите размер блока (n) квадратной матрицы порядка 2*n");
            Console.WriteLine("Пример: Если n=3, значит матрица будет 6х6");
            int block_length = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[block_length * 2, block_length * 2];
            Console.WriteLine("Ввод массива:");
            for (int i = 0; i < block_length*2; i++)
            {
                for (int j = 0; j < block_length*2; j++)
                {
                    Console.Write($"Введите A[{i}][{j}] элемент массива: ");
                    A[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] B = new int[block_length, block_length];
            for (int i = 0; i < block_length; i++)
            {
                for (int j = 0; j < block_length; j++)
                {
                    B[i, j] = A[i, j];
                    
                }
            }
            
            for (int i = 0; i < block_length; i++)
            {
                for (int j = 0; j < block_length; j++)
                {
                    A[i, j] = A[block_length + i, j];

                }
            }
            
            for (int i = 0; i < block_length; i++)
            {
                for (int j = 0; j < block_length; j++)
                {
                    A[block_length + i, j] = A[block_length + i, block_length + j];
                }
            }
            
            
            for (int i = 0; i < block_length; i++)
            {
                for (int j = 0; j < block_length; j++)
                {
                    A[block_length + i, block_length + j] = A[i, block_length + j];
                }
            }
            
            
            for (int i = 0; i < block_length; i++)
            {
                for (int j = 0; j < block_length; j++)
                {
                    A[i, block_length + j] = B[i, j];
                }
            }
            
            Console.WriteLine("Результат:");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++) Console.Write($"{A[i,j]} ");
                Console.WriteLine();
            }
            Console.WriteLine("Результат:");
        }
    }
}
