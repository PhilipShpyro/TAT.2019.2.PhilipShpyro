using System;
using System.Text;

namespace Task1_2
{
    class Program
    {
        static string Notate(int number, int numSystem)
        {
            StringBuilder answer = new StringBuilder();
            int tNumber = number;
            int ost;
            while(tNumber >= numSystem)
            {
                ost = tNumber % numSystem;
                if (ost >= 10)
                    answer.Insert(0, (char)(ost + 55));
                else
                    answer.Insert(0, ost);
                tNumber = tNumber - ost;
                tNumber = tNumber / numSystem;
            }
            if (tNumber >= 10)
                answer.Insert(0, (char)(tNumber + 55));
            else
                answer.Insert(0, tNumber);
            return answer.ToString();
        }
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine());
            //int numSystem = Convert.ToInt32(Console.ReadLine());

            int number = Convert.ToInt32(args[0]);
            int numSystem = Convert.ToByte(args[1]);

            Console.WriteLine(Notate(number, numSystem));
        }
    }
}
