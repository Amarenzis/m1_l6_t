using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Braces_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое предложение c фигурными скобками. Удаляется всё между крайних фигурных скобок. В конце нажмите Enter");
            string sentence = Console.ReadLine();
            //string sentence = "{вообще} такое} например} {или {например{вот {такое}}";

            int braceStart = 0;
            int braceStartQuantity = 0;
            int braceEnd = 0;
            int braceEndQuantity = 0;
            string newSentence = sentence;


            string[] charArray = new string[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                charArray[i] = sentence.Substring(i, 1);
                if (charArray[i] == "{")
                {
                    braceStartQuantity++;
                }
                else if (charArray[i] == "}")
                {
                    braceEndQuantity++;
                }
            }

            Console.WriteLine("Количество начинающих скобок - {0}, количество оканчивающих скобок - {1}", braceStartQuantity, braceEndQuantity);

            int[] braceStartArray = new int[braceStartQuantity];
            int n = 0;
            int[] braceEndArray = new int[braceEndQuantity];
            int m = 0;

            for (int k = 0; k < sentence.Length; k++)
            {
                if (charArray[k] == "{")
                {
                    braceStartArray[n] = k;
                    n++;
                }
                else if (charArray[k] == "}")
                {
                    braceEndArray[m] = k;
                    m++;
                }
            }

            int braceBetween = sentence.Length;
            int braceNearest = 0;


            for (int a = 0; a < braceEndQuantity; a++)
            {
                for (int b = 0; b < braceStartQuantity; b++)
                {
                    if ((braceStartArray[b] >= 0) && (braceEndArray[a] - braceStartArray[b] > 0) && (braceBetween > braceEndArray[a] - braceStartArray[b]))
                    {
                        braceBetween = braceEndArray[a] - braceStartArray[b];
                        braceNearest = b;
                    }
                }
                if (braceBetween < sentence.Length)
                {
                    sentence = sentence.Remove(braceStartArray[braceNearest], braceBetween + 1);
                    Console.WriteLine(sentence);
                    for (int c = braceNearest + 1; c < braceStartQuantity; c++)
                    {
                        braceStartArray[c] -= (braceBetween + 1);
                    }
                    for (int d = a + 1; d < braceEndQuantity; d++)
                    {
                        braceEndArray[d] -= (braceBetween + 1);
                    }
                    braceStartArray[braceNearest] = -1;
                    braceBetween = sentence.Length;
                }
                else
                {
                    continue;
                }
           

            }

            Console.ReadKey();
        }
    }
}
