using System;
using System.Text;

namespace variable
{
    class program

    {
        static void Main(string[] args)
        {
            string[] word = { "Baku", "Seki", "quba" };
            Console.WriteLine(Method1(word));
        }
        static StringBuilder Method1(string[] word)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                word[i] += ",";
                result.Append(word[i]);
            }
            return result;
        }
    }
}