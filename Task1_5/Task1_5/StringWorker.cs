using System.Text;

namespace Task1_5
{
    public class StringWorker
    {
        public static string ShowMaxNotEqualSequenceIn(string word)
        {
            if (word == null || word == "")
                return null;
            string result = word[0].ToString();
            StringBuilder sequence = new StringBuilder();
            sequence.Append(word[0]);
            for(int i = 1; i < word.Length; i++)
            {
                if (word[i] != word[i - 1])
                {
                    sequence.Append(word[i]);
                    continue;
                }
                result = sequence.Length > result.Length ? sequence.ToString() : result;
                sequence.Remove(0, sequence.Length);
                sequence.Append(word[i]);
            }
            return sequence.Length > result.Length ? sequence.ToString() : result;
        }
        public static string ShowMaxNotEqualDigitSequenceIn(string word)
        {
            int index = 0;
            while (index < word.Length)
            {
                if (word[index] >= 48 && word[index] <= 57)
                    break;
                index++;
            }
            if (index == word.Length)
                return null;
            string result = word[index].ToString();
            StringBuilder sequence = new StringBuilder();
            sequence.Append(word[index]);
            for(int i = index + 1; i < word.Length; i++)
            {
                if (word[i] != word[i - 1] && (word[i] >= 48 && word[i] <= 57))
                {
                    sequence.Append(word[i]);
                    continue;
                }
                result = sequence.Length > result.Length ? sequence.ToString() : result;
                sequence.Remove(0, sequence.Length);
                for (int t = i; t < word.Length; t++)
                    if (word[i] >= 48 && word[i] <= 57)
                    {
                        sequence.Append(word[t]);
                        i = t;
                        break;
                    }
            }
            return sequence.Length > result.Length ? sequence.ToString() : result;
        }
        public static string ShowMaxNotEqualLatinSequenceIn(string word)
        {
            int index = 0;
            while (index < word.Length)
            {
                if ((word[index] >= 65 && word[index] <= 90) || (word[index] >= 97 && word[index] <= 122))
                    break;
                index++;
            }
            if (index == word.Length)
                return null;
            string result = word[index].ToString();
            StringBuilder sequence = new StringBuilder();
            sequence.Append(word[index]);
            for (int i = index + 1; i < word.Length; i++)
            {
                if (word[i] != word[i - 1] && ((word[index] >= 65 && word[index] <= 90) || (word[index] >= 97 && word[index] <= 122)))
                {
                    sequence.Append(word[i]);
                    continue;
                }
                result = sequence.Length > result.Length ? sequence.ToString() : result;
                sequence.Remove(0, sequence.Length);
                for (int t = i; t < word.Length; t++)
                    if ((word[index] >= 65 && word[index] <= 90) || (word[index] >= 97 && word[index] <= 122))
                    {
                        sequence.Append(word[t]);
                        i = t;
                        break;
                    }
            }
            return sequence.Length > result.Length ? sequence.ToString() : result;
        }
    }
}
