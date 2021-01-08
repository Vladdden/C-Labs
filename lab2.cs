using System;
    /*
    1 Дано трехзначное число. Вывести на экран все трехзначные числа, которые можно получить из цифр данного числа.
    2 Определить, является ли введенная буква русского алфавита гласной.
    3 Вводим целое число k (1 до 365). Определить день недели, если 1
    января это пятница
    4 Пусть элементами прямоугольного равнобедренного треугольника
    являются:1- катет a; 2-гипотенуза b; 3-высота h, опущенная из вершины
    прямого угла на гипотенузу; 4-площадь S. Составить программу,
    которая по заданному номеру и значению соответствующего элемента
    вычисляла бы значение всех остальных элементов треугольника.
    5 Составить программу, позволяющую по последней цифре данного
    числа определить последнюю цифру куба этого числа.Осуществить
    проверку.
    6 Написать алгоритм нахождения числа дней в месяце, если даны: Номер
    месяца n - целое число а, равное 1 для високосного года и равное 0 в
    противном случае.
    */
namespace lab2
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
                Console.WriteLine("1. Дано трехзначное число. Вывести на экран все трехзначные числа, которые можно получить из цифр данного числа.");
                Console.WriteLine("2. Определить, является ли введенная буква русского алфавита гласной.");
                Console.WriteLine("3. Вводим целое число k (1 до 365). Определить день недели, если 1 января это пятница");
                Console.WriteLine("4. Пусть элементами прямоугольного равнобедренного треугольника являются:1- катет a; 2-гипотенуза b; 3-высота h, опущенная из вершины\n" +
                                  "прямого угла на гипотенузу; 4-площадь S. Составить программу, которая по заданному номеру и значению соответствующего элемента\n" +
                                  "вычисляла бы значение всех остальных элементов треугольника.");
                Console.WriteLine("5. Составить программу, позволяющую по последней цифре данного числа определить последнюю цифру куба этого числа.Осуществить проверку.");
                Console.WriteLine("6. Написать алгоритм нахождения числа дней в месяце, если даны: Номер месяца n - целое число а, равное 1 для високосного года и равное 0 в противном случае.");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Number_XYZ();
                        break;
                    case "2":
                        Vowel();
                        break;
                    case "3":
                        DayOfWeek();
                        break;
                    case "4":
                        Triangle();
                        break;
                    case "5":
                        LastNumeral();
                        break;
                    case "6":
                        AmountOfDays();
                        break;
                    case "0":
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter, чтобы продолжить");
                Console.ReadKey();
            }
        }
        //1. Дано трехзначное число. Вывести на экран все трехзначные числа, которые можно получить из цифр данного числа.
        static void Number_XYZ()
        {
            char temp;
            char[] number = new char[3];
            Console.Write("Введите число: ");
            number = Console.ReadLine().ToCharArray();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    temp = number[j];
                    number[j] = number[j+1]; 
                    number[j+1] = temp;

                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(number[k] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        //2. Определить, является ли введенная буква русского алфавита гласной.
        static void Vowel()
        {
            Console.Write("Введите букву: ");
            char letter = Convert.ToChar(Console.ReadLine().ToLower());
            if (letter != 'а' || letter != 'о' || letter != 'у' || letter != 'ы' || letter != 'э' || letter != 'я' || letter != 'е' || letter != 'ё' || letter != 'ю' || letter != 'и')
                Console.Write("Вы ввели гласную букву!");
            else Console.Write("Вы ввели согласную букву.");
        }
        //3. Вводим целое число k (1 до 365). Определить день недели, если 1 января это пятница
        static void DayOfWeek()
        {
            Console.Write("Введите число от 1 до 365: ");
            int day = Convert.ToInt32(Console.ReadLine());
            day %= 7;
            if (day == 1) Console.WriteLine("Это пятница.");
            if (day == 2) Console.WriteLine("Это суббота.");
            if (day == 3) Console.WriteLine("Это воскресенье.");
            if (day == 4) Console.WriteLine("Это понедельник.");
            if (day == 5) Console.WriteLine("Это вторник.");
            if (day == 6) Console.WriteLine("Это среда.");
            if (day == 0) Console.WriteLine("Это четверг.");
        }
        /*
         *  4. Пусть элементами прямоугольного равнобедренного треугольника
         *  являются:1- катет a; 2-гипотенуза b; 3-высота h, опущенная из вершины
         *  прямого угла на гипотенузу; 4-площадь S. Составить программу,
         *  которая по заданному номеру и значению соответствующего элемента
         *  вычисляла бы значение всех остальных элементов треугольника.
         */
        static void Triangle()
        {
            Console.WriteLine("Элементы: ");
            Console.WriteLine("1 - катет;");
            Console.WriteLine("2 - гипотенуза;");
            Console.WriteLine("3 - высота, опущенная из вершины прямого угла на гипотенузу;");
            Console.WriteLine("4 - площадь.");
            Console.Write("Выберите номер известного элемента: ");
            string choise = Console.ReadLine();
            if (choise == "1")
            {
                Console.Write("Введите значение катета: ");
                float a = Convert.ToSingle(Console.ReadLine());
                float b = a * (float) Math.Sqrt(2);
                float h = b / 2;
                float s = b * h / 2;
                Console.WriteLine("Катет: {0:f1}", a);
                Console.WriteLine("Гипотенуза: {0:f1}", b);
                Console.WriteLine("Высота, опущенная из вершины прямого угла на гипотенузу: {0:f1}", h);
                Console.WriteLine("Площадь: {0:f1}", s);
            }
            else if (choise == "2")
            {
                Console.Write("Введите значение гипотенузы: ");
                float b = Convert.ToSingle(Console.ReadLine());
                float a = b / (float) Math.Sqrt(2);
                float h = b / 2;
                float s = b * h / 2;
                Console.WriteLine("Катет: {0:f1}", a);
                Console.WriteLine("Гипотенуза: {0:f1}", b);
                Console.WriteLine("Высота, опущенная из вершины прямого угла на гипотенузу: {0:f1}", h);
                Console.WriteLine("Площадь: {0:f1}", s);
            }
            else if (choise == "3")
            {
                Console.Write("Введите значение высоты, опущенной из вершины прямого угла на гипотенузу: ");
                float h = Convert.ToSingle(Console.ReadLine());
                float b = 2 * h;
                float a = b / (float) Math.Sqrt(2);
                float s = b * h / 2;
                Console.WriteLine("Катет: {0:f1}", a);
                Console.WriteLine("Гипотенуза: {0:f1}", b);
                Console.WriteLine("Высота, опущенная из вершины прямого угла на гипотенузу: {0:f1}", h);
                Console.WriteLine("Площадь: {0:f1}", s);
            }
            else if (choise == "4")
            {
                Console.Write("Введите площадь прямоугольного равнобедренного треугольника: ");
                float s = Convert.ToSingle(Console.ReadLine());
                float h = (float) Math.Sqrt(s);
                float b = 2 * h;
                float a = b / (float) Math.Sqrt(2);
                Console.WriteLine("Катет: {0:f1}", a);
                Console.WriteLine("Гипотенуза: {0:f1}", b);
                Console.WriteLine("Высота, опущенная из вершины прямого угла на гипотенузу: {0:f1}", h);
                Console.WriteLine("Площадь: {0:f1}", s);
            }
            else Console.Write("Недопустимое значение.");
        }
        //5. Составить программу, позволяющую по последней цифре данного числа определить последнюю цифру куба этого числа.Осуществить проверку.
        static void LastNumeral()
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Последняя цифра куба: {0}", (int) Math.Pow(a,3)%10);
        }
        //6. Написать алгоритм нахождения числа дней в месяце, если даны: Номер месяца n - целое число а, равное 1 для високосного года и равное 0 в противном случае.
        static void AmountOfDays()
        {
            Console.Write("Введите номер месяца: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 1 для високосного года и 0 в противном случае: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (n == 1 || n == 3 || n == 5 || n == 7 || n == 8 || n == 10 || n == 12) Console.Write("В этом месяце 31 день.");
            else
            {
                if (n == 2)
                {
                    if (a == 1)  Console.Write("В этом месяце 29 дней.");
                    else Console.Write("В этом месяце 28 дней.");
                }
                else Console.Write("В этом месяце 30 дней.");
            }
        }
    }
}
