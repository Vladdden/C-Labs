using System;
/*
    1. Даны два массива A и B. Определить которых из них имеет больший диапазон, т.е.
    разницу между самым большим и самым меньшим значением.
    2. Дан массив A размера N. Сформировать новый массив B того же размера по
    следующему правилу: элемент BK равен сумме элементов массива A с номерами от 1 до K
    3. Даны два массива A и B, элементы которых упорядочены по возрастанию. Объединить
    эти массивы так, чтобы результирующий массив C остался упорядоченным по
    возрастанию
    4. Даны два массива A и B. Распечатать те элементы массива А, которых нет в массиве В.
    Распечатать те элементы массива В, которых нет в массиве А.
    5. Дан целочисленный массив размера N. Преобразовать массив, увеличив каждую его
    серию на один элемент. Серия - это группа подряд идущих одинаковых элементов, длина
    серии — количество этих элементов (длина серии может быть равна 1).
    6. *Дан целочисленный массив размера N. Удалить из массива все элементы,
    встречающиеся ровно два раза, и вывести размер полученного массива и его содержимое.
*/
namespace lab4
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
                Console.WriteLine("1. Даны два массива A и B. Определить которых из них имеет больший диапазон, т.е. разницу между самым большим и самым меньшим значением.");
                Console.WriteLine("2. Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент BK равен сумме элементов массива A с номерами от 1 до K.");
                Console.WriteLine("3. Даны два массива A и B, элементы которых упорядочены по возрастанию. Объединить эти массивы так, чтобы результирующий массив C остался упорядоченным по возрастанию.");
                Console.WriteLine("4. Даны два массива A и B. Распечатать те элементы массива А, которых нет в массиве В. Распечатать те элементы массива В, которых нет в массиве А.");
                Console.WriteLine("5. Дан целочисленный массив размера N. Преобразовать массив, увеличив каждую его серию на один элемент. Серия - это группа подряд идущих одинаковых элементов, длина серии — количество этих элементов (длина серии может быть равна 1).");
                Console.WriteLine("6. Дан целочисленный массив размера N. Удалить из массива все элементы, встречающиеся ровно два раза, и вывести размер полученного массива и его содержимое.");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        MaxRangeAB();
                        break;
                    case "2":
                        ArraySumBK();
                        break;
                    case "3":
                        MasssiveSortMinToMax();
                        break;
                    case "4":
                        AnotB();
                        break;
                    case "5":
                        ArrayPP();
                        break;
                    case "6":
                        ArrayNoTwoNum();
                        break;
                    case "0":
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter, чтобы продолжить");
                Console.ReadKey();
            }
        }
        //1. Даны два массива A и B. Определить которых из них имеет больший диапазон, т.е. разницу между самым большим и самым меньшим значением.
        static void MaxRangeAB()
        {
            Console.WriteLine("Введите длину масива А (количество элементов)");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] A = new int [length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите {i+1} элемент массива А: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            int minA = A[0], maxA = A[0];
            for (int i = 0; i < length; i++)
            {
                if (A[i] < minA) minA = A[i];
                if (A[i] > maxA) maxA = A[i];
            }
            
            Console.WriteLine("Введите длину масива B (количество элементов)");
            length = Convert.ToInt32(Console.ReadLine());
            int[] B = new int [length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите {i+1} элемент массива В: ");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }
            int minB = A[0], maxB = A[0];
            for (int i = 0; i < length; i++)
            {
                if (B[i] < minB) minB = B[i];
                if (B[i] > maxB) maxB = B[i];
            }
            
            if ((maxA - minA) > (maxB - minB)) Console.WriteLine("Наибольший диапазон имеет массив А - {0}" , maxA - minA);
            else if ((maxA - minA) < (maxB - minB)) Console.WriteLine("Наибольший диапазон имеет массив B - {0}" , maxB - minB);
            else Console.WriteLine("Диапазоны массивов равны.");
        }
        //2. Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу:
        //элемент BK равен сумме элементов массива A с номерами от 1 до K
        static void ArraySumBK()
        {
            Console.WriteLine("Введите длину масива А (количество элементов)");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int [N];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите {i+1} элемент массива А: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] B = new int [A.Length];
            int sum = 0;
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    sum += A[j];
                }
                B[i] = sum;
                sum = 0;
            }
            for (int i = 0; i < B.Length; i++) Console.WriteLine($"{i+1} элемент массива B: " + B[i]);
        }
        //3. Даны два массива A и B, элементы которых упорядочены по возрастанию. Объединить
        //эти массивы так, чтобы результирующий массив C остался упорядоченным по возрастанию
        static void MasssiveSortMinToMax()
        {
            Console.WriteLine("Введите длину масива А (количество элементов)");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] A = new int [length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите {i+1} элемент массива А: ");
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
            Console.WriteLine("Введите длину масива B (количество элементов)");
            length = Convert.ToInt32(Console.ReadLine());
            int[] B = new int [length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите {i+1} элемент массива B: ");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }
            // сортировка
            for (int i = 0; i < B.Length-1; i++)
            {
                for (int j = i + 1; j < B.Length; j++)
                {
                    if (B[i] > B[j])
                    {
                        temp = B[i];
                        B[i] = B[j];
                        B[j] = temp;
                    }
                    
                }
            }
            int[] C = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length; i++) C[i] = A[i];
            for (int i = 0; i < B.Length; i++) C[A.Length + i] = B[i];
            for (int i = 0; i < C.Length-1; i++)
            {
                for (int j = i + 1; j < C.Length; j++)
                {
                    if (C[i] > C[j])
                    {
                        temp = C[i];
                        C[i] = C[j];
                        C[j] = temp;
                    }
                    
                }
            }
            Console.WriteLine("Массив С:");
            for (int i = 0; i < C.Length; i++) Console.Write("{0} ", C[i]);
        }
        //4. Даны два массива A и B. Распечатать те элементы массива А, которых нет в массиве В.
        //Распечатать те элементы массива В, которых нет в массиве А.
        static void AnotB()
        {
            Console.WriteLine("Введите длину масива А (количество элементов)");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] A = new int [length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите {i+1} элемент массива А: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите длину масива B (количество элементов)");
            length = Convert.ToInt32(Console.ReadLine());
            int[] B = new int [length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите {i+1} элемент массива В: ");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }

            int notBe = 0;
            Console.WriteLine("Элементы массива А, которых нет в массиве В:");
            for (int i = 0; i < A.Length; i++)
            {
                notBe = 0;
                for (int j = 0; j < B.Length; j++)if (A[i] == B[j]) notBe++;
                if (notBe == 0) Console.Write("{0} ", A[i]);
                notBe = 1;
            }
            if (notBe == 0) Console.Write("Не обнаружено !");
            Console.WriteLine();
            
            Console.WriteLine("Элементы массива B, которых нет в массиве A:");
            for (int i = 0; i < B.Length; i++)
            {
                notBe = 0;
                for (int j = 0; j < A.Length; j++) if (B[i] == A[j]) notBe++;
                if (notBe == 0) Console.Write("{0} ", B[i]);
                notBe = 1;
            }
            if (notBe == 0) Console.Write("Не обнаружено !");
        }
        //5. Дан целочисленный массив размера N. Преобразовать массив, увеличив каждую его
        //серию на один элемент. Серия - это группа подряд идущих одинаковых элементов, длина
        //серии — количество этих элементов (длина серии может быть равна 1).
        static void ArrayPP()
        {
            Console.WriteLine("Введите длину масива (количество элементов)");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int [N+1];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите {i+1} элемент массива: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] B = new int[N * 2];
            int Bi = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == A[i + 1])
                {
                    B[Bi] = A[i];
                    Bi++;
                }
                else
                {
                    B[Bi] = A[i];
                    B[Bi + 1] = A[i];
                    Bi += 2;
                }
            }
            
            Console.WriteLine("Массив:");
            for (int i = 0; i < Bi; i++) Console.Write("{0} ", B[i]);
        }
        //6. *Дан целочисленный массив размера N. Удалить из массива все элементы,
        //встречающиеся ровно два раза, и вывести размер полученного массива и его содержимое.
        static void ArrayNoTwoNum()
        {
            Console.WriteLine("Введите длину масива (количество элементов)");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int [N+1];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите {i+1} элемент массива: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] B = new int[A.Length];
            int Bi = 0, couple = 1;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == A[i + 1]) couple++;
                if (A[i] != A[i + 1])
                {
                    if (couple == 2) couple = 1;
                    else
                    {
                        for (int j = 0; j < couple; j++)
                        {
                            B[Bi] = A[i];
                            Bi++;
                        }
                        couple = 1;
                    }
                }
            }
            
            Console.WriteLine("Массив:");
            for (int i = 0; i < Bi; i++) Console.Write("{0} ", B[i]);
        }
    }
}
