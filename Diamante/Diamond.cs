using System;

namespace Diamante
{
    public class Diamond
    {
        static string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "Y", "Z" };
        private int interval = 1;

        public List<string> Create(string letra)
        {
            List<string> result = new List<string>();
            var index = Array.IndexOf(alphabet, letra);

            result.AddRange(Top(letra, index));
            result.AddRange(Botton(letra, index));
            return result;
        }

        private List<string> Top(string letra, int lenghtArray)
        {
            List<string> result = new List<string>();
            int spaces = lenghtArray;

            for (int i = 0; i < (lenghtArray + 1); i++)
            {
                string str = string.Concat(Enumerable.Repeat(" ", spaces));
                if (i <= 0)
                {
                    result.Add(str + alphabet[i]);
                }
                else
                {
                    var spaceInterval = string.Concat(Enumerable.Repeat(" ", interval));
                    result.Add(str + alphabet[i] + spaceInterval + alphabet[i]);
                    interval += 2;
                }
                spaces--;
            }
            return result;
        }


        private List<string> Botton(string letra, int lenghtArray)
        {
            List<string> result = new List<string>();
            int spaces = 1;
            var interval = (lenghtArray * 2) - 1;

            for (int i = (lenghtArray - 1); i >= 0; i--)
            {
                string str = string.Concat(Enumerable.Repeat(" ", spaces));
                if (i <= 0)
                {
                    result.Add(str + alphabet[i]);
                }
                else
                {
                    interval -= 2;
                    var spaceInterval = string.Concat(Enumerable.Repeat(" ", interval));
                    result.Add(str + alphabet[i] + spaceInterval + alphabet[i]);
                }
                spaces++;
            }
            return result;
        }
    }
}
