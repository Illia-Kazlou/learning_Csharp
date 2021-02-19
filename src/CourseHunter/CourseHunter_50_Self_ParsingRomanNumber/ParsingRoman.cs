using System.Collections.Generic;

namespace CourseHunter_50_Self_ParsingRomanNumber
{
    class ParsingRoman
    {
        private static Dictionary<char, int> map = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5},
            { 'X', 10 },
            { 'L',50 },
            { 'C',100 },
            { 'D',500 },
            { 'M',1000 },
        };

        public static int Parsing(string roman)
        {
            int result = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && IsSubtractive(roman[i], roman[i + 1]))
                {
                    char letter = roman[i];
                    result -= map[letter];
                }
                else
                {
                    char letter = roman[i];
                    result += map[letter];
                }
            }
            return result;
        }

        private static bool IsSubtractive(char v1, char v2)
        {
            return map[v1] < map[v2];
        }
    }
}
