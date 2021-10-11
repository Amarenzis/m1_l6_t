using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Braces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое предложение c фигурными скобками. Удаляется всё между крайних фигурных скобок. В конце нажмите Enter");
            string sentence = Console.ReadLine();

            int braceStart = 0;
            int braceEnd = 0;
            int betweenBrace = 0;

            while (sentence.Contains("{") && sentence.Contains("}"))
            {
                braceStart = sentence.IndexOf("{");
                braceEnd = sentence.IndexOf("}");
                if (braceEnd<braceStart)
                {
                    sentence = sentence.Remove(braceEnd,2);
                }
                else
                {
                    betweenBrace = braceEnd - braceStart + 1;
                    sentence = sentence.Remove(braceStart, betweenBrace);
                } 
            }
            sentence = sentence.Replace(" {", "");
            sentence = sentence.Replace("} ", "");
            Console.WriteLine("{0}", sentence);
            Console.ReadKey();
        }
    }
}
