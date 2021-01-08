using System;
/*
 *   1. Вывести все целые числа из диапазона от А до В , кратные трем (А<=В ).
 *   2. Вывести все целые числа Армстронга из диапазона от А до В ( А<=В ).
 *   3. Ввести целое число N > 0. Используя операции деления нацело и взятия остатка от деления, найти число, полученное при прочтении числа N справа налево.
 *   4. Ввести действительное число х и натуральное число n. Вычислить x*(x - n)*(x - 2*n)(x - 3*n)…(x - n^2).
 *   5. Осуществить ввод последовательности целых чисел. Определить, сколько них и какие принимают наибольшее значение. Последовательность потенциально последовательности служит число 0.
 */
namespace lab3
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
                Console.WriteLine("1. Вывести все целые числа из диапазона от А до В , кратные трем (А<=В ).");
                Console.WriteLine("2. Вывести все целые числа Армстронга из диапазона от А до В ( А<=В ).");
                Console.WriteLine("3. Ввести целое число N > 0. Используя операции деления нацело и взятия остатка от деления, найти число, полученное при прочтении числа N справа налево.");
                Console.WriteLine("4. Ввести действительное число х и натуральное число n. Вычислить x*(x - n)*(x - 2*n)(x - 3*n)…(x - n^2).");
                Console.WriteLine("5. Осуществить ввод последовательности целых чисел. Определить, сколько них и какие принимают наибольшее значение. Последовательность потенциально последовательности служит число 0.");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        FromAtoB();
                        break;
                    case "2":
                        IsArmstrongNumber();
                        break;
                    case "3":
                        DivNumber();
                        break;
                    case "4":
                        Formula();
                        break;
                    case "5":
                        Array();
                        break;
                    case "0":
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter, чтобы продолжить");
                Console.ReadKey();
            }
        }
        //1. Вывести все целые числа из диапазона от А до В , кратные трем (А<=В ).
        static void FromAtoB()
        {
            Console.Write("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число В: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++) if (i % 3 == 0) Console.WriteLine($"Число {i} кратно трем."); 
        }
        //2. Вывести все целые числа Армстронга из диапазона от А до В ( А<=В ).
        static void IsArmstrongNumber() 
        {
            Console.Write("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите число В: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int valNum = b.ToString().Length;
            char[] num = new char[valNum];
            int sum;
            for (int i = a; i <= b; i++)
            {
                sum = 0;
                valNum = i.ToString().Length;
                num = i.ToString().ToCharArray();
                for (int j = 0; j < valNum; j++) 
                {
                    sum += (int) Math.Pow(Convert.ToInt32(num[j].ToString()), valNum);
                }
                if (sum == i) Console.WriteLine("Число Армстронга: " + i);
            }
        }
        //3. Ввести целое число N > 0. Используя операции деления нацело и взятия остатка от деления, найти число, полученное при прочтении числа N справа налево.
        static void DivNumber()
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int newNumber = 0;
            int count = number.ToString().Length;
            for (int i = 1; i <= count; i++)
            {
                newNumber += (Convert.ToInt32(number) % 10) * (int) Math.Pow(10, count - i);
                number /= 10;
            }
            Console.WriteLine("Результат: " + newNumber);
        }
        //4. Ввести действительное число х и натуральное число n. Вычислить x*(x - n)*(x - 2*n)(x - 3*n)…(x - n^2).");
        static void Formula()
        {
            Console.Write("Введите действительное число: ");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите натуральное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float z = x;
            for (int i = 1; i <= n; i++)
            {
                z *= (x - i * n);
            }
            Console.WriteLine("Результат: " + z);
        }
        //5. Осуществить ввод последовательности целых чисел. Определить, сколько них и какие принимают наибольшее значение. Последовательность потенциально последовательности служит число 0.");
        static void Array()
        {
            int number, max = 0, n = 0;
            Console.WriteLine("Введите целое число и нажмите Enter, чтобы закончить последовательность нажмите 0:");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > max) max = number;
                if (number != 0) n++;
            } while (number != 0);
            Console.WriteLine("Количество чисел: " + n);
            Console.WriteLine("Максимальное число: " + max);
        }
    }
}
