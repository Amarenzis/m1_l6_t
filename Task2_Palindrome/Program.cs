using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое предложение без знаков препинания, но с пробелами. В конце нажмите Enter");
            string sentenceStart = Console.ReadLine().ToLower().Replace(" ","");
            //Console.WriteLine("Форматированная строка {0}",sentenceStart);

            int charQuantity = sentenceStart.Length;
            string newSentence = "";
            string[] stringArray = new string[charQuantity];

            //Console.WriteLine("Массив имеет вид");
            for (int i = 0; i < charQuantity; i++)
            {
                stringArray[i] = sentenceStart.Substring(i, 1);
                //Console.Write("{0},", stringArray[i]);
            }


            for (int i = charQuantity - 1; i >= 0; i--)
            {
                newSentence += stringArray[i];
            }
            //Console.WriteLine("Новое предложение {0}", newSentence);

            if (String.Compare(sentenceStart,newSentence)==0)
            {
                Console.WriteLine("Выражение - палиндром.");
            }
            else
            {
                Console.WriteLine("Выражение не палиндром.");
            }

            Console.ReadKey();
        }
    }
}
