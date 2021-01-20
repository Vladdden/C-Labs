  using System;
/*
1 Изменить введенную пользователем строку, поменяв местами первый символ ‘r’ и последний символ ‘s’.
2 Пользователь вводит две строки S1, S2. Удалить из первой строки все подстроки равные второй строке.
3 В строке, введенной пользователем найти количество различных букв. Программа должна работать без учёта регистра букв.
4 Заменить в строке пробелы, идущие подряд, на один пробел.
5 Дана строка. Вывести все слова, у которых первая и последняя буквы одинаковые не используя стандартные средства для разбиения строк.
6 Дана строка S. Определить есть ли в строке удвоенные буквы (пара соседствующих одинаковых букв), напечатать слова, содержащие их.
 */
namespace lab6
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
                Console.WriteLine("1. Изменить введенную пользователем строку, поменяв местами первый символ ‘r’ и последний символ ‘s’.");
                Console.WriteLine("2. Пользователь вводит две строки S1, S2. Удалить из первой строки все подстроки равные второй строке.");
                Console.WriteLine("3. В строке, введенной пользователем найти количество различных букв. Программа должна работать без учёта регистра букв.");
                Console.WriteLine("4. Заменить в строке пробелы, идущие подряд, на один пробел.");
                Console.WriteLine("5. Дана строка. Вывести все слова, у которых первая и последняя буквы одинаковые не используя стандартные средства для разбиения строк.");
                Console.WriteLine("6. Дана строка S. Определить есть ли в строке удвоенные буквы (пара соседствующих одинаковых букв), напечатать слова, содержащие их.");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        FirstR_LastS();
                        break;
                    case "2":
                        S1S2();
                        break;
                    case "3":
                        UniqueLetters();
                        break;
                    case "4":
                        Space();
                        break;
                    case "5":
                        FirstAsLast();
                        break;
                    case "6":
                        NNLetters();
                        break;
                    case "0":
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter, чтобы продолжить");
                Console.ReadKey();
            }
        }
        //Изменить введенную пользователем строку, поменяв местами первый символ ‘r’ и последний символ ‘s’.
        static void FirstR_LastS()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            char charR = 'r';
            char charS = 's';
            int indexOfCharR = str.IndexOf(charR);
            int indexOfCharS = str.LastIndexOf(charS);
            
            str = str.Remove(indexOfCharR, 1);
            str = str.Insert(indexOfCharR, charS.ToString());
            
            str = str.Remove(indexOfCharS, 1);
            str = str.Insert(indexOfCharS, charR.ToString());
            
            Console.WriteLine(str);
        }
        //Пользователь вводит две строки S1, S2. Удалить из первой строки все подстроки равные второй строке.
        static void S1S2()
        {
            Console.Write("Введите первую строку: ");
            string firstStr = Console.ReadLine();
            Console.Write("Введите вторую строку (подстроку): ");
            string secondStr = Console.ReadLine();

            firstStr = firstStr.Replace(secondStr, "");
            Console.WriteLine(firstStr);
        }
        //В строке, введенной пользователем найти количество различных букв. Программа должна работать без учёта регистра букв.
        static void UniqueLetters()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine().ToLower();
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != '.' && str[i] != ',' && str[i] != '!' && str[i] != '?' && str[i] != ':' && str[i] != ' ')
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (str[i] == str[j]) str = str.Remove(i, 1);
                    }
                }
                else str = str.Remove(i, 1);
            }

            Console.WriteLine(str);
            Console.WriteLine($"Количество уникальных букв - {str.Length}");
        }
        //Заменить в строке пробелы, идущие подряд, на один пробел.
        static void Space()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') count++;
                else
                {
                    if (count > 1) str = str.Replace(new String(' ', count), " ");
                    count = 0;
                }
            }
            Console.WriteLine(str);
        }
        //Дана строка. Вывести все слова, у которых первая и последняя буквы одинаковые не используя стандартные средства для разбиения строк.
        static void FirstAsLast()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine("Слова, у которых первая и последняя буквы одинаковые:");
            int start = 0, end = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == ' ') start = i;
                if (i+1 == str.Length) end = i;
                if (str[i] == '.' || str[i] == ',' || str[i] == '!' || str[i] == '?' || str[i] == ':' || str[i] == ' ') end = i-1;
                if (str[start] == str[end] && start != end)
                {
                    for (int j = start; j <= end; j++) Console.Write(str[j]);
                    Console.WriteLine();
                    start = 0;
                    end = 1;
                }
            }
        }
        //Дана строка S. Определить есть ли в строке удвоенные буквы (пара соседствующих одинаковых букв), напечатать слова, содержащие их.
        static void NNLetters()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine("Слова, в которых есть удвоенные буквы:");
            
            string[] words = str.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] == s[i-1]) Console.WriteLine(s);
                }
            }
        }
    }
}
