using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение:");
            string s = Console.ReadLine();
            string[] str = s.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlength = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlength)
                {
                    maxlength = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово состоит из " + maxlength + " " + "букв");
            Console.ReadKey();
        }
    }
}
