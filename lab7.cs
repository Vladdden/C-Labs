using System;
using System.Text;

/*
1. Найти предложения содержащие слова А и поменять в них
первое и последнее слово. А – вводиться пользователем.
2. Найти предложения, содержащие максимальное количество
знаков пунктуации.
3. Найти и заменить знаки препинания (. , ? ! и т.д.) словами
«точка», «запятая», «вопросительный знак» и т.д..
4. Найти и заменить слова «ноль», «один» …«девять», цифрами от 0 до 9.
5. Определить, сколько в тексте слов, состоящих не более чем из N
букв. N – вводиться пользователем.
6. Найти предложения, состоящие из N слов. N – вводиться
пользователем. 
 */

namespace lab7
{
    partial class Program
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
                        NoMoreLetters();
                        break;
                    case "6":
                        NWordsSentences();
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
            int max = 0, number = 0;
            string[] sentences = str.Split(new char[] {'!', '.', '?'}, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[sentences.Length];
            for (int i = 0; i < sentences.Length; i++)
            {
                int count = 0;
                foreach (char letter in sentences[i])
                {
                    if (letter == ',') count++;
                    if (letter == ':') count++;
                    if (letter == ';') count++;
                    if (letter == '-') count++;
                    if (letter == '(') count++;
                    if (letter == ')') count++;
                    if (letter == '"') count++;
                    if (letter == '\'') count++;
                }
                array[i] = count;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    number = i;
                }
            }
            Console.WriteLine($"Результат: {number + 1} предложение содержит максимальное количество знаков пунктуации - {max}");
        }
        
        //Найти и заменить знаки препинания (. , ? ! и т.д.) словами «точка», «запятая», «вопросительный знак» и т.д..
        static void SignToWord(){
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);
            sb.Replace(".", " точка");
            sb.Replace("...", " многоточие");
            sb.Replace(",", " запятая");
            sb.Replace("!", " восклицательный знак");
            sb.Replace("?", " вопросительный знак");
            sb.Replace(":", " двоеточие");
            sb.Replace(";", " точка с запятой");
            sb.Replace("-", " тире");
            sb.Replace("(", " открывающая скобка");
            sb.Replace(")", " закрывающая скобка");
            sb.Replace("«", " открывающая кавычка");
            sb.Replace("»", " закрывающая кавычка");
            Console.WriteLine("Результат: " + sb);
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
            sb.Replace("восемь", "8");
            sb.Replace("семь", "7");
            sb.Replace("девять", "9");
            Console.WriteLine(sb);
        }
        
        //Определить, сколько в тексте слов, состоящих не более чем из N букв. N – вводиться пользователем.
        static void NoMoreLetters()
        {
            Console.Write("Введите текст: ");
            string str = Console.ReadLine();
            Console.Write("Введите N: ");
            int N_val = Convert.ToInt32(Console.ReadLine());
            string[] sentences = str.Split(new char[] {'!', '.', '?'}, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            Console.WriteLine($"Слова, в которых букв меньше, чем N({N_val}):");
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(new char[] {' ', '/', '-', '–'}, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    int length = word.Length;
                    if (word.EndsWith(",")) length--;
                    if (word.EndsWith(":")) length--;
                    if (word.EndsWith("-")) length--;
                    if (word.StartsWith("(")) length--;
                    if (word.EndsWith(")")) length--;
                    if (word.StartsWith("«")) length--;
                    if (word.EndsWith("»")) length--;
                    if (length < N_val)
                    {
                        count++;
                        Console.WriteLine($"-{word}; Количество букв - {length}");
                    }
                }
            }
            if (count == 0) Console.WriteLine("Слов с подходящими параметрами не обнаружено!");
        }
        
        //Найти предложения, состоящие из N слов. N – вводиться пользователем.
        static void NWordsSentences()
        {
            Console.Write("Введите текст: ");
            string str = Console.ReadLine();
            Console.Write("Введите N: ");
            int N_val = Convert.ToInt32(Console.ReadLine());
            string[] sentences = str.Split(new char[] {'!', '.', '?'}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Предложения, состоящие из N({N_val}) слов:");
            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(new char[] {' ', '/', '-', '–'}, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length == N_val) Console.WriteLine(sentence);
            }
        }
    }
}
//. , ; ... : ? ! - () "" ''
