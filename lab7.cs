using System;
using System.Text;

/*
1. Найти предложения содержащие слова А и поменять в них
первое и последнее слово. А – вводиться пользователем.
2. Найти предложения, содержащие максимальное количество
знаков пунктуации.
3. Найти и заменить знаки препинания (. , ? ! и т.д.) словами
«точка», «запятая», «вопросительный знак» и т.д..
4. Найти и заменить слова «ноль», «один» …«девять», цифрами от 0
до 9.
5. Определить, сколько в тексте слов, состоящих не более чем из N
букв. N – вводиться пользователем.
6. Найти предложения, состоящие из N слов. N – вводиться
пользователем. 
 */
/*
StringBuilder sb = new StringBuilder("Привет мир");
sb.Append("!");
sb.Insert(7, "компьютерный ");
Console.WriteLine(sb);
 
// заменяем слово
sb.Replace("мир", "world");
Console.WriteLine(sb);
 
// удаляем 13 символов, начиная с 7-го
sb.Remove(7, 13);
Console.WriteLine(sb);
 
// получаем строку из объекта StringBuilder
string s = sb.ToString();
Console.WriteLine(s);
Console.WriteLine(s);
 */
namespace lab7
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
                Console.WriteLine("1. Найти предложения содержащие слова А и поменять в них первое и последнее слово. А – вводиться пользователем.");
                Console.WriteLine("2. Найти предложения, содержащие максимальное количество знаков пунктуации.");
                Console.WriteLine("3. Найти и заменить знаки препинания (. , ? ! и т.д.) словами «точка», «запятая», «вопросительный знак» и т.д..");
                Console.WriteLine("4. Найти и заменить слова «ноль», «один» …«девять», цифрами от 0 до 9.");
                Console.WriteLine("5 Определить, сколько в тексте слов, состоящих не более чем из N букв. N – вводиться пользователем.");
                Console.WriteLine("6 Найти предложения, состоящие из N слов. N – вводиться пользователем. ");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        ChangeFirstAndLastWords();
                        break;
                    case "2":
                        MaxValue();
                        break;
                    case "3":
                        SignToWord();
                        break;
                    case "4":
                        NumberToWord();
                        break;
                    case "5":
                        //Spiral();
                        break;
                    case "6":
                        //FourBlocks();
                        break;
                    case "0":
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter, чтобы продолжить");
                Console.ReadKey();
            }
        }
        //Найти предложения содержащие слова А и поменять в них первое и последнее слово. А – вводиться пользователем.
        static void ChangeFirstAndLastWords(){
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Console.Write("Введите слово А: ");
            string A_word = Console.ReadLine();
            string[] sentences = str.Split(new char[] {'!', '.', '?'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (sentences[i].Contains(A_word))
                {
                    string temp = words[0];
                    int IndexFirst = sentences[i].IndexOf(words[0]);
                    sentences[i] = sentences[i].Remove(IndexFirst, temp.Length).Insert(IndexFirst, words[words.Length-1]);
                    int IndexLast = sentences[i].LastIndexOf(words[words.Length-1]);
                    sentences[i] = sentences[i].Remove(IndexLast, words[words.Length-1].Length).Insert(IndexLast, temp);
                    Console.WriteLine(sentences[i]);
                }
            }
        }
        //Найти предложения, содержащие максимальное количество знаков пунктуации.
        static void MaxValue(){
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            int count = 0;
            string[] sentences = str.Split(new char[] {'!', '.', '?'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sentences.Length; i++)
            {
            }

            /*
            for (int i = 0; i < str.Length; i++) if (str[i] == '.' || str[i] == '?' || str[i] == '!') dot_count++;
            int[,] value = new int[dot_count, 0];
            dot_count = 0;
            for (int i = 0; i < str.Length && dot_count < value.GetLength(0); i++)
            {
                if (str[i] == ',') count++;
                if (str[i] == ':') count++;
                if (str[i] == ';') count++;
                if (str[i] == '-') count++;
                if (str[i] == '(') count++;
                if (str[i] == ')') count++;
                if (str[i] == '"') count++;
                if (str[i] == '\'') count++;
                if (str[i] == '.' || str[i] == '?' || str[i] == '!')
                {
                    value[dot_count, 0] = count;
                    count = 0;
                    dot_count++;
                }
            }
            */
        }
        //Найти и заменить знаки препинания (. , ? ! и т.д.) словами «точка», «запятая», «вопросительный знак» и т.д..
        static void SignToWord(){
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);
            sb.Replace(".", "точка");
            sb.Replace(",", "запятая");
            sb.Replace("!", "восклицательный знак");
            sb.Replace("?", "вопросительный знак");
            sb.Replace(":", "двоеточие");
            sb.Replace(";", "точка с запятой");
            Console.WriteLine(sb);
        }
        //Найти и заменить слова «ноль», «один» …«девять», цифрами от 0 до 9.
        static void NumberToWord()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);
            sb.Replace("ноль", "0");
            sb.Replace("один", "1");
            sb.Replace("два", "2");
            sb.Replace("три", "3");
            sb.Replace("четыре", "4");
            sb.Replace("пять", "5");
            sb.Replace("шесть", "6");
            sb.Replace("семь", "7");
            sb.Replace("восемь", "8");
            sb.Replace("девять", "9");
            Console.WriteLine(sb);
        }
    }
}
//. , ; ... : ? ! - () "" ''
