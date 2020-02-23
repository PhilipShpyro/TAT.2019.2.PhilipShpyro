using System;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            try
            {
                word = args[0];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            if (word == null || word == "") //if args[0] is null or empty
            {
                Console.WriteLine("");
                return;
            }
            string sequence = word[0].ToString();
            StringBuilder tempSequence = new StringBuilder(); //using StringBuilder for efficienty
            tempSequence.Append(word[0]);
            for (int i = 1; i < word.Length; i++)
            {
                if(word[i] != word[i - 1])
                {
                    tempSequence.Append(word[i]);
                }
                else
                {
                    sequence = tempSequence.Length > sequence.Length ? tempSequence.ToString() : sequence;
                    tempSequence = new StringBuilder();
                    tempSequence.Append(word[i]);
                }
            }
            sequence = tempSequence.Length > sequence.Length ? tempSequence.ToString() : sequence; // in case when 'else' was never used in cycle
            Console.WriteLine(sequence);
        }
    }
}
