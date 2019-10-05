using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class FirstRepeatedCharacter
    {
        public char GetFirstRepeatedCharacter(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Empty String");
            }

            char defaultChar = '\n';
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                var c = chars[i];
                if (dictionary.ContainsKey(c))
                {
                    return c;

                }
                dictionary.Add(c, i);
            }
            return defaultChar;

        }
    }
}
