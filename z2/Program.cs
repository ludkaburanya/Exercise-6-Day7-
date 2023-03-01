using System;
using System.Text.RegularExpressions;

namespace z2
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Введите текст:");
            string text = Console.ReadLine();
            string[] words = text.Split(',');

            Regex regex = new Regex(@"а+");
            MatchCollection match = regex.Matches(words[0]);
            int count = 0;
            foreach (Match m in match)
            {
                count+= m.Value.Length;
            }

            Console.WriteLine("Количество букв а перед первой запятой = {0}", count);
            Console.ReadKey();
        }
    }
}