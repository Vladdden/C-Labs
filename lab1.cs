using System; 

namespace lab 
{
    class Program 
    {
        static void Main(string[] args) 
        { 
            string choise = ""; 
            while (choise != "0")
            {
                Console.Clear();
                Console.WriteLine("Выберите программу, которую надо запустить (или выход):");
                Console.WriteLine("1. Ввести ФИО и вывести на экран: «Практическая работу No1 выполнил: ФИО».");
                Console.WriteLine("2. По данным сторонам прямоугольника вычислить его периметр, площадь и длину диагонали.");
                Console.WriteLine("3. Даны два числа. Найти среднее арифметическое их квадратов и среднее арифметическое их модулей.");
                Console.WriteLine("4. Дана длина ребра куба. Найти площадь грани, площадь полной поверхности и объем этого куба.");
                Console.WriteLine("5. Найти длину окружности и площадь круга заданного радиуса R.");
                Console.WriteLine("6. Даны координаты трех вершин треугольника (x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь.");
                Console.WriteLine("7. Дано целое четырехзначное число. Найти сумму его цифр.");
                Console.WriteLine("8. Даны три числа расположить их по убыванию.");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Fio();
                        break;
                    case "2":
                        Rectangle();
                        break;
                    case "3":
                        Average();
                        break;
                    case "4":
                        Cube();
                        break;
                    case "5":
                        Circle();
                        break;
                    case "6":
                        Triangle();
                        break;
                    case "7":
                        Numeral_4();
                        break;
                    case "8":
                        NumberFromMaxtoMin();
                        break;
                    case "0":
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter, чтобы продолжить");
                Console.ReadKey();
            }
        }
        /*
         * Ввести ФИО и вывести на экран: «Практическая работу No1
         * выполнил: ФИО»
         * 
         */
        static void Fio()
        {
            Console.WriteLine("Введите свои ФИО:");
            string fio = Console.ReadLine();
            Console.Write("Практическая работа №1 выполнил: ");
            Console.Write(fio);
        }
        /*
         *  По данным сторонам прямоугольника вычислить его периметр,
         *  площадь и длину диагонали.
         * 
         */
        static void Rectangle()
        {
            float perimeter, area, diagonal_lenght;
            Console.WriteLine("Введите длину прямоугольника:");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника:");
            int width = Convert.ToInt32(Console.ReadLine());
            perimeter = lenght * 2 + width * 2;
            area = lenght * width;
            diagonal_lenght = (float) Math.Sqrt(lenght * lenght + width * width);
            Console.WriteLine($"Периметр равен - {perimeter}");
            Console.WriteLine($"Площадь равна - {area}");
            Console.WriteLine($"Длина диагонали равна - {diagonal_lenght}");
        }
        /*
         *  Даны два числа. Найти среднее арифметическое их квадратов и
         *  среднее арифметическое их модулей.
         * 
         */
        static void Average()
        {
            float x, y, average_sqv;
            Console.Write("Введите первое число: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое их квадратов = {(Math.Pow(x, 2) + Math.Pow(y, 2))/2}");
            Console.WriteLine($"Среднее арифметическое их модулей = {(Math.Abs(x) + Math.Abs(y))/2}");
        }
        /*
         *  Дана длина ребра куба. Найти площадь грани, площадь полной
         *  поверхности и объем этого куба.
         * 
         */
        static void Cube()
        {
            Console.Write("Введите длину ребра куба: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Площадь грани = {Math.Pow(lenght, 2)}");
            Console.WriteLine($"Площадь полной поверхности = {Math.Pow(lenght, 2)*6}");
            Console.WriteLine($"Объем куба = {Math.Pow(lenght, 3)}");
        }
        /*
         * Найти длину окружности и площадь круга заданного радиуса R.
         * 
         */
        static void Circle()
        {
            // Math.PI = 3.1415926535897931;
            Console.Write("Введите радиус круга: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длина окружности = {0:f2}", 2 * Math.PI * radius);
            Console.WriteLine("Площадь круга = {0:f2}", Math.PI * Math.Pow(radius, 2));
        }
        /*
         * Даны координаты трех вершин треугольника (x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь.
         * 
         */
        static void Triangle()
        {
            Console.WriteLine("Введите координаты первой вершины треугольника (через Enter): ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины треугольника (через Enter): ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины треугольника (через Enter): ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            float _2to1 = (float)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            float _3to2 = (float)Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            float _1to3 = (float)Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            float perimeter = (_2to1 + _3to2 + _1to3) / 2;
            float area = (float)Math.Sqrt(perimeter * (perimeter - _2to1) * (perimeter - _3to2) * (perimeter - _1to3));
            Console.WriteLine("Периметр равен - {0:f1}", perimeter);
            Console.WriteLine("Площадь равна - {0:f1}", area);
        }
        /*
         * Дано целое четырехзначное число. Найти сумму его цифр.
         * 
         */
        static void Numeral_4()
        {
            int number, sum = 0;
            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0) {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine($"Сумма цифр введеного числа = {sum}");
        }
        /*
         * Даны три числа расположить их по убыванию.
         */
        static void NumberFromMaxtoMin()
        {
            int[] nums = new int[3];
            int temp;
            Console.Write("Введите первое число: ");
            nums[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            nums[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            nums[2] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            Console.WriteLine("Результат: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
