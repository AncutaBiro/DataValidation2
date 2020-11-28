

/*numără câte vocale și consoane sunt în textul s.*/

using System;

namespace DataValidation2
{
    class Program
    {
        private static int x;
        private static int y;

        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelsAndConsonantsCount("abc"));
        }

  /*      static bool CheckLetters(string s, out int x, out int y)
        {
            bool result = false; x = 0; y = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 97 || s[i] == 65 || s[i] == 101 || s[i] == 69 || s[i] == 105 || s[i] == 73 || s[i] == 111 || s[i] == 79 || s[i] == 117 || s[i] == 85)
                {
                    x++;
                    result = true;
                }

                string ss = s.ToLower(); int c = 0;

                if ((ss[i] == 'a' || ss[i] == 'b' || ss[i] == 'c' || ss[i] == 'd' || ss[i] == 'e' || ss[i] == 'f' ||
                    ss[i] == 'g' || ss[i] == 'h' || ss[i] == 'i' || ss[i] == 'j' || ss[i] == 'k' || ss[i] == 'l' ||
                    ss[i] == 'm' || ss[i] == 'n' || ss[i] == 'o' || ss[i] == 'q' || ss[i] == 'p' || ss[i] == 'r' ||
                    ss[i] == 's' || ss[i] == 't' || ss[i] == 'u' || ss[i] == 'v' || ss[i] == 'w' || ss[i] == 'x' ||
                    ss[i] == 'y' || ss[i] == 'z') && ss[i] != 'a' && ss[i] != 'e' && ss[i] != 'i' && ss[i] != 'o' && ss[i] != 'u') c++;

                if (c > 0) y++;
                result = false;

            }

            return result;
        }*/


/*varianta recomandata si usor de citit/inteles*/
        static (int vowelsCount, int consonantsCount) GetVowelsAndConsonantsCount(string text)
        {
            int vowelsCount = 0;
            int consonantsCount = 0;
            foreach (char c in text)
            {
                if (IsVowel(c))
                {
                    vowelsCount++;
                }
                if (IsConsonant(c))
                {
                    consonantsCount++;
                }
            }
            return (vowelsCount, consonantsCount);
        }

        private static bool IsConsonant(char c)
        {
            return Char.IsLetter(c) && !IsVowel(c);
        }

        private static bool IsVowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) != -1;
        }








    }

}