using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое предложение без знаков препинания, но с пробелами. В конце нажмите Enter");
            string sentencesStart = Console.ReadLine();

            string[] stringArray = sentencesStart.Split();
            int tempQuantity;
            int wordPosition = 0;
            int quantityChar = 0;
            int tempPosition = 0;

            foreach (string s in stringArray)
            {
                tempQuantity = s.Length;
                if (tempQuantity > quantityChar)
                {
                    quantityChar = tempQuantity;
                    wordPosition = tempPosition;
                }
                tempPosition++;
            }
            Console.WriteLine("Самое длинное слово \"{0}\", состоящее из {1} символов.",stringArray[wordPosition], quantityChar);

            Console.ReadKey();

        }
    }
}
