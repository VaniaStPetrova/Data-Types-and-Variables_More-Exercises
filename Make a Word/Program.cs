using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            byte wordSize = byte.Parse(Console.ReadLine());
            char[] wordLetters = new char[wordSize];

            for (int i = 0; i < wordSize; i++)
            {
                wordLetters[i] = char.Parse(Console.ReadLine());
            }

            string word = new string(wordLetters);
            Console.WriteLine("The word is: {0}", word);
        }
    }
}
