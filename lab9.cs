using System;
using System.IO;

/*
1 Составить программу, которая создаёт текстовый файл и записывает в
него последовательность целых чисел, вводимую с клавиатуры (признак
конца ввода – 999).
2 Составить программу, которая создаёт текстовый файл и записывает в
него n целых случайных чисел.
3 Составить программу, которая выводит на экран содержимое файла из
второго задания и дописывает файл из первого задания полученной
информацией.
4 Составить программу, которая в файле, сформированном программой
из третьего задания, находит наибольшее и наименьшее значения,
вычисляет среднее арифметическое чисел.
5 Записать в файл информацию об автобусах(Номер рейса, Время
отправления, Пункт назначения, Время прибытия, Пункт прибытия).
Информацию записать в одну строчку. Вывести на экран всю информацию
об автобусах. Найти автобус по заданному направлению.
 */

namespace lab9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string choise = ""; 
            while (choise != "0")
            {
                Console.Clear();
                Console.WriteLine("Выберите номер программы, которую надо запустить (или выход):");
                Console.WriteLine("1. Составить программу, которая создаёт текстовый файл и записывает в него последовательность целых чисел, вводимую с " +
                                  "клавиатуры (признак конца ввода – 999).");
                Console.WriteLine("2. Составить программу, которая создаёт текстовый файл и записывает в него n целых случайных чисел.");
                Console.WriteLine("3. Составить программу, которая выводит на экран содержимое файла из второго задания и дописывает файл из первого задания " +
                                  "полученной информацией.");
                Console.WriteLine("4. Составить программу, которая в файле, сформированном программой из третьего задания, находит наибольшее и наименьшее значения, " +
                                  "вычисляет среднее арифметическое чисел");
                Console.WriteLine("5 Записать в файл информацию об автобусах(Номер рейса, Время отправления, Пункт назначения, Время прибытия, Пункт прибытия). " +
                                  "Информацию записать в одну строчку. Вывести на экран всю информацию об автобусах. Найти автобус по заданному направлению.");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        No999();
                        break;
                    case "2":
                        RandomInFile();
                        break;
                    case "3":
                        From2to1();
                        break;
                    case "4":
                        ScanFileForMaxMinAv();
                        break;
                    case "5":
                        BusInfo();
                        break;
                    case "0":
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter, чтобы продолжить");
                Console.ReadKey();
            }
        }
        
        //Составить программу, которая создаёт текстовый файл и записывает в него последовательность целых чисел, вводимую с клавиатуры (признак конца ввода – 999).
        static void No999()
        {
            string path = $"{Directory.GetCurrentDirectory()}\\1.txt";
            File.Create(path).Close();
            string text;
            do
            {
                Console.Write("Введите число: ");
                text = Console.ReadLine();
                if (text != "999") File.AppendAllText(path, $"{text} "); //пишет текст в конец файла
            } while (text != "999");
        }
        
        //Составить программу, которая создаёт текстовый файл и записывает в него n целых случайных чисел.
        static void RandomInFile()
        {
            string path = $"{Directory.GetCurrentDirectory()}/2.txt"; // !!!!!!!!!! заменить на обратный слэш
            string text;
            File.Create(path).Close();
            Random rnd = new Random(); //Создание объекта для генерации чисел
            Console.WriteLine("Введите количество генерируемых чисел:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите диапазон значений:");
            Console.Write("От: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("До: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числа:");
            for (int i = 0; i < n; i++)
            {
                text = rnd.Next(a, b+1).ToString(); //Получить случайное число (в диапазоне от a до b)
                File.AppendAllText(path, $"{text} ");
                Console.WriteLine(text);
            }
        }
        
        //Составить программу, которая выводит на экран содержимое файла из второго задания и дописывает файл из первого задания полученной информацией.
        static void From2to1()
        {
            string path = $"{Directory.GetCurrentDirectory()}/2.txt"; // !!!!!!!!!! заменить на обратный слэш
            string text;
            StreamReader file2 = new StreamReader(path);
            text = file2.ReadToEnd();
            file2.Close();
            Console.WriteLine(text);
            path = $"{Directory.GetCurrentDirectory()}/1.txt";
            StreamWriter file1 = new StreamWriter(path, true);
            file1.Write(text);
            file1.Close();
            Console.WriteLine("Первый файл дописан.");
        }
        
        //Составить программу, которая в файле, сформированном программой из третьего задания, находит наибольшее и наименьшее значения,
        //вычисляет среднее арифметическое чисел.
        static void ScanFileForMaxMinAv()
        {
            string path = $"{Directory.GetCurrentDirectory()}/1.txt"; // !!!!!!!!!! заменить на обратный слэш
            string text;
            int min, max, sum = 0;
            StreamReader file1 = new StreamReader(path);
            text = file1.ReadToEnd();
            file1.Close();
            Console.WriteLine("Числа из файла: " + text);
            string[] arr = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] int_array = Array.ConvertAll(arr, int.Parse);
            min = int_array[0]; max = int_array[0];
            for (int i = 0; i < int_array.Length; i++)
            {
                if (int_array[i] < min) min = int_array[i];
                if (int_array[i] > max) max = int_array[i];
                sum += int_array[i];
            }
            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine($"Максимальное значение: {max}");
            Console.WriteLine("Cреднее арифметическое элементов массива: {0:f2}", sum/int_array.Length);
            Console.WriteLine($"Сумма элементов массива: {sum}");
        }
        
        //Записать в файл информацию об автобусах(Номер рейса, Время отправления, Пункт назначения, Время прибытия, Пункт прибытия).
        //Информацию записать в одну строчку. Вывести на экран всю информацию об автобусах. Найти автобус по заданному направлению.
        static void BusInfo()
        {
            string choise = "";
            string number, timeDepart, destination, timeArrive, arrivePoint, info;
            string path = $"{Directory.GetCurrentDirectory()}/5.txt"; // !!!!!!!!!! заменить на обратный слэш
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите необходимый пункт (введите его номер):");
                Console.WriteLine("1. Добавить информацию об автобусе");
                Console.WriteLine("2. Вывести на экран всю информацию об автобусах");
                Console.WriteLine("3. Найти автобус по заданному направлению");
                Console.WriteLine("0. Выйти");
                Console.Write("Выбор: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Console.Write("Введите номер рейса: ");
                        number = Console.ReadLine();
                        Console.Write("Введите время отправления: ");
                        timeDepart = Console.ReadLine();
                        Console.Write("Введите пункт назначения: ");
                        destination = Console.ReadLine();
                        Console.Write("Введите время прибытия: ");
                        timeArrive = Console.ReadLine();
                        Console.Write("Введите пункт прибытия: ");
                        arrivePoint = Console.ReadLine();
                        info = $"{number};{timeDepart};{destination};{timeArrive};{arrivePoint};";
                        StreamWriter infoWriter = new StreamWriter(path, true);
                        infoWriter.WriteLine(info);
                        infoWriter.Close();
                        Console.WriteLine("\nИнформация об автобусе успешно записана в файл.");
                        Console.ReadKey();
                        break;
                    case "2":
                        string text;
                        Console.WriteLine("|-------------|-------------|------------------|----------------|----------------|");
                        Console.WriteLine("| {0,11} | {1,11} | {2,16} | {3,14} | {4,14} |", "Номер рейса", "Отправление", "Пункт назначения", "Время прибытия","Пункт Прибытия");
                        Console.WriteLine("|-------------|-------------|------------------|----------------|----------------|");
                        StreamReader infoReader = new StreamReader(path);
                        do
                        {
                            text = infoReader.ReadLine();
                            string[] words = text.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                            if (words.Length == 5)
                            {
                                number = words[0];
                                timeDepart = words[1];
                                destination = words[2];
                                timeArrive = words[3];
                                arrivePoint = words[4];
                                Console.WriteLine("| {0,-11} | {1,-11} | {2,-16} | {3,-14} | {4,-14} |", number, timeDepart, destination, timeArrive, arrivePoint);
                            }
                            else
                            {
                                Console.WriteLine("Данные записаны в неверном формате.");
                                Console.ReadKey();
                            }
                        } while (!infoReader.EndOfStream);
                        Console.WriteLine("|_____________|_____________|__________________|________________|________________|");
                        infoReader.Close();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Write("Введите место назначения: ");
                        string place  = Console.ReadLine();
                        Console.WriteLine("Вам подойдет: ");
                        int count = 0;
                        StreamReader search = new StreamReader(path);
                        do
                        {
                            text = search.ReadLine();
                            string[] words = text.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                            if (words.Length == 5)
                            {
                                if (words[2].ToLower() == place.ToLower())
                                {
                                    count++;
                                    Console.WriteLine("| {0,-11} | {1,-11} | {2,-16} | {3,-14} | {4,-14} |", words[0], words[1], words[2], words[3], words[4]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Данные записаны в неверном формате.");
                                Console.ReadKey();
                            }
                        } while (!search.EndOfStream);
                        if (count == 0) Console.WriteLine("Подходящие автобусы не найдены.");
                        Console.ReadKey();
                        break;
                    case "0":
                        break;
                }
            } while (choise != "0");
        }
    }
}
